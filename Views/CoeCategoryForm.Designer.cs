using FontAwesome.Sharp;
using System.Drawing;

namespace CBM.Views {
  partial class CoeCategoryForm {
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CoeCategoryForm));
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
      this.nameField = new CBM.Customs.CBMTextbox();
      this.periodYearField = new CBM.Customs.CBMTextbox();
      this.periodYearLabel = new System.Windows.Forms.Label();
      this.engineCapacityField = new CBM.Customs.CBMTextbox();
      this.engineCapacityLabel = new System.Windows.Forms.Label();
      this.maxPowerOutputField = new CBM.Customs.CBMTextbox();
      this.maxPowerOutputLabel = new System.Windows.Forms.Label();
      this.priceField = new CBM.Customs.CBMTextbox();
      this.priceLabel = new System.Windows.Forms.Label();
      this.descriptionField = new CBM.Customs.CBMTextbox();
      this.nameLabel = new System.Windows.Forms.Label();
      this.descriptionLabel = new System.Windows.Forms.Label();
      this.panel1 = new System.Windows.Forms.Panel();
      this.saveBtn = new CBM.Customs.CBMButton();
      this.cancelBtn = new CBM.Customs.CBMButton();
      this.informationLabel = new System.Windows.Forms.Label();
      this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
      this.tabControl.SuspendLayout();
      this.listingTab.SuspendLayout();
      this.panel4.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
      this.panel3.SuspendLayout();
      this.panel2.SuspendLayout();
      this.detailTab.SuspendLayout();
      this.panel1.SuspendLayout();
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
      this.tabControl.Size = new System.Drawing.Size(1501, 1310);
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
      this.listingTab.Size = new System.Drawing.Size(1485, 1263);
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
      this.panel4.Size = new System.Drawing.Size(1479, 964);
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
      this.dataGridView.Size = new System.Drawing.Size(1419, 924);
      this.dataGridView.TabIndex = 2;
      // 
      // panel3
      // 
      this.panel3.Controls.Add(this.prePageBtn);
      this.panel3.Controls.Add(this.nextPageBtn);
      this.panel3.Controls.Add(this.pageLabel);
      this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.panel3.Location = new System.Drawing.Point(3, 1127);
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
      this.detailTab.Controls.Add(this.nameField);
      this.detailTab.Controls.Add(this.periodYearField);
      this.detailTab.Controls.Add(this.periodYearLabel);
      this.detailTab.Controls.Add(this.engineCapacityField);
      this.detailTab.Controls.Add(this.engineCapacityLabel);
      this.detailTab.Controls.Add(this.maxPowerOutputField);
      this.detailTab.Controls.Add(this.maxPowerOutputLabel);
      this.detailTab.Controls.Add(this.priceField);
      this.detailTab.Controls.Add(this.priceLabel);
      this.detailTab.Controls.Add(this.descriptionField);
      this.detailTab.Controls.Add(this.nameLabel);
      this.detailTab.Controls.Add(this.descriptionLabel);
      this.detailTab.Controls.Add(this.panel1);
      this.detailTab.Location = new System.Drawing.Point(8, 39);
      this.detailTab.Name = "detailTab";
      this.detailTab.Padding = new System.Windows.Forms.Padding(3);
      this.detailTab.Size = new System.Drawing.Size(1485, 1263);
      this.detailTab.TabIndex = 1;
      this.detailTab.Text = "tabPage2";
      this.detailTab.UseVisualStyleBackColor = true;
      // 
      // nameField
      // 
      this.nameField.BackColor = System.Drawing.Color.White;
      this.nameField.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
      this.nameField.BorderFocusColor = System.Drawing.Color.Black;
      this.nameField.BorderRadius = 0;
      this.nameField.BorderSize = 2;
      this.nameField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.nameField.ForeColor = System.Drawing.Color.DimGray;
      this.nameField.IsFocused = true;
      this.nameField.Location = new System.Drawing.Point(562, 223);
      this.nameField.Margin = new System.Windows.Forms.Padding(4);
      this.nameField.Multiline = false;
      this.nameField.Name = "nameField";
      this.nameField.Padding = new System.Windows.Forms.Padding(14);
      this.nameField.PasswordChar = false;
      this.nameField.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
      this.nameField.PlaceholderText = "";
      this.nameField.Size = new System.Drawing.Size(604, 59);
      this.nameField.TabIndex = 77;
      this.nameField.Texts = "";
      this.nameField.UnderlinedStyle = false;
      // 
      // periodYearField
      // 
      this.periodYearField.BackColor = System.Drawing.Color.White;
      this.periodYearField.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
      this.periodYearField.BorderFocusColor = System.Drawing.Color.Black;
      this.periodYearField.BorderRadius = 0;
      this.periodYearField.BorderSize = 2;
      this.periodYearField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.periodYearField.ForeColor = System.Drawing.Color.DimGray;
      this.periodYearField.IsFocused = true;
      this.periodYearField.Location = new System.Drawing.Point(562, 1139);
      this.periodYearField.Margin = new System.Windows.Forms.Padding(4);
      this.periodYearField.Multiline = false;
      this.periodYearField.Name = "periodYearField";
      this.periodYearField.Padding = new System.Windows.Forms.Padding(14);
      this.periodYearField.PasswordChar = false;
      this.periodYearField.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
      this.periodYearField.PlaceholderText = "";
      this.periodYearField.Size = new System.Drawing.Size(604, 59);
      this.periodYearField.TabIndex = 76;
      this.periodYearField.Texts = "";
      this.periodYearField.UnderlinedStyle = false;
      // 
      // periodYearLabel
      // 
      this.periodYearLabel.AutoSize = true;
      this.periodYearLabel.Location = new System.Drawing.Point(39, 1154);
      this.periodYearLabel.Name = "periodYearLabel";
      this.periodYearLabel.Size = new System.Drawing.Size(126, 25);
      this.periodYearLabel.TabIndex = 75;
      this.periodYearLabel.Text = "Period Year";
      // 
      // engineCapacityField
      // 
      this.engineCapacityField.BackColor = System.Drawing.Color.White;
      this.engineCapacityField.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
      this.engineCapacityField.BorderFocusColor = System.Drawing.Color.Black;
      this.engineCapacityField.BorderRadius = 0;
      this.engineCapacityField.BorderSize = 2;
      this.engineCapacityField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.engineCapacityField.ForeColor = System.Drawing.Color.DimGray;
      this.engineCapacityField.IsFocused = true;
      this.engineCapacityField.Location = new System.Drawing.Point(562, 721);
      this.engineCapacityField.Margin = new System.Windows.Forms.Padding(4);
      this.engineCapacityField.Multiline = false;
      this.engineCapacityField.Name = "engineCapacityField";
      this.engineCapacityField.Padding = new System.Windows.Forms.Padding(14);
      this.engineCapacityField.PasswordChar = false;
      this.engineCapacityField.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
      this.engineCapacityField.PlaceholderText = "";
      this.engineCapacityField.Size = new System.Drawing.Size(604, 59);
      this.engineCapacityField.TabIndex = 74;
      this.engineCapacityField.Texts = "";
      this.engineCapacityField.UnderlinedStyle = false;
      // 
      // engineCapacityLabel
      // 
      this.engineCapacityLabel.AutoSize = true;
      this.engineCapacityLabel.Location = new System.Drawing.Point(41, 739);
      this.engineCapacityLabel.Name = "engineCapacityLabel";
      this.engineCapacityLabel.Size = new System.Drawing.Size(219, 25);
      this.engineCapacityLabel.TabIndex = 73;
      this.engineCapacityLabel.Text = "Engine Capacity (CC)";
      // 
      // maxPowerOutputField
      // 
      this.maxPowerOutputField.BackColor = System.Drawing.Color.White;
      this.maxPowerOutputField.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
      this.maxPowerOutputField.BorderFocusColor = System.Drawing.Color.Black;
      this.maxPowerOutputField.BorderRadius = 0;
      this.maxPowerOutputField.BorderSize = 2;
      this.maxPowerOutputField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.maxPowerOutputField.ForeColor = System.Drawing.Color.DimGray;
      this.maxPowerOutputField.IsFocused = true;
      this.maxPowerOutputField.Location = new System.Drawing.Point(562, 863);
      this.maxPowerOutputField.Margin = new System.Windows.Forms.Padding(4);
      this.maxPowerOutputField.Multiline = false;
      this.maxPowerOutputField.Name = "maxPowerOutputField";
      this.maxPowerOutputField.Padding = new System.Windows.Forms.Padding(14);
      this.maxPowerOutputField.PasswordChar = false;
      this.maxPowerOutputField.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
      this.maxPowerOutputField.PlaceholderText = "";
      this.maxPowerOutputField.Size = new System.Drawing.Size(604, 59);
      this.maxPowerOutputField.TabIndex = 72;
      this.maxPowerOutputField.Texts = "";
      this.maxPowerOutputField.UnderlinedStyle = false;
      // 
      // maxPowerOutputLabel
      // 
      this.maxPowerOutputLabel.AutoSize = true;
      this.maxPowerOutputLabel.Location = new System.Drawing.Point(41, 874);
      this.maxPowerOutputLabel.Name = "maxPowerOutputLabel";
      this.maxPowerOutputLabel.Size = new System.Drawing.Size(294, 25);
      this.maxPowerOutputLabel.TabIndex = 71;
      this.maxPowerOutputLabel.Text = "Maximum Power Output (KW)";
      // 
      // priceField
      // 
      this.priceField.BackColor = System.Drawing.Color.White;
      this.priceField.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
      this.priceField.BorderFocusColor = System.Drawing.Color.Black;
      this.priceField.BorderRadius = 0;
      this.priceField.BorderSize = 2;
      this.priceField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.priceField.ForeColor = System.Drawing.Color.DimGray;
      this.priceField.IsFocused = true;
      this.priceField.Location = new System.Drawing.Point(562, 999);
      this.priceField.Margin = new System.Windows.Forms.Padding(4);
      this.priceField.Multiline = false;
      this.priceField.Name = "priceField";
      this.priceField.Padding = new System.Windows.Forms.Padding(14);
      this.priceField.PasswordChar = false;
      this.priceField.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
      this.priceField.PlaceholderText = "";
      this.priceField.Size = new System.Drawing.Size(604, 59);
      this.priceField.TabIndex = 70;
      this.priceField.Texts = "";
      this.priceField.UnderlinedStyle = false;
      // 
      // priceLabel
      // 
      this.priceLabel.AutoSize = true;
      this.priceLabel.Location = new System.Drawing.Point(39, 1014);
      this.priceLabel.Name = "priceLabel";
      this.priceLabel.Size = new System.Drawing.Size(93, 25);
      this.priceLabel.TabIndex = 69;
      this.priceLabel.Text = "Price ($)";
      // 
      // descriptionField
      // 
      this.descriptionField.BackColor = System.Drawing.Color.White;
      this.descriptionField.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
      this.descriptionField.BorderFocusColor = System.Drawing.Color.Black;
      this.descriptionField.BorderRadius = 0;
      this.descriptionField.BorderSize = 2;
      this.descriptionField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.descriptionField.ForeColor = System.Drawing.Color.DimGray;
      this.descriptionField.IsFocused = true;
      this.descriptionField.Location = new System.Drawing.Point(562, 367);
      this.descriptionField.Margin = new System.Windows.Forms.Padding(4);
      this.descriptionField.Multiline = true;
      this.descriptionField.Name = "descriptionField";
      this.descriptionField.Padding = new System.Windows.Forms.Padding(14);
      this.descriptionField.PasswordChar = false;
      this.descriptionField.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
      this.descriptionField.PlaceholderText = "";
      this.descriptionField.Size = new System.Drawing.Size(604, 274);
      this.descriptionField.TabIndex = 68;
      this.descriptionField.Texts = "";
      this.descriptionField.UnderlinedStyle = false;
      // 
      // nameLabel
      // 
      this.nameLabel.AutoSize = true;
      this.nameLabel.Location = new System.Drawing.Point(41, 246);
      this.nameLabel.Name = "nameLabel";
      this.nameLabel.Size = new System.Drawing.Size(68, 25);
      this.nameLabel.TabIndex = 55;
      this.nameLabel.Text = "Name";
      // 
      // descriptionLabel
      // 
      this.descriptionLabel.AutoSize = true;
      this.descriptionLabel.Location = new System.Drawing.Point(41, 390);
      this.descriptionLabel.Name = "descriptionLabel";
      this.descriptionLabel.Size = new System.Drawing.Size(120, 25);
      this.descriptionLabel.TabIndex = 56;
      this.descriptionLabel.Text = "Description";
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
      this.informationLabel.Size = new System.Drawing.Size(256, 25);
      this.informationLabel.TabIndex = 37;
      this.informationLabel.Text = "Coe Category Information";
      // 
      // errorProvider
      // 
      this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
      this.errorProvider.ContainerControl = this;
      this.errorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider.Icon")));
      // 
      // CoeCategoryForm
      // 
      this.AcceptButton = this.searchBtn;
      this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.White;
      this.ClientSize = new System.Drawing.Size(1501, 1310);
      this.Controls.Add(this.tabControl);
      this.Location = new System.Drawing.Point(20, 0);
      this.Name = "CoeCategoryForm";
      this.Text = "GroupForm";
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
    private System.Windows.Forms.Label nameLabel;
    private System.Windows.Forms.Label descriptionLabel;
    private System.Windows.Forms.Panel panel1;
    private Customs.CBMButton saveBtn;
    private Customs.CBMButton cancelBtn;
    private System.Windows.Forms.Label informationLabel;
    private Customs.CBMTextbox descriptionField;
    private Customs.CBMTextbox engineCapacityField;
    private System.Windows.Forms.Label engineCapacityLabel;
    private Customs.CBMTextbox maxPowerOutputField;
    private System.Windows.Forms.Label maxPowerOutputLabel;
    private Customs.CBMTextbox priceField;
    private System.Windows.Forms.Label priceLabel;
    private Customs.CBMTextbox periodYearField;
    private System.Windows.Forms.Label periodYearLabel;
    private Customs.CBMTextbox nameField;
  }
}