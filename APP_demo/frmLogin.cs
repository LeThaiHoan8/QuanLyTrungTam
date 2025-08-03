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
	public partial class frmLogin : Form
	{
		string chuoiketnoi = "Data Source=LAPTOP-HK1PT9J5;Initial Catalog=quanlykhoahoc;Integrated Security=True";

		public frmLogin()
		{
			InitializeComponent();
		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			// Lấy giá trị của username và password từ các TextBox tương ứng và loại bỏ khoảng trắng thừa.
			string username = txtUsername.Text.Trim();
			string password = txtPassword.Text.Trim();

			// Gọi phương thức xacthucnguoidung để xác thực người dùng.
			if (xacthucnguoidung(username, password, out string role))
			{
				// Nếu xác thực thành công, ẩn form đăng nhập và hiển thị form chính với vai trò tương ứng.
				this.Hide(); //ẩn form đăng nhập
				frmMain frm = new frmMain(role);
				frm.ShowDialog();
				this.Close();
			}
			else
			{
				MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private bool xacthucnguoidung(string username, string password, out string role)
		{
			// Khởi tạo biến role là chuỗi rỗng.
			role = string.Empty;

			// Câu truy vấn SQL để lấy vai trò của người dùng dựa trên username và password.
			string sql = "SELECT RoleName FROM Users INNER JOIN Roles " +
				"ON Users.RoleID = Roles.RoleID " +
				"WHERE UserName = @UserName " +
				"AND Password = @Password";

			//string sql = "SELECT *FROM Users ,Roles  WHERE Users.RoleID = Roles.RoleID ";

			// Tạo kết nối đến cơ sở dữ liệu sử dụng chuỗi kết nối đã định nghĩa trước đó.
			using (SqlConnection con = new SqlConnection(chuoiketnoi))
			{
				// Tạo đối tượng SqlCommand để thực thi câu lệnh SQL.
				SqlCommand cmd = new SqlCommand(sql, con);
				// Thêm các tham số cho câu lệnh SQL để tránh SQL Injection.
				cmd.Parameters.AddWithValue("@UserName", username);
				cmd.Parameters.AddWithValue("@Password", password);

				con.Open();

				// Thực thi câu lệnh SQL và lấy giá trị đầu tiên của kết quả trả về.
				object result = cmd.ExecuteScalar();

				// Nếu kết quả không null, nghĩa là người dùng tồn tại và xác thực thành công.
				if (result != null)
				{
					// Gán giá trị vai trò cho biến role.
					role = result.ToString();
					return true;
				}
				else
				{
					// Nếu kết quả null, nghĩa là xác thực thất bại.
					return false;
				}
			}
		}


	}
}
