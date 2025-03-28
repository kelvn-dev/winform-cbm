using CBM.Models;
using CBM.Utilities;
using FontAwesome.Sharp;
using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Data;
using System.Windows.Forms;
using System.Xml.Linq;
using static CBM.Enums;

namespace CBM.Views {
  public partial class AdministratorForm : Form {

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
      UserControlUtils.CssFieldLabel(avatarLabel);
      UserControlUtils.CssFieldLabel(usernameLabel);
      UserControlUtils.CssFieldLabel(emailLabel);
      UserControlUtils.CssFieldLabel(phoneLabel);
      UserControlUtils.CssFieldLabel(addressLabel);
      UserControlUtils.CssPageLabel(pageLabel);
    }
    private void CssTextbox() {
      UserControlUtils.CssTextbox(usernameField, "Enter your username");
      UserControlUtils.CssTextbox(emailField, "Enter your email");
      UserControlUtils.CssTextbox(phoneField, "Enter your phone number");
      UserControlUtils.CssTextbox(addressField, "Enter your address");
      UserControlUtils.CssTextbox(zipcodeField, "Zip Code");
      UserControlUtils.CssSearchTextbox(searchField);
    }
    private void CssIconPictureBox() {
      avatarPictureBox.Click += UploadAvatar;
      avatarPictureBox.IconColor = ColorTranslator.FromHtml("#183153");
      avatarPictureBox.ForeColor = ColorTranslator.FromHtml("#183153");
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

    public AdministratorForm() {
      InitializeComponent();
      currentPage = 1;

      CssBtn();
      CssLabel();
      CssTextbox();
      CssIconPictureBox();
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
      dataGridView.Columns["avatar"].Visible = false;
      dataGridView.Columns["password"].Visible = false;
      UserControlUtils.AjustHeightAutomatically(dataGridView);
      UserControlUtils.AddActionColumns(dataGridView);
    }

    #endregion

    #region Validation

    private void AssociateValidation() {
      errorProvider.DataSource = validationBindingSource;

      usernameField.DataBindings.Add("Texts", errorProvider.DataSource, "username", true, DataSourceUpdateMode.OnPropertyChanged);
      emailField.DataBindings.Add("Texts", errorProvider.DataSource, "email", true, DataSourceUpdateMode.OnPropertyChanged);
      phoneField.DataBindings.Add("Texts", errorProvider.DataSource, "phone", true, DataSourceUpdateMode.OnPropertyChanged);

      errorProvider.SetIconPadding(usernameField, 50);
      errorProvider.SetIconPadding(emailField, 50);
      errorProvider.SetIconPadding(phoneField, 50);
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
        avatarPictureBox.Image = null;
        validationBindingSource.DataSource = new Administrator();
        CreateEvent?.Invoke(this, EventArgs.Empty);
        UserControlUtils.CleanFields(this.detailTab.Controls);
        SwitchToDetailTab();
        errorProvider.Clear();
      };

      saveBtn.Click += delegate {
        validationBindingSource.EndEdit();
        Administrator validated = validationBindingSource.Current as Administrator;
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
          Administrator validation = new Administrator();
          validation.email = email;
          validation.username = username;
          validation.phone = phone;
          validation.address = address;
          validation.zipcode = zipcode;
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

      phoneField.KeyPress += EventHandlerUtils.AllowInteger_KeyPress;
    }

    private void UploadAvatar(object sender, EventArgs e) {
      OpenFileDialog opnfd = new OpenFileDialog();
      opnfd.Filter = "Image Files (*.png;*.jpg;*.jpeg;.*.gif;)|*.png;*.jpg;*.jpeg;.*.gif";
      if (opnfd.ShowDialog() == DialogResult.OK) {
        avatarPictureBox.Image = new Bitmap(opnfd.FileName);
        avatarFilename = opnfd.FileName;
      }
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

    public string username {
      get => usernameField.Texts;
      set => usernameField.Texts = value;
    }
    public string email {
      get => emailField.Texts;
      set => emailField.Texts = value;
    }
    public string phone {
      get => phoneField.Texts;
      set => phoneField.Texts = value;
    }
    public string address {
      get => addressField.Texts;
      set => addressField.Texts = value;
    }
    public string zipcode {
      get => zipcodeField.Texts;
      set => zipcodeField.Texts = value;
    }
    public Image avatar {
      get => avatarPictureBox.Image;
      set => avatarPictureBox.Image = value;
    }
    public string avatarFilename;

    #endregion
  }
}
