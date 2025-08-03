namespace APP_demo
{
	partial class frmDanhSachDuThi
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
			this.btnExport = new System.Windows.Forms.Button();
			this.chkTimkiem = new System.Windows.Forms.CheckBox();
			this.chkTimlop = new System.Windows.Forms.CheckBox();
			this.chkTimten = new System.Windows.Forms.CheckBox();
			this.cmbTimlop = new System.Windows.Forms.ComboBox();
			this.btnIn = new System.Windows.Forms.Button();
			this.dtpNgaythi = new System.Windows.Forms.DateTimePicker();
			this.txtPhongthi = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.btnTimkiem = new System.Windows.Forms.Button();
			this.chkTimmonhoc = new System.Windows.Forms.CheckBox();
			this.txtTimten = new System.Windows.Forms.TextBox();
			this.cmbTimmonhoc = new System.Windows.Forms.ComboBox();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.btnInport = new System.Windows.Forms.Button();
			this.btnThem = new System.Windows.Forms.Button();
			this.btnSua = new System.Windows.Forms.Button();
			this.btnXoa = new System.Windows.Forms.Button();
			this.btnThoat = new System.Windows.Forms.Button();
			this.btnLammoi = new System.Windows.Forms.Button();
			this.lbTimkiem = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtCathi = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.cmbMahocvien = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.cmbMamonhoc = new System.Windows.Forms.ComboBox();
			this.cmbMalop = new System.Windows.Forms.ComboBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
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
			// chkTimkiem
			// 
			this.chkTimkiem.AutoSize = true;
			this.chkTimkiem.Location = new System.Drawing.Point(8, 19);
			this.chkTimkiem.Name = "chkTimkiem";
			this.chkTimkiem.Size = new System.Drawing.Size(102, 17);
			this.chkTimkiem.TabIndex = 7;
			this.chkTimkiem.Text = "Tìm kiếm dữ liệu";
			this.chkTimkiem.UseVisualStyleBackColor = true;
			this.chkTimkiem.CheckedChanged += new System.EventHandler(this.chkTimkiem_CheckedChanged);
			// 
			// chkTimlop
			// 
			this.chkTimlop.AutoSize = true;
			this.chkTimlop.Location = new System.Drawing.Point(14, 44);
			this.chkTimlop.Name = "chkTimlop";
			this.chkTimlop.Size = new System.Drawing.Size(84, 17);
			this.chkTimlop.TabIndex = 8;
			this.chkTimlop.Text = "Tìm theo lớp";
			this.chkTimlop.UseVisualStyleBackColor = true;
			this.chkTimlop.CheckedChanged += new System.EventHandler(this.chkTimlop_CheckedChanged);
			// 
			// chkTimten
			// 
			this.chkTimten.AutoSize = true;
			this.chkTimten.Location = new System.Drawing.Point(340, 47);
			this.chkTimten.Name = "chkTimten";
			this.chkTimten.Size = new System.Drawing.Size(129, 17);
			this.chkTimten.TabIndex = 9;
			this.chkTimten.Text = "Tìm theo tên học viên";
			this.chkTimten.UseVisualStyleBackColor = true;
			this.chkTimten.CheckedChanged += new System.EventHandler(this.chkTimten_CheckedChanged);
			// 
			// cmbTimlop
			// 
			this.cmbTimlop.FormattingEnabled = true;
			this.cmbTimlop.Location = new System.Drawing.Point(149, 40);
			this.cmbTimlop.Name = "cmbTimlop";
			this.cmbTimlop.Size = new System.Drawing.Size(104, 21);
			this.cmbTimlop.TabIndex = 6;
			this.cmbTimlop.SelectedIndexChanged += new System.EventHandler(this.cmbTimlop_SelectedIndexChanged);
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
			// dtpNgaythi
			// 
			this.dtpNgaythi.CustomFormat = "MM/dd/yyyy";
			this.dtpNgaythi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpNgaythi.Location = new System.Drawing.Point(318, 52);
			this.dtpNgaythi.Name = "dtpNgaythi";
			this.dtpNgaythi.Size = new System.Drawing.Size(122, 20);
			this.dtpNgaythi.TabIndex = 4;
			// 
			// txtPhongthi
			// 
			this.txtPhongthi.Location = new System.Drawing.Point(560, 55);
			this.txtPhongthi.Name = "txtPhongthi";
			this.txtPhongthi.Size = new System.Drawing.Size(100, 20);
			this.txtPhongthi.TabIndex = 2;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(501, 58);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(52, 13);
			this.label7.TabIndex = 3;
			this.label7.Text = "Phòng thi";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(240, 56);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(50, 13);
			this.label5.TabIndex = 3;
			this.label5.Text = "Ngày Thi";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.btnTimkiem);
			this.groupBox3.Controls.Add(this.chkTimmonhoc);
			this.groupBox3.Controls.Add(this.chkTimkiem);
			this.groupBox3.Controls.Add(this.txtTimten);
			this.groupBox3.Controls.Add(this.chkTimlop);
			this.groupBox3.Controls.Add(this.chkTimten);
			this.groupBox3.Controls.Add(this.cmbTimmonhoc);
			this.groupBox3.Controls.Add(this.cmbTimlop);
			this.groupBox3.Location = new System.Drawing.Point(92, 162);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(804, 101);
			this.groupBox3.TabIndex = 17;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Tìm kiếm";
			// 
			// btnTimkiem
			// 
			this.btnTimkiem.Location = new System.Drawing.Point(602, 41);
			this.btnTimkiem.Name = "btnTimkiem";
			this.btnTimkiem.Size = new System.Drawing.Size(75, 23);
			this.btnTimkiem.TabIndex = 12;
			this.btnTimkiem.Text = "Tìm kiếm";
			this.btnTimkiem.UseVisualStyleBackColor = true;
			this.btnTimkiem.Visible = false;
			this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
			// 
			// chkTimmonhoc
			// 
			this.chkTimmonhoc.AutoSize = true;
			this.chkTimmonhoc.Location = new System.Drawing.Point(14, 78);
			this.chkTimmonhoc.Name = "chkTimmonhoc";
			this.chkTimmonhoc.Size = new System.Drawing.Size(111, 17);
			this.chkTimmonhoc.TabIndex = 11;
			this.chkTimmonhoc.Text = "Tìm theo môn học";
			this.chkTimmonhoc.UseVisualStyleBackColor = true;
			this.chkTimmonhoc.CheckedChanged += new System.EventHandler(this.chkTimmonhoc_CheckedChanged);
			// 
			// txtTimten
			// 
			this.txtTimten.Location = new System.Drawing.Point(473, 45);
			this.txtTimten.Name = "txtTimten";
			this.txtTimten.Size = new System.Drawing.Size(100, 20);
			this.txtTimten.TabIndex = 10;
			this.txtTimten.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTimten_KeyDown);
			// 
			// cmbTimmonhoc
			// 
			this.cmbTimmonhoc.FormattingEnabled = true;
			this.cmbTimmonhoc.Location = new System.Drawing.Point(149, 76);
			this.cmbTimmonhoc.Name = "cmbTimmonhoc";
			this.cmbTimmonhoc.Size = new System.Drawing.Size(104, 21);
			this.cmbTimmonhoc.TabIndex = 6;
			this.cmbTimmonhoc.SelectedIndexChanged += new System.EventHandler(this.cmbTimmonhoc_SelectedIndexChanged);
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.btnInport);
			this.groupBox2.Controls.Add(this.btnExport);
			this.groupBox2.Controls.Add(this.btnIn);
			this.groupBox2.Controls.Add(this.btnThem);
			this.groupBox2.Controls.Add(this.btnSua);
			this.groupBox2.Controls.Add(this.btnXoa);
			this.groupBox2.Controls.Add(this.btnThoat);
			this.groupBox2.Controls.Add(this.btnLammoi);
			this.groupBox2.Location = new System.Drawing.Point(89, 269);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(807, 50);
			this.groupBox2.TabIndex = 16;
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
			// lbTimkiem
			// 
			this.lbTimkiem.ForeColor = System.Drawing.Color.IndianRed;
			this.lbTimkiem.Location = new System.Drawing.Point(324, 142);
			this.lbTimkiem.Name = "lbTimkiem";
			this.lbTimkiem.Size = new System.Drawing.Size(263, 23);
			this.lbTimkiem.TabIndex = 18;
			this.lbTimkiem.Text = "Chế độ tìm kiếm";
			this.lbTimkiem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txtCathi);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.cmbMahocvien);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.cmbMamonhoc);
			this.groupBox1.Controls.Add(this.cmbMalop);
			this.groupBox1.Controls.Add(this.label9);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.dtpNgaythi);
			this.groupBox1.Controls.Add(this.txtPhongthi);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Location = new System.Drawing.Point(89, 31);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(807, 108);
			this.groupBox1.TabIndex = 15;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Thông tin chi tiết về Lớp";
			// 
			// txtCathi
			// 
			this.txtCathi.Location = new System.Drawing.Point(560, 25);
			this.txtCathi.Name = "txtCathi";
			this.txtCathi.Size = new System.Drawing.Size(100, 20);
			this.txtCathi.TabIndex = 13;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(501, 28);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(34, 13);
			this.label3.TabIndex = 14;
			this.label3.Text = "Ca thi";
			// 
			// cmbMahocvien
			// 
			this.cmbMahocvien.FormattingEnabled = true;
			this.cmbMahocvien.Location = new System.Drawing.Point(87, 56);
			this.cmbMahocvien.Name = "cmbMahocvien";
			this.cmbMahocvien.Size = new System.Drawing.Size(122, 21);
			this.cmbMahocvien.TabIndex = 12;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 56);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(66, 13);
			this.label1.TabIndex = 11;
			this.label1.Text = "Mã học viên";
			// 
			// cmbMamonhoc
			// 
			this.cmbMamonhoc.FormattingEnabled = true;
			this.cmbMamonhoc.Location = new System.Drawing.Point(320, 25);
			this.cmbMamonhoc.Name = "cmbMamonhoc";
			this.cmbMamonhoc.Size = new System.Drawing.Size(120, 21);
			this.cmbMamonhoc.TabIndex = 9;
			// 
			// cmbMalop
			// 
			this.cmbMalop.FormattingEnabled = true;
			this.cmbMalop.Location = new System.Drawing.Point(87, 22);
			this.cmbMalop.Name = "cmbMalop";
			this.cmbMalop.Size = new System.Drawing.Size(122, 21);
			this.cmbMalop.TabIndex = 10;
//			this.cmbMalop.SelectedIndexChanged += new System.EventHandler(this.cmbMalop_SelectedIndexChanged);
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(246, 25);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(66, 13);
			this.label9.TabIndex = 7;
			this.label9.Text = "Mã môn học";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(13, 25);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(39, 13);
			this.label8.TabIndex = 8;
			this.label8.Text = "Mã lớp";
			// 
			// label2
			// 
			this.label2.ForeColor = System.Drawing.Color.DarkRed;
			this.label2.Location = new System.Drawing.Point(89, -1);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(698, 29);
			this.label2.TabIndex = 14;
			this.label2.Text = "Danh Mục Danh Sách Dự Thi";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(89, 337);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(807, 267);
			this.dataGridView1.TabIndex = 13;
			this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
			// 
			// frmDanhSachDuThi
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(985, 603);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.lbTimkiem);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.dataGridView1);
			this.Name = "frmDanhSachDuThi";
			this.Text = "frmDanhSachDuThi";
			this.Load += new System.EventHandler(this.frmDanhSachDuThi_Load);
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnExport;
		private System.Windows.Forms.CheckBox chkTimkiem;
		private System.Windows.Forms.CheckBox chkTimlop;
		private System.Windows.Forms.CheckBox chkTimten;
		private System.Windows.Forms.ComboBox cmbTimlop;
		private System.Windows.Forms.Button btnIn;
		private System.Windows.Forms.DateTimePicker dtpNgaythi;
		private System.Windows.Forms.TextBox txtPhongthi;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Button btnTimkiem;
		private System.Windows.Forms.CheckBox chkTimmonhoc;
		private System.Windows.Forms.TextBox txtTimten;
		private System.Windows.Forms.ComboBox cmbTimmonhoc;
		private System.Windows.Forms.ErrorProvider errorProvider1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button btnInport;
		private System.Windows.Forms.Button btnThem;
		private System.Windows.Forms.Button btnSua;
		private System.Windows.Forms.Button btnXoa;
		private System.Windows.Forms.Button btnThoat;
		private System.Windows.Forms.Button btnLammoi;
		private System.Windows.Forms.Label lbTimkiem;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ComboBox cmbMamonhoc;
		private System.Windows.Forms.ComboBox cmbMalop;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.TextBox txtCathi;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox cmbMahocvien;
		private System.Windows.Forms.Label label1;
	}
}