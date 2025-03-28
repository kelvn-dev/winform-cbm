using FontAwesome.Sharp;
using System.Drawing;

namespace CBM.Views {
  partial class FuelTypeForm {
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FuelTypeForm));
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
      this.descriptionField = new CBM.Customs.CBMTextbox();
      this.nameField = new CBM.Customs.CBMTextbox();
      this.nameLabel = new System.Windows.Forms.Label();
      this.descriptionLabel = new System.Windows.Forms.Label();
      this.panel1 = new System.Windows.Forms.Panel();
      this.saveBtn = new CBM.Customs.CBMButton();
      this.cancelBtn = new CBM.Customs.CBMButton();
      this.informationLabel = new System.Windows.Forms.Label();
      this.logoLabel = new System.Windows.Forms.Label();
      this.logoPictureBox = new CBM.Customs.CBMPictureBox();
      this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
      this.tabControl.SuspendLayout();
      this.listingTab.SuspendLayout();
      this.panel4.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
      this.panel3.SuspendLayout();
      this.panel2.SuspendLayout();
      this.detailTab.SuspendLayout();
      this.panel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
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
      this.detailTab.Controls.Add(this.descriptionField);
      this.detailTab.Controls.Add(this.nameField);
      this.detailTab.Controls.Add(this.nameLabel);
      this.detailTab.Controls.Add(this.descriptionLabel);
      this.detailTab.Controls.Add(this.panel1);
      this.detailTab.Controls.Add(this.logoLabel);
      this.detailTab.Controls.Add(this.logoPictureBox);
      this.detailTab.Location = new System.Drawing.Point(8, 39);
      this.detailTab.Name = "detailTab";
      this.detailTab.Padding = new System.Windows.Forms.Padding(3);
      this.detailTab.Size = new System.Drawing.Size(1485, 1022);
      this.detailTab.TabIndex = 1;
      this.detailTab.Text = "tabPage2";
      this.detailTab.UseVisualStyleBackColor = true;
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
      this.descriptionField.IsFocused = false;
      this.descriptionField.Location = new System.Drawing.Point(557, 644);
      this.descriptionField.Margin = new System.Windows.Forms.Padding(4);
      this.descriptionField.Multiline = true;
      this.descriptionField.Name = "descriptionField";
      this.descriptionField.Padding = new System.Windows.Forms.Padding(14);
      this.descriptionField.PasswordChar = false;
      this.descriptionField.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
      this.descriptionField.PlaceholderText = "";
      this.descriptionField.Size = new System.Drawing.Size(604, 300);
      this.descriptionField.TabIndex = 68;
      this.descriptionField.Texts = "";
      this.descriptionField.UnderlinedStyle = false;
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
      this.nameField.Location = new System.Drawing.Point(557, 505);
      this.nameField.Margin = new System.Windows.Forms.Padding(4);
      this.nameField.Multiline = false;
      this.nameField.Name = "nameField";
      this.nameField.Padding = new System.Windows.Forms.Padding(14);
      this.nameField.PasswordChar = false;
      this.nameField.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
      this.nameField.PlaceholderText = "";
      this.nameField.Size = new System.Drawing.Size(604, 59);
      this.nameField.TabIndex = 67;
      this.nameField.Texts = "";
      this.nameField.UnderlinedStyle = false;
      // 
      // nameLabel
      // 
      this.nameLabel.AutoSize = true;
      this.nameLabel.Location = new System.Drawing.Point(36, 523);
      this.nameLabel.Name = "nameLabel";
      this.nameLabel.Size = new System.Drawing.Size(68, 25);
      this.nameLabel.TabIndex = 55;
      this.nameLabel.Text = "Name";
      // 
      // descriptionLabel
      // 
      this.descriptionLabel.AutoSize = true;
      this.descriptionLabel.Location = new System.Drawing.Point(36, 667);
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
      this.informationLabel.Size = new System.Drawing.Size(166, 25);
      this.informationLabel.TabIndex = 37;
      this.informationLabel.Text = "Fuel Information";
      // 
      // logoLabel
      // 
      this.logoLabel.AutoSize = true;
      this.logoLabel.Location = new System.Drawing.Point(36, 205);
      this.logoLabel.Name = "logoLabel";
      this.logoLabel.Size = new System.Drawing.Size(60, 25);
      this.logoLabel.TabIndex = 65;
      this.logoLabel.Text = "Logo";
      // 
      // logoPictureBox
      // 
      this.logoPictureBox.BackColor = System.Drawing.Color.White;
      this.logoPictureBox.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
      this.logoPictureBox.BorderColor = System.Drawing.Color.RoyalBlue;
      this.logoPictureBox.BorderColor2 = System.Drawing.Color.HotPink;
      this.logoPictureBox.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
      this.logoPictureBox.BorderSize = 2;
      this.logoPictureBox.ForeColor = System.Drawing.SystemColors.ControlText;
      this.logoPictureBox.GradientAngle = 50F;
      this.logoPictureBox.IconChar = FontAwesome.Sharp.IconChar.Upload;
      this.logoPictureBox.IconColor = System.Drawing.SystemColors.ControlText;
      this.logoPictureBox.IconFont = FontAwesome.Sharp.IconFont.Auto;
      this.logoPictureBox.IconSize = 270;
      this.logoPictureBox.Location = new System.Drawing.Point(714, 193);
      this.logoPictureBox.Name = "logoPictureBox";
      this.logoPictureBox.Size = new System.Drawing.Size(270, 270);
      this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.logoPictureBox.TabIndex = 66;
      this.logoPictureBox.TabStop = false;
      // 
      // errorProvider
      // 
      this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
      this.errorProvider.ContainerControl = this;
      this.errorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider.Icon")));
      // 
      // FuelTypeForm
      // 
      this.AcceptButton = this.searchBtn;
      this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.White;
      this.ClientSize = new System.Drawing.Size(1501, 1069);
      this.Controls.Add(this.tabControl);
      this.Location = new System.Drawing.Point(20, 0);
      this.Name = "FuelTypeForm";
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
      ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
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
    private System.Windows.Forms.Label logoLabel;
    private Customs.CBMPictureBox logoPictureBox;
    private Customs.CBMTextbox descriptionField;
    private Customs.CBMTextbox nameField;
  }
}