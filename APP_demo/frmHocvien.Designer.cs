namespace APP_demo
{
	partial class frmHocvien
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
			this.chkTimten = new System.Windows.Forms.CheckBox();
			this.btnIn = new System.Windows.Forms.Button();
			this.dtpNgaysinh = new System.Windows.Forms.DateTimePicker();
			this.txtDiachi = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.txtGioitinh = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtTenhocvien = new System.Windows.Forms.TextBox();
			this.btnTimkiem = new System.Windows.Forms.Button();
			this.txtTimten = new System.Windows.Forms.TextBox();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			this.label3 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.btnInport = new System.Windows.Forms.Button();
			this.btnThem = new System.Windows.Forms.Button();
			this.btnSua = new System.Windows.Forms.Button();
			this.btnXoa = new System.Windows.Forms.Button();
			this.btnThoat = new System.Windows.Forms.Button();
			this.btnLammoi = new System.Windows.Forms.Button();
			this.lbTimkiem = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtSdt = new System.Windows.Forms.TextBox();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.txtMahocvien = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
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
			// chkTimten
			// 
			this.chkTimten.AutoSize = true;
			this.chkTimten.Location = new System.Drawing.Point(31, 247);
			this.chkTimten.Name = "chkTimten";
			this.chkTimten.Size = new System.Drawing.Size(129, 17);
			this.chkTimten.TabIndex = 9;
			this.chkTimten.Text = "Tìm theo tên học viên";
			this.chkTimten.UseVisualStyleBackColor = true;
			this.chkTimten.CheckedChanged += new System.EventHandler(this.chkTimten_CheckedChanged);
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
			// dtpNgaysinh
			// 
			this.dtpNgaysinh.CustomFormat = "MM/dd/yyyy";
			this.dtpNgaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpNgaysinh.Location = new System.Drawing.Point(259, 22);
			this.dtpNgaysinh.Name = "dtpNgaysinh";
			this.dtpNgaysinh.Size = new System.Drawing.Size(100, 20);
			this.dtpNgaysinh.TabIndex = 4;
			// 
			// txtDiachi
			// 
			this.txtDiachi.Location = new System.Drawing.Point(469, 19);
			this.txtDiachi.Name = "txtDiachi";
			this.txtDiachi.Size = new System.Drawing.Size(100, 20);
			this.txtDiachi.TabIndex = 2;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(604, 31);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(32, 13);
			this.label9.TabIndex = 3;
			this.label9.Text = "Email";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(408, 25);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(40, 13);
			this.label7.TabIndex = 3;
			this.label7.Text = "Địa chỉ";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(193, 26);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(54, 13);
			this.label5.TabIndex = 3;
			this.label5.Text = "Ngày sinh";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(393, 51);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(70, 13);
			this.label8.TabIndex = 3;
			this.label8.Text = "Số điện thoại";
			// 
			// txtGioitinh
			// 
			this.txtGioitinh.Location = new System.Drawing.Point(259, 48);
			this.txtGioitinh.Name = "txtGioitinh";
			this.txtGioitinh.Size = new System.Drawing.Size(100, 20);
			this.txtGioitinh.TabIndex = 2;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(200, 51);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(47, 13);
			this.label4.TabIndex = 3;
			this.label4.Text = "Giới tính";
			// 
			// txtTenhocvien
			// 
			this.txtTenhocvien.Location = new System.Drawing.Point(64, 45);
			this.txtTenhocvien.Name = "txtTenhocvien";
			this.txtTenhocvien.Size = new System.Drawing.Size(100, 20);
			this.txtTenhocvien.TabIndex = 2;
			// 
			// btnTimkiem
			// 
			this.btnTimkiem.Location = new System.Drawing.Point(317, 241);
			this.btnTimkiem.Name = "btnTimkiem";
			this.btnTimkiem.Size = new System.Drawing.Size(75, 23);
			this.btnTimkiem.TabIndex = 12;
			this.btnTimkiem.Text = "Tìm kiếm";
			this.btnTimkiem.UseVisualStyleBackColor = true;
			this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
			// 
			// txtTimten
			// 
			this.txtTimten.Location = new System.Drawing.Point(181, 244);
			this.txtTimten.Name = "txtTimten";
			this.txtTimten.Size = new System.Drawing.Size(100, 20);
			this.txtTimten.TabIndex = 10;
			this.txtTimten.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTimten_KeyDown);
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(-4, 51);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(70, 13);
			this.label3.TabIndex = 3;
			this.label3.Text = "Tên học viên";
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
			this.groupBox2.Location = new System.Drawing.Point(25, 293);
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
			this.lbTimkiem.Location = new System.Drawing.Point(271, 166);
			this.lbTimkiem.Name = "lbTimkiem";
			this.lbTimkiem.Size = new System.Drawing.Size(263, 23);
			this.lbTimkiem.TabIndex = 18;
			this.lbTimkiem.Text = "Chế độ tìm kiếm";
			this.lbTimkiem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.dtpNgaysinh);
			this.groupBox1.Controls.Add(this.txtSdt);
			this.groupBox1.Controls.Add(this.txtEmail);
			this.groupBox1.Controls.Add(this.txtDiachi);
			this.groupBox1.Controls.Add(this.label9);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.txtGioitinh);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.txtTenhocvien);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.txtMahocvien);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(25, 55);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(807, 108);
			this.groupBox1.TabIndex = 15;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Thông tin chi tiết về Lớp";
			// 
			// txtSdt
			// 
			this.txtSdt.Location = new System.Drawing.Point(469, 45);
			this.txtSdt.Name = "txtSdt";
			this.txtSdt.Size = new System.Drawing.Size(100, 20);
			this.txtSdt.TabIndex = 2;
			// 
			// txtEmail
			// 
			this.txtEmail.Location = new System.Drawing.Point(642, 25);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(100, 20);
			this.txtEmail.TabIndex = 2;
			// 
			// txtMahocvien
			// 
			this.txtMahocvien.Location = new System.Drawing.Point(64, 19);
			this.txtMahocvien.Name = "txtMahocvien";
			this.txtMahocvien.Size = new System.Drawing.Size(100, 20);
			this.txtMahocvien.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(0, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(66, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "Mã học viên";
			// 
			// label2
			// 
			this.label2.ForeColor = System.Drawing.Color.DarkRed;
			this.label2.Location = new System.Drawing.Point(25, 23);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(698, 29);
			this.label2.TabIndex = 14;
			this.label2.Text = "Danh Mục Học Viên\r\n";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(25, 361);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(807, 267);
			this.dataGridView1.TabIndex = 13;
			this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
			// 
			// frmHocvien
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(856, 651);
			this.Controls.Add(this.btnTimkiem);
			this.Controls.Add(this.txtTimten);
			this.Controls.Add(this.chkTimten);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.lbTimkiem);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.dataGridView1);
			this.Name = "frmHocvien";
			this.Text = "frmHocvien";
			this.Load += new System.EventHandler(this.frmHocvien_Load);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnExport;
		private System.Windows.Forms.CheckBox chkTimten;
		private System.Windows.Forms.Button btnIn;
		private System.Windows.Forms.DateTimePicker dtpNgaysinh;
		private System.Windows.Forms.TextBox txtDiachi;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txtGioitinh;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtTenhocvien;
		private System.Windows.Forms.Button btnTimkiem;
		private System.Windows.Forms.TextBox txtTimten;
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
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtMahocvien;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.TextBox txtSdt;
		private System.Windows.Forms.TextBox txtEmail;
	}
}