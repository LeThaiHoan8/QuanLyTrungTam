namespace APP_demo
{
	partial class frmThongkediem
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
			this.btnShow = new System.Windows.Forms.Button();
			this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.cmbMonhoc = new System.Windows.Forms.ComboBox();
			this.chartCot = new System.Windows.Forms.DataVisualization.Charting.Chart();
			((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chartCot)).BeginInit();
			this.SuspendLayout();
			// 
			// btnShow
			// 
			this.btnShow.Location = new System.Drawing.Point(415, 12);
			this.btnShow.Name = "btnShow";
			this.btnShow.Size = new System.Drawing.Size(75, 23);
			this.btnShow.TabIndex = 1;
			this.btnShow.Text = "Hiển thị";
			this.btnShow.UseVisualStyleBackColor = true;
			this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
			// 
			// chart2
			// 
			chartArea1.Name = "ChartArea1";
			this.chart2.ChartAreas.Add(chartArea1);
			legend1.Name = "Legend1";
			this.chart2.Legends.Add(legend1);
			this.chart2.Location = new System.Drawing.Point(587, 41);
			this.chart2.Name = "chart2";
			series1.ChartArea = "ChartArea1";
			series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
			series1.Legend = "Legend1";
			series1.Name = "TienDo";
			this.chart2.Series.Add(series1);
			this.chart2.Size = new System.Drawing.Size(337, 348);
			this.chart2.TabIndex = 2;
			this.chart2.Text = "chart2";
			// 
			// cmbMonhoc
			// 
			this.cmbMonhoc.FormattingEnabled = true;
			this.cmbMonhoc.Location = new System.Drawing.Point(528, 12);
			this.cmbMonhoc.Name = "cmbMonhoc";
			this.cmbMonhoc.Size = new System.Drawing.Size(121, 21);
			this.cmbMonhoc.TabIndex = 3;
			// 
			// chartCot
			// 
			chartArea2.Name = "ChartArea1";
			this.chartCot.ChartAreas.Add(chartArea2);
			legend2.Name = "Legend1";
			this.chartCot.Legends.Add(legend2);
			this.chartCot.Location = new System.Drawing.Point(12, 41);
			this.chartCot.Name = "chartCot";
			series2.ChartArea = "ChartArea1";
			series2.Legend = "Legend1";
			series2.Name = "SoLuongHocVien";
			this.chartCot.Series.Add(series2);
			this.chartCot.Size = new System.Drawing.Size(569, 348);
			this.chartCot.TabIndex = 4;
			// 
			// frmThongkediem
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(949, 437);
			this.Controls.Add(this.chartCot);
			this.Controls.Add(this.cmbMonhoc);
			this.Controls.Add(this.chart2);
			this.Controls.Add(this.btnShow);
			this.Name = "frmThongkediem";
			this.Text = "frmThongkediem";
			this.Load += new System.EventHandler(this.frmThongkediem_Load);
			((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chartCot)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Button btnShow;
		private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
		private System.Windows.Forms.ComboBox cmbMonhoc;
		private System.Windows.Forms.DataVisualization.Charting.Chart chartCot;
	}
}