using CBM.Models;
using CBM.Utilities;
using System;
using System.Drawing;
using System.Windows.Forms;
using static CBM.Enums;

namespace CBM.Views {
  public partial class SubscriptionPlanForm : Form {

    #region Css

    private void CssBtn() {
      UserControlUtils.CssCancelBtn(cancelBtn);
      UserControlUtils.CssSaveBtn(saveBtn);
      UserControlUtils.CssCreateBtn(createBtn);
      UserControlUtils.CssIconButton(searchBtn, Color.White, ColorTranslator.FromHtml(Constant.PLACEHOLDER_COLOR));
      UserControlUtils.CssIconButton(prePageBtn, Color.White, ColorTranslator.FromHtml(Constant.BLUE_COLOR), Constant.MEDIUM_ICON_SIZE);
      UserControlUtils.CssIconButton(nextPageBtn, Color.White, ColorTranslator.FromHtml(Constant.BLUE_COLOR), Constant.MEDIUM_ICON_SIZE);
    }
    private void CssLabel() {
      UserControlUtils.CssInformationLabel(informationLabel);
      UserControlUtils.CssFieldLabel(nameLabel);
      UserControlUtils.CssFieldLabel(descriptionLabel);
      UserControlUtils.CssFieldLabel(monthlyPriceLabel);
      UserControlUtils.CssFieldLabel(yearlyPriceLabel);
      UserControlUtils.CssFieldLabel(vehicleLimitLabel);
      UserControlUtils.CssPageLabel(pageLabel);
    }
    private void CssTextbox() {
      UserControlUtils.CssTextbox(nameField, "Enter name");
      UserControlUtils.CssTextbox(monthlyPriceField, "Enter monthly price");
      UserControlUtils.CssTextbox(yearlyPriceField, "Enter annual price");
      UserControlUtils.CssTextbox(vehicleLimitField, "Enter vehicle limit");
      UserControlUtils.CssTextbox(descriptionField, "Enter description");
      UserControlUtils.CssSearchTextbox(searchField);
    }
    private void CssTabControl() {
      tabControl.TabPages.Remove(detailTab);
      tabControl.Appearance = TabAppearance.FlatButtons;
      tabControl.ItemSize = new Size(0, 1);
      tabControl.SizeMode = TabSizeMode.Fixed;
      listingTab.BackColor = Color.White;
      detailTab.BackColor = Color.White;
    }
    private void CssDatagridView() {
      UserControlUtils.CssDatagridView(dataGridView);
    }

    #endregion

    public SubscriptionPlanForm() {
      InitializeComponent();
      currentPage = 1;

      CssBtn();
      CssLabel();
      CssTextbox();
      CssTabControl();
      CssDatagridView();

      AssociateEvents();
      AssociateValidation();
    }

    #region Common

    private void SwitchToListingTab() {
      tabControl.TabPages.Remove(detailTab);
      tabControl.TabPages.Add(listingTab);
    }

    private void SwitchToDetailTab() {
      tabControl.TabPages.Remove(listingTab);
      tabControl.TabPages.Add(detailTab);
    }

    public void MapDataSource(BindingSource bindingSource) {
      dataGridView.DataSource = bindingSource;
      dataGridView.Columns["id"].Visible = false;
      dataGridView.Columns["created_time"].Visible = false;
      UserControlUtils.AjustHeightAutomatically(dataGridView);
      UserControlUtils.AddActionColumns(dataGridView);
    }

    #endregion

    #region Validation

    private void AssociateValidation() {
      errorProvider.DataSource = validationBindingSource;

      nameField.DataBindings.Add("Texts", errorProvider.DataSource, "name", true, DataSourceUpdateMode.OnPropertyChanged);
      monthlyPriceField.DataBindings.Add("Texts", errorProvider.DataSource, "monthlyPrice", true, DataSourceUpdateMode.OnPropertyChanged);
      yearlyPriceField.DataBindings.Add("Texts", errorProvider.DataSource, "yearlyPrice", true, DataSourceUpdateMode.OnPropertyChanged);
      vehicleLimitField.DataBindings.Add("Texts", errorProvider.DataSource, "vehicleLimit", true, DataSourceUpdateMode.OnPropertyChanged);
      descriptionField.DataBindings.Add("Texts", errorProvider.DataSource, "description", true, DataSourceUpdateMode.OnPropertyChanged);

      errorProvider.SetIconPadding(nameField, 50);
      errorProvider.SetIconPadding(monthlyPriceField, 50);
      errorProvider.SetIconPadding(yearlyPriceField, 50);
      errorProvider.SetIconPadding(vehicleLimitField, 50);
      errorProvider.SetIconPadding(descriptionField, 50);
    }

    #endregion

    #region Events

    public event EventHandler SearchEvent;
    public event EventHandler CreateEvent;
    public event EventHandler UpdateEvent;
    public event EventHandler DeleteEvent;
    public event EventHandler SaveEvent;
    public event EventHandler GetPrePageEvent;
    public event EventHandler GetNextPageEvent;
    public event EventHandler SortEvent;

    private void AssociateEvents() {

      createBtn.Click += delegate {
        validationBindingSource.DataSource = new SubscriptionPlan();
        CreateEvent?.Invoke(this, EventArgs.Empty);
        UserControlUtils.CleanFields(this.detailTab.Controls);
        SwitchToDetailTab();
        errorProvider.Clear();
      };

      saveBtn.Click += delegate {
        validationBindingSource.EndEdit();
        SubscriptionPlan validated = validationBindingSource.Current as SubscriptionPlan;
        if (validated.IsValid) {
          SaveEvent?.Invoke(this, EventArgs.Empty);
          SwitchToListingTab();
        }
      };

      cancelBtn.Click += delegate {
        errorProvider.Clear();
        SwitchToListingTab();
      };

      searchBtn.Click += delegate {
        SearchEvent?.Invoke(this, EventArgs.Empty);
      };
      searchField.KeyDown += (sender, e) => {
        if (e.KeyCode == Keys.Enter) {
          SearchEvent?.Invoke(this, EventArgs.Empty);
          e.SuppressKeyPress = true;
        }
      };

      prePageBtn.Click += delegate {
        GetPrePageEvent?.Invoke(this, EventArgs.Empty);
      };
      nextPageBtn.Click += delegate {
        GetNextPageEvent?.Invoke(this, EventArgs.Empty);
      };

      dataGridView.CellClick += delegate (object sender, DataGridViewCellEventArgs e) {
        if (e.RowIndex == -1) {
          return;
        }
        if (e.ColumnIndex == 0) {
          UpdateEvent?.Invoke(this, EventArgs.Empty);
          SubscriptionPlan validation = new SubscriptionPlan();
          validation.name = name;
          validation.description = description;
          validation.yearlyPrice = float.Parse(yearlyPrice);
          validation.monthlyPrice = float.Parse(monthlyPrice);
          validation.vehicleLimit = Int32.Parse(vehicleLimit);
          validationBindingSource.DataSource = validation;
          SwitchToDetailTab();
          errorProvider.Clear();
        }
        if (e.ColumnIndex == 1) {
          DeleteEvent?.Invoke(this, EventArgs.Empty);
        }
      };

      // Sort event
      dataGridView.ColumnHeaderMouseClick += delegate (object sender, DataGridViewCellMouseEventArgs e) {
        if (e.ColumnIndex == 0 || e.ColumnIndex == 1) {
          return;
        }
        string clickedHeaderText = dataGridView.Columns[e.ColumnIndex].HeaderText;
        if (clickedHeaderText != orderBy) {
          orderBy = clickedHeaderText;
          orderDirection = OrderDirection.ASC;
        }
        else {
          switch (orderDirection) {
            case OrderDirection.ASC:
            orderDirection = OrderDirection.DESC;
            break;
            case OrderDirection.DESC:
            orderDirection = OrderDirection.DESC;
            orderBy = "created_time";
            break;
            default:
            orderDirection = OrderDirection.ASC;
            break;
          }
        }
        SortEvent?.Invoke(this, EventArgs.Empty);
      };

      // Forbid Characters
      monthlyPriceField.KeyPress += EventHandlerUtils.AllowFloat_KeyPress;
      yearlyPriceField.KeyPress += EventHandlerUtils.AllowFloat_KeyPress;
      vehicleLimitField.KeyPress += EventHandlerUtils.AllowInteger_KeyPress;
    }

    #endregion

    #region Variables

    private Guid _id;
    private bool _isUpdate;
    private bool _isSuccessful;
    private string _message;
    private int _currentPage;
    private int _totalPages;
    private string _orderBy;
    private OrderDirection _orderDirection;
    private BindingSource validationBindingSource = new BindingSource();

    public Guid id {
      get => _id;
      set => _id = value;
    }
    public bool isUpdate {
      get => _isUpdate;
      set => _isUpdate = value;
    }
    public bool isSuccessful {
      get => _isSuccessful;
      set => _isSuccessful = value;
    }
    public string message {
      get => _message;
      set => _message = value;
    }
    public int currentPage {
      get => _currentPage;
      set => _currentPage = value;
    }
    public int totalPages {
      get => _totalPages;
      set => _totalPages = value;
    }
    public string orderBy {
      get => _orderBy;
      set => _orderBy = value;
    }
    public OrderDirection orderDirection {
      get => _orderDirection;
      set => _orderDirection = value;
    }

    public string keyword {
      get => searchField.Texts;
      set => searchField.Texts = value;
    }
    public Button GetPrePageBtn() {
      return prePageBtn;
    }

    public Button GetNextPageBtn() {
      return nextPageBtn;
    }

    public Label GetPageLabel() {
      return pageLabel;
    }

    public string name {
      get => nameField.Texts;
      set => nameField.Texts = value;
    }
    public string monthlyPrice {
      get => monthlyPriceField.Texts;
      set => monthlyPriceField.Texts = value;
    }
    public string yearlyPrice {
      get => yearlyPriceField.Texts;
      set => yearlyPriceField.Texts = value;
    }
    public string vehicleLimit {
      get => vehicleLimitField.Texts;
      set => vehicleLimitField.Texts = value;
    }
    public string description {
      get => descriptionField.Texts;
      set => descriptionField.Texts = value;
    }

    #endregion
  }
}
