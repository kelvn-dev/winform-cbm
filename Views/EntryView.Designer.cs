namespace CBM.Views {
  partial class EntryView {
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EntryView));
      this.headerBar = new System.Windows.Forms.Panel();
      this.restoreBtn = new FontAwesome.Sharp.IconButton();
      this.minBtn = new FontAwesome.Sharp.IconButton();
      this.closeBtn = new FontAwesome.Sharp.IconButton();
      this.instructionLabel = new System.Windows.Forms.Label();
      this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
      this.memberBtn = new CBM.Customs.CBMButton();
      this.adminBtn = new CBM.Customs.CBMButton();
      this.headerBar.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
      this.SuspendLayout();
      // 
      // headerBar
      // 
      this.headerBar.Controls.Add(this.restoreBtn);
      this.headerBar.Controls.Add(this.minBtn);
      this.headerBar.Controls.Add(this.closeBtn);
      this.headerBar.Dock = System.Windows.Forms.DockStyle.Top;
      this.headerBar.Location = new System.Drawing.Point(0, 0);
      this.headerBar.Name = "headerBar";
      this.headerBar.Size = new System.Drawing.Size(1748, 71);
      this.headerBar.TabIndex = 0;
      // 
      // restoreBtn
      // 
      this.restoreBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.restoreBtn.IconChar = FontAwesome.Sharp.IconChar.WindowRestore;
      this.restoreBtn.IconColor = System.Drawing.Color.Black;
      this.restoreBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
      this.restoreBtn.Location = new System.Drawing.Point(1580, 11);
      this.restoreBtn.Name = "restoreBtn";
      this.restoreBtn.Size = new System.Drawing.Size(75, 47);
      this.restoreBtn.TabIndex = 2;
      this.restoreBtn.UseVisualStyleBackColor = true;
      // 
      // minBtn
      // 
      this.minBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.minBtn.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
      this.minBtn.IconColor = System.Drawing.Color.Black;
      this.minBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
      this.minBtn.Location = new System.Drawing.Point(1499, 11);
      this.minBtn.Name = "minBtn";
      this.minBtn.Size = new System.Drawing.Size(75, 47);
      this.minBtn.TabIndex = 1;
      this.minBtn.UseVisualStyleBackColor = true;
      // 
      // closeBtn
      // 
      this.closeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.closeBtn.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
      this.closeBtn.IconColor = System.Drawing.Color.Black;
      this.closeBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
      this.closeBtn.Location = new System.Drawing.Point(1661, 12);
      this.closeBtn.Name = "closeBtn";
      this.closeBtn.Size = new System.Drawing.Size(75, 47);
      this.closeBtn.TabIndex = 0;
      this.closeBtn.UseVisualStyleBackColor = true;
      // 
      // instructionLabel
      // 
      this.instructionLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
      this.instructionLabel.AutoSize = true;
      this.instructionLabel.BackColor = System.Drawing.Color.Transparent;
      this.instructionLabel.Location = new System.Drawing.Point(560, 379);
      this.instructionLabel.Name = "instructionLabel";
      this.instructionLabel.Size = new System.Drawing.Size(429, 25);
      this.instructionLabel.TabIndex = 66;
      this.instructionLabel.Text = "Please choose role to access to our system";
      // 
      // errorProvider
      // 
      this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
      this.errorProvider.ContainerControl = this;
      this.errorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider.Icon")));
      // 
      // memberBtn
      // 
      this.memberBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
      this.memberBtn.BorderColor = System.Drawing.Color.Empty;
      this.memberBtn.BorderRadius = 0;
      this.memberBtn.BorderSize = 0;
      this.memberBtn.FlatAppearance.BorderSize = 0;
      this.memberBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.memberBtn.Location = new System.Drawing.Point(975, 462);
      this.memberBtn.Name = "memberBtn";
      this.memberBtn.Size = new System.Drawing.Size(313, 93);
      this.memberBtn.TabIndex = 68;
      this.memberBtn.Text = "Member";
      this.memberBtn.UseVisualStyleBackColor = true;
      // 
      // adminBtn
      // 
      this.adminBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
      this.adminBtn.BorderColor = System.Drawing.Color.Empty;
      this.adminBtn.BorderRadius = 0;
      this.adminBtn.BorderSize = 0;
      this.adminBtn.FlatAppearance.BorderSize = 0;
      this.adminBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.adminBtn.Location = new System.Drawing.Point(565, 462);
      this.adminBtn.Name = "adminBtn";
      this.adminBtn.Size = new System.Drawing.Size(308, 93);
      this.adminBtn.TabIndex = 67;
      this.adminBtn.Text = "Administrator";
      this.adminBtn.UseVisualStyleBackColor = true;
      // 
      // EntryView
      // 
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
      this.BackgroundImage = global::CBM.Properties.Resources.background_login;
      this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.ClientSize = new System.Drawing.Size(1748, 1058);
      this.Controls.Add(this.memberBtn);
      this.Controls.Add(this.adminBtn);
      this.Controls.Add(this.instructionLabel);
      this.Controls.Add(this.headerBar);
      this.DoubleBuffered = true;
      this.Name = "EntryView";
      this.Text = "Z";
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.headerBar.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.Panel headerBar;
    private FontAwesome.Sharp.IconButton restoreBtn;
    private FontAwesome.Sharp.IconButton minBtn;
    private FontAwesome.Sharp.IconButton closeBtn;
    private System.Windows.Forms.Label instructionLabel;
    private System.Windows.Forms.ErrorProvider errorProvider;
    private Customs.CBMButton memberBtn;
    private Customs.CBMButton adminBtn;
  }
}