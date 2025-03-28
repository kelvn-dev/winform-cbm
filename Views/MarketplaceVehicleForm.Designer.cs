using FontAwesome.Sharp;
using System.Drawing;

namespace CBM.Views {
  partial class MarketplaceVehicleForm {
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MarketplaceVehicleForm));
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
      this.statusLabel = new System.Windows.Forms.Label();
      this.descriptionField = new CBM.Customs.CBMTextbox();
      this.descriptionLabel = new System.Windows.Forms.Label();
      this.titleField = new CBM.Customs.CBMTextbox();
      this.titleLabel = new System.Windows.Forms.Label();
      this.brandComboBox = new CBM.Customs.CBMComboBox();
      this.brandLabel = new System.Windows.Forms.Label();
      this.variantComboBox = new CBM.Customs.CBMComboBox();
      this.variantLabel = new System.Windows.Forms.Label();
      this.vehicleModelComboBox = new CBM.Customs.CBMComboBox();
      this.priceField = new CBM.Customs.CBMTextbox();
      this.priceLabel = new System.Windows.Forms.Label();
      this.mileageField = new CBM.Customs.CBMTextbox();
      this.mileageLabel = new System.Windows.Forms.Label();
      this.manufacturingYearField = new CBM.Customs.CBMTextbox();
      this.manufacturingYearLabel = new System.Windows.Forms.Label();
      this.plateNoField = new CBM.Customs.CBMTextbox();
      this.plateNoLabel = new System.Windows.Forms.Label();
      this.modelNameLabel = new System.Windows.Forms.Label();
      this.panel1 = new System.Windows.Forms.Panel();
      this.saveBtn = new CBM.Customs.CBMButton();
      this.cancelBtn = new CBM.Customs.CBMButton();
      this.informationLabel = new System.Windows.Forms.Label();
      this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
      this.isMyCar = new CBM.Customs.CBMCheckBox();
      this.myCarLabel = new System.Windows.Forms.Label();
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
      this.tabControl.Size = new System.Drawing.Size(1501, 1649);
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
      this.listingTab.Size = new System.Drawing.Size(1485, 1602);
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
      this.panel4.Size = new System.Drawing.Size(1479, 1303);
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
      this.dataGridView.Size = new System.Drawing.Size(1419, 1263);
      this.dataGridView.TabIndex = 2;
      // 
      // panel3
      // 
      this.panel3.Controls.Add(this.prePageBtn);
      this.panel3.Controls.Add(this.nextPageBtn);
      this.panel3.Controls.Add(this.pageLabel);
      this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.panel3.Location = new System.Drawing.Point(3, 1466);
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
      this.panel2.Controls.Add(this.myCarLabel);
      this.panel2.Controls.Add(this.isMyCar);
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
      this.createBtn.Text = "Sell my car";
      this.createBtn.UseVisualStyleBackColor = true;
      // 
      // detailTab
      // 
      this.detailTab.Controls.Add(this.statusLabel);
      this.detailTab.Controls.Add(this.descriptionField);
      this.detailTab.Controls.Add(this.descriptionLabel);
      this.detailTab.Controls.Add(this.titleField);
      this.detailTab.Controls.Add(this.titleLabel);
      this.detailTab.Controls.Add(this.brandComboBox);
      this.detailTab.Controls.Add(this.brandLabel);
      this.detailTab.Controls.Add(this.variantComboBox);
      this.detailTab.Controls.Add(this.variantLabel);
      this.detailTab.Controls.Add(this.vehicleModelComboBox);
      this.detailTab.Controls.Add(this.priceField);
      this.detailTab.Controls.Add(this.priceLabel);
      this.detailTab.Controls.Add(this.mileageField);
      this.detailTab.Controls.Add(this.mileageLabel);
      this.detailTab.Controls.Add(this.manufacturingYearField);
      this.detailTab.Controls.Add(this.manufacturingYearLabel);
      this.detailTab.Controls.Add(this.plateNoField);
      this.detailTab.Controls.Add(this.plateNoLabel);
      this.detailTab.Controls.Add(this.modelNameLabel);
      this.detailTab.Controls.Add(this.panel1);
      this.detailTab.Location = new System.Drawing.Point(8, 39);
      this.detailTab.Name = "detailTab";
      this.detailTab.Padding = new System.Windows.Forms.Padding(3);
      this.detailTab.Size = new System.Drawing.Size(1485, 1602);
      this.detailTab.TabIndex = 1;
      this.detailTab.Text = "tabPage2";
      this.detailTab.UseVisualStyleBackColor = true;
      // 
      // statusLabel
      // 
      this.statusLabel.AutoSize = true;
      this.statusLabel.Location = new System.Drawing.Point(39, 821);
      this.statusLabel.Name = "statusLabel";
      this.statusLabel.Size = new System.Drawing.Size(73, 25);
      this.statusLabel.TabIndex = 102;
      this.statusLabel.Text = "Status";
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
      this.descriptionField.Location = new System.Drawing.Point(848, 1251);
      this.descriptionField.Margin = new System.Windows.Forms.Padding(4);
      this.descriptionField.Multiline = true;
      this.descriptionField.Name = "descriptionField";
      this.descriptionField.Padding = new System.Windows.Forms.Padding(14);
      this.descriptionField.PasswordChar = false;
      this.descriptionField.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
      this.descriptionField.PlaceholderText = "";
      this.descriptionField.Size = new System.Drawing.Size(604, 222);
      this.descriptionField.TabIndex = 101;
      this.descriptionField.Texts = "";
      this.descriptionField.UnderlinedStyle = false;
      // 
      // descriptionLabel
      // 
      this.descriptionLabel.AutoSize = true;
      this.descriptionLabel.Location = new System.Drawing.Point(843, 1196);
      this.descriptionLabel.Name = "descriptionLabel";
      this.descriptionLabel.Size = new System.Drawing.Size(120, 25);
      this.descriptionLabel.TabIndex = 100;
      this.descriptionLabel.Text = "Description";
      // 
      // titleField
      // 
      this.titleField.BackColor = System.Drawing.Color.White;
      this.titleField.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
      this.titleField.BorderFocusColor = System.Drawing.Color.Black;
      this.titleField.BorderRadius = 0;
      this.titleField.BorderSize = 2;
      this.titleField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.titleField.ForeColor = System.Drawing.Color.DimGray;
      this.titleField.IsFocused = true;
      this.titleField.Location = new System.Drawing.Point(848, 277);
      this.titleField.Margin = new System.Windows.Forms.Padding(4);
      this.titleField.Multiline = false;
      this.titleField.Name = "titleField";
      this.titleField.Padding = new System.Windows.Forms.Padding(14);
      this.titleField.PasswordChar = false;
      this.titleField.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
      this.titleField.PlaceholderText = "";
      this.titleField.Size = new System.Drawing.Size(604, 59);
      this.titleField.TabIndex = 99;
      this.titleField.Texts = "";
      this.titleField.UnderlinedStyle = false;
      // 
      // titleLabel
      // 
      this.titleLabel.AutoSize = true;
      this.titleLabel.Location = new System.Drawing.Point(843, 222);
      this.titleLabel.Name = "titleLabel";
      this.titleLabel.Size = new System.Drawing.Size(53, 25);
      this.titleLabel.TabIndex = 98;
      this.titleLabel.Text = "Title";
      // 
      // brandComboBox
      // 
      this.brandComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.brandComboBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(27)))), ((int)(((byte)(36)))));
      this.brandComboBox.BorderSize = 1;
      this.brandComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
      this.brandComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
      this.brandComboBox.ForeColor = System.Drawing.Color.DimGray;
      this.brandComboBox.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(27)))), ((int)(((byte)(36)))));
      this.brandComboBox.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.brandComboBox.ListTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(152)))), ((int)(((byte)(152)))));
      this.brandComboBox.Location = new System.Drawing.Point(44, 285);
      this.brandComboBox.MinimumSize = new System.Drawing.Size(200, 30);
      this.brandComboBox.Name = "brandComboBox";
      this.brandComboBox.Padding = new System.Windows.Forms.Padding(1);
      this.brandComboBox.Size = new System.Drawing.Size(606, 66);
      this.brandComboBox.TabIndex = 97;
      this.brandComboBox.Texts = "";
      // 
      // brandLabel
      // 
      this.brandLabel.AutoSize = true;
      this.brandLabel.Location = new System.Drawing.Point(39, 222);
      this.brandLabel.Name = "brandLabel";
      this.brandLabel.Size = new System.Drawing.Size(69, 25);
      this.brandLabel.TabIndex = 96;
      this.brandLabel.Text = "Brand";
      // 
      // variantComboBox
      // 
      this.variantComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.variantComboBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(27)))), ((int)(((byte)(36)))));
      this.variantComboBox.BorderSize = 1;
      this.variantComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
      this.variantComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
      this.variantComboBox.ForeColor = System.Drawing.Color.DimGray;
      this.variantComboBox.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(27)))), ((int)(((byte)(36)))));
      this.variantComboBox.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.variantComboBox.ListTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(152)))), ((int)(((byte)(152)))));
      this.variantComboBox.Location = new System.Drawing.Point(44, 685);
      this.variantComboBox.MinimumSize = new System.Drawing.Size(200, 30);
      this.variantComboBox.Name = "variantComboBox";
      this.variantComboBox.Padding = new System.Windows.Forms.Padding(1);
      this.variantComboBox.Size = new System.Drawing.Size(606, 66);
      this.variantComboBox.TabIndex = 81;
      this.variantComboBox.Texts = "";
      // 
      // variantLabel
      // 
      this.variantLabel.AutoSize = true;
      this.variantLabel.Location = new System.Drawing.Point(39, 622);
      this.variantLabel.Name = "variantLabel";
      this.variantLabel.Size = new System.Drawing.Size(80, 25);
      this.variantLabel.TabIndex = 80;
      this.variantLabel.Text = "Variant";
      // 
      // vehicleModelComboBox
      // 
      this.vehicleModelComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.vehicleModelComboBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(27)))), ((int)(((byte)(36)))));
      this.vehicleModelComboBox.BorderSize = 1;
      this.vehicleModelComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
      this.vehicleModelComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
      this.vehicleModelComboBox.ForeColor = System.Drawing.Color.DimGray;
      this.vehicleModelComboBox.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(27)))), ((int)(((byte)(36)))));
      this.vehicleModelComboBox.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.vehicleModelComboBox.ListTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(152)))), ((int)(((byte)(152)))));
      this.vehicleModelComboBox.Location = new System.Drawing.Point(44, 489);
      this.vehicleModelComboBox.MinimumSize = new System.Drawing.Size(200, 30);
      this.vehicleModelComboBox.Name = "vehicleModelComboBox";
      this.vehicleModelComboBox.Padding = new System.Windows.Forms.Padding(1);
      this.vehicleModelComboBox.Size = new System.Drawing.Size(606, 66);
      this.vehicleModelComboBox.TabIndex = 79;
      this.vehicleModelComboBox.Texts = "";
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
      this.priceField.Location = new System.Drawing.Point(848, 1069);
      this.priceField.Margin = new System.Windows.Forms.Padding(4);
      this.priceField.Multiline = false;
      this.priceField.Name = "priceField";
      this.priceField.Padding = new System.Windows.Forms.Padding(14);
      this.priceField.PasswordChar = false;
      this.priceField.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
      this.priceField.PlaceholderText = "";
      this.priceField.Size = new System.Drawing.Size(604, 59);
      this.priceField.TabIndex = 78;
      this.priceField.Texts = "";
      this.priceField.UnderlinedStyle = false;
      // 
      // priceLabel
      // 
      this.priceLabel.AutoSize = true;
      this.priceLabel.Location = new System.Drawing.Point(843, 1014);
      this.priceLabel.Name = "priceLabel";
      this.priceLabel.Size = new System.Drawing.Size(93, 25);
      this.priceLabel.TabIndex = 77;
      this.priceLabel.Text = "Price ($)";
      // 
      // mileageField
      // 
      this.mileageField.BackColor = System.Drawing.Color.White;
      this.mileageField.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
      this.mileageField.BorderFocusColor = System.Drawing.Color.Black;
      this.mileageField.BorderRadius = 0;
      this.mileageField.BorderSize = 2;
      this.mileageField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.mileageField.ForeColor = System.Drawing.Color.DimGray;
      this.mileageField.IsFocused = true;
      this.mileageField.Location = new System.Drawing.Point(848, 875);
      this.mileageField.Margin = new System.Windows.Forms.Padding(4);
      this.mileageField.Multiline = false;
      this.mileageField.Name = "mileageField";
      this.mileageField.Padding = new System.Windows.Forms.Padding(14);
      this.mileageField.PasswordChar = false;
      this.mileageField.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
      this.mileageField.PlaceholderText = "";
      this.mileageField.Size = new System.Drawing.Size(604, 59);
      this.mileageField.TabIndex = 76;
      this.mileageField.Texts = "";
      this.mileageField.UnderlinedStyle = false;
      // 
      // mileageLabel
      // 
      this.mileageLabel.AutoSize = true;
      this.mileageLabel.Location = new System.Drawing.Point(843, 820);
      this.mileageLabel.Name = "mileageLabel";
      this.mileageLabel.Size = new System.Drawing.Size(139, 25);
      this.mileageLabel.TabIndex = 75;
      this.mileageLabel.Text = "Mileage (Km)";
      // 
      // manufacturingYearField
      // 
      this.manufacturingYearField.BackColor = System.Drawing.Color.White;
      this.manufacturingYearField.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
      this.manufacturingYearField.BorderFocusColor = System.Drawing.Color.Black;
      this.manufacturingYearField.BorderRadius = 0;
      this.manufacturingYearField.BorderSize = 2;
      this.manufacturingYearField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.manufacturingYearField.ForeColor = System.Drawing.Color.DimGray;
      this.manufacturingYearField.IsFocused = true;
      this.manufacturingYearField.Location = new System.Drawing.Point(848, 676);
      this.manufacturingYearField.Margin = new System.Windows.Forms.Padding(4);
      this.manufacturingYearField.Multiline = false;
      this.manufacturingYearField.Name = "manufacturingYearField";
      this.manufacturingYearField.Padding = new System.Windows.Forms.Padding(14);
      this.manufacturingYearField.PasswordChar = false;
      this.manufacturingYearField.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
      this.manufacturingYearField.PlaceholderText = "";
      this.manufacturingYearField.Size = new System.Drawing.Size(604, 59);
      this.manufacturingYearField.TabIndex = 74;
      this.manufacturingYearField.Texts = "";
      this.manufacturingYearField.UnderlinedStyle = false;
      // 
      // manufacturingYearLabel
      // 
      this.manufacturingYearLabel.AutoSize = true;
      this.manufacturingYearLabel.Location = new System.Drawing.Point(843, 621);
      this.manufacturingYearLabel.Name = "manufacturingYearLabel";
      this.manufacturingYearLabel.Size = new System.Drawing.Size(201, 25);
      this.manufacturingYearLabel.TabIndex = 73;
      this.manufacturingYearLabel.Text = "Manufacturing Year";
      // 
      // plateNoField
      // 
      this.plateNoField.BackColor = System.Drawing.Color.White;
      this.plateNoField.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
      this.plateNoField.BorderFocusColor = System.Drawing.Color.Black;
      this.plateNoField.BorderRadius = 0;
      this.plateNoField.BorderSize = 2;
      this.plateNoField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.plateNoField.ForeColor = System.Drawing.Color.DimGray;
      this.plateNoField.IsFocused = true;
      this.plateNoField.Location = new System.Drawing.Point(848, 481);
      this.plateNoField.Margin = new System.Windows.Forms.Padding(4);
      this.plateNoField.Multiline = false;
      this.plateNoField.Name = "plateNoField";
      this.plateNoField.Padding = new System.Windows.Forms.Padding(14);
      this.plateNoField.PasswordChar = false;
      this.plateNoField.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
      this.plateNoField.PlaceholderText = "";
      this.plateNoField.Size = new System.Drawing.Size(604, 59);
      this.plateNoField.TabIndex = 72;
      this.plateNoField.Texts = "";
      this.plateNoField.UnderlinedStyle = false;
      // 
      // plateNoLabel
      // 
      this.plateNoLabel.AutoSize = true;
      this.plateNoLabel.Location = new System.Drawing.Point(843, 426);
      this.plateNoLabel.Name = "plateNoLabel";
      this.plateNoLabel.Size = new System.Drawing.Size(100, 25);
      this.plateNoLabel.TabIndex = 71;
      this.plateNoLabel.Text = "Plate No.";
      // 
      // modelNameLabel
      // 
      this.modelNameLabel.AutoSize = true;
      this.modelNameLabel.Location = new System.Drawing.Point(39, 426);
      this.modelNameLabel.Name = "modelNameLabel";
      this.modelNameLabel.Size = new System.Drawing.Size(71, 25);
      this.modelNameLabel.TabIndex = 55;
      this.modelNameLabel.Text = "Model";
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
      this.informationLabel.Size = new System.Drawing.Size(195, 25);
      this.informationLabel.TabIndex = 37;
      this.informationLabel.Text = "Vehicle Information";
      // 
      // errorProvider
      // 
      this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
      this.errorProvider.ContainerControl = this;
      this.errorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider.Icon")));
      // 
      // isMyCar
      // 
      this.isMyCar.AutoSize = true;
      this.isMyCar.Location = new System.Drawing.Point(812, 59);
      this.isMyCar.MinimumSize = new System.Drawing.Size(90, 44);
      this.isMyCar.Name = "isMyCar";
      this.isMyCar.OffBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(152)))), ((int)(((byte)(152)))));
      this.isMyCar.OffToggleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.isMyCar.OnBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(27)))), ((int)(((byte)(36)))));
      this.isMyCar.OnToggleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.isMyCar.Size = new System.Drawing.Size(90, 44);
      this.isMyCar.TabIndex = 83;
      this.isMyCar.UseVisualStyleBackColor = true;
      // 
      // myCarLabel
      // 
      this.myCarLabel.AutoSize = true;
      this.myCarLabel.Location = new System.Drawing.Point(679, 68);
      this.myCarLabel.Name = "myCarLabel";
      this.myCarLabel.Size = new System.Drawing.Size(88, 25);
      this.myCarLabel.TabIndex = 84;
      this.myCarLabel.Text = "My cars";
      // 
      // MarketplaceVehicleForm
      // 
      this.AcceptButton = this.searchBtn;
      this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.White;
      this.ClientSize = new System.Drawing.Size(1501, 1649);
      this.Controls.Add(this.tabControl);
      this.Location = new System.Drawing.Point(20, 0);
      this.Name = "MarketplaceVehicleForm";
      this.Text = "GroupForm";
      this.tabControl.ResumeLayout(false);
      this.listingTab.ResumeLayout(false);
      this.panel4.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
      this.panel3.ResumeLayout(false);
      this.panel3.PerformLayout();
      this.panel2.ResumeLayout(false);
      this.panel2.PerformLayout();
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
    private System.Windows.Forms.Panel panel1;
    private Customs.CBMButton saveBtn;
    private Customs.CBMButton cancelBtn;
    private System.Windows.Forms.Label informationLabel;
    private Customs.CBMTextbox plateNoField;
    private System.Windows.Forms.Label plateNoLabel;
    private Customs.CBMTextbox manufacturingYearField;
    private System.Windows.Forms.Label manufacturingYearLabel;
    private Customs.CBMTextbox priceField;
    private System.Windows.Forms.Label priceLabel;
    private Customs.CBMTextbox mileageField;
    private System.Windows.Forms.Label mileageLabel;
    private System.Windows.Forms.Label modelNameLabel;
    private Customs.CBMComboBox vehicleModelComboBox;
    private Customs.CBMComboBox variantComboBox;
    private System.Windows.Forms.Label variantLabel;
    private Customs.CBMComboBox brandComboBox;
    private System.Windows.Forms.Label brandLabel;
    private Customs.CBMTextbox titleField;
    private System.Windows.Forms.Label titleLabel;
    private Customs.CBMTextbox descriptionField;
    private System.Windows.Forms.Label descriptionLabel;
    private System.Windows.Forms.Label statusLabel;
    private Customs.CBMCheckBox isMyCar;
    private System.Windows.Forms.Label myCarLabel;
  }
}