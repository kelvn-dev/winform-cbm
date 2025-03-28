using FontAwesome.Sharp;
using System.Drawing;

namespace CBM.Views {
  partial class MemberForm {
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdministratorForm));
      this.tabControl = new System.Windows.Forms.TabControl();
      this.listingTab = new System.Windows.Forms.TabPage();
      this.panel4 = new System.Windows.Forms.Panel();
      this.dataGridView = new System.Windows.Forms.DataGridView();
      this.panel3 = new System.Windows.Forms.Panel();
      this.prePageBtn = new FontAwesome.Sharp.IconButton();
      this.nextPageBtn = new FontAwesome.Sharp.IconButton();
      this.pageLabel = new System.Windows.Forms.Label();
      this.panel2 = new System.Windows.Forms.Panel();
      this.searchBtn = new FontAwesome.Sharp.IconButton();
      this.searchField = new CBM.Customs.CBMTextbox();
      this.createBtn = new CBM.Customs.CBMButton();
      this.detailTab = new System.Windows.Forms.TabPage();
      this.addressField = new CBM.Customs.CBMTextbox();
      this.zipcodeField = new CBM.Customs.CBMTextbox();
      this.phoneField = new CBM.Customs.CBMTextbox();
      this.emailField = new CBM.Customs.CBMTextbox();
      this.usernameField = new CBM.Customs.CBMTextbox();
      this.usernameLabel = new System.Windows.Forms.Label();
      this.emailLabel = new System.Windows.Forms.Label();
      this.panel1 = new System.Windows.Forms.Panel();
      this.saveBtn = new CBM.Customs.CBMButton();
      this.cancelBtn = new CBM.Customs.CBMButton();
      this.informationLabel = new System.Windows.Forms.Label();
      this.avatarLabel = new System.Windows.Forms.Label();
      this.addressLabel = new System.Windows.Forms.Label();
      this.phoneLabel = new System.Windows.Forms.Label();
      this.avatarPictureBox = new CBM.Customs.CBMPictureBox();
      this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
      this.tabControl.SuspendLayout();
      this.listingTab.SuspendLayout();
      this.panel4.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
      this.panel3.SuspendLayout();
      this.panel2.SuspendLayout();
      this.detailTab.SuspendLayout();
      this.panel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.avatarPictureBox)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
      this.SuspendLayout();
      // 
      // tabControl
      // 
      this.tabControl.Controls.Add(this.listingTab);
      this.tabControl.Controls.Add(this.detailTab);
      this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tabControl.Location = new System.Drawing.Point(0, 0);
      this.tabControl.Name = "tabControl";
      this.tabControl.SelectedIndex = 0;
      this.tabControl.Size = new System.Drawing.Size(1501, 1069);
      this.tabControl.TabIndex = 0;
      // 
      // listingTab
      // 
      this.listingTab.Controls.Add(this.panel4);
      this.listingTab.Controls.Add(this.panel3);
      this.listingTab.Controls.Add(this.panel2);
      this.listingTab.Location = new System.Drawing.Point(8, 39);
      this.listingTab.Name = "listingTab";
      this.listingTab.Padding = new System.Windows.Forms.Padding(3);
      this.listingTab.Size = new System.Drawing.Size(1485, 1022);
      this.listingTab.TabIndex = 0;
      this.listingTab.Text = "tabPage1";
      this.listingTab.UseVisualStyleBackColor = true;
      // 
      // panel4
      // 
      this.panel4.Controls.Add(this.dataGridView);
      this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel4.Location = new System.Drawing.Point(3, 163);
      this.panel4.Name = "panel4";
      this.panel4.Padding = new System.Windows.Forms.Padding(30, 20, 30, 20);
      this.panel4.Size = new System.Drawing.Size(1479, 723);
      this.panel4.TabIndex = 2;
      // 
      // dataGridView
      // 
      this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dataGridView.Location = new System.Drawing.Point(30, 20);
      this.dataGridView.Name = "dataGridView";
      this.dataGridView.RowHeadersWidth = 82;
      this.dataGridView.RowTemplate.Height = 33;
      this.dataGridView.Size = new System.Drawing.Size(1419, 683);
      this.dataGridView.TabIndex = 2;
      // 
      // panel3
      // 
      this.panel3.Controls.Add(this.prePageBtn);
      this.panel3.Controls.Add(this.nextPageBtn);
      this.panel3.Controls.Add(this.pageLabel);
      this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.panel3.Location = new System.Drawing.Point(3, 886);
      this.panel3.Name = "panel3";
      this.panel3.Size = new System.Drawing.Size(1479, 133);
      this.panel3.TabIndex = 1;
      // 
      // prePageBtn
      // 
      this.prePageBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
      this.prePageBtn.IconChar = FontAwesome.Sharp.IconChar.CaretSquareLeft;
      this.prePageBtn.IconColor = System.Drawing.Color.Black;
      this.prePageBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
      this.prePageBtn.Location = new System.Drawing.Point(641, 53);
      this.prePageBtn.Name = "prePageBtn";
      this.prePageBtn.Size = new System.Drawing.Size(61, 52);
      this.prePageBtn.TabIndex = 2;
      this.prePageBtn.UseVisualStyleBackColor = true;
      // 
      // nextPageBtn
      // 
      this.nextPageBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
      this.nextPageBtn.IconChar = FontAwesome.Sharp.IconChar.SquareCaretRight;
      this.nextPageBtn.IconColor = System.Drawing.Color.Black;
      this.nextPageBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
      this.nextPageBtn.Location = new System.Drawing.Point(787, 53);
      this.nextPageBtn.Name = "nextPageBtn";
      this.nextPageBtn.Size = new System.Drawing.Size(63, 52);
      this.nextPageBtn.TabIndex = 1;
      this.nextPageBtn.UseVisualStyleBackColor = true;
      // 
      // pageLabel
      // 
      this.pageLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
      this.pageLabel.AutoSize = true;
      this.pageLabel.Location = new System.Drawing.Point(713, 61);
      this.pageLabel.Name = "pageLabel";
      this.pageLabel.Size = new System.Drawing.Size(54, 25);
      this.pageLabel.TabIndex = 0;
      this.pageLabel.Text = "0 / 0";
      // 
      // panel2
      // 
      this.panel2.Controls.Add(this.searchBtn);
      this.panel2.Controls.Add(this.searchField);
      this.panel2.Controls.Add(this.createBtn);
      this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel2.Location = new System.Drawing.Point(3, 3);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(1479, 160);
      this.panel2.TabIndex = 0;
      // 
      // searchBtn
      // 
      this.searchBtn.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
      this.searchBtn.IconColor = System.Drawing.Color.Black;
      this.searchBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
      this.searchBtn.Location = new System.Drawing.Point(55, 65);
      this.searchBtn.Name = "searchBtn";
      this.searchBtn.Size = new System.Drawing.Size(46, 40);
      this.searchBtn.TabIndex = 35;
      this.searchBtn.UseVisualStyleBackColor = true;
      // 
      // searchField
      // 
      this.searchField.BackColor = System.Drawing.Color.White;
      this.searchField.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
      this.searchField.BorderFocusColor = System.Drawing.Color.Black;
      this.searchField.BorderRadius = 0;
      this.searchField.BorderSize = 2;
      this.searchField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.searchField.ForeColor = System.Drawing.Color.DimGray;
      this.searchField.IsFocused = false;
      this.searchField.Location = new System.Drawing.Point(30, 53);
      this.searchField.Margin = new System.Windows.Forms.Padding(4);
      this.searchField.Multiline = false;
      this.searchField.Name = "searchField";
      this.searchField.Padding = new System.Windows.Forms.Padding(14);
      this.searchField.PasswordChar = false;
      this.searchField.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
      this.searchField.PlaceholderText = "";
      this.searchField.Size = new System.Drawing.Size(602, 59);
      this.searchField.TabIndex = 34;
      this.searchField.Texts = "";
      this.searchField.UnderlinedStyle = false;
      // 
      // createBtn
      // 
      this.createBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.createBtn.BorderColor = System.Drawing.Color.Empty;
      this.createBtn.BorderRadius = 0;
      this.createBtn.BorderSize = 0;
      this.createBtn.FlatAppearance.BorderSize = 0;
      this.createBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.createBtn.Location = new System.Drawing.Point(1169, 39);
      this.createBtn.Name = "createBtn";
      this.createBtn.Size = new System.Drawing.Size(280, 93);
      this.createBtn.TabIndex = 33;
      this.createBtn.Text = "Add new";
      this.createBtn.UseVisualStyleBackColor = true;
      // 
      // detailTab
      // 
      this.detailTab.Controls.Add(this.addressField);
      this.detailTab.Controls.Add(this.zipcodeField);
      this.detailTab.Controls.Add(this.phoneField);
      this.detailTab.Controls.Add(this.emailField);
      this.detailTab.Controls.Add(this.usernameField);
      this.detailTab.Controls.Add(this.usernameLabel);
      this.detailTab.Controls.Add(this.emailLabel);
      this.detailTab.Controls.Add(this.panel1);
      this.detailTab.Controls.Add(this.avatarLabel);
      this.detailTab.Controls.Add(this.addressLabel);
      this.detailTab.Controls.Add(this.phoneLabel);
      this.detailTab.Controls.Add(this.avatarPictureBox);
      this.detailTab.Location = new System.Drawing.Point(8, 39);
      this.detailTab.Name = "detailTab";
      this.detailTab.Padding = new System.Windows.Forms.Padding(3);
      this.detailTab.Size = new System.Drawing.Size(1485, 1022);
      this.detailTab.TabIndex = 1;
      this.detailTab.Text = "tabPage2";
      this.detailTab.UseVisualStyleBackColor = true;
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
      this.addressField.Location = new System.Drawing.Point(557, 906);
      this.addressField.Margin = new System.Windows.Forms.Padding(4);
      this.addressField.Multiline = false;
      this.addressField.Name = "addressField";
      this.addressField.Padding = new System.Windows.Forms.Padding(14);
      this.addressField.PasswordChar = false;
      this.addressField.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
      this.addressField.PlaceholderText = "";
      this.addressField.Size = new System.Drawing.Size(381, 59);
      this.addressField.TabIndex = 71;
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
      this.zipcodeField.Location = new System.Drawing.Point(959, 906);
      this.zipcodeField.Margin = new System.Windows.Forms.Padding(4);
      this.zipcodeField.Multiline = false;
      this.zipcodeField.Name = "zipcodeField";
      this.zipcodeField.Padding = new System.Windows.Forms.Padding(14);
      this.zipcodeField.PasswordChar = false;
      this.zipcodeField.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
      this.zipcodeField.PlaceholderText = "";
      this.zipcodeField.Size = new System.Drawing.Size(202, 59);
      this.zipcodeField.TabIndex = 70;
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
      this.phoneField.Location = new System.Drawing.Point(557, 776);
      this.phoneField.Margin = new System.Windows.Forms.Padding(4);
      this.phoneField.Multiline = false;
      this.phoneField.Name = "phoneField";
      this.phoneField.Padding = new System.Windows.Forms.Padding(14);
      this.phoneField.PasswordChar = false;
      this.phoneField.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
      this.phoneField.PlaceholderText = "";
      this.phoneField.Size = new System.Drawing.Size(604, 59);
      this.phoneField.TabIndex = 69;
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
      this.emailField.Location = new System.Drawing.Point(557, 644);
      this.emailField.Margin = new System.Windows.Forms.Padding(4);
      this.emailField.Multiline = false;
      this.emailField.Name = "emailField";
      this.emailField.Padding = new System.Windows.Forms.Padding(14);
      this.emailField.PasswordChar = false;
      this.emailField.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
      this.emailField.PlaceholderText = "";
      this.emailField.Size = new System.Drawing.Size(604, 59);
      this.emailField.TabIndex = 68;
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
      this.usernameField.Location = new System.Drawing.Point(557, 505);
      this.usernameField.Margin = new System.Windows.Forms.Padding(4);
      this.usernameField.Multiline = false;
      this.usernameField.Name = "usernameField";
      this.usernameField.Padding = new System.Windows.Forms.Padding(14);
      this.usernameField.PasswordChar = false;
      this.usernameField.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
      this.usernameField.PlaceholderText = "";
      this.usernameField.Size = new System.Drawing.Size(604, 59);
      this.usernameField.TabIndex = 67;
      this.usernameField.Texts = "";
      this.usernameField.UnderlinedStyle = false;
      // 
      // usernameLabel
      // 
      this.usernameLabel.AutoSize = true;
      this.usernameLabel.Location = new System.Drawing.Point(36, 523);
      this.usernameLabel.Name = "usernameLabel";
      this.usernameLabel.Size = new System.Drawing.Size(110, 25);
      this.usernameLabel.TabIndex = 55;
      this.usernameLabel.Text = "Username";
      // 
      // emailLabel
      // 
      this.emailLabel.AutoSize = true;
      this.emailLabel.Location = new System.Drawing.Point(36, 667);
      this.emailLabel.Name = "emailLabel";
      this.emailLabel.Size = new System.Drawing.Size(65, 25);
      this.emailLabel.TabIndex = 56;
      this.emailLabel.Text = "Email";
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.saveBtn);
      this.panel1.Controls.Add(this.cancelBtn);
      this.panel1.Controls.Add(this.informationLabel);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel1.Location = new System.Drawing.Point(3, 3);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(1479, 134);
      this.panel1.TabIndex = 57;
      // 
      // saveBtn
      // 
      this.saveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.saveBtn.BorderColor = System.Drawing.Color.Empty;
      this.saveBtn.BorderRadius = 0;
      this.saveBtn.BorderSize = 0;
      this.saveBtn.FlatAppearance.BorderSize = 0;
      this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.saveBtn.Location = new System.Drawing.Point(1167, 22);
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
      this.cancelBtn.Location = new System.Drawing.Point(940, 22);
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
      this.informationLabel.Size = new System.Drawing.Size(169, 25);
      this.informationLabel.TabIndex = 37;
      this.informationLabel.Text = "User Information";
      // 
      // avatarLabel
      // 
      this.avatarLabel.AutoSize = true;
      this.avatarLabel.Location = new System.Drawing.Point(36, 205);
      this.avatarLabel.Name = "avatarLabel";
      this.avatarLabel.Size = new System.Drawing.Size(74, 25);
      this.avatarLabel.TabIndex = 65;
      this.avatarLabel.Text = "Avatar";
      // 
      // addressLabel
      // 
      this.addressLabel.AutoSize = true;
      this.addressLabel.Location = new System.Drawing.Point(36, 930);
      this.addressLabel.Name = "addressLabel";
      this.addressLabel.Size = new System.Drawing.Size(91, 25);
      this.addressLabel.TabIndex = 61;
      this.addressLabel.Text = "Address";
      // 
      // phoneLabel
      // 
      this.phoneLabel.AutoSize = true;
      this.phoneLabel.Location = new System.Drawing.Point(36, 800);
      this.phoneLabel.Name = "phoneLabel";
      this.phoneLabel.Size = new System.Drawing.Size(155, 25);
      this.phoneLabel.TabIndex = 60;
      this.phoneLabel.Text = "Phone Number";
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
      this.avatarPictureBox.Location = new System.Drawing.Point(714, 193);
      this.avatarPictureBox.Name = "avatarPictureBox";
      this.avatarPictureBox.Size = new System.Drawing.Size(270, 270);
      this.avatarPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.avatarPictureBox.TabIndex = 66;
      this.avatarPictureBox.TabStop = false;
      // 
      // errorProvider
      // 
      this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
      this.errorProvider.ContainerControl = this;
      this.errorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider.Icon")));
      // 
      // AdministratorForm
      // 
      this.AcceptButton = this.searchBtn;
      this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.White;
      this.ClientSize = new System.Drawing.Size(1501, 1069);
      this.Controls.Add(this.tabControl);
      this.Location = new System.Drawing.Point(20, 0);
      this.Name = "AdministratorForm";
      this.Text = "AdministratorForm";
      this.tabControl.ResumeLayout(false);
      this.listingTab.ResumeLayout(false);
      this.panel4.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
      this.panel3.ResumeLayout(false);
      this.panel3.PerformLayout();
      this.panel2.ResumeLayout(false);
      this.detailTab.ResumeLayout(false);
      this.detailTab.PerformLayout();
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.avatarPictureBox)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TabControl tabControl;
    private System.Windows.Forms.TabPage listingTab;
    private System.Windows.Forms.ErrorProvider errorProvider;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.Panel panel4;
    private System.Windows.Forms.DataGridView dataGridView;
    private System.Windows.Forms.Panel panel3;
    private Customs.CBMButton createBtn;
    private Customs.CBMTextbox searchField;
    private IconButton searchBtn;
    private IconButton prePageBtn;
    private IconButton nextPageBtn;
    private System.Windows.Forms.Label pageLabel;
    private System.Windows.Forms.TabPage detailTab;
    private System.Windows.Forms.Label usernameLabel;
    private System.Windows.Forms.Label emailLabel;
    private System.Windows.Forms.Panel panel1;
    private Customs.CBMButton saveBtn;
    private Customs.CBMButton cancelBtn;
    private System.Windows.Forms.Label informationLabel;
    private System.Windows.Forms.Label avatarLabel;
    private System.Windows.Forms.Label addressLabel;
    private System.Windows.Forms.Label phoneLabel;
    private Customs.CBMPictureBox avatarPictureBox;
    private Customs.CBMTextbox addressField;
    private Customs.CBMTextbox zipcodeField;
    private Customs.CBMTextbox phoneField;
    private Customs.CBMTextbox emailField;
    private Customs.CBMTextbox usernameField;
  }
}