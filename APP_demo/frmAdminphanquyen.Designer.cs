namespace APP_demo
{
	partial class frmAdminphanquyen
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
			this.btnSua = new System.Windows.Forms.Button();
			this.txtMatkhau = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.btnThoat = new System.Windows.Forms.Button();
			this.btnLammoi = new System.Windows.Forms.Button();
			this.lbTimkiem = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.cmbQuyen = new System.Windows.Forms.ComboBox();
			this.label8 = new System.Windows.Forms.Label();
			this.txtTendangnhap = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.btnXoa = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.btnInport = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.btnExport = new System.Windows.Forms.Button();
			this.btnIn = new System.Windows.Forms.Button();
			this.btnThem = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			this.btnTimkiem = new System.Windows.Forms.Button();
			this.txtTimten = new System.Windows.Forms.TextBox();
			this.chkTimten = new System.Windows.Forms.CheckBox();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
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
			// txtMatkhau
			// 
			this.txtMatkhau.Location = new System.Drawing.Point(290, 28);
			this.txtMatkhau.Name = "txtMatkhau";
			this.txtMatkhau.Size = new System.Drawing.Size(100, 20);
			this.txtMatkhau.TabIndex = 2;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(229, 34);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(52, 13);
			this.label7.TabIndex = 3;
			this.label7.Text = "Mật khẩu";
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
			this.lbTimkiem.Location = new System.Drawing.Point(312, 180);
			this.lbTimkiem.Name = "lbTimkiem";
			this.lbTimkiem.Size = new System.Drawing.Size(263, 23);
			this.lbTimkiem.TabIndex = 26;
			this.lbTimkiem.Text = "Chế độ tìm kiếm";
			this.lbTimkiem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.cmbQuyen);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.txtMatkhau);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.txtTendangnhap);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Location = new System.Drawing.Point(66, 69);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(807, 108);
			this.groupBox1.TabIndex = 24;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Thông tin chi tiết về User";
			// 
			// cmbQuyen
			// 
			this.cmbQuyen.FormattingEnabled = true;
			this.cmbQuyen.Location = new System.Drawing.Point(536, 29);
			this.cmbQuyen.Name = "cmbQuyen";
			this.cmbQuyen.Size = new System.Drawing.Size(104, 21);
			this.cmbQuyen.TabIndex = 8;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(462, 32);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(38, 13);
			this.label8.TabIndex = 7;
			this.label8.Text = "Quyền";
			// 
			// txtTendangnhap
			// 
			this.txtTendangnhap.Location = new System.Drawing.Point(97, 29);
			this.txtTendangnhap.Name = "txtTendangnhap";
			this.txtTendangnhap.Size = new System.Drawing.Size(100, 20);
			this.txtTendangnhap.TabIndex = 2;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(19, 35);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(81, 13);
			this.label3.TabIndex = 3;
			this.label3.Text = "Tên đăng nhập";
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
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(66, 301);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(807, 267);
			this.dataGridView1.TabIndex = 22;
			this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
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
			this.groupBox2.Location = new System.Drawing.Point(66, 253);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(807, 50);
			this.groupBox2.TabIndex = 25;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Thao tác";
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
			// label2
			// 
			this.label2.ForeColor = System.Drawing.Color.DarkRed;
			this.label2.Location = new System.Drawing.Point(66, 37);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(698, 29);
			this.label2.TabIndex = 23;
			this.label2.Text = "Danh Mục ADMIN Phân Quyền";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// btnTimkiem
			// 
			this.btnTimkiem.Location = new System.Drawing.Point(356, 224);
			this.btnTimkiem.Name = "btnTimkiem";
			this.btnTimkiem.Size = new System.Drawing.Size(75, 23);
			this.btnTimkiem.TabIndex = 21;
			this.btnTimkiem.Text = "Tìm kiếm";
			this.btnTimkiem.UseVisualStyleBackColor = true;
			this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
			// 
			// txtTimten
			// 
			this.txtTimten.Location = new System.Drawing.Point(220, 227);
			this.txtTimten.Name = "txtTimten";
			this.txtTimten.Size = new System.Drawing.Size(100, 20);
			this.txtTimten.TabIndex = 20;
			this.txtTimten.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTimten_KeyDown);
			// 
			// chkTimten
			// 
			this.chkTimten.AutoSize = true;
			this.chkTimten.Location = new System.Drawing.Point(70, 230);
			this.chkTimten.Name = "chkTimten";
			this.chkTimten.Size = new System.Drawing.Size(129, 17);
			this.chkTimten.TabIndex = 19;
			this.chkTimten.Text = "Tìm theo tên học viên";
			this.chkTimten.UseVisualStyleBackColor = true;
			// 
			// frmAdminphanquyen
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(939, 605);
			this.Controls.Add(this.lbTimkiem);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnTimkiem);
			this.Controls.Add(this.txtTimten);
			this.Controls.Add(this.chkTimten);
			this.Name = "frmAdminphanquyen";
			this.Text = "frmAdminphanquyen";
			this.Load += new System.EventHandler(this.frmAdminphanquyen_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnSua;
		private System.Windows.Forms.TextBox txtMatkhau;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button btnThoat;
		private System.Windows.Forms.Button btnLammoi;
		private System.Windows.Forms.Label lbTimkiem;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox txtTendangnhap;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnXoa;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button btnInport;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button btnExport;
		private System.Windows.Forms.Button btnIn;
		private System.Windows.Forms.Button btnThem;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ErrorProvider errorProvider1;
		private System.Windows.Forms.Button btnTimkiem;
		private System.Windows.Forms.TextBox txtTimten;
		private System.Windows.Forms.CheckBox chkTimten;
		private System.Windows.Forms.ComboBox cmbQuyen;
		private System.Windows.Forms.Label label8;
	}
}