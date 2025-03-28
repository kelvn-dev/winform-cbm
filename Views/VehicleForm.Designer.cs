using FontAwesome.Sharp;
using System.Drawing;

namespace CBM.Views {
  partial class VehicleForm {
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VehicleForm));
      this.tabControl = new System.Windows.Forms.TabControl();
      this.listingTab = new System.Windows.Forms.TabPage();
      this.panel4 = new System.Windows.Forms.Panel();
      this.dataGridView = new System.Windows.Forms.DataGridView();
      this.panel3 = new System.Windows.Forms.Panel();
      this.pageLabel = new System.Windows.Forms.Label();
      this.panel2 = new System.Windows.Forms.Panel();
      this.exportBtn = new CBM.Customs.CBMButton();
      this.searchField = new CBM.Customs.CBMTextbox();
      this.createBtn = new CBM.Customs.CBMButton();
      this.detailTab = new System.Windows.Forms.TabPage();
      this.memberCombobox = new CBM.Customs.CBMComboBox();
      this.memberLabel = new System.Windows.Forms.Label();
      this.buyerBtn = new CBM.Customs.CBMButton();
      this.sellerBtn = new CBM.Customs.CBMButton();
      this.statusField = new CBM.Customs.CBMComboBox();
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
      this.searchBtn = new FontAwesome.Sharp.IconButton();
      this.prePageBtn = new FontAwesome.Sharp.IconButton();
      this.nextPageBtn = new FontAwesome.Sharp.IconButton();
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
      this.panel2.Controls.Add(this.exportBtn);
      this.panel2.Controls.Add(this.searchBtn);
      this.panel2.Controls.Add(this.searchField);
      this.panel2.Controls.Add(this.createBtn);
      this.errorProvider.SetError(this.panel2, resources.GetString("panel2.Error"));
      this.errorProvider.SetIconAlignment(this.panel2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("panel2.IconAlignment"))));
      this.errorProvider.SetIconPadding(this.panel2, ((int)(resources.GetObject("panel2.IconPadding"))));
      this.panel2.Name = "panel2";
      // 
      // exportBtn
      // 
      resources.ApplyResources(this.exportBtn, "exportBtn");
      this.exportBtn.BorderColor = System.Drawing.Color.Empty;
      this.exportBtn.BorderRadius = 0;
      this.exportBtn.BorderSize = 0;
      this.errorProvider.SetError(this.exportBtn, resources.GetString("exportBtn.Error"));
      this.exportBtn.FlatAppearance.BorderSize = 0;
      this.errorProvider.SetIconAlignment(this.exportBtn, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("exportBtn.IconAlignment"))));
      this.errorProvider.SetIconPadding(this.exportBtn, ((int)(resources.GetObject("exportBtn.IconPadding"))));
      this.exportBtn.Name = "exportBtn";
      this.exportBtn.UseVisualStyleBackColor = true;
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
      this.detailTab.Controls.Add(this.memberCombobox);
      this.detailTab.Controls.Add(this.memberLabel);
      this.detailTab.Controls.Add(this.buyerBtn);
      this.detailTab.Controls.Add(this.sellerBtn);
      this.detailTab.Controls.Add(this.statusField);
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
      this.errorProvider.SetError(this.detailTab, resources.GetString("detailTab.Error"));
      this.errorProvider.SetIconAlignment(this.detailTab, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("detailTab.IconAlignment"))));
      this.errorProvider.SetIconPadding(this.detailTab, ((int)(resources.GetObject("detailTab.IconPadding"))));
      this.detailTab.Name = "detailTab";
      this.detailTab.UseVisualStyleBackColor = true;
      // 
      // memberCombobox
      // 
      resources.ApplyResources(this.memberCombobox, "memberCombobox");
      this.memberCombobox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.memberCombobox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(27)))), ((int)(((byte)(36)))));
      this.memberCombobox.BorderSize = 1;
      this.memberCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
      this.errorProvider.SetError(this.memberCombobox, resources.GetString("memberCombobox.Error"));
      this.memberCombobox.ForeColor = System.Drawing.Color.DimGray;
      this.errorProvider.SetIconAlignment(this.memberCombobox, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("memberCombobox.IconAlignment"))));
      this.memberCombobox.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(27)))), ((int)(((byte)(36)))));
      this.errorProvider.SetIconPadding(this.memberCombobox, ((int)(resources.GetObject("memberCombobox.IconPadding"))));
      this.memberCombobox.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.memberCombobox.ListTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(152)))), ((int)(((byte)(152)))));
      this.memberCombobox.Name = "memberCombobox";
      this.memberCombobox.Texts = "";
      // 
      // memberLabel
      // 
      resources.ApplyResources(this.memberLabel, "memberLabel");
      this.errorProvider.SetError(this.memberLabel, resources.GetString("memberLabel.Error"));
      this.errorProvider.SetIconAlignment(this.memberLabel, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("memberLabel.IconAlignment"))));
      this.errorProvider.SetIconPadding(this.memberLabel, ((int)(resources.GetObject("memberLabel.IconPadding"))));
      this.memberLabel.Name = "memberLabel";
      // 
      // buyerBtn
      // 
      resources.ApplyResources(this.buyerBtn, "buyerBtn");
      this.buyerBtn.BorderColor = System.Drawing.Color.Empty;
      this.buyerBtn.BorderRadius = 0;
      this.buyerBtn.BorderSize = 0;
      this.errorProvider.SetError(this.buyerBtn, resources.GetString("buyerBtn.Error"));
      this.buyerBtn.FlatAppearance.BorderSize = 0;
      this.errorProvider.SetIconAlignment(this.buyerBtn, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("buyerBtn.IconAlignment"))));
      this.errorProvider.SetIconPadding(this.buyerBtn, ((int)(resources.GetObject("buyerBtn.IconPadding"))));
      this.buyerBtn.Name = "buyerBtn";
      this.buyerBtn.UseVisualStyleBackColor = true;
      // 
      // sellerBtn
      // 
      resources.ApplyResources(this.sellerBtn, "sellerBtn");
      this.sellerBtn.BorderColor = System.Drawing.Color.Empty;
      this.sellerBtn.BorderRadius = 0;
      this.sellerBtn.BorderSize = 0;
      this.errorProvider.SetError(this.sellerBtn, resources.GetString("sellerBtn.Error"));
      this.sellerBtn.FlatAppearance.BorderSize = 0;
      this.errorProvider.SetIconAlignment(this.sellerBtn, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("sellerBtn.IconAlignment"))));
      this.errorProvider.SetIconPadding(this.sellerBtn, ((int)(resources.GetObject("sellerBtn.IconPadding"))));
      this.sellerBtn.Name = "sellerBtn";
      this.sellerBtn.UseVisualStyleBackColor = true;
      // 
      // statusField
      // 
      resources.ApplyResources(this.statusField, "statusField");
      this.statusField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.statusField.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(27)))), ((int)(((byte)(36)))));
      this.statusField.BorderSize = 1;
      this.statusField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
      this.errorProvider.SetError(this.statusField, resources.GetString("statusField.Error"));
      this.statusField.ForeColor = System.Drawing.Color.DimGray;
      this.errorProvider.SetIconAlignment(this.statusField, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("statusField.IconAlignment"))));
      this.statusField.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(27)))), ((int)(((byte)(36)))));
      this.errorProvider.SetIconPadding(this.statusField, ((int)(resources.GetObject("statusField.IconPadding"))));
      this.statusField.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.statusField.ListTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(152)))), ((int)(((byte)(152)))));
      this.statusField.Name = "statusField";
      this.statusField.Texts = "";
      // 
      // statusLabel
      // 
      resources.ApplyResources(this.statusLabel, "statusLabel");
      this.errorProvider.SetError(this.statusLabel, resources.GetString("statusLabel.Error"));
      this.errorProvider.SetIconAlignment(this.statusLabel, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("statusLabel.IconAlignment"))));
      this.errorProvider.SetIconPadding(this.statusLabel, ((int)(resources.GetObject("statusLabel.IconPadding"))));
      this.statusLabel.Name = "statusLabel";
      // 
      // descriptionField
      // 
      resources.ApplyResources(this.descriptionField, "descriptionField");
      this.descriptionField.BackColor = System.Drawing.Color.White;
      this.descriptionField.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
      this.descriptionField.BorderFocusColor = System.Drawing.Color.Black;
      this.descriptionField.BorderRadius = 0;
      this.descriptionField.BorderSize = 2;
      this.errorProvider.SetError(this.descriptionField, resources.GetString("descriptionField.Error"));
      this.descriptionField.ForeColor = System.Drawing.Color.DimGray;
      this.errorProvider.SetIconAlignment(this.descriptionField, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("descriptionField.IconAlignment"))));
      this.errorProvider.SetIconPadding(this.descriptionField, ((int)(resources.GetObject("descriptionField.IconPadding"))));
      this.descriptionField.IsFocused = true;
      this.descriptionField.Multiline = true;
      this.descriptionField.Name = "descriptionField";
      this.descriptionField.PasswordChar = false;
      this.descriptionField.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
      this.descriptionField.PlaceholderText = "";
      this.descriptionField.Texts = "";
      this.descriptionField.UnderlinedStyle = false;
      // 
      // descriptionLabel
      // 
      resources.ApplyResources(this.descriptionLabel, "descriptionLabel");
      this.errorProvider.SetError(this.descriptionLabel, resources.GetString("descriptionLabel.Error"));
      this.errorProvider.SetIconAlignment(this.descriptionLabel, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("descriptionLabel.IconAlignment"))));
      this.errorProvider.SetIconPadding(this.descriptionLabel, ((int)(resources.GetObject("descriptionLabel.IconPadding"))));
      this.descriptionLabel.Name = "descriptionLabel";
      // 
      // titleField
      // 
      resources.ApplyResources(this.titleField, "titleField");
      this.titleField.BackColor = System.Drawing.Color.White;
      this.titleField.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
      this.titleField.BorderFocusColor = System.Drawing.Color.Black;
      this.titleField.BorderRadius = 0;
      this.titleField.BorderSize = 2;
      this.errorProvider.SetError(this.titleField, resources.GetString("titleField.Error"));
      this.titleField.ForeColor = System.Drawing.Color.DimGray;
      this.errorProvider.SetIconAlignment(this.titleField, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("titleField.IconAlignment"))));
      this.errorProvider.SetIconPadding(this.titleField, ((int)(resources.GetObject("titleField.IconPadding"))));
      this.titleField.IsFocused = true;
      this.titleField.Multiline = false;
      this.titleField.Name = "titleField";
      this.titleField.PasswordChar = false;
      this.titleField.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
      this.titleField.PlaceholderText = "";
      this.titleField.Texts = "";
      this.titleField.UnderlinedStyle = false;
      // 
      // titleLabel
      // 
      resources.ApplyResources(this.titleLabel, "titleLabel");
      this.errorProvider.SetError(this.titleLabel, resources.GetString("titleLabel.Error"));
      this.errorProvider.SetIconAlignment(this.titleLabel, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("titleLabel.IconAlignment"))));
      this.errorProvider.SetIconPadding(this.titleLabel, ((int)(resources.GetObject("titleLabel.IconPadding"))));
      this.titleLabel.Name = "titleLabel";
      // 
      // brandComboBox
      // 
      resources.ApplyResources(this.brandComboBox, "brandComboBox");
      this.brandComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.brandComboBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(27)))), ((int)(((byte)(36)))));
      this.brandComboBox.BorderSize = 1;
      this.brandComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
      this.errorProvider.SetError(this.brandComboBox, resources.GetString("brandComboBox.Error"));
      this.brandComboBox.ForeColor = System.Drawing.Color.DimGray;
      this.errorProvider.SetIconAlignment(this.brandComboBox, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("brandComboBox.IconAlignment"))));
      this.brandComboBox.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(27)))), ((int)(((byte)(36)))));
      this.errorProvider.SetIconPadding(this.brandComboBox, ((int)(resources.GetObject("brandComboBox.IconPadding"))));
      this.brandComboBox.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.brandComboBox.ListTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(152)))), ((int)(((byte)(152)))));
      this.brandComboBox.Name = "brandComboBox";
      this.brandComboBox.Texts = "";
      // 
      // brandLabel
      // 
      resources.ApplyResources(this.brandLabel, "brandLabel");
      this.errorProvider.SetError(this.brandLabel, resources.GetString("brandLabel.Error"));
      this.errorProvider.SetIconAlignment(this.brandLabel, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("brandLabel.IconAlignment"))));
      this.errorProvider.SetIconPadding(this.brandLabel, ((int)(resources.GetObject("brandLabel.IconPadding"))));
      this.brandLabel.Name = "brandLabel";
      // 
      // variantComboBox
      // 
      resources.ApplyResources(this.variantComboBox, "variantComboBox");
      this.variantComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.variantComboBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(27)))), ((int)(((byte)(36)))));
      this.variantComboBox.BorderSize = 1;
      this.variantComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
      this.errorProvider.SetError(this.variantComboBox, resources.GetString("variantComboBox.Error"));
      this.variantComboBox.ForeColor = System.Drawing.Color.DimGray;
      this.errorProvider.SetIconAlignment(this.variantComboBox, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("variantComboBox.IconAlignment"))));
      this.variantComboBox.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(27)))), ((int)(((byte)(36)))));
      this.errorProvider.SetIconPadding(this.variantComboBox, ((int)(resources.GetObject("variantComboBox.IconPadding"))));
      this.variantComboBox.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.variantComboBox.ListTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(152)))), ((int)(((byte)(152)))));
      this.variantComboBox.Name = "variantComboBox";
      this.variantComboBox.Texts = "";
      // 
      // variantLabel
      // 
      resources.ApplyResources(this.variantLabel, "variantLabel");
      this.errorProvider.SetError(this.variantLabel, resources.GetString("variantLabel.Error"));
      this.errorProvider.SetIconAlignment(this.variantLabel, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("variantLabel.IconAlignment"))));
      this.errorProvider.SetIconPadding(this.variantLabel, ((int)(resources.GetObject("variantLabel.IconPadding"))));
      this.variantLabel.Name = "variantLabel";
      // 
      // vehicleModelComboBox
      // 
      resources.ApplyResources(this.vehicleModelComboBox, "vehicleModelComboBox");
      this.vehicleModelComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.vehicleModelComboBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(27)))), ((int)(((byte)(36)))));
      this.vehicleModelComboBox.BorderSize = 1;
      this.vehicleModelComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
      this.errorProvider.SetError(this.vehicleModelComboBox, resources.GetString("vehicleModelComboBox.Error"));
      this.vehicleModelComboBox.ForeColor = System.Drawing.Color.DimGray;
      this.errorProvider.SetIconAlignment(this.vehicleModelComboBox, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("vehicleModelComboBox.IconAlignment"))));
      this.vehicleModelComboBox.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(27)))), ((int)(((byte)(36)))));
      this.errorProvider.SetIconPadding(this.vehicleModelComboBox, ((int)(resources.GetObject("vehicleModelComboBox.IconPadding"))));
      this.vehicleModelComboBox.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.vehicleModelComboBox.ListTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(152)))), ((int)(((byte)(152)))));
      this.vehicleModelComboBox.Name = "vehicleModelComboBox";
      this.vehicleModelComboBox.Texts = "";
      // 
      // priceField
      // 
      resources.ApplyResources(this.priceField, "priceField");
      this.priceField.BackColor = System.Drawing.Color.White;
      this.priceField.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
      this.priceField.BorderFocusColor = System.Drawing.Color.Black;
      this.priceField.BorderRadius = 0;
      this.priceField.BorderSize = 2;
      this.errorProvider.SetError(this.priceField, resources.GetString("priceField.Error"));
      this.priceField.ForeColor = System.Drawing.Color.DimGray;
      this.errorProvider.SetIconAlignment(this.priceField, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("priceField.IconAlignment"))));
      this.errorProvider.SetIconPadding(this.priceField, ((int)(resources.GetObject("priceField.IconPadding"))));
      this.priceField.IsFocused = true;
      this.priceField.Multiline = false;
      this.priceField.Name = "priceField";
      this.priceField.PasswordChar = false;
      this.priceField.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
      this.priceField.PlaceholderText = "";
      this.priceField.Texts = "";
      this.priceField.UnderlinedStyle = false;
      // 
      // priceLabel
      // 
      resources.ApplyResources(this.priceLabel, "priceLabel");
      this.errorProvider.SetError(this.priceLabel, resources.GetString("priceLabel.Error"));
      this.errorProvider.SetIconAlignment(this.priceLabel, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("priceLabel.IconAlignment"))));
      this.errorProvider.SetIconPadding(this.priceLabel, ((int)(resources.GetObject("priceLabel.IconPadding"))));
      this.priceLabel.Name = "priceLabel";
      // 
      // mileageField
      // 
      resources.ApplyResources(this.mileageField, "mileageField");
      this.mileageField.BackColor = System.Drawing.Color.White;
      this.mileageField.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
      this.mileageField.BorderFocusColor = System.Drawing.Color.Black;
      this.mileageField.BorderRadius = 0;
      this.mileageField.BorderSize = 2;
      this.errorProvider.SetError(this.mileageField, resources.GetString("mileageField.Error"));
      this.mileageField.ForeColor = System.Drawing.Color.DimGray;
      this.errorProvider.SetIconAlignment(this.mileageField, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("mileageField.IconAlignment"))));
      this.errorProvider.SetIconPadding(this.mileageField, ((int)(resources.GetObject("mileageField.IconPadding"))));
      this.mileageField.IsFocused = true;
      this.mileageField.Multiline = false;
      this.mileageField.Name = "mileageField";
      this.mileageField.PasswordChar = false;
      this.mileageField.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
      this.mileageField.PlaceholderText = "";
      this.mileageField.Texts = "";
      this.mileageField.UnderlinedStyle = false;
      // 
      // mileageLabel
      // 
      resources.ApplyResources(this.mileageLabel, "mileageLabel");
      this.errorProvider.SetError(this.mileageLabel, resources.GetString("mileageLabel.Error"));
      this.errorProvider.SetIconAlignment(this.mileageLabel, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("mileageLabel.IconAlignment"))));
      this.errorProvider.SetIconPadding(this.mileageLabel, ((int)(resources.GetObject("mileageLabel.IconPadding"))));
      this.mileageLabel.Name = "mileageLabel";
      // 
      // manufacturingYearField
      // 
      resources.ApplyResources(this.manufacturingYearField, "manufacturingYearField");
      this.manufacturingYearField.BackColor = System.Drawing.Color.White;
      this.manufacturingYearField.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
      this.manufacturingYearField.BorderFocusColor = System.Drawing.Color.Black;
      this.manufacturingYearField.BorderRadius = 0;
      this.manufacturingYearField.BorderSize = 2;
      this.errorProvider.SetError(this.manufacturingYearField, resources.GetString("manufacturingYearField.Error"));
      this.manufacturingYearField.ForeColor = System.Drawing.Color.DimGray;
      this.errorProvider.SetIconAlignment(this.manufacturingYearField, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("manufacturingYearField.IconAlignment"))));
      this.errorProvider.SetIconPadding(this.manufacturingYearField, ((int)(resources.GetObject("manufacturingYearField.IconPadding"))));
      this.manufacturingYearField.IsFocused = true;
      this.manufacturingYearField.Multiline = false;
      this.manufacturingYearField.Name = "manufacturingYearField";
      this.manufacturingYearField.PasswordChar = false;
      this.manufacturingYearField.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
      this.manufacturingYearField.PlaceholderText = "";
      this.manufacturingYearField.Texts = "";
      this.manufacturingYearField.UnderlinedStyle = false;
      // 
      // manufacturingYearLabel
      // 
      resources.ApplyResources(this.manufacturingYearLabel, "manufacturingYearLabel");
      this.errorProvider.SetError(this.manufacturingYearLabel, resources.GetString("manufacturingYearLabel.Error"));
      this.errorProvider.SetIconAlignment(this.manufacturingYearLabel, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("manufacturingYearLabel.IconAlignment"))));
      this.errorProvider.SetIconPadding(this.manufacturingYearLabel, ((int)(resources.GetObject("manufacturingYearLabel.IconPadding"))));
      this.manufacturingYearLabel.Name = "manufacturingYearLabel";
      // 
      // plateNoField
      // 
      resources.ApplyResources(this.plateNoField, "plateNoField");
      this.plateNoField.BackColor = System.Drawing.Color.White;
      this.plateNoField.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
      this.plateNoField.BorderFocusColor = System.Drawing.Color.Black;
      this.plateNoField.BorderRadius = 0;
      this.plateNoField.BorderSize = 2;
      this.errorProvider.SetError(this.plateNoField, resources.GetString("plateNoField.Error"));
      this.plateNoField.ForeColor = System.Drawing.Color.DimGray;
      this.errorProvider.SetIconAlignment(this.plateNoField, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("plateNoField.IconAlignment"))));
      this.errorProvider.SetIconPadding(this.plateNoField, ((int)(resources.GetObject("plateNoField.IconPadding"))));
      this.plateNoField.IsFocused = false;
      this.plateNoField.Multiline = false;
      this.plateNoField.Name = "plateNoField";
      this.plateNoField.PasswordChar = false;
      this.plateNoField.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
      this.plateNoField.PlaceholderText = "";
      this.plateNoField.Texts = "";
      this.plateNoField.UnderlinedStyle = false;
      // 
      // plateNoLabel
      // 
      resources.ApplyResources(this.plateNoLabel, "plateNoLabel");
      this.errorProvider.SetError(this.plateNoLabel, resources.GetString("plateNoLabel.Error"));
      this.errorProvider.SetIconAlignment(this.plateNoLabel, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("plateNoLabel.IconAlignment"))));
      this.errorProvider.SetIconPadding(this.plateNoLabel, ((int)(resources.GetObject("plateNoLabel.IconPadding"))));
      this.plateNoLabel.Name = "plateNoLabel";
      // 
      // modelNameLabel
      // 
      resources.ApplyResources(this.modelNameLabel, "modelNameLabel");
      this.errorProvider.SetError(this.modelNameLabel, resources.GetString("modelNameLabel.Error"));
      this.errorProvider.SetIconAlignment(this.modelNameLabel, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("modelNameLabel.IconAlignment"))));
      this.errorProvider.SetIconPadding(this.modelNameLabel, ((int)(resources.GetObject("modelNameLabel.IconPadding"))));
      this.modelNameLabel.Name = "modelNameLabel";
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
      // VehicleForm
      // 
      this.AcceptButton = this.searchBtn;
      resources.ApplyResources(this, "$this");
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.White;
      this.Controls.Add(this.tabControl);
      this.Name = "VehicleForm";
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
    private Customs.CBMComboBox statusField;
    private System.Windows.Forms.Label statusLabel;
    private Customs.CBMButton buyerBtn;
    private Customs.CBMButton sellerBtn;
    private Customs.CBMButton exportBtn;
    private Customs.CBMComboBox memberCombobox;
    private System.Windows.Forms.Label memberLabel;
  }
}