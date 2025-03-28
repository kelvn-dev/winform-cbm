namespace CBM.Views {
  partial class SettingForm {
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingForm));
      this.renewalLabel = new System.Windows.Forms.Label();
      this.panel1 = new System.Windows.Forms.Panel();
      this.informationLabel = new System.Windows.Forms.Label();
      this.renewalField = new CBM.Customs.CBMCheckBox();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // renewalLabel
      // 
      resources.ApplyResources(this.renewalLabel, "renewalLabel");
      this.renewalLabel.Name = "renewalLabel";
      // 
      // panel1
      // 
      resources.ApplyResources(this.panel1, "panel1");
      this.panel1.Controls.Add(this.informationLabel);
      this.panel1.Name = "panel1";
      // 
      // informationLabel
      // 
      resources.ApplyResources(this.informationLabel, "informationLabel");
      this.informationLabel.Name = "informationLabel";
      // 
      // renewalField
      // 
      resources.ApplyResources(this.renewalField, "renewalField");
      this.renewalField.Name = "renewalField";
      this.renewalField.OffBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(152)))), ((int)(((byte)(152)))));
      this.renewalField.OffToggleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.renewalField.OnBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(27)))), ((int)(((byte)(36)))));
      this.renewalField.OnToggleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.renewalField.UseVisualStyleBackColor = true;
      // 
      // SettingForm
      // 
      resources.ApplyResources(this, "$this");
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.renewalLabel);
      this.Controls.Add(this.renewalField);
      this.Name = "SettingForm";
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label renewalLabel;
    private Customs.CBMCheckBox renewalField;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Label informationLabel;
  }
}