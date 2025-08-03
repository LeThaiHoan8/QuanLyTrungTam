using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//khai báo 2 thư viện này
using System.Data.Sql;
using System.Data.SqlClient;
//khai báo thư viện dùng để export execel và inport excel
using System.IO;
using OfficeOpenXml;
using Excel = Microsoft.Office.Interop.Excel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using System.Globalization;

namespace APP_demo
{
	public partial class frmLop : Form
	{
		//chuỗi kết nối
		string chuoiketnoi = "Data Source=LAPTOP-HK1PT9J5;Initial Catalog=quanlykhoahoc;Integrated Security=True";

		SqlConnection con = new SqlConnection();
		public frmLop()
		{
			InitializeComponent();
		}

		//---------------------------------------HÀM CƠ BẢN---------------------------------------
		//hàm load tất cả dữ liệu của form ra khi bấm vào form này
		private void frmLop_Load(object sender, EventArgs e)
		{
			txtMalop.Text = TangMa();
			txtMalop.Enabled = false;
			ketnoicsdl();
			loaddulieulenluoi();

			//cách 1 tách 2 combobox ra sẽ tránh bị trùng dữ liệu
			loadcombobox1(cmbMagiaovien);
			loadcombobox2(cmbMamonhoc);

			dinhdangluoi();
			chkTimkiem_CheckedChanged(sender, e);//khi chưa check vào thì không hiện tìm kiếm ra
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

			//String sql = "SELECT *FROM LOP"; //lệnh này lấy ra bảng lớp mà không có tên gv với tên môn 
			String sql = "SELECT l.MaLop,l.TenLop,l.SiSo,NgayBatDau,NgayKetThuc,SoBuoi," +
				"gv.TenGV,mh.TenMonHoc FROM LOP l, GIAOVIEN gv,MONHOC mh" +
				" where l.MaGiaoVien = gv.MaGV and l.MaMonHoc = mh.MaMonHoc";//câu truy vấn từ bảng lớp được gán vào 1 chuỗi 

			SqlDataAdapter da = new SqlDataAdapter(sql, con);//SqlDataAdapter: lấy dữ liệu từ csdl
			DataTable dt = new DataTable();//DataTable:lưu trữ hoặc quản lý dữ liệu // khai báo báo datatable
			da.Fill(dt);//lấy(đổ) dữ liệu từ csdl qua dataset hoặc datatable
			dataGridView1.DataSource = dt;//từ dữ liệu của datatable gán qua bảng gridview

		}
		//------------------------------------------------------------------------------

		//---------------------------------------HÀM KHAI BÁO---------------------------------------
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

		/*hàm tăng mã tự động của Mã lớp
		hàm này có nhược điểm khi đã thêm dữ liệu khác format của hàm này
		sẽ gây ra lỗi hoặc tạo mã không ưng ý*/
		/*		private string TangMa()
				{
					// Chuỗi SQL để lấy mã lớp lớn nhất từ bảng LOP
					string sql = "SELECT TOP 1 MaLop FROM LOP ORDER BY MaLop DESC";

					// Tạo kết nối với cơ sở dữ liệu
					using (SqlConnection con = new SqlConnection(chuoiketnoi))
					{
						SqlCommand cmd = new SqlCommand(sql, con);//SqlCommand được khởi tạo với câu lệnh SQL và đối tượng kết nối con.
						con.Open();// con.Open() mở kết nối đến cơ sở dữ liệu.
						object result = cmd.ExecuteScalar();//cmd.ExecuteScalar() thực thi lệnh SQL
															//và trả về giá trị của cột đầu tiên trong hàng đầu tiên của kết quả truy vấn. Kết quả này được lưu vào biến result.

						if (result != null)//Nếu result không phải là null, nghĩa là có ít nhất một mã lớp trong bảng.
						{
							string maxMaLop = result.ToString();//string maxMaLop = result.ToString(); chuyển đổi kết quả truy vấn thành chuỗi.
							int maxNumber = int.Parse(maxMaLop.Substring(1)) + 1;//int maxNumber = int.Parse(maxMaLop.Substring(1)) + 1; lấy phần số của mã lớp (bằng cách bỏ ký tự đầu tiên),
																				 //chuyển đổi phần số thành số nguyên, và tăng giá trị lên 1.
							return "L" + maxNumber.ToString("D3");//return "L" + maxNumber.ToString("D3"); trả về mã lớp mới với định dạng "L" + số,
																  //trong đó số được định dạng thành chuỗi 3 chữ số (ví dụ: "001", "002", ...).
						}
						else
						{
							return "L001";
						}
					}

				}*/

		//hàm tăng mã tự động của Mã lớp
		private string TangMa()
		{
			// Chuỗi SQL để lấy mã MaLop lớn nhất từ bảng LOP theo định dạng "Lxxx"
			string sql = "SELECT TOP 1 MaLop FROM LOP " +
						 "WHERE MaLop LIKE 'L%' " +
						 "ORDER BY MaLop DESC";

			// Tạo kết nối với cơ sở dữ liệu
			using (SqlConnection con = new SqlConnection(chuoiketnoi))
			{
				SqlCommand cmd = new SqlCommand(sql, con);
				con.Open();
				object result = cmd.ExecuteScalar();

				if (result != null)
				{
					string maxMaLop = result.ToString();

					// Kiểm tra định dạng của MaLop
					if (maxMaLop.StartsWith("L") && int.TryParse(maxMaLop.Substring(1), out int maxNumber))
					{
						// Tăng giá trị số của MaLop lên 1
						maxNumber += 1;
						return "L" + maxNumber.ToString("D3");
					}
					else
					{
						// Nếu định dạng không phù hợp, trả về "L001"
						return "L001";
					}
				}
				else
				{
					// Nếu không có MaLop nào trong cơ sở dữ liệu, trả về "L001"
					return "L001";
				}
			}
		}

		//hàm định dạng lưới 
		private void dinhdangluoi()
		{			
			dataGridView1.Columns[0].HeaderText = "Mã lớp";
			dataGridView1.Columns[0].Width = 100;
			dataGridView1.Columns[1].HeaderText = "Tên lớp";
			dataGridView1.Columns[1].Width = 100;
			dataGridView1.Columns[2].HeaderText = "Sĩ số ";
			dataGridView1.Columns[2].Width = 60;
			dataGridView1.Columns[3].HeaderText = "Ngày bắt đầu";
			dataGridView1.Columns[3].Width = 100;
			dataGridView1.Columns[4].HeaderText = "Ngày kết thúc";
			dataGridView1.Columns[4].Width = 100;
			dataGridView1.Columns[5].HeaderText = "Số buổi";
			dataGridView1.Columns[5].Width = 60;
			dataGridView1.Columns[6].HeaderText = "Tên giáo viên ";
			dataGridView1.Columns[6].Width = 100;
			dataGridView1.Columns[7].HeaderText = "Tên môn học ";
			dataGridView1.Columns[7].Width = 100;
		}

		//Dùng 1 trong 3 sự kiện sau để hiển thị nội dung lên textbox khi click chuột vào
		//hàm hiển thị nội dung từ dataGridView lên textbox
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
				txtMalop.Text = TangMa();
				txtTenlop.Text = "";
				txtSiso.Text = "";
				txtSobuoi.Text = "";
				return;
			}

			//Nếu e.RowIndex nằm trong phạm vi hợp lệ, tiếp tục các bước kiểm tra và lấy dữ liệu.
			if (e.RowIndex >= 0) //lệnh này tránh người dùng click sai làm chạy vào code
			{

				//giải thích c1: đưa dữ liệu từ hàng ngang thứ e.RowIndex và ô cell[0] để đưa giá trị vào trong textbox
				txtMalop.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
				//giải thích c2: lấy dữ liệu từ lưới từ hàng ngang ở hàng con trỏ chuột nhấp vào và ô của thứ 0
				//chuyển giá trị của vị trí này thành chuỗi(string) và cuối cùng gán vào mã lớp
				txtTenlop.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
				txtSiso.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();

				dtpNgaybatdau.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
				dtpNgayketthuc.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();

				txtSobuoi.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
				cmbMagiaovien.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
				cmbMamonhoc.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
			}
		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			/*txtMalop.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
			txtTenlop.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
			txtSiso.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
			dtpNgaybatdau.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
			dtpNgayketthuc.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();

			txtSobuoi.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
			txtMagiaovien.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
			txtMamonhoc.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();*/
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			/*txtMalop.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
			txtTenlop.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
			txtSiso.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
			dtpNgaybatdau.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
			dtpNgayketthuc.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();

			txtSobuoi.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
			txtMagiaovien.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
			txtMamonhoc.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();*/
		}
		//------------------------------------------------------------------------------

		//---------------------------------------LOAD COMBOBOX---------------------------------------
		//hàm load combobox lên vùng nhập liệu
		private void loadcombobox1(ComboBox cmb)
		{
			try
			{
				//khi để chung 2 combobox trong 1 lệnh sql mà 2 lớp này có quan hệ với nhau thì sẽ bị trùng dữ liệu
				//String sql = "SELECT  *FROM LOP,GIAOVIEN,MONHOC";//lệnh sql này không ràng buộc dữ liệu 
				String sql = "SELECT * FROM GIAOVIEN";
				//String sql = "SELECT DISTINCT * FROM LOP l, GIAOVIEN gv,MONHOC mh where l.MaGiaoVien = gv.MaGV and l.MaMonHoc = mh.MaMonHoc";

				// Tạo SqlDataAdapter để thực hiện truy vấn SQL
				SqlDataAdapter da = new SqlDataAdapter(sql, con);
				// Tạo DataTable để lưu dữ liệu
				DataTable dt = new DataTable();
				// Đổ dữ liệu vào DataTable từ SqlDataAdapter
				da.Fill(dt);

				// Gán DataTable làm nguồn dữ liệu cho ComboBox
				cmb.DataSource = dt;
				// Thiết lập cột dữ liệu sẽ được hiển thị trong ComboBox
				cmb.DisplayMember = dt.Columns["TenGV"].ToString();
				// Thiết lập cột dữ liệu chứa giá trị của ComboBox
				cmb.ValueMember = dt.Columns["MaGV"].ToString();
			}
			catch
			{
				MessageBox.Show("Không load được combobox của bảng giáo viên");
			}

		}

		//hàm load combobox lên vùng nhập liệu
		private void loadcombobox2(ComboBox cmb)
		{
			try
			{
				//khi để chung 2 combobox trong 1 lệnh sql mà 2 lớp này có quan hệ với nhau thì sẽ bị trùng dữ liệu
				//String sql = "SELECT  *FROM LOP,GIAOVIEN,MONHOC";//lệnh sql này không ràng buộc dữ liệu 
				String sql = "SELECT * FROM MONHOC";
				//String sql = "SELECT DISTINCT * FROM LOP l, GIAOVIEN gv,MONHOC mh where l.MaGiaoVien = gv.MaGV and l.MaMonHoc = mh.MaMonHoc";

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

		//---------------------------------------5 NÚT CƠ BẢN(Tạo chuỗi SQL)---------------------------------------
		//Hàm thêm dữ liệu
		private void btnThem_Click(object sender, EventArgs e)
		{
			dinhdangngaythangsql();

			//khai báo biến để dễ nhìn khi viết câu sql

			//string Malop = txtMalop.Text.Trim(); //khai báo cũ
			string Malop = TangMa();
			string Tenlop = txtTenlop.Text.Trim();

			//2 biến này định dạng tháng ngày năm 
			//nếu định dạng khác MM/dd/yyyy hoặc dd/MM/yyyy thì sử dụng
			/*string Ngaybatdau = dtpNgaybatdau.Value.ToShortDateString().Trim();
			string Ngayketthuc = dtpNgayketthuc.Value.ToShortDateString().Trim();*/

			string Ngaybatdau = dtpNgaybatdau.Text;
			string Ngayketthuc = dtpNgayketthuc.Text;
			string Siso = txtSiso.Text.Trim();
			string Sobuoi = txtSobuoi.Text;

			//định nghĩa 2 biến này sai vì khi thêm sẽ lấy tên giáo viên và tên môn học
			//chứ ko lấy mã giáo viên và mã môn học
			/*	string Magiaovien = cmbMagiaovien.Text.Trim();
				string Mamonhoc = cmbMamonhoc.Text.Trim();*/

			string Magiaovien = cmbMagiaovien.SelectedValue.ToString().Trim();//lấy giá trị của combobox
			string Mamonhoc = cmbMamonhoc.SelectedValue.ToString().Trim();

			//lệnh truy vấn này bắt nhập hết các cột 
			//string sqlthem = "insert into LOP values('" + Malop + "',N'" + Tenlop + "'," + Siso + ",'" + Ngaybatdau + "','" + Ngayketthuc + "'," + Sobuoi + ",'" + Magiaovien + "','" + Mamonhoc + "')";

			//xây dựng chuỗi truy vấn SQL bằng cách ghép chuỗi(string concatenation),
			//lệnh này thì cho phép null
			string sqlthem = "insert into LOP(MaLop,TenLop,SiSo,NgayBatDau,NgayKetThuc,SoBuoi,MaGiaoVien,MaMonHoc) values('" + Malop + "',N'" + Tenlop + "','" + Siso + "','" + Ngaybatdau + "','" + Ngayketthuc + "','" + Sobuoi + "','" + Magiaovien + "','" + Mamonhoc + "')";

			errorProvider1.Clear();
			if (txtMalop.Text == "")
			{
				errorProvider1.SetError(txtMalop, "Mã lớp học không được trống");
				MessageBox.Show("Mã lớp học không được trống", "Thông báo",
				MessageBoxButtons.OK, MessageBoxIcon.Error);
				txtMalop.Focus();
				return;
			}
			if (txtTenlop.Text == "")
			{
				errorProvider1.SetError(txtTenlop, "Tên lớp học không được trống");
				MessageBox.Show("Tên lớp học không được trống", "Thông báo",
				MessageBoxButtons.OK, MessageBoxIcon.Error);
				txtMalop.Focus();
				return;
			}

			int siso;
			if (txtSiso.Text != "" && int.TryParse(txtSiso.Text, out siso) == false)
			{
				errorProvider1.SetError(txtSiso, "sai định dạng");
			}
			int sobuoi;
			if (txtSobuoi.Text != "" && int.TryParse(txtSobuoi.Text, out sobuoi) == false)
			{
				errorProvider1.SetError(txtSobuoi, "sai định dạng");
			}

			if (cmbMagiaovien.Text == "")
			{
				errorProvider1.SetError(cmbMagiaovien, "Giáo viên không được trống");
				MessageBox.Show("Giáo viên không được trống", "Thông báo",
				MessageBoxButtons.OK, MessageBoxIcon.Error);
				cmbMagiaovien.Focus();
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

			if (dtpNgaybatdau.Value > dtpNgayketthuc.Value)
			{

				MessageBox.Show("Ngày kết thúc không được sớm hơn ngày bắt đầu", "Thông báo",
				MessageBoxButtons.OK, MessageBoxIcon.Error);

				return;
			}

			/*if (dtpNgaybatdau.Value > DateTime.Now)
			{

				MessageBox.Show("Ngày bắt đầu không hợp lệ", "Thông báo",
				MessageBoxButtons.OK, MessageBoxIcon.Error);

				return;
			}*/

			try
			{
				//Lệnh này tạo một đối tượng SqlCommand mới với câu lệnh SQL(sqlthem) và kết nối cơ sở dữ liệu(con).
				SqlCommand command = new SqlCommand(sqlthem, con);
				//Thực thi câu lệnh SQL và trả về số hàng bị ảnh hưởng
				command.ExecuteNonQuery();
				MessageBox.Show("Thêm thành công");
				loaddulieulenluoi();

				txtMalop.Text = TangMa();// Tạo mã lớp mới
			}
			catch
			{
				MessageBox.Show("Thêm thất bại");
			}

		}

		//Hàm sửa dữ liệu
		private void btnSua_Click(object sender, EventArgs e)
		{
			dinhdangngaythangsql();
			string Malop = txtMalop.Text.Trim();
			string Tenlop = txtTenlop.Text.Trim();
			/*string Ngaybatdau = dtpNgaybatdau.Value.ToShortDateString().Trim();
			string Ngayketthuc = dtpNgayketthuc.Value.ToShortDateString().Trim();*/
			string Ngaybatdau = dtpNgaybatdau.Text;
			string Ngayketthuc = dtpNgayketthuc.Text;
			string Siso = txtSiso.Text.Trim();
			string Sobuoi = txtSobuoi.Text;
			string Magiaovien = cmbMagiaovien.SelectedValue.ToString().Trim();
			string Mamonhoc = cmbMamonhoc.SelectedValue.ToString().Trim();


			string sqlsua = "UPDATE LOP SET TenLop=N'" + Tenlop + "',SiSo=" + Siso + ",NgayBatDau='" + Ngaybatdau + "',NgayKetThuc='" + Ngayketthuc + "',SoBuoi=" + Sobuoi + ",MaGiaoVien='" + Magiaovien + "',MaMonHoc='" + Mamonhoc + "' WHERE MaLop='" + Malop + "'";

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
				txtMalop.Focus();
			}
		}

		//Hàm xóa dữ liệu
		private void btnXoa_Click(object sender, EventArgs e)
		{

			string Malop = txtMalop.Text.Trim();
			string Tenlop = txtTenlop.Text.Trim();
			/*string Ngaybatdau = dtpNgaybatdau.Value.ToShortDateString().Trim();
			string Ngayketthuc = dtpNgayketthuc.Value.ToShortDateString().Trim();*/
			string Ngaybatdau = dtpNgaybatdau.Text;
			string Ngayketthuc = dtpNgayketthuc.Text;
			string Siso = txtSiso.Text.Trim();
			string Sobuoi = txtSobuoi.Text;
			string Magiaovien = cmbMagiaovien.SelectedValue.ToString().Trim();
			string Mamonhoc = cmbMamonhoc.SelectedValue.ToString().Trim();


			string sqlxoa = "DELETE LOP WHERE MaLop='" + Malop + "'";
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

		//hàm làm mới
		private void btnLammoi_Click(object sender, EventArgs e)
		{
			loaddulieulenluoi();
		}

		//hàm thoát
		private void btnThoat_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		//------------------------------------------------------------------------------

		//---------------------------------------TÌM KIẾM NÂNG CAO---------------------------------------
		//điều khiển phần tìm kiểm của Form
		private void chkTimkiem_CheckedChanged(object sender, EventArgs e)
		{
			//đoạn nàu dùng để ẩn hiện các nút trên phần tìm kiếm
			if (chkTimkiem.Checked == true)
			{
				//btnTimkiem.Visible = false;//ẩn nút tìm kiếm

				lbTimkiem.Visible = true;

				chkTimgiaovien.Visible = true;
				cmbTimgiaovien.Visible = true;

				chkTimmonhoc.Visible = true;
				cmbTimmonhoc.Visible = true;

				chkTimten.Visible = true;
				//txtTimten.Visible = true;

			}
			else
			{
				//btnTimkiem.Visible = false;//ẩn nút tìm kiếm

				chkTimgiaovien.Checked = false;
				chkTimmonhoc.Checked = false;
				chkTimten.Checked = false;

				lbTimkiem.Visible = false;

				chkTimgiaovien.Visible = false;
				cmbTimgiaovien.Visible = false;

				chkTimmonhoc.Visible = false;
				cmbTimmonhoc.Visible = false;


				chkTimten.Visible = false;
				txtTimten.Visible = false;

				loaddulieulenluoi();
			}
		}


		//hàm điều khiển sự kiện check hay ko của checkbox giáo viên
		private void chkTimgiaovien_CheckedChanged(object sender, EventArgs e)
		{
			//đoạn nàu dùng để ẩn hiện các nút 
			if (chkTimgiaovien.Checked == true)//nếu checkbox giáo viên được check
			{
				chkTimmonhoc.Visible = false;//ẩn checkbox của môn học
				cmbTimmonhoc.Visible = false;//ẩn combobox của môn học

				cmbTimgiaovien.Enabled = true;//mở combobox của giáo viên
				loadcombobox1(cmbTimgiaovien);//load combobox của giáo viên 


				if (chkTimten.Checked == true)//nếu checkbox của tìm theo lớp được check
				{
					btnTimkiem.Visible = true;//hiện nút tìm kiếm
				}
				else
					btnTimkiem.Visible = false;//ẩn nút tìm kiếm
			}
			else
			{
				chkTimmonhoc.Visible = true;//hiện checkbox của môn học
				cmbTimmonhoc.Visible = true;//hiện combobox của môn học

				cmbTimgiaovien.Enabled = false;//đóng combobox của giáo viên

				btnTimkiem.Visible = false;//ẩn nút tìm kiếm
			}
		}

		//hàm load combobox của giáo viên
		private void cmbTimgiaovien_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				string tengiaovien = cmbTimgiaovien.Text;//lấy giá trị của combobox


				String sql = "SELECT l.MaLop,l.TenLop,l.SiSo,NgayBatDau,NgayKetThuc,SoBuoi,gv.TenGV,mh.TenMonHoc FROM LOP l, GIAOVIEN gv,MONHOC mh " +
					"where l.MaGiaoVien = gv.MaGV and l.MaMonHoc = mh.MaMonHoc " +
					"and gv.TenGV = N'" + tengiaovien + "'"; //câu truy vấn từ bảng lớp được gán vào 1 chuỗi 

				SqlDataAdapter da = new SqlDataAdapter(sql, con);//SqlDataAdapter: lấy dữ liệu từ csdl
				DataTable dt = new DataTable();//DataTable:lưu trữ hoặc quản lý dữ liệu // khai báo báo datatable
				da.Fill(dt);//lấy(đổ) dữ liệu từ csdl qua dataset hoặc datatable
				dataGridView1.DataSource = dt;//từ dữ liệu của datatable gán qua bảng gridview
			}
			catch
			{
				MessageBox.Show("Không load được combobox của bảng giáo viên");
			}

		}


		////hàm điều khiển sự kiện check hay ko của checkbox môn học
		private void chkTimmonhoc_CheckedChanged(object sender, EventArgs e)
		{

			if (chkTimmonhoc.Checked == true)
			{
				chkTimgiaovien.Visible = false;//ẩn checkbox của giáo viên
				cmbTimgiaovien.Visible = false;//ẩn combobox của giáo viên

				cmbTimmonhoc.Enabled = true;//mở combobox của môn học
				loadcombobox2(cmbTimmonhoc);//load combobox của môn học

				//đoạn này dùng để ẩn và hiện nút tìm kiếm trên Form
				if (chkTimten.Checked == true)//nếu checkbox của tìm theo lớp được check
				{
					btnTimkiem.Visible = true;//hiện nút tìm kiếm
				}
				else
					btnTimkiem.Visible = false;//ẩn nút tìm kiếm
			}
			else
			{
				chkTimgiaovien.Visible = true;//hiện checkbox của giáo viên
				cmbTimgiaovien.Visible = true;//hiện combobox của giáo viên

				cmbTimmonhoc.Enabled = false;//đóng combobox của môn học

				btnTimkiem.Visible = false;//ẩn nút tìm kiếm 
			}
		}

		//hàm load combobox của môn học
		private void cmbTimmonhoc_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				string tenmonhoc = cmbTimmonhoc.Text;//lấy giá trị của combobox


				String sql = "SELECT l.MaLop,l.TenLop,l.SiSo,NgayBatDau,NgayKetThuc,SoBuoi,gv.TenGV,mh.TenMonHoc FROM LOP l, GIAOVIEN gv,MONHOC mh " +
					"where l.MaGiaoVien = gv.MaGV and l.MaMonHoc = mh.MaMonHoc " +
					"and mh.TenMonHoc = N'" + tenmonhoc + "'"; //câu truy vấn từ bảng lớp được gán vào 1 chuỗi 

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


		//hàm điều khiển sự kiện check hay ko của checkbox tìm kiếm theo tên lớp
		private void chkTimten_CheckedChanged(object sender, EventArgs e)
		{
			//nếu checkbox được check
			if (chkTimten.Checked == true)
			{
				txtTimten.Visible = true;//hiện textbox của tìm theo lớp
				txtTimten.Text = "";//reset lại thành rỗng trước khi tiến hành nhập mới
				txtTimten.Focus();//con trỏ chuột hiện ngay textbox của tìm theo lớp

				//đoạn này dùng để ẩn và hiện nút tìm kiếm trên Form
				if (chkTimgiaovien.Checked == true)//nếu checkbox của giáo viên được check
				{
					btnTimkiem.Visible = true;//hiện nút tìm kiếm 
				}
				else if (chkTimmonhoc.Checked == true)//nếu checkbox của giáo viên được check
				{
					btnTimkiem.Visible = true;//hiện nút tìm kiếm 
				}
			}
			else //nếu checkbox không được check
			{
				txtTimten.Visible = false;//ẩn textbox của tìm theo lớp
				btnTimkiem.Visible = false;//hiện nút tìm kiếm 
			}
		}

		//hàm xử lý khi nhập xong từ khóa vào ô textbox của tìm theo lớp và nhấn phím enter
		private void txtTimten_KeyDown(object sender, KeyEventArgs e)
		{
			//khi nhấn enter
			if (e.KeyCode == Keys.Enter)
			{
				try
				{
					string tenlop = txtTimten.Text;

					String sql = "SELECT l.MaLop,l.TenLop,l.SiSo,NgayBatDau,NgayKetThuc,SoBuoi,gv.TenGV,mh.TenMonHoc FROM LOP l, GIAOVIEN gv,MONHOC mh " +
						"where l.MaGiaoVien = gv.MaGV and l.MaMonHoc = mh.MaMonHoc " +
						"and l.TenLop like N'%"+ tenlop +"%'"; //câu truy vấn từ bảng lớp được gán vào 1 chuỗi 

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


		//hàm tìm kiếm
		private void btnTimkiem_Click(object sender, EventArgs e)
		{
			if (chkTimgiaovien.Checked == true && chkTimkiem.Checked == true)
			{
				try
				{
					string tengiaovien = cmbTimgiaovien.Text;//lấy giá trị của combobox
					string tenlop = txtTimten.Text;

					String sql = "SELECT l.MaLop,l.TenLop,l.SiSo,NgayBatDau,NgayKetThuc,SoBuoi,gv.TenGV,mh.TenMonHoc FROM LOP l, GIAOVIEN gv,MONHOC mh " +
						"where l.MaGiaoVien = gv.MaGV and l.MaMonHoc = mh.MaMonHoc " +
						"and gv.TenGV = N'" + tengiaovien + "'" +
						"and l.TenLop like N'%"+ tenlop +"%'"; //câu truy vấn từ bảng lớp được gán vào 1 chuỗi 

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
					string tenlop = txtTimten.Text;

					String sql = "SELECT l.MaLop,l.TenLop,l.SiSo,NgayBatDau,NgayKetThuc,SoBuoi,gv.TenGV,mh.TenMonHoc FROM LOP l, GIAOVIEN gv,MONHOC mh " +
						"where l.MaGiaoVien = gv.MaGV and l.MaMonHoc = mh.MaMonHoc " +
						"and mh.TenMonHoc = N'" + tenmonhoc + "'" +
						"and l.TenLop like N'%"+ tenlop +"%' "; //câu truy vấn từ bảng lớp được gán vào 1 chuỗi 

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

		//------------------------------------------------------------------------------

		//---------------------------------------IN ẤN---------------------------------------
		//hàm hiển thị form in ấn  
		private void btnIn_Click(object sender, EventArgs e)
		{
			frmInlop frm = new frmInlop();
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
		//hàm load dữ liệu từ file excel lên datagriview
		//nguyên nhân do khi export file excel ra thì xuất ra tên giáo viên và tên môn học
		//hàm này có nhược điểm khi nhập vào thì phải đúng format
		//là mã giáo viên và mã môn học không cho phép nhập vào tên giáo viên và tên môn học 

		/*		private void ImportExcel(string path)
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
								string Malop = TangMa();
								string Tenlop = row[1].ToString();
								string Siso = row[2].ToString();
								DateTime Ngaybatdau = DateTime.Parse(row[3].ToString());
								DateTime Ngayketthuc = DateTime.Parse(row[4].ToString());
								string Sobuoi = row[5].ToString();
								string Magiaovien = row[6].ToString();
								string Mamonhoc = row[7].ToString();
								//lệnh này thì cho phép null
								string sqlthem = "insert into LOP(MaLop,TenLop,SiSo,NgayBatDau,NgayKetThuc,SoBuoi,MaGiaoVien,MaMonHoc) " +
									"values('" + Malop + "',N'" + Tenlop + "','" + Siso + "','" + Ngaybatdau + "','" + Ngayketthuc + "','" + Sobuoi + "','" + Magiaovien + "','" + Mamonhoc + "')";

								try
								{
									SqlCommand command = new SqlCommand(sqlthem, con);
									command.ExecuteNonQuery();

									loaddulieulenluoi();

									txtMalop.Text = TangMa();// Tạo mã lớp mới
								}
								catch
								{
									MessageBox.Show("Thêm thất bại");
								}
							}
						}
					}
				}*/

		//hàm lấy mã giáo viên từ tên giáo viên của file excel
		private string GetMaGV(string tenGV, SqlConnection conn)
		{
			// Xây dựng câu lệnh SQL để tìm MaGV dựa trên tên giáo viên
			string query = "SELECT MaGV FROM GiaoVien WHERE TenGV = N'" + tenGV + "'";

			// Tạo một SqlCommand với câu lệnh SQL và kết nối đã được truyền vào
			using (SqlCommand cmd = new SqlCommand(query, conn))
			{
				// Thực thi câu lệnh SQL và lấy giá trị đầu tiên từ kết quả (trường MaGV)
				object result = cmd.ExecuteScalar();

				// Nếu kết quả không null, trả về MaGV
				if (result != null)
				{
					return result.ToString();
				}
				else
				{
					// Nếu không tìm thấy MaGV, ném ra một ngoại lệ với thông báo lỗi
					throw new Exception($"Tên giáo viên '{tenGV}' không tồn tại trong bảng GiaoVien.");
				}
			}
		}

		//hàm lấy mã môn học từ tên giáo viên của file excel
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

		//hàm load dữ liệu từ file excel lên datagriview
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
						// Tạo mã lớp mới bằng hàm TangMa
						string Malop = TangMa();
						string Tenlop = row[1].ToString();
						string Siso = row[2].ToString();
						DateTime Ngaybatdau = DateTime.Parse(row[3].ToString());
						DateTime Ngayketthuc = DateTime.Parse(row[4].ToString());
						string Sobuoi = row[5].ToString();
						string TenGV = row[6].ToString();
						string TenMonHoc = row[7].ToString();

						try
						{
							// Lấy MaGV từ TenGV sử dụng hàm GetMaGV
							string MaGV = GetMaGV(TenGV, conn);

							// Lấy MaMonHoc từ TenMonHoc sử dụng hàm GetMaMonHoc
							string MaMonHoc = GetMaMonHoc(TenMonHoc, conn);

							// Xây dựng chuỗi truy vấn SQL để chèn dữ liệu vào bảng LOP
							string sqlthem = "insert into LOP(MaLop,TenLop,SiSo,NgayBatDau,NgayKetThuc,SoBuoi,MaGiaoVien,MaMonHoc) " +
							"values('" + Malop + "',N'" + Tenlop + "','" + Siso + "','" + Ngaybatdau + "','" + Ngayketthuc + "','" + Sobuoi + "','" + MaGV + "','" + MaMonHoc + "')";

							// Thực hiện lệnh SQL
							SqlCommand command = new SqlCommand(sqlthem, conn);
							command.ExecuteNonQuery();

							// Cập nhật lại dữ liệu trên DataGridView
							loaddulieulenluoi();

							// Tạo mã lớp mới để chuẩn bị cho lần nhập kế tiếp
							txtMalop.Text = TangMa();
						}
						catch (Exception ex)
						{
							// Thông báo lỗi nếu có vấn đề xảy ra trong quá trình chèn dữ liệu
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


