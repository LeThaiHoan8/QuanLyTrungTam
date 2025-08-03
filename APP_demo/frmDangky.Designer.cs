namespace APP_demo
{
	partial class frmDangky
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
			this.label1 = new System.Windows.Forms.Label();
			this.txtTendangnhap = new System.Windows.Forms.TextBox();
			this.btnDangky = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.txtMatkhau = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(66, 104);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(84, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Tên Đăng Nhập";
			// 
			// txtTendangnhap
			// 
			this.txtTendangnhap.Location = new System.Drawing.Point(156, 101);
			this.txtTendangnhap.Name = "txtTendangnhap";
			this.txtTendangnhap.Size = new System.Drawing.Size(100, 20);
			this.txtTendangnhap.TabIndex = 1;
			// 
			// btnDangky
			// 
			this.btnDangky.Location = new System.Drawing.Point(191, 253);
			this.btnDangky.Name = "btnDangky";
			this.btnDangky.Size = new System.Drawing.Size(75, 23);
			this.btnDangky.TabIndex = 2;
			this.btnDangky.Text = "Đăng Ký";
			this.btnDangky.UseVisualStyleBackColor = true;
			this.btnDangky.Click += new System.EventHandler(this.btnDangky_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(86, 148);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(53, 13);
			this.label2.TabIndex = 0;
			this.label2.Text = "Mật Khẩu";
			// 
			// txtMatkhau
			// 
			this.txtMatkhau.Location = new System.Drawing.Point(156, 145);
			this.txtMatkhau.Name = "txtMatkhau";
			this.txtMatkhau.Size = new System.Drawing.Size(100, 20);
			this.txtMatkhau.TabIndex = 1;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(294, 52);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(47, 13);
			this.label3.TabIndex = 0;
			this.label3.Text = "Đăng ký";
			// 
			// frmDangky
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnDangky);
			this.Controls.Add(this.txtMatkhau);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtTendangnhap);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label1);
			this.Name = "frmDangky";
			this.Text = "frmDangky";
			this.Load += new System.EventHandler(this.frmDangky_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtTendangnhap;
		private System.Windows.Forms.Button btnDangky;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtMatkhau;
		private System.Windows.Forms.Label label3;
	}
}