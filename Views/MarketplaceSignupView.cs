using CBM.Customs;
using CBM.Models;
using CBM.Presenters;
using CBM.Utilities;
using FontAwesome.Sharp;
using System;
using System.Drawing;
using System.Management;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace CBM.Views {
  public partial class MarketplaceSignupView : Form {

    #region Css

    private void CssThis() {
      // Remove header
      this.Text = string.Empty;
      this.ControlBox = false;
      this.DoubleBuffered = true;
      this.BackColor = ColorTranslator.FromHtml(Constant.BG_COLOR);

      headerBar.BackColor = Color.White;
    }

    private void CssLabel() {
      instructionLabel.ForeColor = ColorTranslator.FromHtml("#595959");
      instructionLabel.Font = new Font(Constant.FONT_FAMILY, Constant.MEDIUM_FONT_SIZE, FontStyle.Regular);

      loginLabel.ForeColor = ColorTranslator.FromHtml(Constant.RED_COLOR);
      loginLabel.Font = new Font(Constant.FONT_FAMILY, Constant.NORMAL_FONT_SIZE, FontStyle.Underline);

      messageLabel.ForeColor = ColorTranslator.FromHtml(Constant.RED_COLOR);
      messageLabel.Font = new Font(Constant.FONT_FAMILY, Constant.MEDIUM_FONT_SIZE, FontStyle.Regular);
      messageLabel.Visible = false;
    }

    private void CssBtn() {
      signupBtn.BackColor = ColorTranslator.FromHtml(Constant.RED_COLOR);
      signupBtn.ForeColor = ColorTranslator.FromHtml(Constant.WHITE_COLOR);
      signupBtn.BorderColor = ColorTranslator.FromHtml(Constant.RED_COLOR);
      signupBtn.BorderRadius = Constant.MIN_BORDER_RADIUS;
      signupBtn.BorderSize = Constant.MIN_BORDER_SIZE;
      signupBtn.Font = new Font(Constant.FONT_FAMILY, Constant.NORMAL_FONT_SIZE);

      UserControlUtils.CssIconButton(emailIcon, Color.White, ColorTranslator.FromHtml(Constant.BLACK_COLOR));
      UserControlUtils.CssIconButton(passwordIcon, Color.White, ColorTranslator.FromHtml(Constant.BLACK_COLOR));
      UserControlUtils.CssIconButton(usernameIcon, Color.White, ColorTranslator.FromHtml(Constant.BLACK_COLOR));
      UserControlUtils.CssIconButton(phoneIcon, Color.White, ColorTranslator.FromHtml(Constant.BLACK_COLOR));
    }

    private void CssTextbox() {
      UserControlUtils.CssLoginTextbox(emailField, "Enter your email");
      UserControlUtils.CssLoginTextbox(passwordField, "Enter your password");
      UserControlUtils.CssLoginTextbox(usernameField, "Enter your username");
      UserControlUtils.CssLoginTextbox(phoneField, "Enter your phone no.");
    }

    #endregion

    public MarketplaceSignupView() {
      InitializeComponent();
      CssThis();
      CssLabel();
      CssBtn();
      CssTextbox();

      UserControlUtils.CssIconButton(closeBtn, Color.White, ColorTranslator.FromHtml(Constant.RED_COLOR));
      UserControlUtils.CssIconButton(restoreBtn, Color.White, ColorTranslator.FromHtml(Constant.YELLO_COLOR));
      UserControlUtils.CssIconButton(minBtn, Color.White, ColorTranslator.FromHtml(Constant.GREEN_COLOR));

      AssociateEvents();
      AssociateValidation();
    }

    #region Common


    #endregion

    #region Validation

    private void AssociateValidation() {
      validationBindingSource.DataSource = new Signup();
      errorProvider.DataSource = validationBindingSource;

      emailField.DataBindings.Add("Texts", errorProvider.DataSource, "email", true, DataSourceUpdateMode.OnPropertyChanged);
      passwordField.DataBindings.Add("Texts", errorProvider.DataSource, "password", true, DataSourceUpdateMode.OnPropertyChanged);
      usernameField.DataBindings.Add("Texts", errorProvider.DataSource, "username", true, DataSourceUpdateMode.OnPropertyChanged);
      phoneField.DataBindings.Add("Texts", errorProvider.DataSource, "phone", true, DataSourceUpdateMode.OnPropertyChanged);

      errorProvider.SetIconPadding(emailField, 50);
      errorProvider.SetIconPadding(passwordField, 50);
      errorProvider.SetIconPadding(usernameField, 50);
      errorProvider.SetIconPadding(phoneField, 50);
    }

    #endregion

    #region Events

    public event EventHandler SignupEvent;

    private void AssociateEvents() {
      closeBtn.Click += CloseForm;
      restoreBtn.Click += RestoreForm;
      minBtn.Click += MinimizeForm;
      loginLabel.Click += delegate {
        this.Hide();
        MarketplaceLoginView loginView = new MarketplaceLoginView();
        new MarketplaceLoginPresenter(loginView);
        loginView.Show();
        this.Hide();
      };

      signupBtn.Click += delegate {
        User validated = validationBindingSource.Current as User;
        if (validated.IsValid) {
          SignupEvent?.Invoke(this, EventArgs.Empty);
          if (isSuccessful) {
            messageLabel.Visible = false;
            MessageBox.Show(message);
            MarketplaceLoginView loginView = new MarketplaceLoginView();
            new MarketplaceLoginPresenter(loginView);
            loginView.Show();
            this.Hide();
          }
          else {
            messageLabel.Text = message;
            messageLabel.Visible = true;
          }
        }
      };

      phoneField.KeyPress += EventHandlerUtils.AllowInteger_KeyPress;
    }

    //Drag Form
    [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
    private extern static void ReleaseCapture();
    [DllImport("user32.DLL", EntryPoint = "SendMessage")]
    private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
    private void DragForm(object sender, MouseEventArgs e) {
      ReleaseCapture();
      SendMessage(this.Handle, 0x112, 0xf012, 0);
    }

    private void CloseForm(object sender, EventArgs e) {
      this.Close();
    }
    private void RestoreForm(object sender, EventArgs e) {
      if (WindowState == FormWindowState.Normal) {
        WindowState = FormWindowState.Maximized;
      }
      else {
        WindowState = FormWindowState.Normal;
      }
    }
    private void MinimizeForm(object sender, EventArgs e) {
      WindowState = FormWindowState.Minimized;
    }

    #endregion

    #region Variables

    private bool _isSuccessful;
    private Member _member;
    private string _message;
    private BindingSource validationBindingSource = new BindingSource();

    public bool isSuccessful {
      get => _isSuccessful;
      set => _isSuccessful = value;
    }
    public string message {
      get => _message;
      set => _message = value;
    }
    public Member member {
      get => _member;
      set => _member = value;
    }

    public string email {
      get => emailField.Texts;
      set => emailField.Texts = value;
    }
    public string password {
      get => passwordField.Texts;
      set => passwordField.Texts = value;
    }
    public string username {
      get => usernameField.Texts;
      set => usernameField.Texts = value;
    }
    public string phone {
      get => phoneField.Texts;
      set => phoneField.Texts = value;
    }

    #endregion
  }
}
