using CBM.Customs;
using CBM.Models;
using CBM.Utilities;
using System;
using System.Drawing;
using System.Windows.Forms;
using static CBM.Enums;

namespace CBM.Views {
  public partial class DealershipForm : Form {

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
      UserControlUtils.CssFieldLabel(memberLabel);
      UserControlUtils.CssFieldLabel(subscriptionPlanLabel);
      UserControlUtils.CssFieldLabel(renewalLabel);
      UserControlUtils.CssFieldLabel(startDateLabel);
      UserControlUtils.CssFieldLabel(endDateLabel);
      UserControlUtils.CssFieldLabel(statusLabel);
    }
    private void CssTextbox() {
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
      UserControlUtils.CssComboBox(memberComboBox);
      UserControlUtils.CssComboBox(subscriptionPlanComboBox);
      UserControlUtils.CssComboBox(statusField);
    }

    #endregion

    public DealershipForm() {
      InitializeComponent();
      MapStatusEnum();
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

    private void MapStatusEnum() {
      statusField.DataSource = Enum.GetValues(typeof(Enums.Status));
    }

    public void MapDataSource(BindingSource bindingSource) {
      dataGridView.DataSource = bindingSource;
      dataGridView.Columns["id"].Visible = false;
      dataGridView.Columns["created_time"].Visible = false;
      dataGridView.Columns["memberId"].Visible = false;
      dataGridView.Columns["subscriptionPlanId"].Visible = false;
      UserControlUtils.AjustHeightAutomatically(dataGridView);
      UserControlUtils.AddActionColumns(dataGridView);
    }

    #endregion

    #region Validation

    private void AssociateValidation() {
      
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
        UserControlUtils.CleanFields(this.detailTab.Controls);
        CreateEvent?.Invoke(this, EventArgs.Empty);
        SwitchToDetailTab();
      };

      saveBtn.Click += delegate {
        SaveEvent?.Invoke(this, EventArgs.Empty);
        if (isSuccessful) {
          SwitchToListingTab();
        }
        else {
          MessageBox.Show(message);
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
          SwitchToDetailTab();
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

    public CBMComboBox GetMemberComboBox() {
      return memberComboBox;
    }

    public CBMComboBox GetSubscriptionPlanComboBox() {
      return subscriptionPlanComboBox;
    }

    public object memberId {
      get => memberComboBox.SelectedValue;
      set => memberComboBox.SelectedItem = value;
    }
    public object subscriptionPlanId {
      get => subscriptionPlanComboBox.SelectedValue;
      set => subscriptionPlanComboBox.SelectedItem = value;
    }
    public bool isRenewal {
      get => renewalField.Checked;
      set => renewalField.Checked = value;
    }
    public DateTime startDate {
      get => startDateField.Value;
      set => startDateField.Value = value;
    }
    public DateTime endDate {
      get => endDateField.Value;
      set => endDateField.Value = value;
    }
    public object status {
      get => statusField.SelectedValue;
      set => statusField.SelectedItem = value;
    }

    #endregion
  }
}
