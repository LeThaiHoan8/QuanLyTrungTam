using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APP_demo
{
	public partial class frmDangky : Form
	{
		string chuoiketnoi = "Data Source=LAPTOP-HK1PT9J5;Initial Catalog=quanlykhoahoc;Integrated Security=True";

		SqlConnection con = new SqlConnection();
		public frmDangky()
		{
			InitializeComponent();
		}

		private void frmDangky_Load(object sender, EventArgs e)
		{
			ketnoicsdl();
		}

		private void ketnoicsdl()
		{
			try
			{
				con = new SqlConnection(chuoiketnoi);//khởi tạo một đối tượng kết nối đến cơ sở dữ liệu SQL Server
				con.Open();//con: sqlconnection chức năng mở kết nối csdl cho phép truy cập vô
				MessageBox.Show("Success");
			}
			catch
			{
				MessageBox.Show("Fall");
			}
		}

		private void btnDangky_Click(object sender, EventArgs e)
		{
			string tendn=txtTendangnhap.Text.Trim();
			string matkhau = txtMatkhau.Text.Trim();

			string sqlthem = "insert into Users(UserName,Password,RoleID) values('" + tendn + "','" + matkhau + "','2')";

			try
			{
				//Lệnh này tạo một đối tượng SqlCommand mới với câu lệnh SQL(sqlthem) và kết nối cơ sở dữ liệu(con).
				SqlCommand command = new SqlCommand(sqlthem, con);
				//Thực thi câu lệnh SQL và trả về số hàng bị ảnh hưởng
				command.ExecuteNonQuery();
				MessageBox.Show("Thêm thành công");
				

				
			}
			catch
			{
				MessageBox.Show("Thêm thất bại");
			}
		}
	}
}
