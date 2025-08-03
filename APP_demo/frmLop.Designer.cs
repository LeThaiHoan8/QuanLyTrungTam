namespace APP_demo
{
	partial class frmLop
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
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.btnThem = new System.Windows.Forms.Button();
			this.txtMalop = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.cmbMamonhoc = new System.Windows.Forms.ComboBox();
			this.cmbMagiaovien = new System.Windows.Forms.ComboBox();
			this.dtpNgayketthuc = new System.Windows.Forms.DateTimePicker();
			this.dtpNgaybatdau = new System.Windows.Forms.DateTimePicker();
			this.txtSobuoi = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.txtSiso = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtTenlop = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.btnSua = new System.Windows.Forms.Button();
			this.btnXoa = new System.Windows.Forms.Button();
			this.btnLammoi = new System.Windows.Forms.Button();
			this.btnThoat = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.btnInport = new System.Windows.Forms.Button();
			this.btnExport = new System.Windows.Forms.Button();
			this.btnIn = new System.Windows.Forms.Button();
			this.chkTimkiem = new System.Windows.Forms.CheckBox();
			this.chkTimgiaovien = new System.Windows.Forms.CheckBox();
			this.cmbTimgiaovien = new System.Windows.Forms.ComboBox();
			this.chkTimten = new System.Windows.Forms.CheckBox();
			this.txtTimten = new System.Windows.Forms.TextBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.btnTimkiem = new System.Windows.Forms.Button();
			this.chkTimmonhoc = new System.Windows.Forms.CheckBox();
			this.cmbTimmonhoc = new System.Windows.Forms.ComboBox();
			this.lbTimkiem = new System.Windows.Forms.Label();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(66, 347);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(807, 267);
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
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
			// txtMalop
			// 
			this.txtMalop.Location = new System.Drawing.Point(64, 19);
			this.txtMalop.Name = "txtMalop";
			this.txtMalop.Size = new System.Drawing.Size(100, 20);
			this.txtMalop.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(5, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(39, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "Mã lớp";
			// 
			// label2
			// 
			this.label2.ForeColor = System.Drawing.Color.DarkRed;
			this.label2.Location = new System.Drawing.Point(66, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(698, 29);
			this.label2.TabIndex = 4;
			this.label2.Text = "Danh Mục Lớp Học";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.cmbMamonhoc);
			this.groupBox1.Controls.Add(this.cmbMagiaovien);
			this.groupBox1.Controls.Add(this.dtpNgayketthuc);
			this.groupBox1.Controls.Add(this.dtpNgaybatdau);
			this.groupBox1.Controls.Add(this.txtSobuoi);
			this.groupBox1.Controls.Add(this.label9);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.txtSiso);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.txtTenlop);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.txtMalop);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(66, 41);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(807, 108);
			this.groupBox1.TabIndex = 5;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Thông tin chi tiết về Lớp";
			// 
			// cmbMamonhoc
			// 
			this.cmbMamonhoc.FormattingEnabled = true;
			this.cmbMamonhoc.Location = new System.Drawing.Point(676, 48);
			this.cmbMamonhoc.Name = "cmbMamonhoc";
			this.cmbMamonhoc.Size = new System.Drawing.Size(104, 21);
			this.cmbMamonhoc.TabIndex = 6;
			// 
			// cmbMagiaovien
			// 
			this.cmbMagiaovien.FormattingEnabled = true;
			this.cmbMagiaovien.Location = new System.Drawing.Point(676, 22);
			this.cmbMagiaovien.Name = "cmbMagiaovien";
			this.cmbMagiaovien.Size = new System.Drawing.Size(104, 21);
			this.cmbMagiaovien.TabIndex = 6;
			// 
			// dtpNgayketthuc
			// 
			this.dtpNgayketthuc.Cursor = System.Windows.Forms.Cursors.Default;
			this.dtpNgayketthuc.CustomFormat = "MM/dd/yyyy";
			this.dtpNgayketthuc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpNgayketthuc.Location = new System.Drawing.Point(471, 19);
			this.dtpNgayketthuc.Name = "dtpNgayketthuc";
			this.dtpNgayketthuc.Size = new System.Drawing.Size(98, 20);
			this.dtpNgayketthuc.TabIndex = 5;
			// 
			// dtpNgaybatdau
			// 
			this.dtpNgaybatdau.CustomFormat = "MM/dd/yyyy";
			this.dtpNgaybatdau.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpNgaybatdau.Location = new System.Drawing.Point(259, 45);
			this.dtpNgaybatdau.Name = "dtpNgaybatdau";
			this.dtpNgaybatdau.Size = new System.Drawing.Size(100, 20);
			this.dtpNgaybatdau.TabIndex = 4;
			// 
			// txtSobuoi
			// 
			this.txtSobuoi.Location = new System.Drawing.Point(469, 42);
			this.txtSobuoi.Name = "txtSobuoi";
			this.txtSobuoi.Size = new System.Drawing.Size(100, 20);
			this.txtSobuoi.TabIndex = 2;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(602, 48);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(66, 13);
			this.label9.TabIndex = 3;
			this.label9.Text = "Mã môn học";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(410, 45);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(41, 13);
			this.label7.TabIndex = 3;
			this.label7.Text = "số buổi";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(181, 49);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(72, 13);
			this.label5.TabIndex = 3;
			this.label5.Text = "Ngày bắt đầu";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(602, 25);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(68, 13);
			this.label8.TabIndex = 3;
			this.label8.Text = "Mã giáo viên";
			// 
			// txtSiso
			// 
			this.txtSiso.Location = new System.Drawing.Point(259, 19);
			this.txtSiso.Name = "txtSiso";
			this.txtSiso.Size = new System.Drawing.Size(100, 20);
			this.txtSiso.TabIndex = 2;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(391, 19);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(74, 13);
			this.label6.TabIndex = 3;
			this.label6.Text = "Ngày kết thúc";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(200, 22);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(33, 13);
			this.label4.TabIndex = 3;
			this.label4.Text = "Sĩ số";
			// 
			// txtTenlop
			// 
			this.txtTenlop.Location = new System.Drawing.Point(64, 45);
			this.txtTenlop.Name = "txtTenlop";
			this.txtTenlop.Size = new System.Drawing.Size(100, 20);
			this.txtTenlop.TabIndex = 2;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(5, 48);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(43, 13);
			this.label3.TabIndex = 3;
			this.label3.Text = "Tên lớp";
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
			this.groupBox2.Location = new System.Drawing.Point(66, 279);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(807, 50);
			this.groupBox2.TabIndex = 6;
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
			// chkTimgiaovien
			// 
			this.chkTimgiaovien.AutoSize = true;
			this.chkTimgiaovien.Location = new System.Drawing.Point(14, 44);
			this.chkTimgiaovien.Name = "chkTimgiaovien";
			this.chkTimgiaovien.Size = new System.Drawing.Size(113, 17);
			this.chkTimgiaovien.TabIndex = 8;
			this.chkTimgiaovien.Text = "Tìm theo giáo viên";
			this.chkTimgiaovien.UseVisualStyleBackColor = true;
			this.chkTimgiaovien.CheckedChanged += new System.EventHandler(this.chkTimgiaovien_CheckedChanged);
			// 
			// cmbTimgiaovien
			// 
			this.cmbTimgiaovien.FormattingEnabled = true;
			this.cmbTimgiaovien.Location = new System.Drawing.Point(149, 40);
			this.cmbTimgiaovien.Name = "cmbTimgiaovien";
			this.cmbTimgiaovien.Size = new System.Drawing.Size(104, 21);
			this.cmbTimgiaovien.TabIndex = 6;
			this.cmbTimgiaovien.SelectedIndexChanged += new System.EventHandler(this.cmbTimgiaovien_SelectedIndexChanged);
			// 
			// chkTimten
			// 
			this.chkTimten.AutoSize = true;
			this.chkTimten.Location = new System.Drawing.Point(335, 44);
			this.chkTimten.Name = "chkTimten";
			this.chkTimten.Size = new System.Drawing.Size(102, 17);
			this.chkTimten.TabIndex = 9;
			this.chkTimten.Text = "Tìm theo tên lớp\r\n";
			this.chkTimten.UseVisualStyleBackColor = true;
			this.chkTimten.CheckedChanged += new System.EventHandler(this.chkTimten_CheckedChanged);
			// 
			// txtTimten
			// 
			this.txtTimten.Location = new System.Drawing.Point(441, 41);
			this.txtTimten.Name = "txtTimten";
			this.txtTimten.Size = new System.Drawing.Size(100, 20);
			this.txtTimten.TabIndex = 10;
			this.txtTimten.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTimten_KeyDown);
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.btnTimkiem);
			this.groupBox3.Controls.Add(this.chkTimmonhoc);
			this.groupBox3.Controls.Add(this.chkTimkiem);
			this.groupBox3.Controls.Add(this.txtTimten);
			this.groupBox3.Controls.Add(this.chkTimgiaovien);
			this.groupBox3.Controls.Add(this.chkTimten);
			this.groupBox3.Controls.Add(this.cmbTimmonhoc);
			this.groupBox3.Controls.Add(this.cmbTimgiaovien);
			this.groupBox3.Location = new System.Drawing.Point(69, 172);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(804, 101);
			this.groupBox3.TabIndex = 11;
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
			// cmbTimmonhoc
			// 
			this.cmbTimmonhoc.FormattingEnabled = true;
			this.cmbTimmonhoc.Location = new System.Drawing.Point(149, 76);
			this.cmbTimmonhoc.Name = "cmbTimmonhoc";
			this.cmbTimmonhoc.Size = new System.Drawing.Size(104, 21);
			this.cmbTimmonhoc.TabIndex = 6;
			this.cmbTimmonhoc.SelectedIndexChanged += new System.EventHandler(this.cmbTimmonhoc_SelectedIndexChanged);
			// 
			// lbTimkiem
			// 
			this.lbTimkiem.ForeColor = System.Drawing.Color.IndianRed;
			this.lbTimkiem.Location = new System.Drawing.Point(301, 152);
			this.lbTimkiem.Name = "lbTimkiem";
			this.lbTimkiem.Size = new System.Drawing.Size(263, 23);
			this.lbTimkiem.TabIndex = 12;
			this.lbTimkiem.Text = "Chế độ tìm kiếm";
			this.lbTimkiem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// frmLop
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(911, 645);
			this.Controls.Add(this.lbTimkiem);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.dataGridView1);
			this.Name = "frmLop";
			this.Text = "Form Lớp Học";
			this.Load += new System.EventHandler(this.frmLop_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button btnThem;
		private System.Windows.Forms.TextBox txtMalop;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtSiso;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtTenlop;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnSua;
		private System.Windows.Forms.Button btnXoa;
		private System.Windows.Forms.Button btnLammoi;
		private System.Windows.Forms.Button btnThoat;
		private System.Windows.Forms.TextBox txtSobuoi;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.DateTimePicker dtpNgayketthuc;
		private System.Windows.Forms.DateTimePicker dtpNgaybatdau;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.ComboBox cmbMagiaovien;
		private System.Windows.Forms.ComboBox cmbMamonhoc;
		private System.Windows.Forms.CheckBox chkTimkiem;
		private System.Windows.Forms.CheckBox chkTimgiaovien;
		private System.Windows.Forms.ComboBox cmbTimgiaovien;
		private System.Windows.Forms.CheckBox chkTimten;
		private System.Windows.Forms.TextBox txtTimten;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.CheckBox chkTimmonhoc;
		private System.Windows.Forms.ComboBox cmbTimmonhoc;
		private System.Windows.Forms.Label lbTimkiem;
		private System.Windows.Forms.Button btnTimkiem;
		private System.Windows.Forms.Button btnIn;
		private System.Windows.Forms.Button btnInport;
		private System.Windows.Forms.Button btnExport;
		private System.Windows.Forms.ErrorProvider errorProvider1;
	}
}

