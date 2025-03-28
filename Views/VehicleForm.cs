using CBM.Customs;
using CBM.Models;
using CBM.Utilities;
using ClosedXML.Excel;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using static CBM.Enums;

namespace CBM.Views {
  public partial class VehicleForm : Form {

    #region Css

    private void CssBtn() {
      UserControlUtils.CssCancelBtn(cancelBtn);
      UserControlUtils.CssCancelBtn(exportBtn);
      UserControlUtils.CssSaveBtn(saveBtn);
      UserControlUtils.CssSaveBtn(sellerBtn);
      UserControlUtils.CssSaveBtn(buyerBtn);
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
      UserControlUtils.CssFieldLabel(variantLabel);
      UserControlUtils.CssFieldLabel(titleLabel);
      UserControlUtils.CssFieldLabel(plateNoLabel);
      UserControlUtils.CssFieldLabel(manufacturingYearLabel);
      UserControlUtils.CssFieldLabel(mileageLabel);
      UserControlUtils.CssFieldLabel(descriptionLabel);
      UserControlUtils.CssFieldLabel(statusLabel);
      UserControlUtils.CssFieldLabel(memberLabel);
      UserControlUtils.CssFieldLabel(priceLabel);
    }
    private void CssTextbox() {
      UserControlUtils.CssTextbox(titleField, "Enter vehicle's title");
      UserControlUtils.CssTextbox(plateNoField, "Enter vehicle's plate number");
      UserControlUtils.CssTextbox(manufacturingYearField, "Enter vehicle's manufacturing year");
      UserControlUtils.CssTextbox(mileageField, "Enter vehicle's mileage (Km)");
      UserControlUtils.CssTextbox(priceField, "Enter vehicle's price ($)");
      UserControlUtils.CssTextbox(descriptionField, "Enter vehicle's description");
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
      UserControlUtils.CssComboBox(variantComboBox);
      UserControlUtils.CssComboBox(statusField);
      UserControlUtils.CssComboBox(memberCombobox);
    }

    #endregion

    public VehicleForm(CommonView commonView) {
      InitializeComponent();
      MapStatusEnum();
      currentPage = 1;
      this.commonView = commonView;

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

    public void UpdateColorStatusCell() {
      foreach (DataGridViewRow row in dataGridView.Rows) {
        DataGridViewCell statusCell = row.Cells["status"];
        switch (statusCell.Value.ToString()) {
          case "PENDING":
          statusCell.Style.ForeColor = ColorTranslator.FromHtml(Constant.YELLO_COLOR);
          break;
          case "REJECTED":
          statusCell.Style.ForeColor = ColorTranslator.FromHtml(Constant.RED_COLOR);
          break;
          case "APPROVED":
          statusCell.Style.ForeColor = ColorTranslator.FromHtml(Constant.GREEN_COLOR);
          break;
          default:
          break;
        }
      }
    }
    public DataGridView GetDataGridView() { return dataGridView; }

    public void SwitchToListingTab() {
      tabControl.TabPages.Remove(detailTab);
      tabControl.TabPages.Add(listingTab);
      UpdateColorStatusCell();
    }

    public void SwitchToDetailTab() {
      tabControl.TabPages.Remove(listingTab);
      tabControl.TabPages.Add(detailTab);
    }

    private void MapStatusEnum() {
      statusField.DataSource = Enum.GetValues(typeof(Enums.Status));
    }

    public void MapDataSource(BindingSource bindingSource) {
      dataGridView.DataSource = bindingSource;
      dataGridView.Columns["id"].Visible = false;
      dataGridView.Columns["created_time"].Visible = false;
      dataGridView.Columns["description"].Visible = false;
      dataGridView.Columns["variantId"].Visible = false;
      dataGridView.Columns["memberId"].Visible = false;
      dataGridView.Columns["buyerId"].Visible = false;
      UserControlUtils.AjustHeightAutomatically(dataGridView);
      UserControlUtils.AddActionColumns(dataGridView);
    }

    #endregion

    #region Validation

    private void AssociateValidation() {
      errorProvider.DataSource = validationBindingSource;

      plateNoField.DataBindings.Add("Texts", errorProvider.DataSource, "plateNo", true, DataSourceUpdateMode.OnPropertyChanged);
      manufacturingYearField.DataBindings.Add("Texts", errorProvider.DataSource, "manufacturingYear", true, DataSourceUpdateMode.OnPropertyChanged);
      mileageField.DataBindings.Add("Texts", errorProvider.DataSource, "mileage", true, DataSourceUpdateMode.OnPropertyChanged);
      priceField.DataBindings.Add("Texts", errorProvider.DataSource, "price", true, DataSourceUpdateMode.OnPropertyChanged);

      errorProvider.SetIconPadding(plateNoField, 50);
      errorProvider.SetIconPadding(manufacturingYearField, 50);
      errorProvider.SetIconPadding(mileageField, 50);
      errorProvider.SetIconPadding(priceField, 50);
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
    public event EventHandler LoadCorrespondingVariant;

    private void ExportData(object sender, EventArgs e) {
      using (SaveFileDialog saveFileDialog = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsx"}) {
        if (saveFileDialog.ShowDialog() == DialogResult.OK) {
          using (XLWorkbook workbook = new XLWorkbook()) {
            DataTable dt = new DataTable();

            // Add columns to the DataTable based on the columns in the DataGridView
            int index = -1;
            foreach (DataGridViewColumn column in dataGridView.Columns) {
              ++index;
              if (index < 2 || index > 8) {
                continue;
              }
              Console.WriteLine(index);
              dt.Columns.Add(column.HeaderText, typeof(String));
            }

            // Add rows to the DataTable based on the rows in the DataGridView
            
            foreach (DataGridViewRow row in dataGridView.Rows) {
              // Create a new row in the DataTable
              dt.Rows.Add();
              index = -1;
              // Set the value of each cell in the DataTable to the value of the corresponding cell in the DataGridView
              foreach (DataGridViewCell cell in row.Cells) {
                ++index;
                if (index < 2 || index > 8) {
                  continue;
                }
                Console.WriteLine(index);
                dt.Rows[dt.Rows.Count - 1][index-2] = cell.Value.ToString();
              }
            }
            workbook.Worksheets.Add(dt, "Vehicles");
            workbook.SaveAs(saveFileDialog.FileName);
            MessageBox.Show("Exported data successfully");
          }
        }
      }
    }

    private void AssociateEvents() {
      exportBtn.Click += ExportData;

      sellerBtn.Click += delegate {
        if (memberId == null || memberId.ToString() == "00000000-0000-0000-0000-000000000000") {
          MessageBox.Show("This vehicle doesn't have seller");
        }
        else {
          commonView.OpenChildForm(new SellerForm(sellerId, this), true);
        }
      };

      buyerBtn.Click += delegate {
        if (buyerId == null || buyerId.ToString() == "00000000-0000-0000-0000-000000000000") {
          MessageBox.Show("This vehicle doesn't have buyer");
        }
        else {
          commonView.OpenChildForm(new BuyerForm(buyerId, this), true);
        }
      };

      brandComboBox.OnSelectedIndexChanged += delegate {
        LoadCorrespondingVehicleModel?.Invoke(this, EventArgs.Empty);
        vehicleModelComboBox.Visible = true;
      };
      vehicleModelComboBox.OnSelectedIndexChanged += delegate {
        LoadCorrespondingVariant?.Invoke(this, EventArgs.Empty);
        variantComboBox.Visible = true;
      };

      createBtn.Click += delegate {
        UserControlUtils.CleanFields(this.detailTab.Controls);
        validationBindingSource.DataSource = new Vehicle();
        CreateEvent?.Invoke(this, EventArgs.Empty);
        SwitchToDetailTab();
        errorProvider.Clear();
        vehicleModelComboBox.Visible = false;
        variantComboBox.Visible = false;
      };

      saveBtn.Click += delegate {
        validationBindingSource.EndEdit();
        Vehicle validatedVehicle = validationBindingSource.Current as Vehicle;
        if (validatedVehicle.IsValid) {
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
          Vehicle validation = new Vehicle();
          validation.title = title;
          validation.plateNo = plateNo;
          validation.manufacturingYear = manufacturingYear;
          validation.mileage = float.Parse(mileage);
          validation.price = float.Parse(price);
          validation.description = description;
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
      manufacturingYearField.KeyPress += EventHandlerUtils.AllowInteger_KeyPress;
      priceField.KeyPress += EventHandlerUtils.AllowFloat_KeyPress;
    }

    #endregion

    #region Variables

    private CommonView commonView;
    private Guid _sellerId;
    private Guid _buyerId;
    private Guid _id;
    private bool _isUpdate;
    private bool _isSuccessful;
    private string _message;
    private int _currentPage;
    private int _totalPages;
    private string _orderBy;
    private OrderDirection _orderDirection;
    private BindingSource validationBindingSource = new BindingSource();

    public Guid sellerId {
      get => _sellerId;
      set => _sellerId = value;
    }
    public Guid buyerId {
      get => _buyerId;
      set => _buyerId = value;
    }
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

    public CBMComboBox GetVariantComboBox() {
      return variantComboBox;
    }

    public CBMComboBox GetMemberComboBox() {
      return memberCombobox;
    }

    public string title {
      get => titleField.Texts;
      set => titleField.Texts = value;
    }
    public string plateNo {
      get => plateNoField.Texts;
      set => plateNoField.Texts = value;
    }
    public string manufacturingYear {
      get => manufacturingYearField.Texts;
      set => manufacturingYearField.Texts = value;
    }
    public string mileage {
      get => mileageField.Texts;
      set => mileageField.Texts = value;
    }
    public string price {
      get => priceField.Texts;
      set => priceField.Texts = value;
    }
    public string description {
      get => descriptionField.Texts;
      set => descriptionField.Texts = value;
    }

    // ComboBox
    public object status {
      get => statusField.SelectedValue;
      set => statusField.SelectedItem = value;
    }
    public object brandId {
      get => brandComboBox.SelectedValue;
      set => brandComboBox.SelectedItem = value;
    }
    public object vehicleModelId {
      get => vehicleModelComboBox.SelectedValue;
      set => vehicleModelComboBox.SelectedItem = value;
    }
    public object variantId {
      get => variantComboBox.SelectedValue;
      set => variantComboBox.SelectedItem = value;
    }
    public object memberId {
      get => memberCombobox.SelectedValue;
      set => variantComboBox.SelectedItem = value;
    }

    #endregion
  }
}
