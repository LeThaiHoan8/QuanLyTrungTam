namespace APP_demo
{
	partial class frmThongKeDiemofHV
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
			this.chartCot = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.btnShow = new System.Windows.Forms.Button();
			this.cmbHocvien = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.chartCot)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
			this.SuspendLayout();
			// 
			// chartCot
			// 
			chartArea1.Name = "ChartArea1";
			this.chartCot.ChartAreas.Add(chartArea1);
			legend1.Name = "Legend1";
			this.chartCot.Legends.Add(legend1);
			this.chartCot.Location = new System.Drawing.Point(36, 52);
			this.chartCot.Name = "chartCot";
			series1.ChartArea = "ChartArea1";
			series1.Legend = "Legend1";
			series1.Name = "DiemHocVien";
			this.chartCot.Series.Add(series1);
			this.chartCot.Size = new System.Drawing.Size(917, 325);
			this.chartCot.TabIndex = 8;
			// 
			// chart2
			// 
			chartArea2.Name = "ChartArea1";
			this.chart2.ChartAreas.Add(chartArea2);
			legend2.Name = "Legend1";
			this.chart2.Legends.Add(legend2);
			this.chart2.Location = new System.Drawing.Point(250, 383);
			this.chart2.Name = "chart2";
			series2.ChartArea = "ChartArea1";
			series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
			series2.Legend = "Legend1";
			series2.Name = "TienDo";
			this.chart2.Series.Add(series2);
			this.chart2.Size = new System.Drawing.Size(577, 309);
			this.chart2.TabIndex = 6;
			this.chart2.Text = "chart2";
			// 
			// btnShow
			// 
			this.btnShow.Location = new System.Drawing.Point(439, 23);
			this.btnShow.Name = "btnShow";
			this.btnShow.Size = new System.Drawing.Size(75, 23);
			this.btnShow.TabIndex = 5;
			this.btnShow.Text = "Hiển thị";
			this.btnShow.UseVisualStyleBackColor = true;
			this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
			// 
			// cmbHocvien
			// 
			this.cmbHocvien.FormattingEnabled = true;
			this.cmbHocvien.Location = new System.Drawing.Point(541, 23);
			this.cmbHocvien.Name = "cmbHocvien";
			this.cmbHocvien.Size = new System.Drawing.Size(121, 21);
			this.cmbHocvien.TabIndex = 10;
			// 
			// frmThongKeDiemofHV
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(965, 749);
			this.Controls.Add(this.cmbHocvien);
			this.Controls.Add(this.chartCot);
			this.Controls.Add(this.chart2);
			this.Controls.Add(this.btnShow);
			this.Name = "frmThongKeDiemofHV";
			this.Text = "frmThongKeDiemofHV";
			this.Load += new System.EventHandler(this.frmThongKeDiemofHV_Load);
			((System.ComponentModel.ISupportInitialize)(this.chartCot)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataVisualization.Charting.Chart chartCot;
		private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
		private System.Windows.Forms.Button btnShow;
		private System.Windows.Forms.ComboBox cmbHocvien;
	}
}