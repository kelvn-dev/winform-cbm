using FontAwesome.Sharp;
using System.Drawing;

namespace CBM.Views {
  partial class MarketplaceDealershipForm {
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
      this.endDateField = new CBM.Customs.CBMDatePicker();
      this.endDateLabel = new System.Windows.Forms.Label();
      this.startDateField = new CBM.Customs.CBMDatePicker();
      this.startDateLabel = new System.Windows.Forms.Label();
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
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // endDateField
      // 
      this.endDateField.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(27)))), ((int)(((byte)(36)))));
      this.endDateField.BorderSize = 2;
      this.endDateField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
      this.endDateField.Location = new System.Drawing.Point(962, 477);
      this.endDateField.MinimumSize = new System.Drawing.Size(4, 70);
      this.endDateField.Name = "endDateField";
      this.endDateField.Size = new System.Drawing.Size(476, 70);
      this.endDateField.SkinColor = System.Drawing.Color.White;
      this.endDateField.TabIndex = 112;
      this.endDateField.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(27)))), ((int)(((byte)(36)))));
      // 
      // endDateLabel
      // 
      this.endDateLabel.AutoSize = true;
      this.endDateLabel.Location = new System.Drawing.Point(957, 418);
      this.endDateLabel.Name = "endDateLabel";
      this.endDateLabel.Size = new System.Drawing.Size(101, 25);
      this.endDateLabel.TabIndex = 111;
      this.endDateLabel.Text = "End Date";
      // 
      // startDateField
      // 
      this.startDateField.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(27)))), ((int)(((byte)(36)))));
      this.startDateField.BorderSize = 2;
      this.startDateField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
      this.startDateField.Location = new System.Drawing.Point(962, 273);
      this.startDateField.MinimumSize = new System.Drawing.Size(4, 70);
      this.startDateField.Name = "startDateField";
      this.startDateField.Size = new System.Drawing.Size(476, 70);
      this.startDateField.SkinColor = System.Drawing.Color.White;
      this.startDateField.TabIndex = 110;
      this.startDateField.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(27)))), ((int)(((byte)(36)))));
      // 
      // startDateLabel
      // 
      this.startDateLabel.AutoSize = true;
      this.startDateLabel.Location = new System.Drawing.Point(957, 214);
      this.startDateLabel.Name = "startDateLabel";
      this.startDateLabel.Size = new System.Drawing.Size(108, 25);
      this.startDateLabel.TabIndex = 109;
      this.startDateLabel.Text = "Start Date";
      // 
      // renewalLabel
      // 
      this.renewalLabel.AutoSize = true;
      this.renewalLabel.Location = new System.Drawing.Point(957, 650);
      this.renewalLabel.Name = "renewalLabel";
      this.renewalLabel.Size = new System.Drawing.Size(95, 25);
      this.renewalLabel.TabIndex = 106;
      this.renewalLabel.Text = "Renewal";
      // 
      // renewalField
      // 
      this.renewalField.AutoSize = true;
      this.renewalField.Location = new System.Drawing.Point(1348, 641);
      this.renewalField.MinimumSize = new System.Drawing.Size(90, 44);
      this.renewalField.Name = "renewalField";
      this.renewalField.OffBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(152)))), ((int)(((byte)(152)))));
      this.renewalField.OffToggleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.renewalField.OnBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(27)))), ((int)(((byte)(36)))));
      this.renewalField.OnToggleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.renewalField.Size = new System.Drawing.Size(90, 44);
      this.renewalField.TabIndex = 105;
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
      this.subscriptionPlanComboBox.Location = new System.Drawing.Point(41, 277);
      this.subscriptionPlanComboBox.MinimumSize = new System.Drawing.Size(200, 30);
      this.subscriptionPlanComboBox.Name = "subscriptionPlanComboBox";
      this.subscriptionPlanComboBox.Padding = new System.Windows.Forms.Padding(1);
      this.subscriptionPlanComboBox.Size = new System.Drawing.Size(606, 66);
      this.subscriptionPlanComboBox.TabIndex = 104;
      this.subscriptionPlanComboBox.Texts = "";
      // 
      // subscriptionPlanLabel
      // 
      this.subscriptionPlanLabel.AutoSize = true;
      this.subscriptionPlanLabel.Location = new System.Drawing.Point(36, 214);
      this.subscriptionPlanLabel.Name = "subscriptionPlanLabel";
      this.subscriptionPlanLabel.Size = new System.Drawing.Size(178, 25);
      this.subscriptionPlanLabel.TabIndex = 102;
      this.subscriptionPlanLabel.Text = "Subscription plan";
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.saveBtn);
      this.panel1.Controls.Add(this.cancelBtn);
      this.panel1.Controls.Add(this.informationLabel);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel1.Location = new System.Drawing.Point(0, 0);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(1501, 134);
      this.panel1.TabIndex = 103;
      // 
      // saveBtn
      // 
      this.saveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.saveBtn.BorderColor = System.Drawing.Color.Empty;
      this.saveBtn.BorderRadius = 0;
      this.saveBtn.BorderSize = 0;
      this.saveBtn.FlatAppearance.BorderSize = 0;
      this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.saveBtn.Location = new System.Drawing.Point(1189, 22);
      this.saveBtn.Name = "saveBtn";
      this.saveBtn.Size = new System.Drawing.Size(280, 93);
      this.saveBtn.TabIndex = 32;
      this.saveBtn.Text = "Register Dealership";
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
      this.cancelBtn.Location = new System.Drawing.Point(962, 22);
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
      this.statusField.Location = new System.Drawing.Point(41, 481);
      this.statusField.MinimumSize = new System.Drawing.Size(200, 30);
      this.statusField.Name = "statusField";
      this.statusField.Padding = new System.Windows.Forms.Padding(1);
      this.statusField.Size = new System.Drawing.Size(606, 66);
      this.statusField.TabIndex = 114;
      this.statusField.Texts = "";
      // 
      // statusLabel
      // 
      this.statusLabel.AutoSize = true;
      this.statusLabel.Location = new System.Drawing.Point(36, 418);
      this.statusLabel.Name = "statusLabel";
      this.statusLabel.Size = new System.Drawing.Size(73, 25);
      this.statusLabel.TabIndex = 113;
      this.statusLabel.Text = "Status";
      // 
      // MarketplaceDealershipForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.White;
      this.ClientSize = new System.Drawing.Size(1501, 1462);
      this.Controls.Add(this.statusField);
      this.Controls.Add(this.statusLabel);
      this.Controls.Add(this.endDateField);
      this.Controls.Add(this.endDateLabel);
      this.Controls.Add(this.startDateField);
      this.Controls.Add(this.startDateLabel);
      this.Controls.Add(this.renewalLabel);
      this.Controls.Add(this.renewalField);
      this.Controls.Add(this.subscriptionPlanComboBox);
      this.Controls.Add(this.subscriptionPlanLabel);
      this.Controls.Add(this.panel1);
      this.Location = new System.Drawing.Point(20, 0);
      this.Name = "MarketplaceDealershipForm";
      this.Text = "GroupForm";
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private Customs.CBMDatePicker endDateField;
    private System.Windows.Forms.Label endDateLabel;
    private Customs.CBMDatePicker startDateField;
    private System.Windows.Forms.Label startDateLabel;
    private System.Windows.Forms.Label renewalLabel;
    private Customs.CBMCheckBox renewalField;
    private Customs.CBMComboBox subscriptionPlanComboBox;
    private System.Windows.Forms.Label subscriptionPlanLabel;
    private System.Windows.Forms.Panel panel1;
    private Customs.CBMButton saveBtn;
    private Customs.CBMButton cancelBtn;
    private System.Windows.Forms.Label informationLabel;
    private Customs.CBMComboBox statusField;
    private System.Windows.Forms.Label statusLabel;
  }
}