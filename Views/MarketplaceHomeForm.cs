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
  public partial class MarketplaceHomeForm : Form {

    #region Css

    private void CssBtn() {
      UserControlUtils.CssCancelBtn(cancelBtn);
      UserControlUtils.CssCancelBtn(resetPasswordBtn);
      UserControlUtils.CssSaveBtn(saveBtn);
    }
    private void CssLabel() {
      UserControlUtils.CssInformationLabel(informationLabel);
      UserControlUtils.CssFieldLabel(avatarLabel);
      UserControlUtils.CssFieldLabel(usernameLabel);
      UserControlUtils.CssFieldLabel(emailLabel);
      UserControlUtils.CssFieldLabel(phoneLabel);
      UserControlUtils.CssFieldLabel(addressLabel);
      UserControlUtils.CssFieldLabel(oldPassowordLabel);
      UserControlUtils.CssFieldLabel(passowordLabel);
    }
    private void CssTextbox() {
      UserControlUtils.CssTextbox(usernameField, "Enter your username");
      UserControlUtils.CssTextbox(emailField, "Enter your email");
      UserControlUtils.CssTextbox(phoneField, "Enter your phone number");
      UserControlUtils.CssTextbox(addressField, "Enter your address");
      UserControlUtils.CssTextbox(zipcodeField, "Zip Code");
      UserControlUtils.CssTextbox(oldPasswordField, "Old password");
      UserControlUtils.CssTextbox(passwordField, "New password");
    }
    private void CssIconPictureBox() {
      avatarPictureBox.Click += UploadAvatar;
      avatarPictureBox.IconColor = ColorTranslator.FromHtml("#183153");
      avatarPictureBox.ForeColor = ColorTranslator.FromHtml("#183153");
    }

    #endregion

    public MarketplaceHomeForm(Member member) {
      InitializeComponent();

      CssBtn();
      CssLabel();
      CssTextbox();
      CssIconPictureBox();

      this.member = member;
      id = member.id;
      informationLabel.Text += member.username;
      //username = member.username.Trim();
      //email = member.email.Trim();
      //phone = member.phone.Trim();
      //address = member.address.Trim();
      //zipcode = member.zipcode.Trim();
      //if (member.avatar != null) {
      //  MemoryStream stream = new MemoryStream(member.avatar);
      //  avatarPictureBox.Image = Image.FromStream(stream);
      //}

      AssociateEvents();
      AssociateValidation();
    }

    #region Common

    #endregion

    #region Validation

    private void AssociateValidation() {
      validationBindingSource.DataSource = member;
      errorProvider.DataSource = validationBindingSource;

      usernameField.DataBindings.Add("Texts", errorProvider.DataSource, "username", true, DataSourceUpdateMode.OnPropertyChanged);
      emailField.DataBindings.Add("Texts", errorProvider.DataSource, "email", true, DataSourceUpdateMode.OnPropertyChanged);
      phoneField.DataBindings.Add("Texts", errorProvider.DataSource, "phone", true, DataSourceUpdateMode.OnPropertyChanged);

      errorProvider.SetIconPadding(usernameField, 50);
      errorProvider.SetIconPadding(emailField, 50);
      errorProvider.SetIconPadding(phoneField, 50);

      // Password ErrorProvider
      passwordValidationBindingSource.DataSource = new ResetPassword();
      passwordErrorProvider.DataSource = passwordValidationBindingSource;

      oldPasswordField.DataBindings.Add("Texts", passwordErrorProvider.DataSource, "oldPassword", true, DataSourceUpdateMode.OnPropertyChanged);
      passwordField.DataBindings.Add("Texts", passwordErrorProvider.DataSource, "password", true, DataSourceUpdateMode.OnPropertyChanged);

      passwordErrorProvider.SetIconPadding(oldPasswordField, 50);
      passwordErrorProvider.SetIconPadding(passwordField, 50);
    }

    #endregion

    #region Events

    public event EventHandler SaveEvent;
    public event EventHandler ResetPasswordEvent;

    private void AssociateEvents() {

      passwordField.Enter += delegate {
        passwordField.Texts = string.Empty;
      };

      saveBtn.Click += delegate {
        validationBindingSource.EndEdit();
        Member validated = validationBindingSource.Current as Member;
        if (validated.IsValid) {
          SaveEvent?.Invoke(this, EventArgs.Empty);
          if (isSuccessful) {
          }
          else {
            MessageBox.Show(message);
          }
        }
      };

      cancelBtn.Click += delegate {
        username = member.username.Trim();
        email = member.email.Trim();
        phone = member.phone.Trim();
        address = member.address.Trim();
        zipcode = member.zipcode.Trim();
      };

      resetPasswordBtn.Click += delegate {
        validationBindingSource.EndEdit();
        ResetPassword validated = passwordValidationBindingSource.Current as ResetPassword;
        if (validated.IsValid) {
          ResetPasswordEvent?.Invoke(this, EventArgs.Empty);
          MessageBox.Show(message);
          oldPasswordField.Texts = string.Empty;
          passwordField.Texts = string.Empty;
        }
      };

      phoneField.KeyPress += EventHandlerUtils.AllowInteger_KeyPress;
      zipcodeField.KeyPress += EventHandlerUtils.AllowInteger_KeyPress;
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
    private bool _isSuccessful;
    private string _message;
    public Member member;
    private BindingSource validationBindingSource = new BindingSource();
    private BindingSource passwordValidationBindingSource = new BindingSource();

    public Guid id {
      get => _id;
      set => _id = value;
    }
    public bool isSuccessful {
      get => _isSuccessful;
      set => _isSuccessful = value;
    }
    public string message {
      get => _message;
      set => _message = value;
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
    public string password {
      get => passwordField.Texts;
    }
    public string oldPassword {
      get => oldPasswordField.Texts;
    }
    public Image avatar {
      get => avatarPictureBox.Image;
      set => avatarPictureBox.Image = value;
    }
    public string avatarFilename;

    #endregion
  }
}
