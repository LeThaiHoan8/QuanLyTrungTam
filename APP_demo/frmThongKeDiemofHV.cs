using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using data=System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;
using System.Linq.Expressions;
using System.Data;

namespace APP_demo
{
	public partial class frmThongKeDiemofHV : Form
	{
		string chuoiketnoi = "Data Source=LAPTOP-HK1PT9J5;Initial Catalog=quanlykhoahoc;Integrated Security=True";
		SqlConnection con = new SqlConnection();
		public frmThongKeDiemofHV()
		{
			InitializeComponent();
		}

		//form load 
		private void frmThongKeDiemofHV_Load(object sender, EventArgs e)
		{
			ketnoicsdl();
			loadcombobox1(cmbHocvien);
		}

		//nút hiển thị
		private void btnShow_Click(object sender, EventArgs e)
		{
			loaddulieulenbieudocot();
			loaddulieulenbieudotron();
		}

		//kết nối csdl
		private void ketnoicsdl()
		{
			try
			{
				con = new SqlConnection(chuoiketnoi);
				con.Open();//con: sqlconnection chức năng mở kết nối csdl cho phép truy cập vô
				MessageBox.Show("Success");
			}
			catch
			{
				MessageBox.Show("Fall");
			}
		}

		//load csdl
		private void loadcombobox1(ComboBox cmb)
		{
			try
			{
				String sql = "SELECT * FROM HOCVIEN";

				SqlDataAdapter da = new SqlDataAdapter(sql, con);
				data.DataTable dt = new data.DataTable();
				da.Fill(dt);

				cmb.DataSource = dt;
				cmb.DisplayMember = dt.Columns["TenHV"].ToString();
				cmb.ValueMember = dt.Columns["MaHV"].ToString();
			}
			catch
			{
				MessageBox.Show("Không load được combobox của bảng Môn Học");
			}

		}

		//load dữ liệu lên biểu đố cột
		private void loaddulieulenbieudocot()
		{
			try
			{
				// Lấy mã học viên từ ComboBox
				string hoccien = cmbHocvien.Text.Trim();

				con = new SqlConnection(chuoiketnoi);
				data.DataTable dt = new data.DataTable();

				// Câu truy vấn SQL để lấy điểm của học viên qua các môn học
				string sql = "SELECT mh.TenMonHoc, dsd.Diem " +
							 "FROM DanhSachDiem dsd " +
							 "INNER JOIN MonHoc mh ON dsd.MaMonHoc = mh.MaMonHoc " +
							 "INNER JOIN HocVien hv ON dsd.MaHocVien = hv.MaHV " +
							 "WHERE hv.TenHV = N'" + hoccien + "'";

				SqlDataAdapter da = new SqlDataAdapter(sql, con);

				// Mở kết nối tới cơ sở dữ liệu
				con.Open();
				// Đổ dữ liệu từ SqlDataAdapter vào DataTable
				da.Fill(dt);

				// Xóa tiêu đề biểu đồ nếu đã có
				chartCot.Titles.Clear();
				// Thêm tiêu đề cho biểu đồ
				chartCot.Titles.Add("Biểu đồ điểm của học viên qua các môn học");

				// Thiết lập tiêu đề cho trục X của biểu đồ
				chartCot.ChartAreas["ChartArea1"].AxisX.Title = "Môn học";
				// Thiết lập tiêu đề cho trục Y của biểu đồ
				chartCot.ChartAreas["ChartArea1"].AxisY.Title = "Điểm";
				// Thiết lập giá trị tối thiểu cho trục Y
				chartCot.ChartAreas["ChartArea1"].AxisY.Minimum = 0;
				// Thiết lập giá trị tối đa cho trục Y
				chartCot.ChartAreas["ChartArea1"].AxisY.Maximum = 10; // Giả sử điểm tối đa là 10

				// Xóa các dòng lưới trên trục X và Y
				chartCot.ChartAreas["ChartArea1"].AxisX.MajorGrid.LineWidth = 0;
				chartCot.ChartAreas["ChartArea1"].AxisX.MinorGrid.LineWidth = 0;
				chartCot.ChartAreas["ChartArea1"].AxisY.MajorGrid.LineWidth = 0;
				chartCot.ChartAreas["ChartArea1"].AxisY.MinorGrid.LineWidth = 0;

				// Xóa series "DiemHocVien" nếu đã tồn tại
				if (chartCot.Series.IndexOf("DiemHocVien") != -1)
					chartCot.Series.Remove(chartCot.Series["DiemHocVien"]);

				// Thêm một series mới vào biểu đồ
				chartCot.Series.Add("DiemHocVien");

				// Đặt kiểu biểu đồ cho series "DiemHocVien" là biểu đồ cột
				chartCot.Series["DiemHocVien"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
				// Đặt kiểu vẽ của các cột là hình trụ
				chartCot.Series["DiemHocVien"]["DrawingStyle"] = "Cylinder";

				// Thiết lập màu cho cột
				chartCot.Series["DiemHocVien"].Color = Color.DarkGreen;
				// Thiết lập tên cho chú thích
				chartCot.Series["DiemHocVien"].LegendText = "Điểm học viên";

				// Thêm dữ liệu vào biểu đồ từ DataTable
				foreach (DataRow row in dt.Rows)
				{
					DataPoint point = new DataPoint();
					//Thiết lập nhãn trục X là tên môn học
					point.AxisLabel = row["TenMonHoc"].ToString();
					//Thiết lập giá trị trục Y là điểm
					point.YValues = new double[] { Convert.ToDouble(row["Diem"]) };

					// Thiết lập màu cho cột
					point.Color = Color.DarkGreen;
					// Thiết lập nhãn để hiển thị điểm trên cột
					point.Label = row["Diem"].ToString();

					// Thêm điểm vào biểu đồ
					chartCot.Series["DiemHocVien"].Points.Add(point);
				}

				// Đóng kết nối cơ sở dữ liệu
				con.Close();
			}
			catch (Exception exp)
			{
				// Hiển thị thông báo lỗi nếu có lỗi xảy ra
				MessageBox.Show("Có lỗi xảy ra: " + exp.Message);
			}
		}

		//load dữ liệu lên biểu đồ tròn
		private void loaddulieulenbieudotron()
		{
			try
			{
				// Lấy giá trị học viên từ ComboBox
				string hoccien = cmbHocvien.Text.Trim();

				con = new SqlConnection(chuoiketnoi);
				data.DataTable dt = new data.DataTable();

				// Câu truy vấn SQL để lấy trạng thái và số lượng môn học tương ứng của học viên
				string sql = "SELECT TrangThai, COUNT(MaMonHoc) AS SoMonHoc " +
							 "FROM DanhSachDiem dsd " +
							 "INNER JOIN HocVien hv ON dsd.MaHocVien = hv.MaHV " +
							 "WHERE hv.TenHV = N'" + hoccien + "' " +
							 "GROUP BY TrangThai";

				SqlDataAdapter da = new SqlDataAdapter(sql, con);

				// Mở kết nối tới cơ sở dữ liệu
				con.Open();
				// Đổ dữ liệu từ SqlDataAdapter vào DataTable
				da.Fill(dt);
				// Đóng kết nối cơ sở dữ liệu
				con.Close();

				// Xóa tiêu đề biểu đồ nếu đã có
				chart2.Titles.Clear();
				// Thêm tiêu đề cho biểu đồ
				chart2.Titles.Add("Biểu đồ trạng thái học tập của học viên");

				// Xóa series "TrangThai" nếu đã tồn tại
				if (chart2.Series.IndexOf("TrangThai") != -1)
					chart2.Series.Remove(chart2.Series["TrangThai"]);

				// Thêm một series mới vào biểu đồ
				chart2.Series.Add("TrangThai");

				// Đặt kiểu biểu đồ cho series "TrangThai" là biểu đồ tròn
				chart2.Series["TrangThai"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;

				// Thêm dữ liệu vào biểu đồ từ DataTable và hiển thị nhãn dữ liệu
				foreach (DataRow row in dt.Rows)
				{
					string trangThai = row["TrangThai"].ToString();
					double soMonHoc = Convert.ToDouble(row["SoMonHoc"]);

					// Thêm điểm dữ liệu vào series sử dụng AddXY
					int pointIndex = chart2.Series["TrangThai"].Points.AddXY(trangThai, soMonHoc);
					DataPoint point = chart2.Series["TrangThai"].Points[pointIndex];

					// Chỉ hiển thị tên trạng thái trên chú thích
					point.LegendText = trangThai;
					// Hiển thị số lượng môn học trên biểu đồ
					point.Label = soMonHoc.ToString();

					// Thiết lập tooltip hiển thị số lượng môn học khi di chuột qua
					point.ToolTip = $"{trangThai}: {soMonHoc}";
				}
			}
			catch (Exception exp)
			{
				// Hiển thị thông báo lỗi nếu có lỗi xảy ra
				MessageBox.Show("Có lỗi xảy ra: " + exp.Message);
			}
		}

	
	}
}
