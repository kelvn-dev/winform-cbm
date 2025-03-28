using CBM.Customs;
using CBM.Models;
using CBM.Utilities;
using FontAwesome.Sharp;
using System;
using System.Drawing;
using System.Windows.Controls;
using System.Windows.Forms;
using static CBM.Enums;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CBM.Views {
  public partial class VehicleModelForm : Form {

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
      UserControlUtils.CssFieldLabel(modelYearLabel);
      UserControlUtils.CssFieldLabel(brandLabel);
      UserControlUtils.CssFieldLabel(vehicleTypeLabel);
      UserControlUtils.CssPageLabel(pageLabel);
    }
    private void CssTextbox() {
      UserControlUtils.CssTextbox(nameField, "Enter model's name");
      UserControlUtils.CssTextbox(modelYearField, "Enter model's year");
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
    private void CssComboBox() {
      UserControlUtils.CssComboBox(brandComboBox);
      UserControlUtils.CssComboBox(vehicleTypeComboBox);
    }

    #endregion

    public VehicleModelForm() {
      InitializeComponent();
      currentPage = 1;

      CssBtn();
      CssLabel();
      CssTextbox();
      CssTabControl();
      CssDatagridView();
      CssComboBox();

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
      dataGridView.Columns["brandId"].Visible = false;
      dataGridView.Columns["vehicleTypeId"].Visible = false;
      UserControlUtils.AjustHeightAutomatically(dataGridView);
      UserControlUtils.AddActionColumns(dataGridView);
    }

    #endregion

    #region Validation

    private void AssociateValidation() {
      errorProvider.DataSource = validationBindingSource;

      nameField.DataBindings.Add("Texts", errorProvider.DataSource, "name", true, DataSourceUpdateMode.OnPropertyChanged);
      modelYearField.DataBindings.Add("Texts", errorProvider.DataSource, "modelYear", true, DataSourceUpdateMode.OnPropertyChanged);


      errorProvider.SetIconPadding(nameField, 50);
      errorProvider.SetIconPadding(modelYearField, 50);
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
        validationBindingSource.DataSource = new VehicleModel();
        CreateEvent?.Invoke(this, EventArgs.Empty);
        UserControlUtils.CleanFields(this.detailTab.Controls);
        SwitchToDetailTab();
        errorProvider.Clear();
      };

      saveBtn.Click += delegate {
        validationBindingSource.EndEdit();
        VehicleModel validated = validationBindingSource.Current as VehicleModel;
        if (validated.IsValid) {
          SaveEvent?.Invoke(this, EventArgs.Empty);
          if (isSuccessful) {
            SwitchToListingTab();
          }
          else {
            MessageBox.Show(message);
          }
        }
      };

      cancelBtn.Click += delegate {
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
          VehicleModel validatedModel = new VehicleModel();
          validatedModel.name = name;
          validatedModel.modelYear = modelYear;
          validationBindingSource.DataSource = validatedModel;
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

      // Forbid characters
      modelYearField.KeyPress += EventHandlerUtils.AllowInteger_KeyPress;
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
    public System.Windows.Forms.Button GetPrePageBtn() {
      return prePageBtn;
    }

    public System.Windows.Forms.Button GetNextPageBtn() {
      return nextPageBtn;
    }

    public System.Windows.Forms.Label GetPageLabel() {
      return pageLabel;
    }

    public CBMComboBox GetBrandComboBox() {
      return brandComboBox;
    }

    public CBMComboBox GetVehicleTypeComboBox() {
      return vehicleTypeComboBox;
    }

    public string name {
      get => nameField.Texts;
      set => nameField.Texts = value;
    }
    public string modelYear {
      get => modelYearField.Texts;
      set => modelYearField.Texts = value;
    }
    public object brandId {
      get => brandComboBox.SelectedValue;
      set => brandComboBox.SelectedItem = value;
    }
    public object vehicleTypeId {
      get => vehicleTypeComboBox.SelectedValue;
      set => vehicleTypeComboBox.SelectedItem = value;
    }

    #endregion
  }
}
