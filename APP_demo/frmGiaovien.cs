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
using System.IO;
using OfficeOpenXml;
using Excel = Microsoft.Office.Interop.Excel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace APP_demo
{
	public partial class frmGiaovien : Form
	{
		string chuoiketnoi = "Data Source=LAPTOP-HK1PT9J5;Initial Catalog=quanlykhoahoc;Integrated Security=True";

		SqlConnection con = new SqlConnection();
		public frmGiaovien()
		{
			InitializeComponent();
		}

		//---------------------------------------HÀM CƠ BẢN---------------------------------------
		private void frmGiaovien_Load(object sender, EventArgs e)
		{
			txtMagiaovien.Text = TangMa();
			txtMagiaovien.Enabled = false;
			ketnoicsdl();
			loaddulieulenluoi();
			dinhdangluoi();
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

		//hàm tải(load) dữ liệu lên lưới 
		private void loaddulieulenluoi()
		{  //datatable là 1 phạm vi nhỏ của dataset

			String sql = "SELECT *FROM GIAOVIEN";

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
			dataGridView1.Columns[0].HeaderText = "Mã giáo viên";
			dataGridView1.Columns[0].Width = 100;
			dataGridView1.Columns[1].HeaderText = "Tên giáo viên";
			dataGridView1.Columns[1].Width = 130;
			dataGridView1.Columns[2].HeaderText = "Ngày sinh";
			dataGridView1.Columns[2].Width = 130;
			dataGridView1.Columns[3].HeaderText = "Giới tính";
			dataGridView1.Columns[3].Width = 70;
			dataGridView1.Columns[4].HeaderText = "Địa chỉ";
			dataGridView1.Columns[4].Width = 130;
			dataGridView1.Columns[5].HeaderText = "Số điện thoại ";
			dataGridView1.Columns[5].Width = 100;
			dataGridView1.Columns[6].HeaderText = "Email";
			dataGridView1.Columns[6].Width = 100;
		}

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
				txtMagiaovien.Text = TangMa();
				txtTengiaovien.Text = "";
				txtGioitinh.Text = "";
				txtDiachi.Text = "";
				return;
			}

			//Nếu e.RowIndex nằm trong phạm vi hợp lệ, tiếp tục các bước kiểm tra và lấy dữ liệu.
			if (e.RowIndex >= 0) //lệnh này tránh người dùng click sai làm chạy vào code
			{

				//giải thích c1: đưa dữ liệu từ hàng ngang thứ e.RowIndex và ô cell[0] để đưa giá trị vào trong textbox
				txtMagiaovien.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
				//giải thích c2: lấy dữ liệu từ lưới từ hàng ngang ở hàng con trỏ chuột nhấp vào và ô của thứ 0
				
				txtTengiaovien.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
				dtpNgaysinh.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
				txtGioitinh.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
				txtDiachi.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
				txtSdt.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
				txtEmail.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
			}
		
	}
		
		private string TangMa()
		{
			
			string sql = "SELECT TOP 1 MAGV FROM GIAOVIEN ORDER BY MAGV DESC";

			// Tạo kết nối với cơ sở dữ liệu
			using (SqlConnection con = new SqlConnection(chuoiketnoi))
			{
				SqlCommand cmd = new SqlCommand(sql, con);
				con.Open();
				object result = cmd.ExecuteScalar();
													

				if (result != null)
				{
					string Maxmahv = result.ToString();
					int maxNumber = int.Parse(Maxmahv.Substring(2)) + 1;
					return "GV" + maxNumber.ToString("D3");
				}
				else
				{
					return "GV001";
				}
			}

		}
		
		private void dinhdangngaythangsql()
		{
			//dữ liệu hiện lên bảng phụ thuộc vào máy của người dùng ở định dạng nào 
			try
			{
				string sqldinhdangngaythang = "SET DATEFORMAT mdy";//m:tháng d:ngày y:năm
				SqlCommand command = new SqlCommand(sqldinhdangngaythang, con);
				command.ExecuteNonQuery();
			}
			catch
			{
				MessageBox.Show("Không định dạng được");
			}
		}
		//------------------------------------------------------------------------------

		//---------------------------------------5 NÚT CƠ BẢN---------------------------------------
		private void btnThem_Click(object sender, EventArgs e)
		{
			dinhdangngaythangsql();

			//khai báo biến để dễ nhìn khi viết câu sql


			string Magv = TangMa();
			string Tengv = txtTengiaovien.Text.Trim();
			string Ngaysinh = dtpNgaysinh.Text;
			string Gioitinh = txtGioitinh.Text.Trim();

			string Diachi = txtDiachi.Text.Trim();
			string sdt = txtSdt.Text.Trim();
			string email = txtEmail.Text.Trim();

			//lệnh này thì cho phép null
			string sqlthem = "insert into GIAOVIEN(MaGV,TenGV,NgaySinh,GioiTinh,DiaChi,SoDienThoai,Email) " +
				"values('" + Magv + "',N'" + Tengv + "','" + Ngaysinh + "',N'" + Gioitinh + "',N'" + Diachi + "','" + sdt + "','" + email + "')";

			errorProvider1.Clear();
			if (txtMagiaovien.Text == "")
			{
				errorProvider1.SetError(txtMagiaovien, "Mã giáo viên không được trống");
				MessageBox.Show("Mã giáo viên không được trống", "Thông báo",
				MessageBoxButtons.OK, MessageBoxIcon.Error);
				txtMagiaovien.Focus();
				return;
			}
			if (txtTengiaovien.Text == "")
			{
				errorProvider1.SetError(txtTengiaovien, "Tên giáo viên không được trống");
				MessageBox.Show("Tên giáo viên không được trống", "Thông báo",
				MessageBoxButtons.OK, MessageBoxIcon.Error);
				txtTengiaovien.Focus();
				return;
			}

			int Sodienthoai;
			if (txtSdt.Text != "" && int.TryParse(txtSdt.Text, out Sodienthoai) == false)
			{
				errorProvider1.SetError(txtSdt, "sai định dạng");
			}


			try
			{
				//Lệnh này tạo một đối tượng SqlCommand mới với câu lệnh SQL(sqlthem) và kết nối cơ sở dữ liệu(con).
				SqlCommand command = new SqlCommand(sqlthem, con);
				//Thực thi câu lệnh SQL và trả về số hàng bị ảnh hưởng
				command.ExecuteNonQuery();
				MessageBox.Show("Thêm thành công");
				loaddulieulenluoi();

				txtMagiaovien.Text = TangMa();// Tạo mã lớp mới
			}
			catch
			{
				MessageBox.Show("Thêm thất bại");
			}
		}

		private void btnSua_Click(object sender, EventArgs e)
		{
			dinhdangngaythangsql();
			string Magv = txtMagiaovien.Text.Trim();
			string TengV = txtTengiaovien.Text.Trim();
			string NgaySinh = dtpNgaysinh.Text;
			string GioiTinh = txtGioitinh.Text.Trim();

			string DiaChi = txtDiachi.Text.Trim();
			string SoDienThoai = txtSdt.Text;
			string Email = txtEmail.Text.Trim();


			string sqlsua = "UPDATE GIAOVIEN SET TenGV=N'" + TengV + "',NgaySinh='" + NgaySinh + "',GioiTinh=N'" + GioiTinh + "',DiaChi=N'" + DiaChi + "',SoDienThoai=" + SoDienThoai + ",Email='" + Email + "' " +
				"WHERE MaGV='" + Magv + "'";

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
				txtMagiaovien.Focus();
			}
		}

		private void btnXoa_Click(object sender, EventArgs e)
		{
			string Magv = txtMagiaovien.Text.Trim();

			string sqlxoa = "DELETE GIAOVIEN WHERE MaGV='" + Magv + "'";
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

		//---------------------------------------Xuất-Nhập Excel---------------------------------------
		//---------------------------------------Xuất-file-Excel---------------------------------------
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

		//---------------------------------------Nhập-file-Excel---------------------------------------
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

		private void ImportExcel(string path)
		{
			string connectionString = "Data Source=LAPTOP-HK1PT9J5;Initial Catalog=quanlykhoahoc;Integrated Security=True";
			using (ExcelPackage excelPackage = new ExcelPackage(new FileInfo(path)))//Mở file Excel từ đường dẫn được cung cấp (path) và tạo một ExcelPackage mới.
			{
				ExcelWorksheet excelWorksheet = excelPackage.Workbook.Worksheets[0];//Lấy sheet đầu tiên trong workbook Excel.
				DataTable newDataTable = new DataTable();// Tạo một DataTable mới để lưu dữ liệu từ Excel.

				// Thêm tất cả các cột vào DataTable
				for (int i = excelWorksheet.Dimension.Start.Column; i <= excelWorksheet.Dimension.End.Column; i++)//Vòng lặp qua tất cả các cột trong sheet Excel.
				{
					newDataTable.Columns.Add(excelWorksheet.Cells[1, i].Value.ToString());//Thêm các tiêu đề cột từ hàng đầu tiên của sheet Excel vào DataTable.
				}

				// Thêm hàng vào DataTable
				for (int i = excelWorksheet.Dimension.Start.Row + 1; i <= excelWorksheet.Dimension.End.Row; i++)//Vòng lặp qua tất cả các hàng, bắt đầu từ hàng thứ 2 (bỏ qua tiêu đề cột).
				{
					List<string> listRow = new List<string>();//Tạo một danh sách để lưu dữ liệu của một hàng.
					for (int j = excelWorksheet.Dimension.Start.Column; j <= excelWorksheet.Dimension.End.Column; j++)//Vòng lặp qua tất cả các cột trong một hàng.
					{
						var cellValue = excelWorksheet.Cells[i, j]?.Value?.ToString() ?? string.Empty;//Lấy giá trị của ô hiện tại, nếu giá trị là null, sử dụng chuỗi rỗng.
						listRow.Add(cellValue);//Thêm giá trị ô vào danh sách listRow.
					}
					newDataTable.Rows.Add(listRow.ToArray());
				}

				// Hợp nhất dữ liệu mới với dữ liệu hiện có trong DataGridView
				DataTable currentDataTable = (DataTable)dataGridView1.DataSource;// Lấy DataTable hiện tại từ dataGridView1.
				if (currentDataTable != null)//Kiểm tra nếu dataGridView1 đã có dữ liệu.
				{
					foreach (DataRow row in newDataTable.Rows)// Vòng lặp qua tất cả các hàng trong newDataTable.
					{
						currentDataTable.ImportRow(row);//Nhập từng hàng từ newDataTable vào currentDataTable.
					}
				}
				else
				{
					currentDataTable = newDataTable;//Nếu dataGridView1 không có dữ liệu, gán newDataTable cho currentDataTable.
				}

				dataGridView1.DataSource = currentDataTable;//Cập nhật dataGridView1 với currentDataTable.

				// Chèn từng dòng dữ liệu vào cơ sở dữ liệu
				using (SqlConnection conn = new SqlConnection(connectionString))//Mở một kết nối tới cơ sở dữ liệu.
				{
					conn.Open();
					foreach (DataRow row in newDataTable.Rows)//Vòng lặp qua tất cả các hàng trong newDataTable.
					{
						string Magv = TangMa();
						string Tengv = row[1].ToString();
						DateTime Ngaysinh = DateTime.Parse(row[2].ToString());
						string Gioitinh = row[3].ToString();
						string Diachi = row[4].ToString();
						string Sodienthoai = row[5].ToString();
						string Email = row[6].ToString();
						//lệnh này thì cho phép null
						string sqlthem = "insert into GIAOVIEN(MaGV,TenGV,NgaySinh,GioiTinh,DiaChi,SoDienThoai,Email) " +
						" values('" + Magv + "',N'" + Tengv + "','" + Ngaysinh + "',N'" + Gioitinh + "',N'" + Diachi + "','" + Sodienthoai + "','" + Email + "')";

						try
						{
							SqlCommand command = new SqlCommand(sqlthem, con);
							command.ExecuteNonQuery();

							loaddulieulenluoi();

							txtMagiaovien.Text = TangMa();// Tạo mã lớp mới
						}
						catch
						{
							MessageBox.Show("Thêm thất bại");
						}
					}
				}
			}


		}
		//------------------------------------------------------------------------------

		//---------------------------------------IN ẤN---------------------------------------
		private void btnIn_Click(object sender, EventArgs e)
		{
			frmInGiaoVien frm=new frmInGiaoVien();
			frm.ShowDialog();
		}
		//------------------------------------------------------------------------------

		//---------------------------------------TÌM KIẾM CƠ BẢN---------------------------------------
		private void btnTimkiem_Click(object sender, EventArgs e)
		{
			try
			{
				string tengiaovien = txtTimten.Text.Trim();

				String sql = "SELECT *FROM GIAOVIEN" +
							" WHERE TenGV like N'%"+ tengiaovien +"%'"; 

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
			if (e.KeyCode == Keys.Enter)
			{
				try
				{
					string tengiaovien = txtTimten.Text.Trim();

					String sql = "SELECT *FROM GIAOVIEN" +
								" WHERE TenGV like N'%" + tengiaovien + "%'"; 

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
		}
		//------------------------------------------------------------------------------

		//---------------------------------------THỐNG KÊ---------------------------------------
		private void btnThongke_Click(object sender, EventArgs e)
		{
			frmThongKeDiemofHV frm=new frmThongKeDiemofHV();
			frm.ShowDialog();
		}
		//------------------------------------------------------------------------------

	}
}
