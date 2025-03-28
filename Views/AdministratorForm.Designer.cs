using FontAwesome.Sharp;
using System.Drawing;

namespace CBM.Views {
  partial class AdministratorForm {
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
      this.pageLabel = new System.Windows.Forms.Label();
      this.panel2 = new System.Windows.Forms.Panel();
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
      this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
      this.searchBtn = new FontAwesome.Sharp.IconButton();
      this.prePageBtn = new FontAwesome.Sharp.IconButton();
      this.nextPageBtn = new FontAwesome.Sharp.IconButton();
      this.avatarPictureBox = new CBM.Customs.CBMPictureBox();
      this.tabControl.SuspendLayout();
      this.listingTab.SuspendLayout();
      this.panel4.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
      this.panel3.SuspendLayout();
      this.panel2.SuspendLayout();
      this.detailTab.SuspendLayout();
      this.panel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.avatarPictureBox)).BeginInit();
      this.SuspendLayout();
      // 
      // tabControl
      // 
      resources.ApplyResources(this.tabControl, "tabControl");
      this.tabControl.Controls.Add(this.listingTab);
      this.tabControl.Controls.Add(this.detailTab);
      this.errorProvider.SetError(this.tabControl, resources.GetString("tabControl.Error"));
      this.errorProvider.SetIconAlignment(this.tabControl, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("tabControl.IconAlignment"))));
      this.errorProvider.SetIconPadding(this.tabControl, ((int)(resources.GetObject("tabControl.IconPadding"))));
      this.tabControl.Name = "tabControl";
      this.tabControl.SelectedIndex = 0;
      // 
      // listingTab
      // 
      resources.ApplyResources(this.listingTab, "listingTab");
      this.listingTab.Controls.Add(this.panel4);
      this.listingTab.Controls.Add(this.panel3);
      this.listingTab.Controls.Add(this.panel2);
      this.errorProvider.SetError(this.listingTab, resources.GetString("listingTab.Error"));
      this.errorProvider.SetIconAlignment(this.listingTab, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("listingTab.IconAlignment"))));
      this.errorProvider.SetIconPadding(this.listingTab, ((int)(resources.GetObject("listingTab.IconPadding"))));
      this.listingTab.Name = "listingTab";
      this.listingTab.UseVisualStyleBackColor = true;
      // 
      // panel4
      // 
      resources.ApplyResources(this.panel4, "panel4");
      this.panel4.Controls.Add(this.dataGridView);
      this.errorProvider.SetError(this.panel4, resources.GetString("panel4.Error"));
      this.errorProvider.SetIconAlignment(this.panel4, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("panel4.IconAlignment"))));
      this.errorProvider.SetIconPadding(this.panel4, ((int)(resources.GetObject("panel4.IconPadding"))));
      this.panel4.Name = "panel4";
      // 
      // dataGridView
      // 
      resources.ApplyResources(this.dataGridView, "dataGridView");
      this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.errorProvider.SetError(this.dataGridView, resources.GetString("dataGridView.Error"));
      this.errorProvider.SetIconAlignment(this.dataGridView, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("dataGridView.IconAlignment"))));
      this.errorProvider.SetIconPadding(this.dataGridView, ((int)(resources.GetObject("dataGridView.IconPadding"))));
      this.dataGridView.Name = "dataGridView";
      this.dataGridView.RowTemplate.Height = 33;
      // 
      // panel3
      // 
      resources.ApplyResources(this.panel3, "panel3");
      this.panel3.Controls.Add(this.prePageBtn);
      this.panel3.Controls.Add(this.nextPageBtn);
      this.panel3.Controls.Add(this.pageLabel);
      this.errorProvider.SetError(this.panel3, resources.GetString("panel3.Error"));
      this.errorProvider.SetIconAlignment(this.panel3, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("panel3.IconAlignment"))));
      this.errorProvider.SetIconPadding(this.panel3, ((int)(resources.GetObject("panel3.IconPadding"))));
      this.panel3.Name = "panel3";
      // 
      // pageLabel
      // 
      resources.ApplyResources(this.pageLabel, "pageLabel");
      this.errorProvider.SetError(this.pageLabel, resources.GetString("pageLabel.Error"));
      this.errorProvider.SetIconAlignment(this.pageLabel, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("pageLabel.IconAlignment"))));
      this.errorProvider.SetIconPadding(this.pageLabel, ((int)(resources.GetObject("pageLabel.IconPadding"))));
      this.pageLabel.Name = "pageLabel";
      // 
      // panel2
      // 
      resources.ApplyResources(this.panel2, "panel2");
      this.panel2.Controls.Add(this.searchBtn);
      this.panel2.Controls.Add(this.searchField);
      this.panel2.Controls.Add(this.createBtn);
      this.errorProvider.SetError(this.panel2, resources.GetString("panel2.Error"));
      this.errorProvider.SetIconAlignment(this.panel2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("panel2.IconAlignment"))));
      this.errorProvider.SetIconPadding(this.panel2, ((int)(resources.GetObject("panel2.IconPadding"))));
      this.panel2.Name = "panel2";
      // 
      // searchField
      // 
      resources.ApplyResources(this.searchField, "searchField");
      this.searchField.BackColor = System.Drawing.Color.White;
      this.searchField.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
      this.searchField.BorderFocusColor = System.Drawing.Color.Black;
      this.searchField.BorderRadius = 0;
      this.searchField.BorderSize = 2;
      this.errorProvider.SetError(this.searchField, resources.GetString("searchField.Error"));
      this.searchField.ForeColor = System.Drawing.Color.DimGray;
      this.errorProvider.SetIconAlignment(this.searchField, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("searchField.IconAlignment"))));
      this.errorProvider.SetIconPadding(this.searchField, ((int)(resources.GetObject("searchField.IconPadding"))));
      this.searchField.IsFocused = false;
      this.searchField.Multiline = false;
      this.searchField.Name = "searchField";
      this.searchField.PasswordChar = false;
      this.searchField.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
      this.searchField.PlaceholderText = "";
      this.searchField.Texts = "";
      this.searchField.UnderlinedStyle = false;
      // 
      // createBtn
      // 
      resources.ApplyResources(this.createBtn, "createBtn");
      this.createBtn.BorderColor = System.Drawing.Color.Empty;
      this.createBtn.BorderRadius = 0;
      this.createBtn.BorderSize = 0;
      this.errorProvider.SetError(this.createBtn, resources.GetString("createBtn.Error"));
      this.createBtn.FlatAppearance.BorderSize = 0;
      this.errorProvider.SetIconAlignment(this.createBtn, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("createBtn.IconAlignment"))));
      this.errorProvider.SetIconPadding(this.createBtn, ((int)(resources.GetObject("createBtn.IconPadding"))));
      this.createBtn.Name = "createBtn";
      this.createBtn.UseVisualStyleBackColor = true;
      // 
      // detailTab
      // 
      resources.ApplyResources(this.detailTab, "detailTab");
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
      this.errorProvider.SetError(this.detailTab, resources.GetString("detailTab.Error"));
      this.errorProvider.SetIconAlignment(this.detailTab, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("detailTab.IconAlignment"))));
      this.errorProvider.SetIconPadding(this.detailTab, ((int)(resources.GetObject("detailTab.IconPadding"))));
      this.detailTab.Name = "detailTab";
      this.detailTab.UseVisualStyleBackColor = true;
      // 
      // addressField
      // 
      resources.ApplyResources(this.addressField, "addressField");
      this.addressField.BackColor = System.Drawing.Color.White;
      this.addressField.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
      this.addressField.BorderFocusColor = System.Drawing.Color.Black;
      this.addressField.BorderRadius = 0;
      this.addressField.BorderSize = 2;
      this.errorProvider.SetError(this.addressField, resources.GetString("addressField.Error"));
      this.addressField.ForeColor = System.Drawing.Color.DimGray;
      this.errorProvider.SetIconAlignment(this.addressField, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("addressField.IconAlignment"))));
      this.errorProvider.SetIconPadding(this.addressField, ((int)(resources.GetObject("addressField.IconPadding"))));
      this.addressField.IsFocused = false;
      this.addressField.Multiline = false;
      this.addressField.Name = "addressField";
      this.addressField.PasswordChar = false;
      this.addressField.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
      this.addressField.PlaceholderText = "";
      this.addressField.Texts = "";
      this.addressField.UnderlinedStyle = false;
      // 
      // zipcodeField
      // 
      resources.ApplyResources(this.zipcodeField, "zipcodeField");
      this.zipcodeField.BackColor = System.Drawing.Color.White;
      this.zipcodeField.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
      this.zipcodeField.BorderFocusColor = System.Drawing.Color.Black;
      this.zipcodeField.BorderRadius = 0;
      this.zipcodeField.BorderSize = 2;
      this.errorProvider.SetError(this.zipcodeField, resources.GetString("zipcodeField.Error"));
      this.zipcodeField.ForeColor = System.Drawing.Color.DimGray;
      this.errorProvider.SetIconAlignment(this.zipcodeField, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("zipcodeField.IconAlignment"))));
      this.errorProvider.SetIconPadding(this.zipcodeField, ((int)(resources.GetObject("zipcodeField.IconPadding"))));
      this.zipcodeField.IsFocused = false;
      this.zipcodeField.Multiline = false;
      this.zipcodeField.Name = "zipcodeField";
      this.zipcodeField.PasswordChar = false;
      this.zipcodeField.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
      this.zipcodeField.PlaceholderText = "";
      this.zipcodeField.Texts = "";
      this.zipcodeField.UnderlinedStyle = false;
      // 
      // phoneField
      // 
      resources.ApplyResources(this.phoneField, "phoneField");
      this.phoneField.BackColor = System.Drawing.Color.White;
      this.phoneField.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
      this.phoneField.BorderFocusColor = System.Drawing.Color.Black;
      this.phoneField.BorderRadius = 0;
      this.phoneField.BorderSize = 2;
      this.errorProvider.SetError(this.phoneField, resources.GetString("phoneField.Error"));
      this.phoneField.ForeColor = System.Drawing.Color.DimGray;
      this.errorProvider.SetIconAlignment(this.phoneField, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("phoneField.IconAlignment"))));
      this.errorProvider.SetIconPadding(this.phoneField, ((int)(resources.GetObject("phoneField.IconPadding"))));
      this.phoneField.IsFocused = false;
      this.phoneField.Multiline = false;
      this.phoneField.Name = "phoneField";
      this.phoneField.PasswordChar = false;
      this.phoneField.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
      this.phoneField.PlaceholderText = "";
      this.phoneField.Texts = "";
      this.phoneField.UnderlinedStyle = false;
      // 
      // emailField
      // 
      resources.ApplyResources(this.emailField, "emailField");
      this.emailField.BackColor = System.Drawing.Color.White;
      this.emailField.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
      this.emailField.BorderFocusColor = System.Drawing.Color.Black;
      this.emailField.BorderRadius = 0;
      this.emailField.BorderSize = 2;
      this.errorProvider.SetError(this.emailField, resources.GetString("emailField.Error"));
      this.emailField.ForeColor = System.Drawing.Color.DimGray;
      this.errorProvider.SetIconAlignment(this.emailField, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("emailField.IconAlignment"))));
      this.errorProvider.SetIconPadding(this.emailField, ((int)(resources.GetObject("emailField.IconPadding"))));
      this.emailField.IsFocused = false;
      this.emailField.Multiline = false;
      this.emailField.Name = "emailField";
      this.emailField.PasswordChar = false;
      this.emailField.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
      this.emailField.PlaceholderText = "";
      this.emailField.Texts = "";
      this.emailField.UnderlinedStyle = false;
      // 
      // usernameField
      // 
      resources.ApplyResources(this.usernameField, "usernameField");
      this.usernameField.BackColor = System.Drawing.Color.White;
      this.usernameField.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
      this.usernameField.BorderFocusColor = System.Drawing.Color.Black;
      this.usernameField.BorderRadius = 0;
      this.usernameField.BorderSize = 2;
      this.errorProvider.SetError(this.usernameField, resources.GetString("usernameField.Error"));
      this.usernameField.ForeColor = System.Drawing.Color.DimGray;
      this.errorProvider.SetIconAlignment(this.usernameField, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("usernameField.IconAlignment"))));
      this.errorProvider.SetIconPadding(this.usernameField, ((int)(resources.GetObject("usernameField.IconPadding"))));
      this.usernameField.IsFocused = true;
      this.usernameField.Multiline = false;
      this.usernameField.Name = "usernameField";
      this.usernameField.PasswordChar = false;
      this.usernameField.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
      this.usernameField.PlaceholderText = "";
      this.usernameField.Texts = "";
      this.usernameField.UnderlinedStyle = false;
      // 
      // usernameLabel
      // 
      resources.ApplyResources(this.usernameLabel, "usernameLabel");
      this.errorProvider.SetError(this.usernameLabel, resources.GetString("usernameLabel.Error"));
      this.errorProvider.SetIconAlignment(this.usernameLabel, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("usernameLabel.IconAlignment"))));
      this.errorProvider.SetIconPadding(this.usernameLabel, ((int)(resources.GetObject("usernameLabel.IconPadding"))));
      this.usernameLabel.Name = "usernameLabel";
      // 
      // emailLabel
      // 
      resources.ApplyResources(this.emailLabel, "emailLabel");
      this.errorProvider.SetError(this.emailLabel, resources.GetString("emailLabel.Error"));
      this.errorProvider.SetIconAlignment(this.emailLabel, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("emailLabel.IconAlignment"))));
      this.errorProvider.SetIconPadding(this.emailLabel, ((int)(resources.GetObject("emailLabel.IconPadding"))));
      this.emailLabel.Name = "emailLabel";
      // 
      // panel1
      // 
      resources.ApplyResources(this.panel1, "panel1");
      this.panel1.Controls.Add(this.saveBtn);
      this.panel1.Controls.Add(this.cancelBtn);
      this.panel1.Controls.Add(this.informationLabel);
      this.errorProvider.SetError(this.panel1, resources.GetString("panel1.Error"));
      this.errorProvider.SetIconAlignment(this.panel1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("panel1.IconAlignment"))));
      this.errorProvider.SetIconPadding(this.panel1, ((int)(resources.GetObject("panel1.IconPadding"))));
      this.panel1.Name = "panel1";
      // 
      // saveBtn
      // 
      resources.ApplyResources(this.saveBtn, "saveBtn");
      this.saveBtn.BorderColor = System.Drawing.Color.Empty;
      this.saveBtn.BorderRadius = 0;
      this.saveBtn.BorderSize = 0;
      this.errorProvider.SetError(this.saveBtn, resources.GetString("saveBtn.Error"));
      this.saveBtn.FlatAppearance.BorderSize = 0;
      this.errorProvider.SetIconAlignment(this.saveBtn, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("saveBtn.IconAlignment"))));
      this.errorProvider.SetIconPadding(this.saveBtn, ((int)(resources.GetObject("saveBtn.IconPadding"))));
      this.saveBtn.Name = "saveBtn";
      this.saveBtn.UseVisualStyleBackColor = true;
      // 
      // cancelBtn
      // 
      resources.ApplyResources(this.cancelBtn, "cancelBtn");
      this.cancelBtn.BorderColor = System.Drawing.Color.Empty;
      this.cancelBtn.BorderRadius = 0;
      this.cancelBtn.BorderSize = 0;
      this.errorProvider.SetError(this.cancelBtn, resources.GetString("cancelBtn.Error"));
      this.cancelBtn.FlatAppearance.BorderSize = 0;
      this.errorProvider.SetIconAlignment(this.cancelBtn, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("cancelBtn.IconAlignment"))));
      this.errorProvider.SetIconPadding(this.cancelBtn, ((int)(resources.GetObject("cancelBtn.IconPadding"))));
      this.cancelBtn.Name = "cancelBtn";
      this.cancelBtn.UseVisualStyleBackColor = true;
      // 
      // informationLabel
      // 
      resources.ApplyResources(this.informationLabel, "informationLabel");
      this.errorProvider.SetError(this.informationLabel, resources.GetString("informationLabel.Error"));
      this.errorProvider.SetIconAlignment(this.informationLabel, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("informationLabel.IconAlignment"))));
      this.errorProvider.SetIconPadding(this.informationLabel, ((int)(resources.GetObject("informationLabel.IconPadding"))));
      this.informationLabel.Name = "informationLabel";
      // 
      // avatarLabel
      // 
      resources.ApplyResources(this.avatarLabel, "avatarLabel");
      this.errorProvider.SetError(this.avatarLabel, resources.GetString("avatarLabel.Error"));
      this.errorProvider.SetIconAlignment(this.avatarLabel, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("avatarLabel.IconAlignment"))));
      this.errorProvider.SetIconPadding(this.avatarLabel, ((int)(resources.GetObject("avatarLabel.IconPadding"))));
      this.avatarLabel.Name = "avatarLabel";
      // 
      // addressLabel
      // 
      resources.ApplyResources(this.addressLabel, "addressLabel");
      this.errorProvider.SetError(this.addressLabel, resources.GetString("addressLabel.Error"));
      this.errorProvider.SetIconAlignment(this.addressLabel, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("addressLabel.IconAlignment"))));
      this.errorProvider.SetIconPadding(this.addressLabel, ((int)(resources.GetObject("addressLabel.IconPadding"))));
      this.addressLabel.Name = "addressLabel";
      // 
      // phoneLabel
      // 
      resources.ApplyResources(this.phoneLabel, "phoneLabel");
      this.errorProvider.SetError(this.phoneLabel, resources.GetString("phoneLabel.Error"));
      this.errorProvider.SetIconAlignment(this.phoneLabel, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("phoneLabel.IconAlignment"))));
      this.errorProvider.SetIconPadding(this.phoneLabel, ((int)(resources.GetObject("phoneLabel.IconPadding"))));
      this.phoneLabel.Name = "phoneLabel";
      // 
      // errorProvider
      // 
      this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
      this.errorProvider.ContainerControl = this;
      resources.ApplyResources(this.errorProvider, "errorProvider");
      // 
      // searchBtn
      // 
      resources.ApplyResources(this.searchBtn, "searchBtn");
      this.errorProvider.SetError(this.searchBtn, resources.GetString("searchBtn.Error"));
      this.errorProvider.SetIconAlignment(this.searchBtn, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("searchBtn.IconAlignment"))));
      this.searchBtn.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
      this.searchBtn.IconColor = System.Drawing.Color.Black;
      this.searchBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
      this.errorProvider.SetIconPadding(this.searchBtn, ((int)(resources.GetObject("searchBtn.IconPadding"))));
      this.searchBtn.Name = "searchBtn";
      this.searchBtn.UseVisualStyleBackColor = true;
      // 
      // prePageBtn
      // 
      resources.ApplyResources(this.prePageBtn, "prePageBtn");
      this.errorProvider.SetError(this.prePageBtn, resources.GetString("prePageBtn.Error"));
      this.errorProvider.SetIconAlignment(this.prePageBtn, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("prePageBtn.IconAlignment"))));
      this.prePageBtn.IconChar = FontAwesome.Sharp.IconChar.CaretSquareLeft;
      this.prePageBtn.IconColor = System.Drawing.Color.Black;
      this.prePageBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
      this.errorProvider.SetIconPadding(this.prePageBtn, ((int)(resources.GetObject("prePageBtn.IconPadding"))));
      this.prePageBtn.Name = "prePageBtn";
      this.prePageBtn.UseVisualStyleBackColor = true;
      // 
      // nextPageBtn
      // 
      resources.ApplyResources(this.nextPageBtn, "nextPageBtn");
      this.errorProvider.SetError(this.nextPageBtn, resources.GetString("nextPageBtn.Error"));
      this.errorProvider.SetIconAlignment(this.nextPageBtn, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("nextPageBtn.IconAlignment"))));
      this.nextPageBtn.IconChar = FontAwesome.Sharp.IconChar.SquareCaretRight;
      this.nextPageBtn.IconColor = System.Drawing.Color.Black;
      this.nextPageBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
      this.errorProvider.SetIconPadding(this.nextPageBtn, ((int)(resources.GetObject("nextPageBtn.IconPadding"))));
      this.nextPageBtn.Name = "nextPageBtn";
      this.nextPageBtn.UseVisualStyleBackColor = true;
      // 
      // avatarPictureBox
      // 
      resources.ApplyResources(this.avatarPictureBox, "avatarPictureBox");
      this.avatarPictureBox.BackColor = System.Drawing.Color.White;
      this.avatarPictureBox.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
      this.avatarPictureBox.BorderColor = System.Drawing.Color.RoyalBlue;
      this.avatarPictureBox.BorderColor2 = System.Drawing.Color.HotPink;
      this.avatarPictureBox.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
      this.avatarPictureBox.BorderSize = 2;
      this.errorProvider.SetError(this.avatarPictureBox, resources.GetString("avatarPictureBox.Error"));
      this.avatarPictureBox.ForeColor = System.Drawing.SystemColors.ControlText;
      this.avatarPictureBox.GradientAngle = 50F;
      this.errorProvider.SetIconAlignment(this.avatarPictureBox, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("avatarPictureBox.IconAlignment"))));
      this.avatarPictureBox.IconChar = FontAwesome.Sharp.IconChar.Upload;
      this.avatarPictureBox.IconColor = System.Drawing.SystemColors.ControlText;
      this.avatarPictureBox.IconFont = FontAwesome.Sharp.IconFont.Auto;
      this.errorProvider.SetIconPadding(this.avatarPictureBox, ((int)(resources.GetObject("avatarPictureBox.IconPadding"))));
      this.avatarPictureBox.IconSize = 270;
      this.avatarPictureBox.Name = "avatarPictureBox";
      this.avatarPictureBox.TabStop = false;
      // 
      // AdministratorForm
      // 
      this.AcceptButton = this.searchBtn;
      resources.ApplyResources(this, "$this");
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.White;
      this.Controls.Add(this.tabControl);
      this.Name = "AdministratorForm";
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
      ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.avatarPictureBox)).EndInit();
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