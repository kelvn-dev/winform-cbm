namespace CBM.Views {
  partial class MarketplaceLoginView {
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MarketplaceLoginView));
      this.headerBar = new System.Windows.Forms.Panel();
      this.restoreBtn = new FontAwesome.Sharp.IconButton();
      this.minBtn = new FontAwesome.Sharp.IconButton();
      this.closeBtn = new FontAwesome.Sharp.IconButton();
      this.instructionLabel = new System.Windows.Forms.Label();
      this.forgotPasswordLabel = new System.Windows.Forms.Label();
      this.messageLabel = new System.Windows.Forms.Label();
      this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
      this.signupLabel = new System.Windows.Forms.Label();
      this.passwordIcon = new FontAwesome.Sharp.IconButton();
      this.emailIcon = new FontAwesome.Sharp.IconButton();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.loginBtn = new CBM.Customs.CBMButton();
      this.passwordField = new CBM.Customs.CBMTextbox();
      this.emailField = new CBM.Customs.CBMTextbox();
      this.headerBar.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.SuspendLayout();
      // 
      // headerBar
      // 
      this.headerBar.Controls.Add(this.restoreBtn);
      this.headerBar.Controls.Add(this.minBtn);
      this.headerBar.Controls.Add(this.closeBtn);
      this.headerBar.Dock = System.Windows.Forms.DockStyle.Top;
      this.headerBar.Location = new System.Drawing.Point(0, 0);
      this.headerBar.Name = "headerBar";
      this.headerBar.Size = new System.Drawing.Size(1748, 71);
      this.headerBar.TabIndex = 0;
      // 
      // restoreBtn
      // 
      this.restoreBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.restoreBtn.IconChar = FontAwesome.Sharp.IconChar.WindowRestore;
      this.restoreBtn.IconColor = System.Drawing.Color.Black;
      this.restoreBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
      this.restoreBtn.Location = new System.Drawing.Point(1580, 11);
      this.restoreBtn.Name = "restoreBtn";
      this.restoreBtn.Size = new System.Drawing.Size(75, 47);
      this.restoreBtn.TabIndex = 2;
      this.restoreBtn.UseVisualStyleBackColor = true;
      // 
      // minBtn
      // 
      this.minBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.minBtn.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
      this.minBtn.IconColor = System.Drawing.Color.Black;
      this.minBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
      this.minBtn.Location = new System.Drawing.Point(1499, 11);
      this.minBtn.Name = "minBtn";
      this.minBtn.Size = new System.Drawing.Size(75, 47);
      this.minBtn.TabIndex = 1;
      this.minBtn.UseVisualStyleBackColor = true;
      // 
      // closeBtn
      // 
      this.closeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.closeBtn.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
      this.closeBtn.IconColor = System.Drawing.Color.Black;
      this.closeBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
      this.closeBtn.Location = new System.Drawing.Point(1661, 12);
      this.closeBtn.Name = "closeBtn";
      this.closeBtn.Size = new System.Drawing.Size(75, 47);
      this.closeBtn.TabIndex = 0;
      this.closeBtn.UseVisualStyleBackColor = true;
      // 
      // instructionLabel
      // 
      this.instructionLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
      this.instructionLabel.AutoSize = true;
      this.instructionLabel.BackColor = System.Drawing.Color.Transparent;
      this.instructionLabel.Location = new System.Drawing.Point(560, 379);
      this.instructionLabel.Name = "instructionLabel";
      this.instructionLabel.Size = new System.Drawing.Size(402, 25);
      this.instructionLabel.TabIndex = 66;
      this.instructionLabel.Text = "Please login to your account to continue.";
      // 
      // forgotPasswordLabel
      // 
      this.forgotPasswordLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
      this.forgotPasswordLabel.AutoSize = true;
      this.forgotPasswordLabel.BackColor = System.Drawing.Color.Transparent;
      this.forgotPasswordLabel.Location = new System.Drawing.Point(984, 811);
      this.forgotPasswordLabel.Name = "forgotPasswordLabel";
      this.forgotPasswordLabel.Size = new System.Drawing.Size(184, 25);
      this.forgotPasswordLabel.TabIndex = 73;
      this.forgotPasswordLabel.Text = "Forgot password?";
      // 
      // messageLabel
      // 
      this.messageLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
      this.messageLabel.AutoSize = true;
      this.messageLabel.BackColor = System.Drawing.Color.Transparent;
      this.messageLabel.Location = new System.Drawing.Point(701, 528);
      this.messageLabel.Name = "messageLabel";
      this.messageLabel.Size = new System.Drawing.Size(261, 25);
      this.messageLabel.TabIndex = 74;
      this.messageLabel.Text = "Wrong email or password.";
      // 
      // errorProvider
      // 
      this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
      this.errorProvider.ContainerControl = this;
      this.errorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider.Icon")));
      // 
      // signupLabel
      // 
      this.signupLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
      this.signupLabel.AutoSize = true;
      this.signupLabel.BackColor = System.Drawing.Color.Transparent;
      this.signupLabel.Location = new System.Drawing.Point(560, 1019);
      this.signupLabel.Name = "signupLabel";
      this.signupLabel.Size = new System.Drawing.Size(441, 25);
      this.signupLabel.TabIndex = 75;
      this.signupLabel.Text = "New to CarBuyer? Sign up for a new account";
      // 
      // passwordIcon
      // 
      this.passwordIcon.Anchor = System.Windows.Forms.AnchorStyles.Top;
      this.passwordIcon.IconChar = FontAwesome.Sharp.IconChar.Lock;
      this.passwordIcon.IconColor = System.Drawing.Color.Black;
      this.passwordIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
      this.passwordIcon.Location = new System.Drawing.Point(582, 707);
      this.passwordIcon.Name = "passwordIcon";
      this.passwordIcon.Size = new System.Drawing.Size(46, 40);
      this.passwordIcon.TabIndex = 71;
      this.passwordIcon.UseVisualStyleBackColor = true;
      // 
      // emailIcon
      // 
      this.emailIcon.Anchor = System.Windows.Forms.AnchorStyles.Top;
      this.emailIcon.IconChar = FontAwesome.Sharp.IconChar.User;
      this.emailIcon.IconColor = System.Drawing.Color.Black;
      this.emailIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
      this.emailIcon.Location = new System.Drawing.Point(579, 616);
      this.emailIcon.Name = "emailIcon";
      this.emailIcon.Size = new System.Drawing.Size(46, 40);
      this.emailIcon.TabIndex = 69;
      this.emailIcon.UseVisualStyleBackColor = true;
      // 
      // pictureBox1
      // 
      this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
      this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
      this.pictureBox1.Image = global::CBM.Properties.Resources.cbm_logo;
      this.pictureBox1.Location = new System.Drawing.Point(549, 77);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(702, 393);
      this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.pictureBox1.TabIndex = 6;
      this.pictureBox1.TabStop = false;
      // 
      // loginBtn
      // 
      this.loginBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
      this.loginBtn.BorderColor = System.Drawing.Color.Empty;
      this.loginBtn.BorderRadius = 0;
      this.loginBtn.BorderSize = 0;
      this.loginBtn.FlatAppearance.BorderSize = 0;
      this.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.loginBtn.Location = new System.Drawing.Point(565, 880);
      this.loginBtn.Name = "loginBtn";
      this.loginBtn.Size = new System.Drawing.Size(686, 84);
      this.loginBtn.TabIndex = 72;
      this.loginBtn.Text = "Login";
      this.loginBtn.UseVisualStyleBackColor = true;
      // 
      // passwordField
      // 
      this.passwordField.Anchor = System.Windows.Forms.AnchorStyles.Top;
      this.passwordField.BackColor = System.Drawing.Color.White;
      this.passwordField.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
      this.passwordField.BorderFocusColor = System.Drawing.Color.Black;
      this.passwordField.BorderRadius = 0;
      this.passwordField.BorderSize = 2;
      this.passwordField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.passwordField.ForeColor = System.Drawing.Color.DimGray;
      this.passwordField.IsFocused = false;
      this.passwordField.Location = new System.Drawing.Point(565, 696);
      this.passwordField.Margin = new System.Windows.Forms.Padding(4);
      this.passwordField.Multiline = false;
      this.passwordField.Name = "passwordField";
      this.passwordField.Padding = new System.Windows.Forms.Padding(14);
      this.passwordField.PasswordChar = true;
      this.passwordField.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
      this.passwordField.PlaceholderText = "";
      this.passwordField.Size = new System.Drawing.Size(686, 59);
      this.passwordField.TabIndex = 70;
      this.passwordField.Texts = "";
      this.passwordField.UnderlinedStyle = false;
      // 
      // emailField
      // 
      this.emailField.Anchor = System.Windows.Forms.AnchorStyles.Top;
      this.emailField.BackColor = System.Drawing.Color.White;
      this.emailField.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
      this.emailField.BorderFocusColor = System.Drawing.Color.Black;
      this.emailField.BorderRadius = 0;
      this.emailField.BorderSize = 2;
      this.emailField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.emailField.ForeColor = System.Drawing.Color.DimGray;
      this.emailField.IsFocused = false;
      this.emailField.Location = new System.Drawing.Point(565, 606);
      this.emailField.Margin = new System.Windows.Forms.Padding(4);
      this.emailField.Multiline = false;
      this.emailField.Name = "emailField";
      this.emailField.Padding = new System.Windows.Forms.Padding(14);
      this.emailField.PasswordChar = false;
      this.emailField.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
      this.emailField.PlaceholderText = "";
      this.emailField.Size = new System.Drawing.Size(686, 59);
      this.emailField.TabIndex = 68;
      this.emailField.Texts = "";
      this.emailField.UnderlinedStyle = false;
      // 
      // MarketplaceLoginView
      // 
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
      this.BackgroundImage = global::CBM.Properties.Resources.background_login;
      this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.ClientSize = new System.Drawing.Size(1748, 1118);
      this.Controls.Add(this.signupLabel);
      this.Controls.Add(this.messageLabel);
      this.Controls.Add(this.forgotPasswordLabel);
      this.Controls.Add(this.loginBtn);
      this.Controls.Add(this.passwordIcon);
      this.Controls.Add(this.passwordField);
      this.Controls.Add(this.emailIcon);
      this.Controls.Add(this.emailField);
      this.Controls.Add(this.instructionLabel);
      this.Controls.Add(this.pictureBox1);
      this.Controls.Add(this.headerBar);
      this.DoubleBuffered = true;
      this.Name = "MarketplaceLoginView";
      this.Text = "Z";
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.headerBar.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.Panel headerBar;
    private FontAwesome.Sharp.IconButton restoreBtn;
    private FontAwesome.Sharp.IconButton minBtn;
    private FontAwesome.Sharp.IconButton closeBtn;
    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.Label instructionLabel;
    private FontAwesome.Sharp.IconButton emailIcon;
    private Customs.CBMTextbox emailField;
    private FontAwesome.Sharp.IconButton passwordIcon;
    private Customs.CBMTextbox passwordField;
    private Customs.CBMButton loginBtn;
    private System.Windows.Forms.Label forgotPasswordLabel;
    private System.Windows.Forms.Label messageLabel;
    private System.Windows.Forms.ErrorProvider errorProvider;
    private System.Windows.Forms.Label signupLabel;
  }
}