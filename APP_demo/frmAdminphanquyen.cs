using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using Excel = Microsoft.Office.Interop.Excel;


namespace APP_demo
{
	public partial class frmAdminphanquyen : Form
	{
		string chuoiketnoi = "Data Source=LAPTOP-HK1PT9J5;Initial Catalog=quanlykhoahoc;Integrated Security=True";

		SqlConnection con = new SqlConnection();
		public frmAdminphanquyen()
		{
			InitializeComponent();
		}
		//---------------------------------------HÀM CƠ BẢN---------------------------------------
		private void frmAdminphanquyen_Load(object sender, EventArgs e)
		{
			txtTendangnhap.Text = TangMa();
			txtTendangnhap.Enabled = false;
			ketnoicsdl();
			loadcombobox1(cmbQuyen);
			loaddulieulenluoi();
			dinhdangluoi();
		}

		//hàm kết nối cơ sở dữ liệu
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

		//hàm tải(load) dữ liệu lên lưới 
		private void loaddulieulenluoi()
		{  //datatable là 1 phạm vi nhỏ của dataset

			String sql = "SELECT UserName,Password,ROLENAME " +
				"FROM USERS U, ROLES R " +
				"WHERE U.ROLEID = R.ROLEID";//câu truy vấn từ bảng lớp được gán vào 1 chuỗi 

			SqlDataAdapter da = new SqlDataAdapter(sql, con);//SqlDataAdapter: lấy dữ liệu từ csdl
			DataTable dt = new DataTable();//DataTable:lưu trữ hoặc quản lý dữ liệu // khai báo báo datatable
			da.Fill(dt);//lấy(đổ) dữ liệu từ csdl qua dataset hoặc datatable
			dataGridView1.DataSource = dt;//từ dữ liệu của datatable gán qua bảng gridview

		}
		//------------------------------------------------------------------------------

		//---------------------------------------HÀM KHAI BÁO---------------------------------------
		//hàm định dạng lưới 
		private void dinhdangluoi()
		{
			dataGridView1.Columns[0].HeaderText = "Tên User";
			dataGridView1.Columns[0].Width = 130;
			dataGridView1.Columns[1].HeaderText = "Mật khẩu";
			dataGridView1.Columns[1].Width = 100;
			dataGridView1.Columns[2].HeaderText = "Quyền";
			dataGridView1.Columns[2].Width = 130;
			
		}

		//hàm hiển thị nội dung lên textbox khi click chuột vào
		private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			// Kiểm tra nếu người dùng click vào hàng tiêu đề
			if (e.RowIndex == -1)
			{
				// Bỏ qua thao tác nếu người dùng click vào hàng tiêu đề
				return;
			}

			// Kiểm tra nếu hàng không có dữ liệu
			if (dataGridView1.Rows[e.RowIndex].Cells[0].Value == null || string.IsNullOrEmpty(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString()))
			//Giá trị của ô đầu tiên trong hàng hiện tại là null.
			//Giá trị của ô đầu tiên trong hàng hiện tại là một chuỗi rỗng.
			{
				txtTendangnhap.Text = TangMa();


				return;
			}

			//Nếu e.RowIndex nằm trong phạm vi hợp lệ, tiếp tục các bước kiểm tra và lấy dữ liệu.
			if (e.RowIndex >= 0) //lệnh này tránh người dùng click sai làm chạy vào code
			{

				//giải thích c1: đưa dữ liệu từ hàng ngang thứ e.RowIndex và ô cell[0] để đưa giá trị vào trong textbox

				//giải thích c2: lấy dữ liệu từ lưới từ hàng ngang ở hàng con trỏ chuột nhấp vào và ô của thứ 0
				
				txtTendangnhap.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();

				txtMatkhau.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
				cmbQuyen.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();

			}
		}
		
		//Hàm tăng mã tự động
		private string TangMa()
		{
			// Chuỗi SQL để lấy mã UserName lớn nhất từ bảng USERS theo định dạng "Uxxx"
			string sql = "SELECT TOP 1 UserName FROM USERS " +
				"WHERE UserName LIKE 'U%' " +
				"ORDER BY UserName DESC";

			// Tạo kết nối với cơ sở dữ liệu
			using (SqlConnection con = new SqlConnection(chuoiketnoi))
			{
				SqlCommand cmd = new SqlCommand(sql, con);
				con.Open();
				object result = cmd.ExecuteScalar();

				if (result != null)
				{
					string maxUserName = result.ToString();

					// Kiểm tra định dạng của UserName
					if (maxUserName.StartsWith("U") && int.TryParse(maxUserName.Substring(1), out int maxNumber))
					{
						// Tăng giá trị số của UserName lên 1
						maxNumber += 1;
						return "U" + maxNumber.ToString("D3");
					}
					else
					{
						// Nếu định dạng không phù hợp, trả về "U001"
						return "U001";
					}
				}
				else
				{
					// Nếu không có UserName nào trong cơ sở dữ liệu, trả về "U001"
					return "U001";
				}
			}
		}
		//------------------------------------------------------------------------------

		//---------------------------------------LOAD COMBOBOX---------------------------------------
		//hàm load  combobox
		private void loadcombobox1(ComboBox cmb)
		{
			try
			{
				String sql = "SELECT * FROM ROLES WHERE RoleName != 'Admin'"; //không cho load admin
				
				// Tạo SqlDataAdapter để thực hiện truy vấn SQL
				SqlDataAdapter da = new SqlDataAdapter(sql, con);
				// Tạo DataTable để lưu dữ liệu
				DataTable dt = new DataTable();
				// Đổ dữ liệu vào DataTable từ SqlDataAdapter
				da.Fill(dt);

				// Gán DataTable làm nguồn dữ liệu cho ComboBox
				cmb.DataSource = dt;
				// Thiết lập cột dữ liệu sẽ được hiển thị trong ComboBox
				cmb.DisplayMember = dt.Columns["ROLENAME"].ToString();
				// Thiết lập cột dữ liệu chứa giá trị của ComboBox
				cmb.ValueMember = dt.Columns["ROLEID"].ToString();
			}
			catch
			{
				MessageBox.Show("Không load được combobox quyền của USER ");
			}

		}
		//------------------------------------------------------------------------------

		//---------------------------------------5 NÚT CƠ BẢN---------------------------------------
		private void btnThem_Click(object sender, EventArgs e)
		{
			string Tendangnhap = TangMa();
			string Matkhau = txtMatkhau.Text.Trim();
			string Quyen = cmbQuyen.SelectedValue.ToString().Trim();//lấy giá trị của combobox
					
			//lệnh này thì cho phép null
			string sqlthem = "insert into Users(UserName,Password,RoleID) " +
				"values(N'" + Tendangnhap + "',N'" + Matkhau + "','" + Quyen + "')";

			errorProvider1.Clear();

			if (txtTendangnhap.Text == "")
			{
				errorProvider1.SetError(txtTendangnhap, "Tên đăng nhập không được trống");
				MessageBox.Show("Tên đăng nhập không được trống", "Thông báo",
				MessageBoxButtons.OK, MessageBoxIcon.Error);
				txtTendangnhap.Focus();
				return;
			}
			if (txtMatkhau.Text == "")
			{
				errorProvider1.SetError(txtMatkhau, "Mật khẩu không được trống");
				MessageBox.Show("Mật khẩu không được trống", "Thông báo",
				MessageBoxButtons.OK, MessageBoxIcon.Error);
				txtMatkhau.Focus();
				return;
			}			
			try
			{
				//Lệnh này tạo một đối tượng SqlCommand mới với câu lệnh SQL(sqlthem) và kết nối cơ sở dữ liệu(con).
				SqlCommand command = new SqlCommand(sqlthem, con);
				//Thực thi câu lệnh SQL và trả về số hàng bị ảnh hưởng
				command.ExecuteNonQuery();
				MessageBox.Show("Thêm thành công");
				loaddulieulenluoi();

				txtTendangnhap.Text = TangMa();// Tạo mã lớp mới
			}
			catch
			{
				MessageBox.Show("Thêm thất bại");
			}

		}

		private void btnSua_Click(object sender, EventArgs e)
		{
			string Tendangnhap = txtTendangnhap.Text.Trim();
			string Matkhau = txtMatkhau.Text.Trim();
			string Quyen = cmbQuyen.SelectedValue.ToString().Trim();//lấy giá trị của combobox

			string sqlsua = "UPDATE Users SET Password=N'" + Matkhau + "',RoleID='" + Quyen + "'" +
				" WHERE UserName=N'" + Tendangnhap + "'";

			try
			{
				SqlCommand command = new SqlCommand(sqlsua, con);
				command.ExecuteNonQuery();
				MessageBox.Show("Sửa thành công");
				loaddulieulenluoi();
			}
			catch
			{
				MessageBox.Show("Sửa thất bại");
				txtTendangnhap.Focus();
			}
		}

		private void btnXoa_Click(object sender, EventArgs e)
		{
			string Tendangnhap = txtTendangnhap.Text.Trim();
			string Matkhau = txtMatkhau.Text.Trim();
			string Quyen = cmbQuyen.SelectedValue.ToString().Trim();//lấy giá trị của combobox

			string sqlxoa = "DELETE Users WHERE UserName=N'" + Tendangnhap + "'";
			if (dataGridView1.Rows.Count == 0)
			{
				return;
			}
			DialogResult dr = MessageBox.Show(" Có chắc chắn xóa phòng này không ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (dr == DialogResult.Yes)
			{
				try
				{
					SqlCommand command = new SqlCommand(sqlxoa, con);
					command.ExecuteNonQuery();
					MessageBox.Show("Xóa thành công");
					loaddulieulenluoi();
				}
				catch
				{
					MessageBox.Show("Xóa thất bại");
				}
			}
			else
				return;
		}

		private void btnLammoi_Click(object sender, EventArgs e)
		{
			loaddulieulenluoi();
		}

		private void btnThoat_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		//------------------------------------------------------------------------------

		//---------------------------------------TÌM KIẾM CƠ BẢN---------------------------------------
		private void btnTimkiem_Click(object sender, EventArgs e)
		{
			try
			{
				string tendangnhap = txtTimten.Text.Trim();

				String sql = "SELECT *FROM Users" +
							" WHERE UserName like N'%" + tendangnhap + "%'"; 

				SqlDataAdapter da = new SqlDataAdapter(sql, con);//SqlDataAdapter: lấy dữ liệu từ csdl
				DataTable dt = new DataTable();//DataTable:lưu trữ hoặc quản lý dữ liệu // khai báo báo datatable
				da.Fill(dt);//lấy(đổ) dữ liệu từ csdl qua dataset hoặc datatable
				dataGridView1.DataSource = dt;//từ dữ liệu của datatable gán qua bảng gridview
			}
			catch
			{
				MessageBox.Show("Không tìm thấy");
			}
		}

		private void txtTimten_KeyDown(object sender, KeyEventArgs e)
		{
			try
			{
				string tendangnhap = txtTimten.Text.Trim();

				String sql = "SELECT *FROM Users" +
							" WHERE UserName like N'%" + tendangnhap + "%'"; 

				SqlDataAdapter da = new SqlDataAdapter(sql, con);//SqlDataAdapter: lấy dữ liệu từ csdl
				DataTable dt = new DataTable();//DataTable:lưu trữ hoặc quản lý dữ liệu // khai báo báo datatable
				da.Fill(dt);//lấy(đổ) dữ liệu từ csdl qua dataset hoặc datatable
				dataGridView1.DataSource = dt;//từ dữ liệu của datatable gán qua bảng gridview
			}
			catch
			{
				MessageBox.Show("Không tìm thấy");
			}
		}
		//------------------------------------------------------------------------------

		//---------------------------------------IN ẤN---------------------------------------
		private void btnIn_Click(object sender, EventArgs e)
		{
			frmInAdminPhanQuyen frm =new frmInAdminPhanQuyen();
			frm.ShowDialog();
		}
		//------------------------------------------------------------------------------

		//---------------------------------------Xuất-Nhập Excel---------------------------------------
		//---------------------------------------Xuất-file-Excel---------------------------------------
		//hàm xuất dữ liệu từ datagriview sang excel
		private void ExportExcel(string path)
		{
			Excel.Application application = new Excel.Application(); //Tạo một đối tượng Excel.Application mới để tương tác với Excel.
			application.Application.Workbooks.Add(Type.Missing);//Thêm một workbook mới vào ứng dụng Excel.

			// Add column headers
			for (int i = 0; i < dataGridView1.Columns.Count; i++)//Vòng lặp này chạy qua tất cả các cột trong dataGridView1.
			{
				application.Cells[1, i + 1] = dataGridView1.Columns[i].HeaderText;// Đặt tiêu đề cột từ dataGridView1 vào hàng đầu tiên của sheet Excel.
			}

			// Add rows
			for (int i = 0; i < dataGridView1.Rows.Count; i++)//Vòng lặp này chạy qua tất cả các hàng trong dataGridView1.
			{
				for (int j = 0; j < dataGridView1.Columns.Count; j++)// Vòng lặp bên trong này chạy qua tất cả các cột của mỗi hàng.
				{
					application.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value?.ToString();//Đặt giá trị từ dataGridView1 vào các ô tương ứng trong sheet Excel. Sử dụng ?.ToString() để đảm bảo không gặp lỗi khi giá trị là null.
				}
			}

			application.Columns.AutoFit();//Tự động điều chỉnh độ rộng của các cột để phù hợp với nội dung.
			application.ActiveWorkbook.SaveCopyAs(path);//Lưu workbook vào đường dẫn được chỉ định.
			application.ActiveWorkbook.Saved = true;//Đánh dấu workbook là đã được lưu để tránh thông báo hỏi người dùng có muốn lưu thay đổi khi đóng Excel.
			application.Quit();//Đóng ứng dụng Excel.
		}
		private void btnExport_Click(object sender, EventArgs e)
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog();//Tạo một đối tượng SaveFileDialog mới để cho phép người dùng chọn đường dẫn và tên file để lưu.
			saveFileDialog.Title = "Export Excel";//Đặt tiêu đề cho hộp thoại lưu file.
			saveFileDialog.Filter = "Excel (*.xlsx)|*.xlsx|Excel 2003 (*.xls)|*.xls";//Đặt bộ lọc cho hộp thoại lưu file, cho phép người dùng chọn giữa định dạng .xlsx và .xls.

			if (saveFileDialog.ShowDialog() == DialogResult.OK)//Hiển thị hộp thoại lưu file và kiểm tra nếu người dùng nhấn nút "OK".
			{
				try
				{
					ExportExcel(saveFileDialog.FileName);// Gọi hàm ExportExcel với đường dẫn file mà người dùng đã chọn.
					MessageBox.Show("Xuất file thành công!");
				}
				catch (Exception ex)
				{
					MessageBox.Show("Xuất file không thành công!\n" + ex.Message);
				}
			}
		}

		//---------------------------------------Nhập-file-Excel---------------------------------------
					//-------sử dụng tham số hóa truy vấn (parameterized query)---------
		//hàm chuyển đổi RoleName thành RoleID từ dữ liệu chuỗi chuyển sang số đúng format của csdl
		/*private int GetRoleID(string roleName, SqlConnection conn)
		{
			string query = "SELECT RoleID FROM Roles WHERE RoleName = @RoleName";
			using (SqlCommand cmd = new SqlCommand(query, conn))
			{
				cmd.Parameters.AddWithValue("@RoleName", roleName);
				object result = cmd.ExecuteScalar();
				if (result != null)
				{
					return Convert.ToInt32(result);
				}
				else
				{
					throw new Exception($"RoleName '{roleName}' không tồn tại trong bảng Roles.");
				}
			}
		}*/

		/*private void ImportExcel(string path)
		{
			string connectionString = "Data Source=LAPTOP-HK1PT9J5;Initial Catalog=quanlykhoahoc;Integrated Security=True";
			using (ExcelPackage excelPackage = new ExcelPackage(new FileInfo(path)))
			{
				ExcelWorksheet excelWorksheet = excelPackage.Workbook.Worksheets[0];
				DataTable newDataTable = new DataTable();

				// Thêm tất cả các cột vào DataTable
				for (int i = excelWorksheet.Dimension.Start.Column; i <= excelWorksheet.Dimension.End.Column; i++)
				{
					newDataTable.Columns.Add(excelWorksheet.Cells[1, i].Value.ToString());
				}

				// Thêm hàng vào DataTable
				for (int i = excelWorksheet.Dimension.Start.Row + 1; i <= excelWorksheet.Dimension.End.Row; i++)
				{
					List<string> listRow = new List<string>();
					for (int j = excelWorksheet.Dimension.Start.Column; j <= excelWorksheet.Dimension.End.Column; j++)
					{
						var cellValue = excelWorksheet.Cells[i, j]?.Value?.ToString() ?? string.Empty;
						listRow.Add(cellValue);
					}
					newDataTable.Rows.Add(listRow.ToArray());
				}

				// Hợp nhất dữ liệu mới với dữ liệu hiện có trong DataGridView
				DataTable currentDataTable = (DataTable)dataGridView1.DataSource;
				if (currentDataTable != null)
				{
					foreach (DataRow row in newDataTable.Rows)
					{
						currentDataTable.ImportRow(row);
					}
				}
				else
				{
					currentDataTable = newDataTable;
				}

				dataGridView1.DataSource = currentDataTable;

				// Chèn từng dòng dữ liệu vào cơ sở dữ liệu
				using (SqlConnection conn = new SqlConnection(connectionString))
				{
					conn.Open();
					foreach (DataRow row in newDataTable.Rows)
					{
						string Tendangnhap = TangMa();
						string Matkhau = row[1].ToString();
						string RoleName = row[2].ToString();

						try
						{
							// Lấy RoleID từ RoleName
							int RoleID = GetRoleID(RoleName, conn);

							// Chèn dữ liệu vào bảng Users
							string sqlthem = "INSERT INTO Users (UserName, Password, RoleID) VALUES (@UserName, @Password, @RoleID)";
							using (SqlCommand command = new SqlCommand(sqlthem, conn))
							{
								command.Parameters.AddWithValue("@UserName", Tendangnhap);
								command.Parameters.AddWithValue("@Password", Matkhau);
								command.Parameters.AddWithValue("@RoleID", RoleID);
								command.ExecuteNonQuery();
							}

							loaddulieulenluoi();

							txtTendangnhap.Text = TangMa(); // Tạo mã đăng nhập mới
						}
						catch (Exception ex)
						{
							MessageBox.Show($"Thêm thất bại: {ex.Message}");
						}
					}
				}
			}
		}*/

					//------xây dựng chuỗi truy vấn SQL bằng cách ghép chuỗi (string concatenation)-------
		//hàm chuyển đổi RoleName thành RoleID từ dữ liệu chuỗi chuyển sang số đúng format của csdl
		private int GetRoleID(string roleName, SqlConnection conn)
	{
		// Xây dựng chuỗi truy vấn SQL bằng cách ghép chuỗi
		string query = "SELECT RoleID FROM Roles WHERE RoleName = N'" + roleName + "'";

		using (SqlCommand cmd = new SqlCommand(query, conn))
		{
			object result = cmd.ExecuteScalar();
			if (result != null)
			{
				return Convert.ToInt32(result);
			}
			else
			{
				throw new Exception($"RoleName '{roleName}' không tồn tại trong bảng Roles.");
			}
		}
	}

		//hàm load dữ liệu từ file excel lên datagriview
		private void ImportExcel(string path)
		{
			string connectionString = "Data Source=LAPTOP-HK1PT9J5;Initial Catalog=quanlykhoahoc;Integrated Security=True";
			using (ExcelPackage excelPackage = new ExcelPackage(new FileInfo(path)))
			{
				ExcelWorksheet excelWorksheet = excelPackage.Workbook.Worksheets[0];
				DataTable newDataTable = new DataTable();

				// Thêm tất cả các cột vào DataTable
				for (int i = excelWorksheet.Dimension.Start.Column; i <= excelWorksheet.Dimension.End.Column; i++)
				{
					newDataTable.Columns.Add(excelWorksheet.Cells[1, i].Value.ToString());
				}

				// Thêm hàng vào DataTable
				for (int i = excelWorksheet.Dimension.Start.Row + 1; i <= excelWorksheet.Dimension.End.Row; i++)
				{
					List<string> listRow = new List<string>();
					for (int j = excelWorksheet.Dimension.Start.Column; j <= excelWorksheet.Dimension.End.Column; j++)
					{
						var cellValue = excelWorksheet.Cells[i, j]?.Value?.ToString() ?? string.Empty;
						listRow.Add(cellValue);
					}
					newDataTable.Rows.Add(listRow.ToArray());
				}

				// Hợp nhất dữ liệu mới với dữ liệu hiện có trong DataGridView
				DataTable currentDataTable = (DataTable)dataGridView1.DataSource;
				if (currentDataTable != null)
				{
					foreach (DataRow row in newDataTable.Rows)
					{
						currentDataTable.ImportRow(row);
					}
				}
				else
				{
					currentDataTable = newDataTable;
				}

				dataGridView1.DataSource = currentDataTable;

				// Chèn từng dòng dữ liệu vào cơ sở dữ liệu
				using (SqlConnection conn = new SqlConnection(connectionString))
				{
					conn.Open();
					foreach (DataRow row in newDataTable.Rows)
					{
						string Tendangnhap = TangMa();
						string Matkhau = row[1].ToString();
						string RoleName = row[2].ToString();

						try
						{
							// Lấy RoleID từ RoleName
							int RoleID = GetRoleID(RoleName, conn);

							// Xây dựng chuỗi truy vấn SQL bằng cách ghép chuỗi
							string sqlthem = "INSERT INTO Users (UserName, Password, RoleID) " +
								"VALUES (N'" + Tendangnhap + "', N'" + Matkhau + "', " + RoleID + ")";

							SqlCommand command = new SqlCommand(sqlthem, conn);
							command.ExecuteNonQuery();

							loaddulieulenluoi();

							txtTendangnhap.Text = TangMa(); // Tạo mã đăng nhập mới
						}
						catch (Exception ex)
						{
							MessageBox.Show($"Thêm thất bại: {ex.Message}");
						}
					}
				}
			}
		}

		private void btnInport_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();//Tạo một đối tượng OpenFileDialog mới để cho phép người dùng chọn file Excel.
			openFileDialog.Title = "Import Excel";//Đặt tiêu đề cho hộp thoại mở file.
			openFileDialog.Filter = "Excel (*.xlsx)|*.xlsx|Excel 2003 (*.xls)|*.xls";//Đặt bộ lọc cho hộp thoại mở file, cho phép người dùng chọn giữa định dạng .xlsx và .xls.

			if (openFileDialog.ShowDialog() == DialogResult.OK)//Hiển thị hộp thoại mở file và kiểm tra nếu người dùng nhấn nút "OK".
			{
				try
				{
					ImportExcel(openFileDialog.FileName);//Gọi hàm ImportExcel với đường dẫn file mà người dùng đã chọn.
					MessageBox.Show("Nhập file thành công!");
				}
				catch (Exception ex)
				{
					MessageBox.Show("Nhập file không thành công!\n" + ex.Message);
				}
			}
		}
		//------------------------------------------------------------------------------
		
	}
}
