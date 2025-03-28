using FontAwesome.Sharp;
using System.Drawing;

namespace CBM.Views {
  partial class VariantForm {
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VariantForm));
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
      this.brandComboBox = new CBM.Customs.CBMComboBox();
      this.brandLabel = new System.Windows.Forms.Label();
      this.smartKeyLabel = new System.Windows.Forms.Label();
      this.smartKeyField = new CBM.Customs.CBMCheckBox();
      this.bluetoothInterfaceLabel = new System.Windows.Forms.Label();
      this.bluetoothInterfaceField = new CBM.Customs.CBMCheckBox();
      this.navigationSystemLabel = new System.Windows.Forms.Label();
      this.navigationSystemField = new CBM.Customs.CBMCheckBox();
      this.autoHeadlightLabel = new System.Windows.Forms.Label();
      this.autoHeadlightField = new CBM.Customs.CBMCheckBox();
      this.fuelTypeComboBox = new CBM.Customs.CBMComboBox();
      this.fuelTypeLabel = new System.Windows.Forms.Label();
      this.vehicleModelComboBox = new CBM.Customs.CBMComboBox();
      this.batteryTypeField = new CBM.Customs.CBMTextbox();
      this.batteryTypeLabel = new System.Windows.Forms.Label();
      this.driveTypeField = new CBM.Customs.CBMTextbox();
      this.driveTypeLabel = new System.Windows.Forms.Label();
      this.engineTypeField = new CBM.Customs.CBMTextbox();
      this.engineTypeLabel = new System.Windows.Forms.Label();
      this.variantYearField = new CBM.Customs.CBMTextbox();
      this.variantYearLabel = new System.Windows.Forms.Label();
      this.variantNameField = new CBM.Customs.CBMTextbox();
      this.variantNameLabel = new System.Windows.Forms.Label();
      this.modelNameLabel = new System.Windows.Forms.Label();
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
      this.tabControl.Size = new System.Drawing.Size(1501, 1462);
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
      this.listingTab.Size = new System.Drawing.Size(1485, 1415);
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
      this.panel4.Size = new System.Drawing.Size(1479, 1116);
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
      this.dataGridView.Size = new System.Drawing.Size(1419, 1076);
      this.dataGridView.TabIndex = 2;
      // 
      // panel3
      // 
      this.panel3.Controls.Add(this.prePageBtn);
      this.panel3.Controls.Add(this.nextPageBtn);
      this.panel3.Controls.Add(this.pageLabel);
      this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.panel3.Location = new System.Drawing.Point(3, 1279);
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
      this.detailTab.Controls.Add(this.brandComboBox);
      this.detailTab.Controls.Add(this.brandLabel);
      this.detailTab.Controls.Add(this.smartKeyLabel);
      this.detailTab.Controls.Add(this.smartKeyField);
      this.detailTab.Controls.Add(this.bluetoothInterfaceLabel);
      this.detailTab.Controls.Add(this.bluetoothInterfaceField);
      this.detailTab.Controls.Add(this.navigationSystemLabel);
      this.detailTab.Controls.Add(this.navigationSystemField);
      this.detailTab.Controls.Add(this.autoHeadlightLabel);
      this.detailTab.Controls.Add(this.autoHeadlightField);
      this.detailTab.Controls.Add(this.fuelTypeComboBox);
      this.detailTab.Controls.Add(this.fuelTypeLabel);
      this.detailTab.Controls.Add(this.vehicleModelComboBox);
      this.detailTab.Controls.Add(this.batteryTypeField);
      this.detailTab.Controls.Add(this.batteryTypeLabel);
      this.detailTab.Controls.Add(this.driveTypeField);
      this.detailTab.Controls.Add(this.driveTypeLabel);
      this.detailTab.Controls.Add(this.engineTypeField);
      this.detailTab.Controls.Add(this.engineTypeLabel);
      this.detailTab.Controls.Add(this.variantYearField);
      this.detailTab.Controls.Add(this.variantYearLabel);
      this.detailTab.Controls.Add(this.variantNameField);
      this.detailTab.Controls.Add(this.variantNameLabel);
      this.detailTab.Controls.Add(this.modelNameLabel);
      this.detailTab.Controls.Add(this.panel1);
      this.detailTab.Location = new System.Drawing.Point(8, 39);
      this.detailTab.Name = "detailTab";
      this.detailTab.Padding = new System.Windows.Forms.Padding(3);
      this.detailTab.Size = new System.Drawing.Size(1485, 1415);
      this.detailTab.TabIndex = 1;
      this.detailTab.Text = "tabPage2";
      this.detailTab.UseVisualStyleBackColor = true;
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
      // smartKeyLabel
      // 
      this.smartKeyLabel.AutoSize = true;
      this.smartKeyLabel.Location = new System.Drawing.Point(39, 1227);
      this.smartKeyLabel.Name = "smartKeyLabel";
      this.smartKeyLabel.Size = new System.Drawing.Size(111, 25);
      this.smartKeyLabel.TabIndex = 95;
      this.smartKeyLabel.Text = "Smart Key";
      // 
      // smartKeyField
      // 
      this.smartKeyField.AutoSize = true;
      this.smartKeyField.Location = new System.Drawing.Point(560, 1218);
      this.smartKeyField.MinimumSize = new System.Drawing.Size(90, 44);
      this.smartKeyField.Name = "smartKeyField";
      this.smartKeyField.OffBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(152)))), ((int)(((byte)(152)))));
      this.smartKeyField.OffToggleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.smartKeyField.OnBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(27)))), ((int)(((byte)(36)))));
      this.smartKeyField.OnToggleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.smartKeyField.Size = new System.Drawing.Size(90, 44);
      this.smartKeyField.TabIndex = 94;
      this.smartKeyField.UseVisualStyleBackColor = true;
      // 
      // bluetoothInterfaceLabel
      // 
      this.bluetoothInterfaceLabel.AutoSize = true;
      this.bluetoothInterfaceLabel.Location = new System.Drawing.Point(39, 1103);
      this.bluetoothInterfaceLabel.Name = "bluetoothInterfaceLabel";
      this.bluetoothInterfaceLabel.Size = new System.Drawing.Size(192, 25);
      this.bluetoothInterfaceLabel.TabIndex = 93;
      this.bluetoothInterfaceLabel.Text = "Bluetooth Interface";
      // 
      // bluetoothInterfaceField
      // 
      this.bluetoothInterfaceField.AutoSize = true;
      this.bluetoothInterfaceField.Location = new System.Drawing.Point(560, 1094);
      this.bluetoothInterfaceField.MinimumSize = new System.Drawing.Size(90, 44);
      this.bluetoothInterfaceField.Name = "bluetoothInterfaceField";
      this.bluetoothInterfaceField.OffBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(152)))), ((int)(((byte)(152)))));
      this.bluetoothInterfaceField.OffToggleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.bluetoothInterfaceField.OnBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(27)))), ((int)(((byte)(36)))));
      this.bluetoothInterfaceField.OnToggleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.bluetoothInterfaceField.Size = new System.Drawing.Size(90, 44);
      this.bluetoothInterfaceField.TabIndex = 92;
      this.bluetoothInterfaceField.UseVisualStyleBackColor = true;
      // 
      // navigationSystemLabel
      // 
      this.navigationSystemLabel.AutoSize = true;
      this.navigationSystemLabel.Location = new System.Drawing.Point(39, 976);
      this.navigationSystemLabel.Name = "navigationSystemLabel";
      this.navigationSystemLabel.Size = new System.Drawing.Size(191, 25);
      this.navigationSystemLabel.TabIndex = 91;
      this.navigationSystemLabel.Text = "Navigation System";
      // 
      // navigationSystemField
      // 
      this.navigationSystemField.AutoSize = true;
      this.navigationSystemField.Location = new System.Drawing.Point(560, 967);
      this.navigationSystemField.MinimumSize = new System.Drawing.Size(90, 44);
      this.navigationSystemField.Name = "navigationSystemField";
      this.navigationSystemField.OffBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(152)))), ((int)(((byte)(152)))));
      this.navigationSystemField.OffToggleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.navigationSystemField.OnBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(27)))), ((int)(((byte)(36)))));
      this.navigationSystemField.OnToggleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.navigationSystemField.Size = new System.Drawing.Size(90, 44);
      this.navigationSystemField.TabIndex = 90;
      this.navigationSystemField.UseVisualStyleBackColor = true;
      // 
      // autoHeadlightLabel
      // 
      this.autoHeadlightLabel.AutoSize = true;
      this.autoHeadlightLabel.Location = new System.Drawing.Point(39, 848);
      this.autoHeadlightLabel.Name = "autoHeadlightLabel";
      this.autoHeadlightLabel.Size = new System.Drawing.Size(153, 25);
      this.autoHeadlightLabel.TabIndex = 83;
      this.autoHeadlightLabel.Text = "Auto Headlight";
      // 
      // autoHeadlightField
      // 
      this.autoHeadlightField.AutoSize = true;
      this.autoHeadlightField.Location = new System.Drawing.Point(560, 839);
      this.autoHeadlightField.MinimumSize = new System.Drawing.Size(90, 44);
      this.autoHeadlightField.Name = "autoHeadlightField";
      this.autoHeadlightField.OffBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(152)))), ((int)(((byte)(152)))));
      this.autoHeadlightField.OffToggleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.autoHeadlightField.OnBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(27)))), ((int)(((byte)(36)))));
      this.autoHeadlightField.OnToggleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.autoHeadlightField.Size = new System.Drawing.Size(90, 44);
      this.autoHeadlightField.TabIndex = 82;
      this.autoHeadlightField.UseVisualStyleBackColor = true;
      // 
      // fuelTypeComboBox
      // 
      this.fuelTypeComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.fuelTypeComboBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(27)))), ((int)(((byte)(36)))));
      this.fuelTypeComboBox.BorderSize = 1;
      this.fuelTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
      this.fuelTypeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
      this.fuelTypeComboBox.ForeColor = System.Drawing.Color.DimGray;
      this.fuelTypeComboBox.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(27)))), ((int)(((byte)(36)))));
      this.fuelTypeComboBox.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.fuelTypeComboBox.ListTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(152)))), ((int)(((byte)(152)))));
      this.fuelTypeComboBox.Location = new System.Drawing.Point(44, 685);
      this.fuelTypeComboBox.MinimumSize = new System.Drawing.Size(200, 30);
      this.fuelTypeComboBox.Name = "fuelTypeComboBox";
      this.fuelTypeComboBox.Padding = new System.Windows.Forms.Padding(1);
      this.fuelTypeComboBox.Size = new System.Drawing.Size(606, 66);
      this.fuelTypeComboBox.TabIndex = 81;
      this.fuelTypeComboBox.Texts = "";
      // 
      // fuelTypeLabel
      // 
      this.fuelTypeLabel.AutoSize = true;
      this.fuelTypeLabel.Location = new System.Drawing.Point(39, 622);
      this.fuelTypeLabel.Name = "fuelTypeLabel";
      this.fuelTypeLabel.Size = new System.Drawing.Size(108, 25);
      this.fuelTypeLabel.TabIndex = 80;
      this.fuelTypeLabel.Text = "Fuel Type";
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
      // batteryTypeField
      // 
      this.batteryTypeField.BackColor = System.Drawing.Color.White;
      this.batteryTypeField.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
      this.batteryTypeField.BorderFocusColor = System.Drawing.Color.Black;
      this.batteryTypeField.BorderRadius = 0;
      this.batteryTypeField.BorderSize = 2;
      this.batteryTypeField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.batteryTypeField.ForeColor = System.Drawing.Color.DimGray;
      this.batteryTypeField.IsFocused = true;
      this.batteryTypeField.Location = new System.Drawing.Point(848, 1069);
      this.batteryTypeField.Margin = new System.Windows.Forms.Padding(4);
      this.batteryTypeField.Multiline = false;
      this.batteryTypeField.Name = "batteryTypeField";
      this.batteryTypeField.Padding = new System.Windows.Forms.Padding(14);
      this.batteryTypeField.PasswordChar = false;
      this.batteryTypeField.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
      this.batteryTypeField.PlaceholderText = "";
      this.batteryTypeField.Size = new System.Drawing.Size(604, 59);
      this.batteryTypeField.TabIndex = 78;
      this.batteryTypeField.Texts = "";
      this.batteryTypeField.UnderlinedStyle = false;
      // 
      // batteryTypeLabel
      // 
      this.batteryTypeLabel.AutoSize = true;
      this.batteryTypeLabel.Location = new System.Drawing.Point(843, 1014);
      this.batteryTypeLabel.Name = "batteryTypeLabel";
      this.batteryTypeLabel.Size = new System.Drawing.Size(134, 25);
      this.batteryTypeLabel.TabIndex = 77;
      this.batteryTypeLabel.Text = "Battery Type";
      // 
      // driveTypeField
      // 
      this.driveTypeField.BackColor = System.Drawing.Color.White;
      this.driveTypeField.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
      this.driveTypeField.BorderFocusColor = System.Drawing.Color.Black;
      this.driveTypeField.BorderRadius = 0;
      this.driveTypeField.BorderSize = 2;
      this.driveTypeField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.driveTypeField.ForeColor = System.Drawing.Color.DimGray;
      this.driveTypeField.IsFocused = true;
      this.driveTypeField.Location = new System.Drawing.Point(848, 875);
      this.driveTypeField.Margin = new System.Windows.Forms.Padding(4);
      this.driveTypeField.Multiline = false;
      this.driveTypeField.Name = "driveTypeField";
      this.driveTypeField.Padding = new System.Windows.Forms.Padding(14);
      this.driveTypeField.PasswordChar = false;
      this.driveTypeField.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
      this.driveTypeField.PlaceholderText = "";
      this.driveTypeField.Size = new System.Drawing.Size(604, 59);
      this.driveTypeField.TabIndex = 76;
      this.driveTypeField.Texts = "";
      this.driveTypeField.UnderlinedStyle = false;
      // 
      // driveTypeLabel
      // 
      this.driveTypeLabel.AutoSize = true;
      this.driveTypeLabel.Location = new System.Drawing.Point(843, 820);
      this.driveTypeLabel.Name = "driveTypeLabel";
      this.driveTypeLabel.Size = new System.Drawing.Size(116, 25);
      this.driveTypeLabel.TabIndex = 75;
      this.driveTypeLabel.Text = "Drive Type";
      // 
      // engineTypeField
      // 
      this.engineTypeField.BackColor = System.Drawing.Color.White;
      this.engineTypeField.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
      this.engineTypeField.BorderFocusColor = System.Drawing.Color.Black;
      this.engineTypeField.BorderRadius = 0;
      this.engineTypeField.BorderSize = 2;
      this.engineTypeField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.engineTypeField.ForeColor = System.Drawing.Color.DimGray;
      this.engineTypeField.IsFocused = true;
      this.engineTypeField.Location = new System.Drawing.Point(848, 676);
      this.engineTypeField.Margin = new System.Windows.Forms.Padding(4);
      this.engineTypeField.Multiline = false;
      this.engineTypeField.Name = "engineTypeField";
      this.engineTypeField.Padding = new System.Windows.Forms.Padding(14);
      this.engineTypeField.PasswordChar = false;
      this.engineTypeField.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
      this.engineTypeField.PlaceholderText = "";
      this.engineTypeField.Size = new System.Drawing.Size(604, 59);
      this.engineTypeField.TabIndex = 74;
      this.engineTypeField.Texts = "";
      this.engineTypeField.UnderlinedStyle = false;
      // 
      // engineTypeLabel
      // 
      this.engineTypeLabel.AutoSize = true;
      this.engineTypeLabel.Location = new System.Drawing.Point(843, 621);
      this.engineTypeLabel.Name = "engineTypeLabel";
      this.engineTypeLabel.Size = new System.Drawing.Size(133, 25);
      this.engineTypeLabel.TabIndex = 73;
      this.engineTypeLabel.Text = "Engine Type";
      // 
      // variantYearField
      // 
      this.variantYearField.BackColor = System.Drawing.Color.White;
      this.variantYearField.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
      this.variantYearField.BorderFocusColor = System.Drawing.Color.Black;
      this.variantYearField.BorderRadius = 0;
      this.variantYearField.BorderSize = 2;
      this.variantYearField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.variantYearField.ForeColor = System.Drawing.Color.DimGray;
      this.variantYearField.IsFocused = true;
      this.variantYearField.Location = new System.Drawing.Point(848, 481);
      this.variantYearField.Margin = new System.Windows.Forms.Padding(4);
      this.variantYearField.Multiline = false;
      this.variantYearField.Name = "variantYearField";
      this.variantYearField.Padding = new System.Windows.Forms.Padding(14);
      this.variantYearField.PasswordChar = false;
      this.variantYearField.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
      this.variantYearField.PlaceholderText = "";
      this.variantYearField.Size = new System.Drawing.Size(604, 59);
      this.variantYearField.TabIndex = 72;
      this.variantYearField.Texts = "";
      this.variantYearField.UnderlinedStyle = false;
      // 
      // variantYearLabel
      // 
      this.variantYearLabel.AutoSize = true;
      this.variantYearLabel.Location = new System.Drawing.Point(843, 426);
      this.variantYearLabel.Name = "variantYearLabel";
      this.variantYearLabel.Size = new System.Drawing.Size(132, 25);
      this.variantYearLabel.TabIndex = 71;
      this.variantYearLabel.Text = "Variant Year";
      // 
      // variantNameField
      // 
      this.variantNameField.BackColor = System.Drawing.Color.White;
      this.variantNameField.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
      this.variantNameField.BorderFocusColor = System.Drawing.Color.Black;
      this.variantNameField.BorderRadius = 0;
      this.variantNameField.BorderSize = 2;
      this.variantNameField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.variantNameField.ForeColor = System.Drawing.Color.DimGray;
      this.variantNameField.IsFocused = true;
      this.variantNameField.Location = new System.Drawing.Point(848, 285);
      this.variantNameField.Margin = new System.Windows.Forms.Padding(4);
      this.variantNameField.Multiline = false;
      this.variantNameField.Name = "variantNameField";
      this.variantNameField.Padding = new System.Windows.Forms.Padding(14);
      this.variantNameField.PasswordChar = false;
      this.variantNameField.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
      this.variantNameField.PlaceholderText = "";
      this.variantNameField.Size = new System.Drawing.Size(604, 59);
      this.variantNameField.TabIndex = 70;
      this.variantNameField.Texts = "";
      this.variantNameField.UnderlinedStyle = false;
      // 
      // variantNameLabel
      // 
      this.variantNameLabel.AutoSize = true;
      this.variantNameLabel.Location = new System.Drawing.Point(845, 222);
      this.variantNameLabel.Name = "variantNameLabel";
      this.variantNameLabel.Size = new System.Drawing.Size(80, 25);
      this.variantNameLabel.TabIndex = 69;
      this.variantNameLabel.Text = "Variant";
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
      this.informationLabel.Size = new System.Drawing.Size(192, 25);
      this.informationLabel.TabIndex = 37;
      this.informationLabel.Text = "Variant Information";
      // 
      // errorProvider
      // 
      this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
      this.errorProvider.ContainerControl = this;
      this.errorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider.Icon")));
      // 
      // VariantForm
      // 
      this.AcceptButton = this.searchBtn;
      this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.White;
      this.ClientSize = new System.Drawing.Size(1501, 1462);
      this.Controls.Add(this.tabControl);
      this.Location = new System.Drawing.Point(20, 0);
      this.Name = "VariantForm";
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
    private System.Windows.Forms.Panel panel1;
    private Customs.CBMButton saveBtn;
    private Customs.CBMButton cancelBtn;
    private System.Windows.Forms.Label informationLabel;
    private Customs.CBMTextbox variantYearField;
    private System.Windows.Forms.Label variantYearLabel;
    private Customs.CBMTextbox variantNameField;
    private System.Windows.Forms.Label variantNameLabel;
    private Customs.CBMTextbox engineTypeField;
    private System.Windows.Forms.Label engineTypeLabel;
    private Customs.CBMTextbox batteryTypeField;
    private System.Windows.Forms.Label batteryTypeLabel;
    private Customs.CBMTextbox driveTypeField;
    private System.Windows.Forms.Label driveTypeLabel;
    private System.Windows.Forms.Label modelNameLabel;
    private Customs.CBMComboBox vehicleModelComboBox;
    private Customs.CBMComboBox fuelTypeComboBox;
    private System.Windows.Forms.Label fuelTypeLabel;
    private Customs.CBMCheckBox autoHeadlightField;
    private System.Windows.Forms.Label bluetoothInterfaceLabel;
    private Customs.CBMCheckBox bluetoothInterfaceField;
    private System.Windows.Forms.Label navigationSystemLabel;
    private Customs.CBMCheckBox navigationSystemField;
    private System.Windows.Forms.Label autoHeadlightLabel;
    private System.Windows.Forms.Label smartKeyLabel;
    private Customs.CBMCheckBox smartKeyField;
    private Customs.CBMComboBox brandComboBox;
    private System.Windows.Forms.Label brandLabel;
  }
}