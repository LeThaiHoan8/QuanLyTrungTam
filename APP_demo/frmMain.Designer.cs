namespace APP_demo
{
	partial class frmMain
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.mnLop = new System.Windows.Forms.ToolStripMenuItem();
			this.mnHocvien = new System.Windows.Forms.ToolStripMenuItem();
			this.mnGiaovien = new System.Windows.Forms.ToolStripMenuItem();
			this.mnMonhoc = new System.Windows.Forms.ToolStripMenuItem();
			this.mnPhanquyen = new System.Windows.Forms.ToolStripMenuItem();
			this.mnDanhsachduthi = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnHocvien,
            this.mnGiaovien,
            this.mnMonhoc,
            this.mnLop,
            this.mnDanhsachduthi,
            this.mnPhanquyen});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(800, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// mnLop
			// 
			this.mnLop.Name = "mnLop";
			this.mnLop.Size = new System.Drawing.Size(83, 20);
			this.mnLop.Text = "Quản lý Lớp";
			this.mnLop.Click += new System.EventHandler(this.mnLop_Click);
			// 
			// mnHocvien
			// 
			this.mnHocvien.Name = "mnHocvien";
			this.mnHocvien.Size = new System.Drawing.Size(108, 20);
			this.mnHocvien.Text = "Quản lý học viên";
			this.mnHocvien.Click += new System.EventHandler(this.mnHocvien_Click);
			// 
			// mnGiaovien
			// 
			this.mnGiaovien.Name = "mnGiaovien";
			this.mnGiaovien.Size = new System.Drawing.Size(111, 20);
			this.mnGiaovien.Text = "Quản lý giáo viên";
			this.mnGiaovien.Click += new System.EventHandler(this.mnGiaovien_Click);
			// 
			// mnMonhoc
			// 
			this.mnMonhoc.Name = "mnMonhoc";
			this.mnMonhoc.Size = new System.Drawing.Size(111, 20);
			this.mnMonhoc.Text = "Quản lý môn học";
			this.mnMonhoc.Click += new System.EventHandler(this.mnMonhoc_Click);
			// 
			// mnPhanquyen
			// 
			this.mnPhanquyen.Name = "mnPhanquyen";
			this.mnPhanquyen.Size = new System.Drawing.Size(172, 20);
			this.mnPhanquyen.Text = "Quản Lý Phân Quyền ADMIN";
			this.mnPhanquyen.Click += new System.EventHandler(this.mnPhanquyen_Click);
			// 
			// mnDanhsachduthi
			// 
			this.mnDanhsachduthi.Name = "mnDanhsachduthi";
			this.mnDanhsachduthi.Size = new System.Drawing.Size(158, 20);
			this.mnDanhsachduthi.Text = "Quản Lý Danh Sách Dự Thi";
			this.mnDanhsachduthi.Click += new System.EventHandler(this.mnDanhsachduthi_Click);
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "frmMain";
			this.Text = "frmMain";
			this.Load += new System.EventHandler(this.frmMain_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem mnLop;
		private System.Windows.Forms.ToolStripMenuItem mnHocvien;
		private System.Windows.Forms.ToolStripMenuItem mnGiaovien;
		private System.Windows.Forms.ToolStripMenuItem mnMonhoc;
		private System.Windows.Forms.ToolStripMenuItem mnPhanquyen;
		private System.Windows.Forms.ToolStripMenuItem mnDanhsachduthi;
	}
}