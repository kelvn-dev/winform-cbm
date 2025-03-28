using CBM.Customs;
using CBM.Models;
using CBM.Utilities;
using System;
using System.Drawing;
using System.Windows.Forms;
using static CBM.Enums;

namespace CBM.Views {
  public partial class VariantForm : Form {

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
      UserControlUtils.CssPageLabel(pageLabel);
      UserControlUtils.CssFieldLabel(brandLabel);
      UserControlUtils.CssFieldLabel(modelNameLabel);
      UserControlUtils.CssFieldLabel(fuelTypeLabel);
      UserControlUtils.CssFieldLabel(variantNameLabel);
      UserControlUtils.CssFieldLabel(variantYearLabel);
      UserControlUtils.CssFieldLabel(engineTypeLabel);
      UserControlUtils.CssFieldLabel(driveTypeLabel);
      UserControlUtils.CssFieldLabel(batteryTypeLabel);
      UserControlUtils.CssFieldLabel(autoHeadlightLabel);
      UserControlUtils.CssFieldLabel(navigationSystemLabel);
      UserControlUtils.CssFieldLabel(bluetoothInterfaceLabel);
      UserControlUtils.CssFieldLabel(smartKeyLabel);
    }
    private void CssTextbox() {
      UserControlUtils.CssTextbox(variantNameField, "Enter variant's name");
      UserControlUtils.CssTextbox(variantYearField, "Enter variant's year");
      UserControlUtils.CssTextbox(engineTypeField, "Enter variant's engine type");
      UserControlUtils.CssTextbox(driveTypeField, "Enter variant's drive type");
      UserControlUtils.CssTextbox(batteryTypeField, "Enter variant's battery type");
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
      UserControlUtils.CssComboBox(vehicleModelComboBox);
      UserControlUtils.CssComboBox(fuelTypeComboBox);
    }

    #endregion

    public VariantForm() {
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
      dataGridView.Columns["description"].Visible = false;
      dataGridView.Columns["engineType"].Visible = false;
      dataGridView.Columns["batteryType"].Visible = false;
      dataGridView.Columns["driveType"].Visible = false;
      dataGridView.Columns["autoHeadlight"].Visible = false;
      dataGridView.Columns["navigationSystem"].Visible = false;
      dataGridView.Columns["bluetoothInterface"].Visible = false;
      dataGridView.Columns["smartKey"].Visible = false;
      dataGridView.Columns["vehicleModelId"].Visible = false;
      dataGridView.Columns["fuelTypeId"].Visible = false;
      UserControlUtils.AjustHeightAutomatically(dataGridView);
      UserControlUtils.AddActionColumns(dataGridView);
    }

    #endregion

    #region Validation

    private void AssociateValidation() {
      errorProvider.DataSource = validationBindingSource;

      variantNameField.DataBindings.Add("Texts", errorProvider.DataSource, "name", true, DataSourceUpdateMode.OnPropertyChanged);
      variantYearField.DataBindings.Add("Texts", errorProvider.DataSource, "variantYear", true, DataSourceUpdateMode.OnPropertyChanged);

      errorProvider.SetIconPadding(variantNameField, 50);
      errorProvider.SetIconPadding(variantYearField, 50);
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
    public event EventHandler LoadCorrespondingVehicleModel;

    private void AssociateEvents() {
      brandComboBox.OnSelectedIndexChanged += delegate {
        LoadCorrespondingVehicleModel?.Invoke(this, EventArgs.Empty);
        vehicleModelComboBox.Visible = true;
      };

      createBtn.Click += delegate {
        UserControlUtils.CleanFields(this.detailTab.Controls);
        validationBindingSource.DataSource = new Variant();
        CreateEvent?.Invoke(this, EventArgs.Empty);
        SwitchToDetailTab();
        errorProvider.Clear();
        vehicleModelComboBox.Visible = false;
      };

      saveBtn.Click += delegate {
        validationBindingSource.EndEdit();
        Variant validatedVariant = validationBindingSource.Current as Variant;
        if (validatedVariant.IsValid) {
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
          Variant validation = new Variant();
          validation.name = variantName;
          validation.variantYear = variantYear;
          validation.driveType = driveType;
          validation.batteryType = batteryType;
          validation.engineType = engineType;
          validation.autoHeadlight = autoHeadlight;
          validation.bluetoothInterface = bluetoothInterface;
          validation.navigationSystem = navigationSystem;
          validation.smartKey = smartKey;
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
      variantYearField.KeyPress += EventHandlerUtils.AllowInteger_KeyPress;
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

    public CBMComboBox GetBrandComboBox() {
      return brandComboBox;
    }

    public CBMComboBox GetVehicleModelComboBox() {
      return vehicleModelComboBox;
    }

    public CBMComboBox GetFuelTypeComboBox() {
      return fuelTypeComboBox;
    }

    public string variantName {
      get => variantNameField.Texts;
      set => variantNameField.Texts = value;
    }
    public string variantYear {
      get => variantYearField.Texts;
      set => variantYearField.Texts = value;
    }
    public string engineType {
      get => engineTypeField.Texts;
      set => engineTypeField.Texts = value;
    }
    public string driveType {
      get => driveTypeField.Texts;
      set => driveTypeField.Texts = value;
    }
    public string batteryType {
      get => batteryTypeField.Texts;
      set => batteryTypeField.Texts = value;
    }
    public object brandId {
      get => brandComboBox.SelectedValue;
      set => brandComboBox.SelectedItem = value;
    }
    public object vehicleModelId {
      get => vehicleModelComboBox.SelectedValue;
      set => vehicleModelComboBox.SelectedItem = value;
    }
    public object fuelTypeId {
      get => fuelTypeComboBox.SelectedValue;
      set => fuelTypeComboBox.SelectedItem = value;
    }
    public bool autoHeadlight {
      get => autoHeadlightField.Checked;
      set => autoHeadlightField.Checked = value;
    }
    public bool navigationSystem {
      get => navigationSystemField.Checked;
      set => navigationSystemField.Checked = value;
    }
    public bool bluetoothInterface {
      get => bluetoothInterfaceField.Checked;
      set => bluetoothInterfaceField.Checked = value;
    }
    public bool smartKey {
      get => smartKeyField.Checked;
      set => smartKeyField.Checked = value;
    }

    #endregion
  }
}
