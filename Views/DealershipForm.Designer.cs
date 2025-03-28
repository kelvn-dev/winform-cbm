using FontAwesome.Sharp;
using System.Drawing;

namespace CBM.Views {
  partial class DealershipForm {
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
      this.endDateField = new CBM.Customs.CBMDatePicker();
      this.endDateLabel = new System.Windows.Forms.Label();
      this.startDateField = new CBM.Customs.CBMDatePicker();
      this.startDateLabel = new System.Windows.Forms.Label();
      this.memberComboBox = new CBM.Customs.CBMComboBox();
      this.memberLabel = new System.Windows.Forms.Label();
      this.renewalLabel = new System.Windows.Forms.Label();
      this.renewalField = new CBM.Customs.CBMCheckBox();
      this.subscriptionPlanComboBox = new CBM.Customs.CBMComboBox();
      this.subscriptionPlanLabel = new System.Windows.Forms.Label();
      this.panel1 = new System.Windows.Forms.Panel();
      this.saveBtn = new CBM.Customs.CBMButton();
      this.cancelBtn = new CBM.Customs.CBMButton();
      this.informationLabel = new System.Windows.Forms.Label();
      this.statusField = new CBM.Customs.CBMComboBox();
      this.statusLabel = new System.Windows.Forms.Label();
      this.tabControl.SuspendLayout();
      this.listingTab.SuspendLayout();
      this.panel4.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
      this.panel3.SuspendLayout();
      this.panel2.SuspendLayout();
      this.detailTab.SuspendLayout();
      this.panel1.SuspendLayout();
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
      this.detailTab.Controls.Add(this.statusField);
      this.detailTab.Controls.Add(this.statusLabel);
      this.detailTab.Controls.Add(this.endDateField);
      this.detailTab.Controls.Add(this.endDateLabel);
      this.detailTab.Controls.Add(this.startDateField);
      this.detailTab.Controls.Add(this.startDateLabel);
      this.detailTab.Controls.Add(this.memberComboBox);
      this.detailTab.Controls.Add(this.memberLabel);
      this.detailTab.Controls.Add(this.renewalLabel);
      this.detailTab.Controls.Add(this.renewalField);
      this.detailTab.Controls.Add(this.subscriptionPlanComboBox);
      this.detailTab.Controls.Add(this.subscriptionPlanLabel);
      this.detailTab.Controls.Add(this.panel1);
      this.detailTab.Location = new System.Drawing.Point(8, 39);
      this.detailTab.Name = "detailTab";
      this.detailTab.Padding = new System.Windows.Forms.Padding(3);
      this.detailTab.Size = new System.Drawing.Size(1485, 1415);
      this.detailTab.TabIndex = 1;
      this.detailTab.Text = "tabPage2";
      this.detailTab.UseVisualStyleBackColor = true;
      // 
      // endDateField
      // 
      this.endDateField.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(27)))), ((int)(((byte)(36)))));
      this.endDateField.BorderSize = 2;
      this.endDateField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
      this.endDateField.Location = new System.Drawing.Point(943, 485);
      this.endDateField.MinimumSize = new System.Drawing.Size(4, 70);
      this.endDateField.Name = "endDateField";
      this.endDateField.Size = new System.Drawing.Size(476, 70);
      this.endDateField.SkinColor = System.Drawing.Color.White;
      this.endDateField.TabIndex = 101;
      this.endDateField.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(27)))), ((int)(((byte)(36)))));
      // 
      // endDateLabel
      // 
      this.endDateLabel.AutoSize = true;
      this.endDateLabel.Location = new System.Drawing.Point(938, 426);
      this.endDateLabel.Name = "endDateLabel";
      this.endDateLabel.Size = new System.Drawing.Size(101, 25);
      this.endDateLabel.TabIndex = 100;
      this.endDateLabel.Text = "End Date";
      // 
      // startDateField
      // 
      this.startDateField.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(27)))), ((int)(((byte)(36)))));
      this.startDateField.BorderSize = 2;
      this.startDateField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
      this.startDateField.Location = new System.Drawing.Point(943, 281);
      this.startDateField.MinimumSize = new System.Drawing.Size(4, 70);
      this.startDateField.Name = "startDateField";
      this.startDateField.Size = new System.Drawing.Size(476, 70);
      this.startDateField.SkinColor = System.Drawing.Color.White;
      this.startDateField.TabIndex = 99;
      this.startDateField.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(27)))), ((int)(((byte)(36)))));
      // 
      // startDateLabel
      // 
      this.startDateLabel.AutoSize = true;
      this.startDateLabel.Location = new System.Drawing.Point(938, 222);
      this.startDateLabel.Name = "startDateLabel";
      this.startDateLabel.Size = new System.Drawing.Size(108, 25);
      this.startDateLabel.TabIndex = 98;
      this.startDateLabel.Text = "Start Date";
      // 
      // memberComboBox
      // 
      this.memberComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.memberComboBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(27)))), ((int)(((byte)(36)))));
      this.memberComboBox.BorderSize = 1;
      this.memberComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
      this.memberComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
      this.memberComboBox.ForeColor = System.Drawing.Color.DimGray;
      this.memberComboBox.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(27)))), ((int)(((byte)(36)))));
      this.memberComboBox.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.memberComboBox.ListTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(152)))), ((int)(((byte)(152)))));
      this.memberComboBox.Location = new System.Drawing.Point(44, 285);
      this.memberComboBox.MinimumSize = new System.Drawing.Size(200, 30);
      this.memberComboBox.Name = "memberComboBox";
      this.memberComboBox.Padding = new System.Windows.Forms.Padding(1);
      this.memberComboBox.Size = new System.Drawing.Size(606, 66);
      this.memberComboBox.TabIndex = 97;
      this.memberComboBox.Texts = "";
      // 
      // memberLabel
      // 
      this.memberLabel.AutoSize = true;
      this.memberLabel.Location = new System.Drawing.Point(39, 222);
      this.memberLabel.Name = "memberLabel";
      this.memberLabel.Size = new System.Drawing.Size(90, 25);
      this.memberLabel.TabIndex = 96;
      this.memberLabel.Text = "Member";
      // 
      // renewalLabel
      // 
      this.renewalLabel.AutoSize = true;
      this.renewalLabel.Location = new System.Drawing.Point(938, 658);
      this.renewalLabel.Name = "renewalLabel";
      this.renewalLabel.Size = new System.Drawing.Size(95, 25);
      this.renewalLabel.TabIndex = 83;
      this.renewalLabel.Text = "Renewal";
      // 
      // renewalField
      // 
      this.renewalField.AutoSize = true;
      this.renewalField.Location = new System.Drawing.Point(1329, 649);
      this.renewalField.MinimumSize = new System.Drawing.Size(90, 44);
      this.renewalField.Name = "renewalField";
      this.renewalField.OffBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(152)))), ((int)(((byte)(152)))));
      this.renewalField.OffToggleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.renewalField.OnBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(27)))), ((int)(((byte)(36)))));
      this.renewalField.OnToggleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.renewalField.Size = new System.Drawing.Size(90, 44);
      this.renewalField.TabIndex = 82;
      this.renewalField.UseVisualStyleBackColor = true;
      // 
      // subscriptionPlanComboBox
      // 
      this.subscriptionPlanComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.subscriptionPlanComboBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(27)))), ((int)(((byte)(36)))));
      this.subscriptionPlanComboBox.BorderSize = 1;
      this.subscriptionPlanComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
      this.subscriptionPlanComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
      this.subscriptionPlanComboBox.ForeColor = System.Drawing.Color.DimGray;
      this.subscriptionPlanComboBox.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(27)))), ((int)(((byte)(36)))));
      this.subscriptionPlanComboBox.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.subscriptionPlanComboBox.ListTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(152)))), ((int)(((byte)(152)))));
      this.subscriptionPlanComboBox.Location = new System.Drawing.Point(44, 489);
      this.subscriptionPlanComboBox.MinimumSize = new System.Drawing.Size(200, 30);
      this.subscriptionPlanComboBox.Name = "subscriptionPlanComboBox";
      this.subscriptionPlanComboBox.Padding = new System.Windows.Forms.Padding(1);
      this.subscriptionPlanComboBox.Size = new System.Drawing.Size(606, 66);
      this.subscriptionPlanComboBox.TabIndex = 79;
      this.subscriptionPlanComboBox.Texts = "";
      // 
      // subscriptionPlanLabel
      // 
      this.subscriptionPlanLabel.AutoSize = true;
      this.subscriptionPlanLabel.Location = new System.Drawing.Point(39, 426);
      this.subscriptionPlanLabel.Name = "subscriptionPlanLabel";
      this.subscriptionPlanLabel.Size = new System.Drawing.Size(178, 25);
      this.subscriptionPlanLabel.TabIndex = 55;
      this.subscriptionPlanLabel.Text = "Subscription plan";
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
      this.informationLabel.Size = new System.Drawing.Size(227, 25);
      this.informationLabel.TabIndex = 37;
      this.informationLabel.Text = "Dealership Information";
      // 
      // statusField
      // 
      this.statusField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.statusField.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(27)))), ((int)(((byte)(36)))));
      this.statusField.BorderSize = 1;
      this.statusField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
      this.statusField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
      this.statusField.ForeColor = System.Drawing.Color.DimGray;
      this.statusField.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(27)))), ((int)(((byte)(36)))));
      this.statusField.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.statusField.ListTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(152)))), ((int)(((byte)(152)))));
      this.statusField.Location = new System.Drawing.Point(44, 712);
      this.statusField.MinimumSize = new System.Drawing.Size(200, 30);
      this.statusField.Name = "statusField";
      this.statusField.Padding = new System.Windows.Forms.Padding(1);
      this.statusField.Size = new System.Drawing.Size(606, 66);
      this.statusField.TabIndex = 105;
      this.statusField.Texts = "";
      // 
      // statusLabel
      // 
      this.statusLabel.AutoSize = true;
      this.statusLabel.Location = new System.Drawing.Point(39, 649);
      this.statusLabel.Name = "statusLabel";
      this.statusLabel.Size = new System.Drawing.Size(73, 25);
      this.statusLabel.TabIndex = 104;
      this.statusLabel.Text = "Status";
      // 
      // DealershipForm
      // 
      this.AcceptButton = this.searchBtn;
      this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.White;
      this.ClientSize = new System.Drawing.Size(1501, 1462);
      this.Controls.Add(this.tabControl);
      this.Location = new System.Drawing.Point(20, 0);
      this.Name = "DealershipForm";
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
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TabControl tabControl;
    private System.Windows.Forms.TabPage listingTab;
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
    private System.Windows.Forms.Label subscriptionPlanLabel;
    private Customs.CBMComboBox subscriptionPlanComboBox;
    private Customs.CBMCheckBox renewalField;
    private System.Windows.Forms.Label renewalLabel;
    private Customs.CBMComboBox memberComboBox;
    private System.Windows.Forms.Label memberLabel;
    private System.Windows.Forms.Label startDateLabel;
    private Customs.CBMDatePicker endDateField;
    private System.Windows.Forms.Label endDateLabel;
    private Customs.CBMDatePicker startDateField;
    private Customs.CBMComboBox statusField;
    private System.Windows.Forms.Label statusLabel;
  }
}