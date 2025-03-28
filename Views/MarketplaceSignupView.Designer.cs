namespace CBM.Views {
  partial class MarketplaceSignupView {
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MarketplaceSignupView));
      this.headerBar = new System.Windows.Forms.Panel();
      this.restoreBtn = new FontAwesome.Sharp.IconButton();
      this.minBtn = new FontAwesome.Sharp.IconButton();
      this.closeBtn = new FontAwesome.Sharp.IconButton();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.instructionLabel = new System.Windows.Forms.Label();
      this.emailIcon = new FontAwesome.Sharp.IconButton();
      this.passwordIcon = new FontAwesome.Sharp.IconButton();
      this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
      this.loginLabel = new System.Windows.Forms.Label();
      this.usernameIcon = new FontAwesome.Sharp.IconButton();
      this.phoneIcon = new FontAwesome.Sharp.IconButton();
      this.messageLabel = new System.Windows.Forms.Label();
      this.phoneField = new CBM.Customs.CBMTextbox();
      this.usernameField = new CBM.Customs.CBMTextbox();
      this.signupBtn = new CBM.Customs.CBMButton();
      this.passwordField = new CBM.Customs.CBMTextbox();
      this.emailField = new CBM.Customs.CBMTextbox();
      this.headerBar.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
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
      // instructionLabel
      // 
      this.instructionLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
      this.instructionLabel.AutoSize = true;
      this.instructionLabel.BackColor = System.Drawing.Color.Transparent;
      this.instructionLabel.Location = new System.Drawing.Point(716, 381);
      this.instructionLabel.Name = "instructionLabel";
      this.instructionLabel.Size = new System.Drawing.Size(212, 25);
      this.instructionLabel.TabIndex = 66;
      this.instructionLabel.Text = "Sign up new account";
      // 
      // emailIcon
      // 
      this.emailIcon.Anchor = System.Windows.Forms.AnchorStyles.Top;
      this.emailIcon.IconChar = FontAwesome.Sharp.IconChar.User;
      this.emailIcon.IconColor = System.Drawing.Color.Black;
      this.emailIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
      this.emailIcon.Location = new System.Drawing.Point(579, 626);
      this.emailIcon.Name = "emailIcon";
      this.emailIcon.Size = new System.Drawing.Size(46, 40);
      this.emailIcon.TabIndex = 69;
      this.emailIcon.UseVisualStyleBackColor = true;
      // 
      // passwordIcon
      // 
      this.passwordIcon.Anchor = System.Windows.Forms.AnchorStyles.Top;
      this.passwordIcon.IconChar = FontAwesome.Sharp.IconChar.Lock;
      this.passwordIcon.IconColor = System.Drawing.Color.Black;
      this.passwordIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
      this.passwordIcon.Location = new System.Drawing.Point(582, 838);
      this.passwordIcon.Name = "passwordIcon";
      this.passwordIcon.Size = new System.Drawing.Size(46, 40);
      this.passwordIcon.TabIndex = 71;
      this.passwordIcon.UseVisualStyleBackColor = true;
      // 
      // errorProvider
      // 
      this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
      this.errorProvider.ContainerControl = this;
      this.errorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider.Icon")));
      // 
      // loginLabel
      // 
      this.loginLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
      this.loginLabel.AutoSize = true;
      this.loginLabel.BackColor = System.Drawing.Color.Transparent;
      this.loginLabel.Location = new System.Drawing.Point(577, 1074);
      this.loginLabel.Name = "loginLabel";
      this.loginLabel.Size = new System.Drawing.Size(441, 25);
      this.loginLabel.TabIndex = 75;
      this.loginLabel.Text = "Already have an account? Login to CarBuyer";
      // 
      // usernameIcon
      // 
      this.usernameIcon.Anchor = System.Windows.Forms.AnchorStyles.Top;
      this.usernameIcon.IconChar = FontAwesome.Sharp.IconChar.CircleUser;
      this.usernameIcon.IconColor = System.Drawing.Color.Black;
      this.usernameIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
      this.usernameIcon.Location = new System.Drawing.Point(579, 518);
      this.usernameIcon.Name = "usernameIcon";
      this.usernameIcon.Size = new System.Drawing.Size(46, 40);
      this.usernameIcon.TabIndex = 77;
      this.usernameIcon.UseVisualStyleBackColor = true;
      // 
      // phoneIcon
      // 
      this.phoneIcon.Anchor = System.Windows.Forms.AnchorStyles.Top;
      this.phoneIcon.IconChar = FontAwesome.Sharp.IconChar.Phone;
      this.phoneIcon.IconColor = System.Drawing.Color.Black;
      this.phoneIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
      this.phoneIcon.Location = new System.Drawing.Point(579, 731);
      this.phoneIcon.Name = "phoneIcon";
      this.phoneIcon.Size = new System.Drawing.Size(46, 40);
      this.phoneIcon.TabIndex = 79;
      this.phoneIcon.UseVisualStyleBackColor = true;
      // 
      // messageLabel
      // 
      this.messageLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
      this.messageLabel.AutoSize = true;
      this.messageLabel.BackColor = System.Drawing.Color.Transparent;
      this.messageLabel.Location = new System.Drawing.Point(617, 445);
      this.messageLabel.Name = "messageLabel";
      this.messageLabel.Size = new System.Drawing.Size(359, 25);
      this.messageLabel.TabIndex = 80;
      this.messageLabel.Text = "Account with this email already exist";
      // 
      // phoneField
      // 
      this.phoneField.Anchor = System.Windows.Forms.AnchorStyles.Top;
      this.phoneField.BackColor = System.Drawing.Color.White;
      this.phoneField.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
      this.phoneField.BorderFocusColor = System.Drawing.Color.Black;
      this.phoneField.BorderRadius = 0;
      this.phoneField.BorderSize = 2;
      this.phoneField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.phoneField.ForeColor = System.Drawing.Color.DimGray;
      this.phoneField.IsFocused = false;
      this.phoneField.Location = new System.Drawing.Point(565, 721);
      this.phoneField.Margin = new System.Windows.Forms.Padding(4);
      this.phoneField.Multiline = false;
      this.phoneField.Name = "phoneField";
      this.phoneField.Padding = new System.Windows.Forms.Padding(14);
      this.phoneField.PasswordChar = false;
      this.phoneField.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
      this.phoneField.PlaceholderText = "";
      this.phoneField.Size = new System.Drawing.Size(686, 59);
      this.phoneField.TabIndex = 78;
      this.phoneField.Texts = "";
      this.phoneField.UnderlinedStyle = false;
      // 
      // usernameField
      // 
      this.usernameField.Anchor = System.Windows.Forms.AnchorStyles.Top;
      this.usernameField.BackColor = System.Drawing.Color.White;
      this.usernameField.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
      this.usernameField.BorderFocusColor = System.Drawing.Color.Black;
      this.usernameField.BorderRadius = 0;
      this.usernameField.BorderSize = 2;
      this.usernameField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.usernameField.ForeColor = System.Drawing.Color.DimGray;
      this.usernameField.IsFocused = false;
      this.usernameField.Location = new System.Drawing.Point(565, 508);
      this.usernameField.Margin = new System.Windows.Forms.Padding(4);
      this.usernameField.Multiline = false;
      this.usernameField.Name = "usernameField";
      this.usernameField.Padding = new System.Windows.Forms.Padding(14);
      this.usernameField.PasswordChar = false;
      this.usernameField.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
      this.usernameField.PlaceholderText = "";
      this.usernameField.Size = new System.Drawing.Size(686, 59);
      this.usernameField.TabIndex = 76;
      this.usernameField.Texts = "";
      this.usernameField.UnderlinedStyle = false;
      // 
      // signupBtn
      // 
      this.signupBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
      this.signupBtn.BorderColor = System.Drawing.Color.Empty;
      this.signupBtn.BorderRadius = 0;
      this.signupBtn.BorderSize = 0;
      this.signupBtn.FlatAppearance.BorderSize = 0;
      this.signupBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.signupBtn.Location = new System.Drawing.Point(565, 955);
      this.signupBtn.Name = "signupBtn";
      this.signupBtn.Size = new System.Drawing.Size(686, 84);
      this.signupBtn.TabIndex = 72;
      this.signupBtn.Text = "Sign up";
      this.signupBtn.UseVisualStyleBackColor = true;
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
      this.passwordField.Location = new System.Drawing.Point(565, 827);
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
      this.emailField.Location = new System.Drawing.Point(565, 616);
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
      // MarketplaceSignupView
      // 
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
      this.BackgroundImage = global::CBM.Properties.Resources.background_login;
      this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.ClientSize = new System.Drawing.Size(1748, 1118);
      this.Controls.Add(this.messageLabel);
      this.Controls.Add(this.phoneIcon);
      this.Controls.Add(this.phoneField);
      this.Controls.Add(this.usernameIcon);
      this.Controls.Add(this.usernameField);
      this.Controls.Add(this.loginLabel);
      this.Controls.Add(this.signupBtn);
      this.Controls.Add(this.passwordIcon);
      this.Controls.Add(this.passwordField);
      this.Controls.Add(this.emailIcon);
      this.Controls.Add(this.emailField);
      this.Controls.Add(this.instructionLabel);
      this.Controls.Add(this.pictureBox1);
      this.Controls.Add(this.headerBar);
      this.DoubleBuffered = true;
      this.Name = "MarketplaceSignupView";
      this.Text = "Z";
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.headerBar.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
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
    private Customs.CBMButton signupBtn;
    private System.Windows.Forms.ErrorProvider errorProvider;
    private System.Windows.Forms.Label loginLabel;
    private FontAwesome.Sharp.IconButton phoneIcon;
    private Customs.CBMTextbox phoneField;
    private FontAwesome.Sharp.IconButton usernameIcon;
    private Customs.CBMTextbox usernameField;
    private System.Windows.Forms.Label messageLabel;
  }
}