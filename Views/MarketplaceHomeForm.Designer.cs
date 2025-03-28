using FontAwesome.Sharp;
using System.Drawing;

namespace CBM.Views {
  partial class MarketplaceHomeForm {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
      this.phoneLabel = new System.Windows.Forms.Label();
      this.addressLabel = new System.Windows.Forms.Label();
      this.avatarLabel = new System.Windows.Forms.Label();
      this.emailLabel = new System.Windows.Forms.Label();
      this.usernameLabel = new System.Windows.Forms.Label();
      this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
      this.panel1 = new System.Windows.Forms.Panel();
      this.resetPasswordBtn = new CBM.Customs.CBMButton();
      this.saveBtn = new CBM.Customs.CBMButton();
      this.cancelBtn = new CBM.Customs.CBMButton();
      this.informationLabel = new System.Windows.Forms.Label();
      this.oldPassowordLabel = new System.Windows.Forms.Label();
      this.passowordLabel = new System.Windows.Forms.Label();
      this.passwordErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
      this.passwordField = new CBM.Customs.CBMTextbox();
      this.oldPasswordField = new CBM.Customs.CBMTextbox();
      this.addressField = new CBM.Customs.CBMTextbox();
      this.zipcodeField = new CBM.Customs.CBMTextbox();
      this.phoneField = new CBM.Customs.CBMTextbox();
      this.emailField = new CBM.Customs.CBMTextbox();
      this.usernameField = new CBM.Customs.CBMTextbox();
      this.avatarPictureBox = new CBM.Customs.CBMPictureBox();
      ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
      this.panel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.passwordErrorProvider)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.avatarPictureBox)).BeginInit();
      this.SuspendLayout();
      // 
      // phoneLabel
      // 
      this.phoneLabel.AutoSize = true;
      this.phoneLabel.Location = new System.Drawing.Point(188, 755);
      this.phoneLabel.Name = "phoneLabel";
      this.phoneLabel.Size = new System.Drawing.Size(155, 25);
      this.phoneLabel.TabIndex = 74;
      this.phoneLabel.Text = "Phone Number";
      // 
      // addressLabel
      // 
      this.addressLabel.AutoSize = true;
      this.addressLabel.Location = new System.Drawing.Point(188, 885);
      this.addressLabel.Name = "addressLabel";
      this.addressLabel.Size = new System.Drawing.Size(91, 25);
      this.addressLabel.TabIndex = 75;
      this.addressLabel.Text = "Address";
      // 
      // avatarLabel
      // 
      this.avatarLabel.AutoSize = true;
      this.avatarLabel.Location = new System.Drawing.Point(188, 160);
      this.avatarLabel.Name = "avatarLabel";
      this.avatarLabel.Size = new System.Drawing.Size(74, 25);
      this.avatarLabel.TabIndex = 76;
      this.avatarLabel.Text = "Avatar";
      // 
      // emailLabel
      // 
      this.emailLabel.AutoSize = true;
      this.emailLabel.Location = new System.Drawing.Point(188, 622);
      this.emailLabel.Name = "emailLabel";
      this.emailLabel.Size = new System.Drawing.Size(65, 25);
      this.emailLabel.TabIndex = 73;
      this.emailLabel.Text = "Email";
      // 
      // usernameLabel
      // 
      this.usernameLabel.AutoSize = true;
      this.usernameLabel.Location = new System.Drawing.Point(188, 478);
      this.usernameLabel.Name = "usernameLabel";
      this.usernameLabel.Size = new System.Drawing.Size(110, 25);
      this.usernameLabel.TabIndex = 72;
      this.usernameLabel.Text = "Username";
      // 
      // errorProvider
      // 
      this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
      this.errorProvider.ContainerControl = this;
      this.errorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider.Icon")));
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.resetPasswordBtn);
      this.panel1.Controls.Add(this.saveBtn);
      this.panel1.Controls.Add(this.cancelBtn);
      this.panel1.Controls.Add(this.informationLabel);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel1.Location = new System.Drawing.Point(0, 0);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(1501, 134);
      this.panel1.TabIndex = 83;
      // 
      // resetPasswordBtn
      // 
      this.resetPasswordBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.resetPasswordBtn.BorderColor = System.Drawing.Color.Empty;
      this.resetPasswordBtn.BorderRadius = 0;
      this.resetPasswordBtn.BorderSize = 0;
      this.resetPasswordBtn.FlatAppearance.BorderSize = 0;
      this.resetPasswordBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.resetPasswordBtn.Location = new System.Drawing.Point(571, 22);
      this.resetPasswordBtn.Name = "resetPasswordBtn";
      this.resetPasswordBtn.Size = new System.Drawing.Size(322, 93);
      this.resetPasswordBtn.TabIndex = 38;
      this.resetPasswordBtn.Text = "Reset password";
      this.resetPasswordBtn.UseVisualStyleBackColor = true;
      // 
      // saveBtn
      // 
      this.saveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.saveBtn.BorderColor = System.Drawing.Color.Empty;
      this.saveBtn.BorderRadius = 0;
      this.saveBtn.BorderSize = 0;
      this.saveBtn.FlatAppearance.BorderSize = 0;
      this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.saveBtn.Location = new System.Drawing.Point(1189, 22);
      this.saveBtn.Name = "saveBtn";
      this.saveBtn.Size = new System.Drawing.Size(280, 93);
      this.saveBtn.TabIndex = 32;
      this.saveBtn.Text = "Save Changes";
      this.saveBtn.UseVisualStyleBackColor = true;
      // 
      // cancelBtn
      // 
      this.cancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.cancelBtn.BorderColor = System.Drawing.Color.Empty;
      this.cancelBtn.BorderRadius = 0;
      this.cancelBtn.BorderSize = 0;
      this.cancelBtn.FlatAppearance.BorderSize = 0;
      this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.cancelBtn.Location = new System.Drawing.Point(962, 22);
      this.cancelBtn.Name = "cancelBtn";
      this.cancelBtn.Size = new System.Drawing.Size(184, 93);
      this.cancelBtn.TabIndex = 33;
      this.cancelBtn.Text = "Cancel";
      this.cancelBtn.UseVisualStyleBackColor = true;
      // 
      // informationLabel
      // 
      this.informationLabel.AutoSize = true;
      this.informationLabel.Location = new System.Drawing.Point(36, 56);
      this.informationLabel.Name = "informationLabel";
      this.informationLabel.Size = new System.Drawing.Size(113, 25);
      this.informationLabel.TabIndex = 37;
      this.informationLabel.Text = "Welcome, ";
      // 
      // oldPassowordLabel
      // 
      this.oldPassowordLabel.AutoSize = true;
      this.oldPassowordLabel.Location = new System.Drawing.Point(188, 1059);
      this.oldPassowordLabel.Name = "oldPassowordLabel";
      this.oldPassowordLabel.Size = new System.Drawing.Size(143, 25);
      this.oldPassowordLabel.TabIndex = 84;
      this.oldPassowordLabel.Text = "Old password";
      // 
      // passowordLabel
      // 
      this.passowordLabel.AutoSize = true;
      this.passowordLabel.Location = new System.Drawing.Point(188, 1144);
      this.passowordLabel.Name = "passowordLabel";
      this.passowordLabel.Size = new System.Drawing.Size(152, 25);
      this.passowordLabel.TabIndex = 87;
      this.passowordLabel.Text = "New password";
      // 
      // passwordErrorProvider
      // 
      this.passwordErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
      this.passwordErrorProvider.ContainerControl = this;
      this.passwordErrorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("passwordErrorProvider.Icon")));
      // 
      // passwordField
      // 
      this.passwordField.BackColor = System.Drawing.Color.White;
      this.passwordField.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
      this.passwordField.BorderFocusColor = System.Drawing.Color.Black;
      this.passwordField.BorderRadius = 0;
      this.passwordField.BorderSize = 2;
      this.passwordField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.passwordField.ForeColor = System.Drawing.Color.DimGray;
      this.passwordField.IsFocused = false;
      this.passwordField.Location = new System.Drawing.Point(709, 1127);
      this.passwordField.Margin = new System.Windows.Forms.Padding(4);
      this.passwordField.Multiline = false;
      this.passwordField.Name = "passwordField";
      this.passwordField.Padding = new System.Windows.Forms.Padding(14);
      this.passwordField.PasswordChar = true;
      this.passwordField.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
      this.passwordField.PlaceholderText = "New password";
      this.passwordField.Size = new System.Drawing.Size(604, 59);
      this.passwordField.TabIndex = 86;
      this.passwordField.Texts = "";
      this.passwordField.UnderlinedStyle = false;
      // 
      // oldPasswordField
      // 
      this.oldPasswordField.BackColor = System.Drawing.Color.White;
      this.oldPasswordField.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
      this.oldPasswordField.BorderFocusColor = System.Drawing.Color.Black;
      this.oldPasswordField.BorderRadius = 0;
      this.oldPasswordField.BorderSize = 2;
      this.oldPasswordField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.oldPasswordField.ForeColor = System.Drawing.Color.DimGray;
      this.oldPasswordField.IsFocused = false;
      this.oldPasswordField.Location = new System.Drawing.Point(709, 1036);
      this.oldPasswordField.Margin = new System.Windows.Forms.Padding(4);
      this.oldPasswordField.Multiline = false;
      this.oldPasswordField.Name = "oldPasswordField";
      this.oldPasswordField.Padding = new System.Windows.Forms.Padding(14);
      this.oldPasswordField.PasswordChar = true;
      this.oldPasswordField.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
      this.oldPasswordField.PlaceholderText = "Old password";
      this.oldPasswordField.Size = new System.Drawing.Size(604, 59);
      this.oldPasswordField.TabIndex = 85;
      this.oldPasswordField.Texts = "";
      this.oldPasswordField.UnderlinedStyle = false;
      // 
      // addressField
      // 
      this.addressField.BackColor = System.Drawing.Color.White;
      this.addressField.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
      this.addressField.BorderFocusColor = System.Drawing.Color.Black;
      this.addressField.BorderRadius = 0;
      this.addressField.BorderSize = 2;
      this.addressField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.addressField.ForeColor = System.Drawing.Color.DimGray;
      this.addressField.IsFocused = false;
      this.addressField.Location = new System.Drawing.Point(709, 861);
      this.addressField.Margin = new System.Windows.Forms.Padding(4);
      this.addressField.Multiline = false;
      this.addressField.Name = "addressField";
      this.addressField.Padding = new System.Windows.Forms.Padding(14);
      this.addressField.PasswordChar = false;
      this.addressField.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
      this.addressField.PlaceholderText = "";
      this.addressField.Size = new System.Drawing.Size(381, 59);
      this.addressField.TabIndex = 82;
      this.addressField.Texts = "";
      this.addressField.UnderlinedStyle = false;
      // 
      // zipcodeField
      // 
      this.zipcodeField.BackColor = System.Drawing.Color.White;
      this.zipcodeField.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
      this.zipcodeField.BorderFocusColor = System.Drawing.Color.Black;
      this.zipcodeField.BorderRadius = 0;
      this.zipcodeField.BorderSize = 2;
      this.zipcodeField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.zipcodeField.ForeColor = System.Drawing.Color.DimGray;
      this.zipcodeField.IsFocused = false;
      this.zipcodeField.Location = new System.Drawing.Point(1111, 861);
      this.zipcodeField.Margin = new System.Windows.Forms.Padding(4);
      this.zipcodeField.Multiline = false;
      this.zipcodeField.Name = "zipcodeField";
      this.zipcodeField.Padding = new System.Windows.Forms.Padding(14);
      this.zipcodeField.PasswordChar = false;
      this.zipcodeField.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
      this.zipcodeField.PlaceholderText = "";
      this.zipcodeField.Size = new System.Drawing.Size(202, 59);
      this.zipcodeField.TabIndex = 81;
      this.zipcodeField.Texts = "";
      this.zipcodeField.UnderlinedStyle = false;
      // 
      // phoneField
      // 
      this.phoneField.BackColor = System.Drawing.Color.White;
      this.phoneField.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
      this.phoneField.BorderFocusColor = System.Drawing.Color.Black;
      this.phoneField.BorderRadius = 0;
      this.phoneField.BorderSize = 2;
      this.phoneField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.phoneField.ForeColor = System.Drawing.Color.DimGray;
      this.phoneField.IsFocused = false;
      this.phoneField.Location = new System.Drawing.Point(709, 731);
      this.phoneField.Margin = new System.Windows.Forms.Padding(4);
      this.phoneField.Multiline = false;
      this.phoneField.Name = "phoneField";
      this.phoneField.Padding = new System.Windows.Forms.Padding(14);
      this.phoneField.PasswordChar = false;
      this.phoneField.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
      this.phoneField.PlaceholderText = "";
      this.phoneField.Size = new System.Drawing.Size(604, 59);
      this.phoneField.TabIndex = 80;
      this.phoneField.Texts = "";
      this.phoneField.UnderlinedStyle = false;
      // 
      // emailField
      // 
      this.emailField.BackColor = System.Drawing.Color.White;
      this.emailField.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
      this.emailField.BorderFocusColor = System.Drawing.Color.Black;
      this.emailField.BorderRadius = 0;
      this.emailField.BorderSize = 2;
      this.emailField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.emailField.ForeColor = System.Drawing.Color.DimGray;
      this.emailField.IsFocused = false;
      this.emailField.Location = new System.Drawing.Point(709, 599);
      this.emailField.Margin = new System.Windows.Forms.Padding(4);
      this.emailField.Multiline = false;
      this.emailField.Name = "emailField";
      this.emailField.Padding = new System.Windows.Forms.Padding(14);
      this.emailField.PasswordChar = false;
      this.emailField.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
      this.emailField.PlaceholderText = "";
      this.emailField.Size = new System.Drawing.Size(604, 59);
      this.emailField.TabIndex = 79;
      this.emailField.Texts = "";
      this.emailField.UnderlinedStyle = false;
      // 
      // usernameField
      // 
      this.usernameField.BackColor = System.Drawing.Color.White;
      this.usernameField.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
      this.usernameField.BorderFocusColor = System.Drawing.Color.Black;
      this.usernameField.BorderRadius = 0;
      this.usernameField.BorderSize = 2;
      this.usernameField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.usernameField.ForeColor = System.Drawing.Color.DimGray;
      this.usernameField.IsFocused = true;
      this.usernameField.Location = new System.Drawing.Point(709, 460);
      this.usernameField.Margin = new System.Windows.Forms.Padding(4);
      this.usernameField.Multiline = false;
      this.usernameField.Name = "usernameField";
      this.usernameField.Padding = new System.Windows.Forms.Padding(14);
      this.usernameField.PasswordChar = false;
      this.usernameField.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
      this.usernameField.PlaceholderText = "";
      this.usernameField.Size = new System.Drawing.Size(604, 59);
      this.usernameField.TabIndex = 78;
      this.usernameField.Texts = "";
      this.usernameField.UnderlinedStyle = false;
      // 
      // avatarPictureBox
      // 
      this.avatarPictureBox.BackColor = System.Drawing.Color.White;
      this.avatarPictureBox.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
      this.avatarPictureBox.BorderColor = System.Drawing.Color.RoyalBlue;
      this.avatarPictureBox.BorderColor2 = System.Drawing.Color.HotPink;
      this.avatarPictureBox.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
      this.avatarPictureBox.BorderSize = 2;
      this.avatarPictureBox.ForeColor = System.Drawing.SystemColors.ControlText;
      this.avatarPictureBox.GradientAngle = 50F;
      this.avatarPictureBox.IconChar = FontAwesome.Sharp.IconChar.Upload;
      this.avatarPictureBox.IconColor = System.Drawing.SystemColors.ControlText;
      this.avatarPictureBox.IconFont = FontAwesome.Sharp.IconFont.Auto;
      this.avatarPictureBox.IconSize = 270;
      this.avatarPictureBox.Location = new System.Drawing.Point(866, 148);
      this.avatarPictureBox.Name = "avatarPictureBox";
      this.avatarPictureBox.Size = new System.Drawing.Size(270, 270);
      this.avatarPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.avatarPictureBox.TabIndex = 77;
      this.avatarPictureBox.TabStop = false;
      // 
      // HomeForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.White;
      this.ClientSize = new System.Drawing.Size(1501, 1316);
      this.Controls.Add(this.passowordLabel);
      this.Controls.Add(this.passwordField);
      this.Controls.Add(this.oldPasswordField);
      this.Controls.Add(this.oldPassowordLabel);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.addressField);
      this.Controls.Add(this.zipcodeField);
      this.Controls.Add(this.phoneField);
      this.Controls.Add(this.emailField);
      this.Controls.Add(this.usernameField);
      this.Controls.Add(this.usernameLabel);
      this.Controls.Add(this.emailLabel);
      this.Controls.Add(this.avatarLabel);
      this.Controls.Add(this.addressLabel);
      this.Controls.Add(this.phoneLabel);
      this.Controls.Add(this.avatarPictureBox);
      this.Location = new System.Drawing.Point(20, 0);
      this.Name = "HomeForm";
      this.Text = "AdministratorForm";
      ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.passwordErrorProvider)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.avatarPictureBox)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private Customs.CBMPictureBox avatarPictureBox;
    private System.Windows.Forms.Label phoneLabel;
    private System.Windows.Forms.Label addressLabel;
    private System.Windows.Forms.Label avatarLabel;
    private System.Windows.Forms.Label emailLabel;
    private System.Windows.Forms.Label usernameLabel;
    private Customs.CBMTextbox usernameField;
    private Customs.CBMTextbox emailField;
    private Customs.CBMTextbox phoneField;
    private Customs.CBMTextbox zipcodeField;
    private Customs.CBMTextbox addressField;
    private System.Windows.Forms.ErrorProvider errorProvider;
    private Customs.CBMTextbox passwordField;
    private Customs.CBMTextbox oldPasswordField;
    private System.Windows.Forms.Label oldPassowordLabel;
    private System.Windows.Forms.Panel panel1;
    private Customs.CBMButton resetPasswordBtn;
    private Customs.CBMButton saveBtn;
    private Customs.CBMButton cancelBtn;
    private System.Windows.Forms.Label informationLabel;
    private System.Windows.Forms.Label passowordLabel;
    private System.Windows.Forms.ErrorProvider passwordErrorProvider;
  }
}