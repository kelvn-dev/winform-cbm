namespace CBM.Views {
  partial class ReportView {
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
      System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
      System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
      System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
      System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
      System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
      System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
      System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
      System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
      this.panel1 = new System.Windows.Forms.Panel();
      this.approvedLabel = new System.Windows.Forms.Label();
      this.approvedVehicleCount = new System.Windows.Forms.Label();
      this.panel2 = new System.Windows.Forms.Panel();
      this.soldVehicleCount = new System.Windows.Forms.Label();
      this.soldLabel = new System.Windows.Forms.Label();
      this.panel3 = new System.Windows.Forms.Panel();
      this.soldPrice = new System.Windows.Forms.Label();
      this.priceLabel = new System.Windows.Forms.Label();
      this.chartPrice = new System.Windows.Forms.DataVisualization.Charting.Chart();
      this.chartBrand = new System.Windows.Forms.DataVisualization.Charting.Chart();
      this.panel1.SuspendLayout();
      this.panel2.SuspendLayout();
      this.panel3.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.chartPrice)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.chartBrand)).BeginInit();
      this.SuspendLayout();
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.approvedVehicleCount);
      this.panel1.Controls.Add(this.approvedLabel);
      this.panel1.Location = new System.Drawing.Point(43, 32);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(345, 98);
      this.panel1.TabIndex = 0;
      // 
      // approvedLabel
      // 
      this.approvedLabel.AutoSize = true;
      this.approvedLabel.Location = new System.Drawing.Point(36, 13);
      this.approvedLabel.Name = "approvedLabel";
      this.approvedLabel.Size = new System.Drawing.Size(292, 25);
      this.approvedLabel.TabIndex = 0;
      this.approvedLabel.Text = "Number of approved vehicles";
      // 
      // approvedVehicleCount
      // 
      this.approvedVehicleCount.AutoSize = true;
      this.approvedVehicleCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.approvedVehicleCount.Location = new System.Drawing.Point(104, 38);
      this.approvedVehicleCount.Name = "approvedVehicleCount";
      this.approvedVehicleCount.Size = new System.Drawing.Size(130, 46);
      this.approvedVehicleCount.TabIndex = 1;
      this.approvedVehicleCount.Text = "10000";
      // 
      // panel2
      // 
      this.panel2.Controls.Add(this.soldVehicleCount);
      this.panel2.Controls.Add(this.soldLabel);
      this.panel2.Location = new System.Drawing.Point(427, 32);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(345, 98);
      this.panel2.TabIndex = 2;
      // 
      // soldVehicleCount
      // 
      this.soldVehicleCount.AutoSize = true;
      this.soldVehicleCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.soldVehicleCount.Location = new System.Drawing.Point(104, 38);
      this.soldVehicleCount.Name = "soldVehicleCount";
      this.soldVehicleCount.Size = new System.Drawing.Size(130, 46);
      this.soldVehicleCount.TabIndex = 1;
      this.soldVehicleCount.Text = "10000";
      // 
      // soldLabel
      // 
      this.soldLabel.AutoSize = true;
      this.soldLabel.Location = new System.Drawing.Point(55, 13);
      this.soldLabel.Name = "soldLabel";
      this.soldLabel.Size = new System.Drawing.Size(242, 25);
      this.soldLabel.TabIndex = 0;
      this.soldLabel.Text = "Number of sold vehicles";
      // 
      // panel3
      // 
      this.panel3.Controls.Add(this.soldPrice);
      this.panel3.Controls.Add(this.priceLabel);
      this.panel3.Location = new System.Drawing.Point(801, 32);
      this.panel3.Name = "panel3";
      this.panel3.Size = new System.Drawing.Size(756, 98);
      this.panel3.TabIndex = 3;
      // 
      // soldPrice
      // 
      this.soldPrice.AutoSize = true;
      this.soldPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.soldPrice.Location = new System.Drawing.Point(104, 38);
      this.soldPrice.Name = "soldPrice";
      this.soldPrice.Size = new System.Drawing.Size(130, 46);
      this.soldPrice.TabIndex = 1;
      this.soldPrice.Text = "10000";
      // 
      // priceLabel
      // 
      this.priceLabel.AutoSize = true;
      this.priceLabel.Location = new System.Drawing.Point(79, 13);
      this.priceLabel.Name = "priceLabel";
      this.priceLabel.Size = new System.Drawing.Size(153, 25);
      this.priceLabel.TabIndex = 0;
      this.priceLabel.Text = "Gross revenue";
      // 
      // chartPrice
      // 
      chartArea1.Name = "ChartArea1";
      this.chartPrice.ChartAreas.Add(chartArea1);
      legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
      legend1.Name = "Legend1";
      this.chartPrice.Legends.Add(legend1);
      this.chartPrice.Location = new System.Drawing.Point(46, 155);
      this.chartPrice.Name = "chartPrice";
      series1.ChartArea = "ChartArea1";
      series1.Legend = "Legend1";
      series1.Name = "Series1";
      this.chartPrice.Series.Add(series1);
      this.chartPrice.Size = new System.Drawing.Size(903, 569);
      this.chartPrice.TabIndex = 4;
      title1.Alignment = System.Drawing.ContentAlignment.TopLeft;
      title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
      title1.Name = "Title1";
      title1.Text = "Gross revenue";
      this.chartPrice.Titles.Add(title1);
      // 
      // chartBrand
      // 
      chartArea2.Name = "ChartArea1";
      this.chartBrand.ChartAreas.Add(chartArea2);
      legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
      legend2.Name = "Legend1";
      this.chartBrand.Legends.Add(legend2);
      this.chartBrand.Location = new System.Drawing.Point(969, 155);
      this.chartBrand.Name = "chartBrand";
      series2.ChartArea = "ChartArea1";
      series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
      series2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
      series2.IsValueShownAsLabel = true;
      series2.LabelForeColor = System.Drawing.Color.White;
      series2.Legend = "Legend1";
      series2.Name = "Series1";
      this.chartBrand.Series.Add(series2);
      this.chartBrand.Size = new System.Drawing.Size(588, 569);
      this.chartBrand.TabIndex = 5;
      title2.Alignment = System.Drawing.ContentAlignment.TopLeft;
      title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
      title2.Name = "Title1";
      title2.Text = "Top 5 brands";
      this.chartBrand.Titles.Add(title2);
      // 
      // ReportView
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.SystemColors.Control;
      this.ClientSize = new System.Drawing.Size(1609, 831);
      this.Controls.Add(this.chartBrand);
      this.Controls.Add(this.chartPrice);
      this.Controls.Add(this.panel3);
      this.Controls.Add(this.panel2);
      this.Controls.Add(this.panel1);
      this.Name = "ReportView";
      this.Text = "ReportView";
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.panel2.ResumeLayout(false);
      this.panel2.PerformLayout();
      this.panel3.ResumeLayout(false);
      this.panel3.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.chartPrice)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.chartBrand)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Label approvedVehicleCount;
    private System.Windows.Forms.Label approvedLabel;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.Label soldVehicleCount;
    private System.Windows.Forms.Label soldLabel;
    private System.Windows.Forms.Panel panel3;
    private System.Windows.Forms.Label soldPrice;
    private System.Windows.Forms.Label priceLabel;
    private System.Windows.Forms.DataVisualization.Charting.Chart chartPrice;
    private System.Windows.Forms.DataVisualization.Charting.Chart chartBrand;
  }
}