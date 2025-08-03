namespace APP_demo
{
	partial class frmMonhoc
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
			this.components = new System.ComponentModel.Container();
			this.btnTimkiem = new System.Windows.Forms.Button();
			this.txtTimten = new System.Windows.Forms.TextBox();
			this.chkTimten = new System.Windows.Forms.CheckBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.label2 = new System.Windows.Forms.Label();
			this.lbTimkiem = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtTenmonhoc = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtMamonhoc = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnLammoi = new System.Windows.Forms.Button();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.btnInport = new System.Windows.Forms.Button();
			this.btnExport = new System.Windows.Forms.Button();
			this.btnIn = new System.Windows.Forms.Button();
			this.btnThem = new System.Windows.Forms.Button();
			this.btnSua = new System.Windows.Forms.Button();
			this.btnXoa = new System.Windows.Forms.Button();
			this.btnThoat = new System.Windows.Forms.Button();
			this.btnThongke = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnTimkiem
			// 
			this.btnTimkiem.Location = new System.Drawing.Point(343, 255);
			this.btnTimkiem.Name = "btnTimkiem";
			this.btnTimkiem.Size = new System.Drawing.Size(75, 23);
			this.btnTimkiem.TabIndex = 27;
			this.btnTimkiem.Text = "Tìm kiếm";
			this.btnTimkiem.UseVisualStyleBackColor = true;
			this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
			// 
			// txtTimten
			// 
			this.txtTimten.Location = new System.Drawing.Point(206, 258);
			this.txtTimten.Name = "txtTimten";
			this.txtTimten.Size = new System.Drawing.Size(100, 20);
			this.txtTimten.TabIndex = 26;
			this.txtTimten.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTimten_KeyDown);
			// 
			// chkTimten
			// 
			this.chkTimten.AutoSize = true;
			this.chkTimten.Location = new System.Drawing.Point(56, 261);
			this.chkTimten.Name = "chkTimten";
			this.chkTimten.Size = new System.Drawing.Size(129, 17);
			this.chkTimten.TabIndex = 25;
			this.chkTimten.Text = "Tìm theo tên học viên";
			this.chkTimten.UseVisualStyleBackColor = true;
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(47, 367);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(807, 267);
			this.dataGridView1.TabIndex = 28;
//			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
			// 
			// label2
			// 
			this.label2.ForeColor = System.Drawing.Color.DarkRed;
			this.label2.Location = new System.Drawing.Point(47, 29);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(698, 29);
			this.label2.TabIndex = 29;
			this.label2.Text = "Danh Mục Giáo Viên";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lbTimkiem
			// 
			this.lbTimkiem.ForeColor = System.Drawing.Color.IndianRed;
			this.lbTimkiem.Location = new System.Drawing.Point(281, 172);
			this.lbTimkiem.Name = "lbTimkiem";
			this.lbTimkiem.Size = new System.Drawing.Size(263, 23);
			this.lbTimkiem.TabIndex = 32;
			this.lbTimkiem.Text = "Chế độ tìm kiếm";
			this.lbTimkiem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txtTenmonhoc);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.txtMamonhoc);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(47, 61);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(807, 108);
			this.groupBox1.TabIndex = 30;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Thông tin chi tiết về Môn Học";
			// 
			// txtTenmonhoc
			// 
			this.txtTenmonhoc.Location = new System.Drawing.Point(271, 18);
			this.txtTenmonhoc.Name = "txtTenmonhoc";
			this.txtTenmonhoc.Size = new System.Drawing.Size(100, 20);
			this.txtTenmonhoc.TabIndex = 2;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(197, 25);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(70, 13);
			this.label3.TabIndex = 3;
			this.label3.Text = "Tên môn học";
			// 
			// txtMamonhoc
			// 
			this.txtMamonhoc.Location = new System.Drawing.Point(76, 19);
			this.txtMamonhoc.Name = "txtMamonhoc";
			this.txtMamonhoc.Size = new System.Drawing.Size(100, 20);
			this.txtMamonhoc.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(2, 25);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(66, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "Mã môn học";
			// 
			// btnLammoi
			// 
			this.btnLammoi.Location = new System.Drawing.Point(249, 19);
			this.btnLammoi.Name = "btnLammoi";
			this.btnLammoi.Size = new System.Drawing.Size(75, 23);
			this.btnLammoi.TabIndex = 1;
			this.btnLammoi.Text = "Làm mới";
			this.btnLammoi.UseVisualStyleBackColor = true;
			this.btnLammoi.Click += new System.EventHandler(this.btnLammoi_Click);
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.btnThongke);
			this.groupBox2.Controls.Add(this.btnInport);
			this.groupBox2.Controls.Add(this.btnExport);
			this.groupBox2.Controls.Add(this.btnIn);
			this.groupBox2.Controls.Add(this.btnThem);
			this.groupBox2.Controls.Add(this.btnSua);
			this.groupBox2.Controls.Add(this.btnXoa);
			this.groupBox2.Controls.Add(this.btnThoat);
			this.groupBox2.Controls.Add(this.btnLammoi);
			this.groupBox2.Location = new System.Drawing.Point(47, 299);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(807, 50);
			this.groupBox2.TabIndex = 31;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Thao tác";
			// 
			// btnInport
			// 
			this.btnInport.Location = new System.Drawing.Point(575, 19);
			this.btnInport.Name = "btnInport";
			this.btnInport.Size = new System.Drawing.Size(75, 23);
			this.btnInport.TabIndex = 3;
			this.btnInport.Text = "Inport Excel";
			this.btnInport.UseVisualStyleBackColor = true;
			this.btnInport.Click += new System.EventHandler(this.btnInport_Click);
			// 
			// btnExport
			// 
			this.btnExport.Location = new System.Drawing.Point(494, 19);
			this.btnExport.Name = "btnExport";
			this.btnExport.Size = new System.Drawing.Size(75, 23);
			this.btnExport.TabIndex = 3;
			this.btnExport.Text = "Export Excel";
			this.btnExport.UseVisualStyleBackColor = true;
			this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
			// 
			// btnIn
			// 
			this.btnIn.Location = new System.Drawing.Point(411, 19);
			this.btnIn.Name = "btnIn";
			this.btnIn.Size = new System.Drawing.Size(75, 23);
			this.btnIn.TabIndex = 2;
			this.btnIn.Text = "In Ấn";
			this.btnIn.UseVisualStyleBackColor = true;
			this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
			// 
			// btnThem
			// 
			this.btnThem.Location = new System.Drawing.Point(6, 19);
			this.btnThem.Name = "btnThem";
			this.btnThem.Size = new System.Drawing.Size(75, 23);
			this.btnThem.TabIndex = 1;
			this.btnThem.Text = "Thêm";
			this.btnThem.UseVisualStyleBackColor = true;
			this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
			// 
			// btnSua
			// 
			this.btnSua.Location = new System.Drawing.Point(87, 19);
			this.btnSua.Name = "btnSua";
			this.btnSua.Size = new System.Drawing.Size(75, 23);
			this.btnSua.TabIndex = 1;
			this.btnSua.Text = "Sửa";
			this.btnSua.UseVisualStyleBackColor = true;
			this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
			// 
			// btnXoa
			// 
			this.btnXoa.Location = new System.Drawing.Point(168, 19);
			this.btnXoa.Name = "btnXoa";
			this.btnXoa.Size = new System.Drawing.Size(75, 23);
			this.btnXoa.TabIndex = 1;
			this.btnXoa.Text = "Xóa";
			this.btnXoa.UseVisualStyleBackColor = true;
			this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
			// 
			// btnThoat
			// 
			this.btnThoat.Location = new System.Drawing.Point(330, 19);
			this.btnThoat.Name = "btnThoat";
			this.btnThoat.Size = new System.Drawing.Size(75, 23);
			this.btnThoat.TabIndex = 1;
			this.btnThoat.Text = "Thoát";
			this.btnThoat.UseVisualStyleBackColor = true;
			this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
			// 
			// btnThongke
			// 
			this.btnThongke.Location = new System.Drawing.Point(656, 19);
			this.btnThongke.Name = "btnThongke";
			this.btnThongke.Size = new System.Drawing.Size(75, 23);
			this.btnThongke.TabIndex = 4;
			this.btnThongke.Text = "Thống kê";
			this.btnThongke.UseVisualStyleBackColor = true;
			this.btnThongke.Click += new System.EventHandler(this.btnThongke_Click);
			// 
			// frmMonhoc
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(906, 660);
			this.Controls.Add(this.btnTimkiem);
			this.Controls.Add(this.txtTimten);
			this.Controls.Add(this.chkTimten);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.lbTimkiem);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.groupBox2);
			this.Name = "frmMonhoc";
			this.Text = "frmMonhoc";
			this.Load += new System.EventHandler(this.frmMonhoc_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnTimkiem;
		private System.Windows.Forms.TextBox txtTimten;
		private System.Windows.Forms.CheckBox chkTimten;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lbTimkiem;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox txtTenmonhoc;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtMamonhoc;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnLammoi;
		private System.Windows.Forms.ErrorProvider errorProvider1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button btnInport;
		private System.Windows.Forms.Button btnExport;
		private System.Windows.Forms.Button btnIn;
		private System.Windows.Forms.Button btnThem;
		private System.Windows.Forms.Button btnSua;
		private System.Windows.Forms.Button btnXoa;
		private System.Windows.Forms.Button btnThoat;
		private System.Windows.Forms.Button btnThongke;
	}
}