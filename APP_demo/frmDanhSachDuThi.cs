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
using System.Globalization;

namespace APP_demo
{
	public partial class frmDanhSachDuThi : Form
	{
		string chuoiketnoi = "Data Source=LAPTOP-HK1PT9J5;Initial Catalog=quanlykhoahoc;Integrated Security=True";

		SqlConnection con = new SqlConnection();
		public frmDanhSachDuThi()
		{
			InitializeComponent();
		}

		//---------------------------------------HÀM CƠ BẢN---------------------------------------
		private void frmDanhSachDuThi_Load(object sender, EventArgs e)
		{
			
			ketnoicsdl();
			loaddulieulenluoi();

			
			loadcombobox1(cmbMalop);
			loadcombobox2(cmbMahocvien);
			loadcombobox3(cmbMamonhoc);

			dinhdangluoi();
			chkTimkiem_CheckedChanged(sender, e);
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

				string sql = "SELECT l.TenLop,hv.TenHV,mh.TenMonHoc,ds.NgayThi,ds.CaThi,ds.PhongThi " +
				" FROM DanhSachDuThi ds,Lop l,HocVien hv,MonHoc mh" +
				" where ds.MaLop=l.MaLop" +
				" and ds.MaHocVien=hv.MaHV" +
				" and ds.MaMonHoc=mh.MaMonHoc";
			SqlDataAdapter da = new SqlDataAdapter(sql, con);//SqlDataAdapter: lấy dữ liệu từ csdl
			DataTable dt = new DataTable();//DataTable:lưu trữ hoặc quản lý dữ liệu // khai báo báo datatable
			da.Fill(dt);//lấy(đổ) dữ liệu từ csdl qua dataset hoặc datatable
			dataGridView1.DataSource = dt;//từ dữ liệu của datatable gán qua bảng gridview

		}

		//hàm định dạng lưới 
		private void dinhdangluoi()
		{
			dataGridView1.Columns[0].HeaderText = "Tên lớp";
			dataGridView1.Columns[0].Width = 150;
			dataGridView1.Columns[1].HeaderText = "Tên học viên";
			dataGridView1.Columns[1].Width = 150;
			dataGridView1.Columns[2].HeaderText = "Tên môn học";
			dataGridView1.Columns[2].Width = 150;
			dataGridView1.Columns[3].HeaderText = "Ngày thi";
			dataGridView1.Columns[3].Width = 100;
			dataGridView1.Columns[4].HeaderText = "Ca thi";
			dataGridView1.Columns[4].Width = 100;
			dataGridView1.Columns[5].HeaderText = "Phòng thi";
			dataGridView1.Columns[5].Width = 100;
			
		}
		//------------------------------------------------------------------------------

		//---------------------------------------HÀM KHẢI BÁO---------------------------------------
		//hàm định dạng ngày tháng năm
		//nếu dữ liệu nhập vào ko lỗi thì ko có hàm này cũng dc
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

		private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{// Kiểm tra nếu người dùng click vào hàng tiêu đề
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


				txtCathi.Text = "";
				txtPhongthi.Text = "";
				return;
			}

			//Nếu e.RowIndex nằm trong phạm vi hợp lệ, tiếp tục các bước kiểm tra và lấy dữ liệu.
			if (e.RowIndex >= 0) //lệnh này tránh người dùng click sai làm chạy vào code
			{

				//giải thích c1: đưa dữ liệu từ hàng ngang thứ e.RowIndex và ô cell[0] để đưa giá trị vào trong textbox
				cmbMalop.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
				//giải thích c2: lấy dữ liệu từ lưới từ hàng ngang ở hàng con trỏ chuột nhấp vào và ô của thứ 0
				
				cmbMahocvien.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
				cmbMamonhoc.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();

				dtpNgaythi.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
				txtCathi.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();

				txtPhongthi.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();

			}

		}
		//------------------------------------------------------------------------------

		//---------------------------------------LOAD COMBOBOX---------------------------------------
		//hàm load combobox lên vùng nhập liệu
		private void loadcombobox1(ComboBox cmb)
		{
			try
			{
				String sql = "SELECT * FROM LOP";

				// Tạo SqlDataAdapter để thực hiện truy vấn SQL
				SqlDataAdapter da = new SqlDataAdapter(sql, con);
				// Tạo DataTable để lưu dữ liệu
				DataTable dt = new DataTable();
				// Đổ dữ liệu vào DataTable từ SqlDataAdapter
				da.Fill(dt);

				// Gán DataTable làm nguồn dữ liệu cho ComboBox
				cmb.DataSource = dt;
				// Thiết lập cột dữ liệu sẽ được hiển thị trong ComboBox
				cmb.DisplayMember = dt.Columns["TenLop"].ToString();
				// Thiết lập cột dữ liệu chứa giá trị của ComboBox
				cmb.ValueMember = dt.Columns["MaLop"].ToString();
			}
			catch
			{
				MessageBox.Show("Không load được combobox của bảng lớp");
			}

		}

		//hàm load combobox lên vùng nhập liệu
		private void loadcombobox2(ComboBox cmb)
		{
			try
			{
				String sql = "SELECT * FROM HOCVIEN";

				SqlDataAdapter da = new SqlDataAdapter(sql, con);
				DataTable dt = new DataTable();
				da.Fill(dt);

				cmb.DataSource = dt;
				cmb.DisplayMember = dt.Columns["TenHV"].ToString();
				cmb.ValueMember = dt.Columns["MaHV"].ToString();
			}
			catch
			{
				MessageBox.Show("Không load được combobox của học viên");
			}

		}

		//hàm load combobox lên vùng nhập liệu
		private void loadcombobox3(ComboBox cmb)
		{
			try
			{
					String sql = "SELECT * FROM MONHOC";
			
				SqlDataAdapter da = new SqlDataAdapter(sql, con);
				DataTable dt = new DataTable();
				da.Fill(dt);

				cmb.DataSource = dt;
				cmb.DisplayMember = dt.Columns["TenMonHoc"].ToString();
				cmb.ValueMember = dt.Columns["MaMonHoc"].ToString();
			}
			catch
			{
				MessageBox.Show("Không load được combobox của bảng môn học");
			}

		}
		//------------------------------------------------------------------------------

		//---------------------------------------5 NÚT CƠ BẢN---------------------------------------
		private void btnThem_Click(object sender, EventArgs e)
		{
			dinhdangngaythangsql();
			string Malop = cmbMalop.SelectedValue.ToString().Trim();
			string Hocvien = cmbMahocvien.SelectedValue.ToString().Trim();
			string Mamonhoc = cmbMamonhoc.SelectedValue.ToString().Trim();
			string Ngaythi =dtpNgaythi.Text;	
			string Cathi = txtCathi.Text;
			string Phongthi = txtPhongthi.Text;

			
			//xây dựng chuỗi truy vấn SQL bằng cách ghép chuỗi(string concatenation),
			//lệnh này thì cho phép null
			string sqlthem = "insert into DanhSachDuThi(MaLop,MaHocVien,MaMonHoc,NgayThi,CaThi,PhongThi) " +
			"values('" + Malop + "','" + Hocvien + "','" + Mamonhoc + "','" + Ngaythi + "','" + Cathi + "','" + Phongthi + "')";

			errorProvider1.Clear();
			if (cmbMalop.Text == "")
			{
				errorProvider1.SetError(cmbMalop, "Mã lớp học không được trống");
				MessageBox.Show("Mã lớp học không được trống", "Thông báo",
				MessageBoxButtons.OK, MessageBoxIcon.Error);
				cmbMalop.Focus();
				return;
			}
			if (cmbMahocvien.Text == "")
			{
				errorProvider1.SetError(cmbMahocvien, "Học viên không được trống");
				MessageBox.Show("Học viên không được trống", "Thông báo",
				MessageBoxButtons.OK, MessageBoxIcon.Error);
				cmbMahocvien.Focus();
				return;
			}
			if (cmbMamonhoc.Text == "")
			{
				errorProvider1.SetError(cmbMamonhoc, "Môn học không được trống");
				MessageBox.Show("Môn học không được trống", "Thông báo",
				MessageBoxButtons.OK, MessageBoxIcon.Error);
				cmbMamonhoc.Focus();
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
			
			}
			catch
			{
				MessageBox.Show("Thêm thất bại");
			}
		}

		private void btnSua_Click(object sender, EventArgs e)
		{
			dinhdangngaythangsql();

		
			string Malop = cmbMalop.SelectedValue.ToString().Trim();
			string Hocvien = cmbMahocvien.SelectedValue.ToString().Trim();
			string Mamonhoc = cmbMamonhoc.SelectedValue.ToString().Trim();
			string Ngaythi = dtpNgaythi.Text;
			string Cathi = txtCathi.Text;
			string Phongthi = txtPhongthi.Text;

			string sqlsua = "UPDATE DanhSachDuThi " +
				"SET NgayThi='" + Ngaythi + "',CaThi='" + Cathi + "',PhongThi='" + Phongthi + "' " +
				"WHERE MaLop='" + Malop + "'" +
				"AND MaHocVien='" + Hocvien + "' " +
				"AND MaMonHoc='" + Mamonhoc + "' ";

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
				
			}
		}

		private void btnXoa_Click(object sender, EventArgs e)
		{
			string Malop = cmbMalop.SelectedValue.ToString().Trim();
			string Hocvien = cmbMahocvien.SelectedValue.ToString().Trim();
			string Mamonhoc = cmbMamonhoc.SelectedValue.ToString().Trim();

			string sqlxoa = "DELETE DanhSachDuThi WHERE MaLop='" + Malop + "'" +
				"AND MaHocVien='" + Hocvien + "'" +
				"AND MaMonHoc='" + Mamonhoc + "' ";


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

		//---------------------------------------IN ẤN---------------------------------------
		private void btnIn_Click(object sender, EventArgs e)
		{
			frmInDanhSachDuThi frm=new frmInDanhSachDuThi();
			frm.ShowDialog();
		}
		//------------------------------------------------------------------------------

		//---------------------------------------Xuất-Nhập Excel---------------------------------------
		//---------------------------------------Xuất-file-Excel---------------------------------------
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
		private string GetMaLop(string TenLop, SqlConnection conn)
		{
			// Xây dựng câu lệnh SQL để tìm MaMonHoc dựa trên tên môn học
			string query = "SELECT MaLop FROM LOP WHERE TenLop = N'" + TenLop + "'";

			// Tạo một SqlCommand với câu lệnh SQL và kết nối đã được truyền vào
			using (SqlCommand cmd = new SqlCommand(query, conn))
			{
				// Thực thi câu lệnh SQL và lấy giá trị đầu tiên từ kết quả (trường MaMonHoc)
				object result = cmd.ExecuteScalar();

				// Nếu kết quả không null, trả về MaMonHoc
				if (result != null)
				{
					return result.ToString();
				}
				else
				{
					// Nếu không tìm thấy MaMonHoc, ném ra một ngoại lệ với thông báo lỗi
					throw new Exception($"Tên môn học '{TenLop}' không tồn tại trong bảng Lớp.");
				}
			}
		}
		private string GetMaHocVien(string TenHV, SqlConnection conn)
		{
			// Xây dựng câu lệnh SQL để tìm MaMonHoc dựa trên tên môn học
			string query = "SELECT MaHV FROM HocVien WHERE TenHV = N'" + TenHV + "'";

			// Tạo một SqlCommand với câu lệnh SQL và kết nối đã được truyền vào
			using (SqlCommand cmd = new SqlCommand(query, conn))
			{
				// Thực thi câu lệnh SQL và lấy giá trị đầu tiên từ kết quả (trường MaMonHoc)
				object result = cmd.ExecuteScalar();

				// Nếu kết quả không null, trả về MaMonHoc
				if (result != null)
				{
					return result.ToString();
				}
				else
				{
					// Nếu không tìm thấy MaMonHoc, ném ra một ngoại lệ với thông báo lỗi
					throw new Exception($"Tên môn học '{TenHV}' không tồn tại trong bảng Học Viên.");
				}
			}
		}
		private string GetMaMonHoc(string tenMonHoc, SqlConnection conn)
		{
			// Xây dựng câu lệnh SQL để tìm MaMonHoc dựa trên tên môn học
			string query = "SELECT MaMonHoc FROM MonHoc WHERE TenMonHoc = N'" + tenMonHoc + "'";

			// Tạo một SqlCommand với câu lệnh SQL và kết nối đã được truyền vào
			using (SqlCommand cmd = new SqlCommand(query, conn))
			{
				// Thực thi câu lệnh SQL và lấy giá trị đầu tiên từ kết quả (trường MaMonHoc)
				object result = cmd.ExecuteScalar();

				// Nếu kết quả không null, trả về MaMonHoc
				if (result != null)
				{
					return result.ToString();
				}
				else
				{
					// Nếu không tìm thấy MaMonHoc, ném ra một ngoại lệ với thông báo lỗi
					throw new Exception($"Tên môn học '{tenMonHoc}' không tồn tại trong bảng MonHoc.");
				}
			}
		}

		//sử dụng biếng parameter
		/*private void ImportExcel(string path)
		{
			// Chuỗi kết nối đến cơ sở dữ liệu SQL Server
			string connectionString = "Data Source=LAPTOP-HK1PT9J5;Initial Catalog=quanlykhoahoc;Integrated Security=True";

			// Mở file Excel sử dụng thư viện EPPlus
			using (ExcelPackage excelPackage = new ExcelPackage(new FileInfo(path)))
			{
				// Lấy worksheet đầu tiên từ file Excel
				ExcelWorksheet excelWorksheet = excelPackage.Workbook.Worksheets[0];
				DataTable newDataTable = new DataTable();

				// Thêm tất cả các cột từ Excel vào DataTable
				for (int i = excelWorksheet.Dimension.Start.Column; i <= excelWorksheet.Dimension.End.Column; i++)
				{
					newDataTable.Columns.Add(excelWorksheet.Cells[1, i].Value.ToString());
				}

				// Thêm từng hàng dữ liệu từ Excel vào DataTable
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

				// Mở kết nối đến cơ sở dữ liệu SQL Server
				using (SqlConnection conn = new SqlConnection(connectionString))
				{
					conn.Open();
					foreach (DataRow row in newDataTable.Rows)
					{
						string TenLop = row[0].ToString().Trim();
						string TenHocVien = row[1].ToString().Trim();
						string TenMonHoc = row[2].ToString().Trim();
						DateTime NgayThi = DateTime.Parse(row[3].ToString());
						string CaThi = row[4].ToString().Trim();
						string PhongThi = row[5].ToString().Trim();

						try
						{
							string MaLop = GetMaLop(TenLop, conn);
							string MaHocVien = GetMaHocVien(TenHocVien, conn);
							string MaMonHoc = GetMaMonHoc(TenMonHoc, conn);

							// Kiểm tra xem bản ghi đã tồn tại hay chưa
							string checkExistQuery = "SELECT COUNT(*) FROM DanhSachDuThi WHERE MaLop = @MaLop AND MaHocVien = @MaHocVien AND MaMonHoc = @MaMonHoc";
							SqlCommand checkExistCommand = new SqlCommand(checkExistQuery, conn);
							checkExistCommand.Parameters.AddWithValue("@MaLop", MaLop);
							checkExistCommand.Parameters.AddWithValue("@MaHocVien", MaHocVien);
							checkExistCommand.Parameters.AddWithValue("@MaMonHoc", MaMonHoc);
							int recordCount = (int)checkExistCommand.ExecuteScalar();

							if (recordCount > 0)
							{
								// Nếu bản ghi đã tồn tại, thực hiện cập nhật
								string sqlUpdate = "UPDATE DanhSachDuThi SET NgayThi = @NgayThi, CaThi = @CaThi, PhongThi = @PhongThi " +
												   "WHERE MaLop = @MaLop AND MaHocVien = @MaHocVien AND MaMonHoc = @MaMonHoc";
								SqlCommand updateCommand = new SqlCommand(sqlUpdate, conn);
								updateCommand.Parameters.AddWithValue("@NgayThi", NgayThi);
								updateCommand.Parameters.AddWithValue("@CaThi", CaThi);
								updateCommand.Parameters.AddWithValue("@PhongThi", PhongThi);
								updateCommand.Parameters.AddWithValue("@MaLop", MaLop);
								updateCommand.Parameters.AddWithValue("@MaHocVien", MaHocVien);
								updateCommand.Parameters.AddWithValue("@MaMonHoc", MaMonHoc);
								updateCommand.ExecuteNonQuery();
							}
							else
							{
								// Nếu bản ghi chưa tồn tại, thực hiện chèn mới
								string sqlInsert = "INSERT INTO DanhSachDuThi(MaLop, MaHocVien, MaMonHoc, NgayThi, CaThi, PhongThi) " +
												   "VALUES(@MaLop, @MaHocVien, @MaMonHoc, @NgayThi, @CaThi, @PhongThi)";
								SqlCommand insertCommand = new SqlCommand(sqlInsert, conn);
								insertCommand.Parameters.AddWithValue("@MaLop", MaLop);
								insertCommand.Parameters.AddWithValue("@MaHocVien", MaHocVien);
								insertCommand.Parameters.AddWithValue("@MaMonHoc", MaMonHoc);
								insertCommand.Parameters.AddWithValue("@NgayThi", NgayThi);
								insertCommand.Parameters.AddWithValue("@CaThi", CaThi);
								insertCommand.Parameters.AddWithValue("@PhongThi", PhongThi);
								insertCommand.ExecuteNonQuery();
							}
						}
						catch (Exception ex)
						{
							// Thông báo lỗi nếu có vấn đề xảy ra trong quá trình xử lý dữ liệu
							MessageBox.Show($"Xử lý thất bại: {ex.Message}");
						}
					}

					// Cập nhật lại dữ liệu trên DataGridView
					loaddulieulenluoi();
				}
			}
		}*/

		//xây dựng chuỗi truy vấn SQL bằng cách ghép chuỗi (string concatenation)
		private void ImportExcel(string path)
		{
			// Chuỗi kết nối đến cơ sở dữ liệu SQL Server
			string connectionString = "Data Source=LAPTOP-HK1PT9J5;Initial Catalog=quanlykhoahoc;Integrated Security=True";

			// Mở file Excel sử dụng thư viện EPPlus
			using (ExcelPackage excelPackage = new ExcelPackage(new FileInfo(path)))
			{
				// Lấy worksheet đầu tiên từ file Excel
				ExcelWorksheet excelWorksheet = excelPackage.Workbook.Worksheets[0];
				DataTable newDataTable = new DataTable();

				// Thêm tất cả các cột từ Excel vào DataTable
				for (int i = excelWorksheet.Dimension.Start.Column; i <= excelWorksheet.Dimension.End.Column; i++)
				{
					newDataTable.Columns.Add(excelWorksheet.Cells[1, i].Value.ToString());
				}

				// Thêm từng hàng dữ liệu từ Excel vào DataTable
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

				// Mở kết nối đến cơ sở dữ liệu SQL Server
				using (SqlConnection conn = new SqlConnection(connectionString))
				{
					conn.Open();
					foreach (DataRow row in newDataTable.Rows)
					{
						string TenLop = row[0].ToString().Trim();
						string TenHocVien = row[1].ToString().Trim();
						string TenMonHoc = row[2].ToString().Trim();
						DateTime NgayThi = DateTime.Parse(row[3].ToString());
						string CaThi = row[4].ToString().Trim();
						string PhongThi = row[5].ToString().Trim();

						try
						{
							string MaLop = GetMaLop(TenLop, conn);
							string MaHocVien = GetMaHocVien(TenHocVien, conn);
							string MaMonHoc = GetMaMonHoc(TenMonHoc, conn);

							// Kiểm tra xem bản ghi đã tồn tại hay chưa bằng cách ghép chuỗi
							string checkExistQuery = "SELECT COUNT(*) FROM DanhSachDuThi WHERE MaLop = '" + MaLop + "' AND MaHocVien = '" + MaHocVien + "' AND MaMonHoc = '" + MaMonHoc + "'";
							SqlCommand checkExistCommand = new SqlCommand(checkExistQuery, conn);
							int recordCount = (int)checkExistCommand.ExecuteScalar();

							if (recordCount > 0)
							{
								// Nếu bản ghi đã tồn tại, thực hiện cập nhật bằng cách ghép chuỗi
								string sqlUpdate = "UPDATE DanhSachDuThi SET " +
												   "NgayThi = '" + NgayThi.ToString("yyyy-MM-dd") + "', " +
												   "CaThi = '" + CaThi + "', " +
												   "PhongThi = '" + PhongThi + "' " +
												   "WHERE MaLop = '" + MaLop + "' AND MaHocVien = '" + MaHocVien + "' AND MaMonHoc = '" + MaMonHoc + "'";
								SqlCommand updateCommand = new SqlCommand(sqlUpdate, conn);
								updateCommand.ExecuteNonQuery();
							}
							else
							{
								// Nếu bản ghi chưa tồn tại, thực hiện chèn mới bằng cách ghép chuỗi
								string sqlInsert = "INSERT INTO DanhSachDuThi(MaLop, MaHocVien, MaMonHoc, NgayThi, CaThi, PhongThi) VALUES('" +
												   MaLop + "', '" +
												   MaHocVien + "', '" +
												   MaMonHoc + "', '" +
												   NgayThi.ToString("yyyy-MM-dd") + "', '" +
												   CaThi + "', '" +
												   PhongThi + "')";
								SqlCommand insertCommand = new SqlCommand(sqlInsert, conn);
								insertCommand.ExecuteNonQuery();
							}
						}
						catch (Exception ex)
						{
							// Thông báo lỗi nếu có vấn đề xảy ra trong quá trình xử lý dữ liệu
							MessageBox.Show($"Xử lý thất bại: {ex.Message}");
						}
					}

					// Cập nhật lại dữ liệu trên DataGridView
					loaddulieulenluoi();
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

		//---------------------------------------TÌM KIẾM NÂNG CAO---------------------------------------
		private void btnTimkiem_Click(object sender, EventArgs e)
		{
			if (chkTimlop.Checked == true && chkTimkiem.Checked == true)
			{
				try
				{
					string tenlop = cmbTimlop.Text;//lấy giá trị của combobox
					
					string tenhocvien=txtTimten.Text;

					String sql = "SELECT l.TenLop,hv.TenHV,mh.TenMonHoc,ds.NgayThi,ds.CaThi,ds.PhongThi FROM DanhSachDuThi ds, Lop l,MONHOC mh,HocVien hv " +
						"where ds.MaLop = l.MaLop and l.MaMonHoc = mh.MaMonHoc and ds.MaHocVien = hv.MaHV " +
						"and l.TenLop = N'"+ tenlop + "' " +
						
						"and hv.TenHV like N'%"+tenhocvien +"%' "; //câu truy vấn từ bảng lớp được gán vào 1 chuỗi 

					SqlDataAdapter da = new SqlDataAdapter(sql, con);//SqlDataAdapter: lấy dữ liệu từ csdl
					DataTable dt = new DataTable();//DataTable:lưu trữ hoặc quản lý dữ liệu // khai báo báo datatable
					da.Fill(dt);//lấy(đổ) dữ liệu từ csdl qua dataset hoặc datatable
					dataGridView1.DataSource = dt;//từ dữ liệu của datatable gán qua bảng gridview
				}
				catch
				{
					MessageBox.Show("Không load được ");
				}
			}
			else if (chkTimmonhoc.Checked == true && chkTimkiem.Checked == true)
			{
				try
				{
					string tenmonhoc = cmbTimmonhoc.Text;//lấy giá trị của combobox
					string tenhocvien = txtTimten.Text;

					String sql = "SELECT l.TenLop,hv.TenHV,mh.TenMonHoc,ds.NgayThi,ds.CaThi,ds.PhongThi FROM DanhSachDuThi ds, Lop l,MONHOC mh,HocVien hv " +
						"where ds.MaLop = l.MaLop and l.MaMonHoc = mh.MaMonHoc and ds.MaHocVien = hv.MaHV " +
						
						"and mh.TenMonHoc = N'" + tenmonhoc + "' " +
						"and hv.TenHV like N'%" + tenhocvien + "%' "; //câu truy vấn từ bảng lớp được gán vào 1 chuỗi 

					SqlDataAdapter da = new SqlDataAdapter(sql, con);//SqlDataAdapter: lấy dữ liệu từ csdl
					DataTable dt = new DataTable();//DataTable:lưu trữ hoặc quản lý dữ liệu // khai báo báo datatable
					da.Fill(dt);//lấy(đổ) dữ liệu từ csdl qua dataset hoặc datatable
					dataGridView1.DataSource = dt;//từ dữ liệu của datatable gán qua bảng gridview
				}
				catch
				{
					MessageBox.Show("Không load được ");
				}
			}
		}
		private void chkTimkiem_CheckedChanged(object sender, EventArgs e)
		{
			//đoạn nàu dùng để ẩn hiện các nút trên phần tìm kiếm
			if (chkTimkiem.Checked == true)
			{				
				lbTimkiem.Visible = true;

				chkTimlop.Visible = true;
				cmbTimlop.Visible = true;

				chkTimmonhoc.Visible = true;
				cmbTimmonhoc.Visible = true;

				chkTimten.Visible = true;				
			}
			else
			{
				chkTimlop.Checked = false;
				chkTimmonhoc.Checked = false;
				chkTimten.Checked = false;

				lbTimkiem.Visible = false;

				chkTimlop.Visible = false;
				cmbTimlop.Visible = false;

				chkTimmonhoc.Visible = false;
				cmbTimmonhoc.Visible = false;


				chkTimten.Visible = false;
				txtTimten.Visible = false;

				loaddulieulenluoi();
			}
		}

		private void chkTimlop_CheckedChanged(object sender, EventArgs e)
		{
			//đoạn nàu dùng để ẩn hiện các nút 
			if (chkTimlop.Checked == true)
			{
				chkTimmonhoc.Visible = false;
				cmbTimmonhoc.Visible = false;

				cmbTimlop.Enabled = true;
				loadcombobox1(cmbTimlop);


				if (chkTimten.Checked == true)
				{
					btnTimkiem.Visible = true;
				}
				else
					btnTimkiem.Visible = false;
			}
			else
			{
				chkTimmonhoc.Visible = true;
				cmbTimmonhoc.Visible = true;

				cmbTimlop.Enabled = false;

				btnTimkiem.Visible = false;
			}
		}

		private void chkTimmonhoc_CheckedChanged(object sender, EventArgs e)
		{
			if (chkTimmonhoc.Checked == true)
			{
				chkTimlop.Visible = false;
				cmbTimlop.Visible = false;

				cmbTimmonhoc.Enabled = true;
				loadcombobox3(cmbTimmonhoc);

				//đoạn này dùng để ẩn và hiện nút tìm kiếm trên Form
				if (chkTimten.Checked == true)
				{
					btnTimkiem.Visible = true;
				}
				else
					btnTimkiem.Visible = false;
			}
			else
			{
				chkTimlop.Visible = true;
				cmbTimlop.Visible = true;

				cmbTimmonhoc.Enabled = false;

				btnTimkiem.Visible = false;
			}
		}

		private void chkTimten_CheckedChanged(object sender, EventArgs e)
		{
			//nếu checkbox được check
			if (chkTimten.Checked == true)
			{
				txtTimten.Visible = true;
				txtTimten.Text = "";
				txtTimten.Focus();

				//đoạn này dùng để ẩn và hiện nút tìm kiếm trên Form
				if (chkTimlop.Checked == true)
				{
					btnTimkiem.Visible = true;
				}
				else if (chkTimmonhoc.Checked == true)
				{
					btnTimkiem.Visible = true;
				}
			}
			else //nếu checkbox không được check
			{
				txtTimten.Visible = false;
				btnTimkiem.Visible = false;
			}
		}

		private void txtTimten_KeyDown(object sender, KeyEventArgs e)
		{
			//khi nhấn enter
			if (e.KeyCode == Keys.Enter)
			{
				try
				{
					string tenhocvien = txtTimten.Text;

					String sql = "SELECT * FROM DanhSachDuThi ds, HocVien hv " +
						" where ds.MaHocVien = hv.MaHV "+
						" and hv.TenHV like N'%" + tenhocvien + "%' "; 

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

		private void cmbTimlop_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				string tenlop = cmbTimlop.Text;//lấy giá trị của combobox

				String sql = "SELECT l.TenLop,hv.TenHV,mh.TenMonHoc,ds.NgayThi,ds.CaThi,ds.PhongThi " +
					" FROM DanhSachDuThi ds,Lop l,HocVien hv,MonHoc mh" +
					" where l.MaLop = ds.MaLop" +
					" and l.TenLop=N'"+ tenlop + "'"; 

				SqlDataAdapter da = new SqlDataAdapter(sql, con);//SqlDataAdapter: lấy dữ liệu từ csdl
				DataTable dt = new DataTable();//DataTable:lưu trữ hoặc quản lý dữ liệu // khai báo báo datatable
				da.Fill(dt);//lấy(đổ) dữ liệu từ csdl qua dataset hoặc datatable
				dataGridView1.DataSource = dt;//từ dữ liệu của datatable gán qua bảng gridview
			}
			catch
			{
				MessageBox.Show("Không load được combobox của bảng lớp");
			}

		}

		private void cmbTimmonhoc_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				string tenmonhoc = cmbTimmonhoc.Text;//lấy giá trị của combobox
				
				String sql = "SELECT l.TenLop,hv.TenHV,mh.TenMonHoc,ds.NgayThi,ds.CaThi,ds.PhongThi " +
					" FROM DanhSachDuThi ds,Lop l,HocVien hv,MonHoc mh " +
					" where ds.MaMonHoc = mh.MaMonHoc " +
					" and mh.TenMonHoc = N'" + tenmonhoc + "'";

				SqlDataAdapter da = new SqlDataAdapter(sql, con);//SqlDataAdapter: lấy dữ liệu từ csdl
				DataTable dt = new DataTable();//DataTable:lưu trữ hoặc quản lý dữ liệu // khai báo báo datatable
				da.Fill(dt);//lấy(đổ) dữ liệu từ csdl qua dataset hoặc datatable
				dataGridView1.DataSource = dt;//từ dữ liệu của datatable gán qua bảng gridview
			}
			catch
			{
				MessageBox.Show("Không load được combobox của bảng môn học");
			}
		}
		//------------------------------------------------------------------------------

	}
}
