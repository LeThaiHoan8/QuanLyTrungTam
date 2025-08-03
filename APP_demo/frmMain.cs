using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APP_demo
{
	public partial class frmMain : Form
	{
		private string userRole;

		public frmMain(string role)
		{
			InitializeComponent();
			userRole = role;
			ApplyRolePermissions();
		}

		private void ApplyRolePermissions()
		{
			switch (userRole)
			{
				case "Admin":
					// Admin có toàn quyền
					break;
				case "User":
					// Ẩn hoặc khóa các chức năng không được phép sử dụng
					mnGiaovien.Visible=false;
					
					mnLop.Visible=false;
					mnPhanquyen.Visible=false;

					break;
				case "NhanVien":
					mnPhanquyen.Visible = false;

					break;

				case "GiaoVien":
					mnPhanquyen.Visible = false;
					mnGiaovien.Visible = false;

					break;
				default:
					// Quyền mặc định hoặc không có quyền
					
					break;
			}
		}

		private void frmMain_Load(object sender, EventArgs e)
		{

		}

		private void mnLop_Click(object sender, EventArgs e)
		{
			frmLop frmLop = new frmLop();
			frmLop.Show();
		}

		private void mnHocvien_Click(object sender, EventArgs e)
		{
			frmHocvien frm=new frmHocvien();
			frm.Show();
		}

		private void mnGiaovien_Click(object sender, EventArgs e)
		{
			frmGiaovien frm=new frmGiaovien();
			frm.Show();
		}

		private void mnMonhoc_Click(object sender, EventArgs e)
		{
			frmMonhoc frm=new frmMonhoc();
			frm.Show();
		}

		private void mnPhanquyen_Click(object sender, EventArgs e)
		{
			frmAdminphanquyen frm=new frmAdminphanquyen();
			frm.Show();
		}

		private void mnDanhsachduthi_Click(object sender, EventArgs e)
		{
			frmDanhSachDuThi frm=new frmDanhSachDuThi();
			frm.Show();
		}
	}
}
