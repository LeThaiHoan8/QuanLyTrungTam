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
using System.Data.Sql;
//using System.Data.SqlClient;
//thư viện vẽ biểu đồ
using System.Windows.Forms.DataVisualization.Charting;
using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;
using System.Linq.Expressions;

namespace APP_demo
{
	public partial class frmThongkediem : Form
	{
		string chuoiketnoi = "Data Source=LAPTOP-HK1PT9J5;Initial Catalog=quanlykhoahoc;Integrated Security=True";
		SqlConnection con = new SqlConnection();
		public frmThongkediem()
		{
			InitializeComponent();
		}
		
		//form load
		private void frmThongkediem_Load(object sender, EventArgs e)
		{
			ketnoicsdl();
			loadcombobox1(cmbMonhoc);

		}

		//kết nói csdl
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

		//load combobox môn học
		private void loadcombobox1(ComboBox cmb)
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
				MessageBox.Show("Không load được combobox của bảng Môn Học");
			}

		}

		//nút hiển thị
		private void btnShow_Click(object sender, EventArgs e)
		{
			loaddulieulenbieudocot();
			loaddulieulenbieudotron();
		}

		//hàm ví dụ dễ hiểu
		private void fillchart()
		{
			/*try
	{
		DataTable dt = new DataTable();
		SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM LopHoc_HocVien", con);
		con.Open();
		da.Fill(dt);
		con.Close();

		MessageBox.Show("Đổ thành công");

		chart1.ChartAreas["ChartArea1"].AxisX.Title = "Điểm Sinh Viên";
		chart1.ChartAreas["ChartArea1"].AxisY.Title = "Điểm";
		chart1.ChartAreas["ChartArea1"].AxisX.Interval = 1;

		chart1.Series.Add("EX");
		chart1.Series["Diem"]["DrawingStyle"]="Cylinder";
		for (int i = 0; i < dt.Rows.Count; i++)
		{
			chart1.Series["Diem"].Points.AddXY(dt.Rows[i]["MaHocVien"], dt.Rows[i]["Diem"]);
			chart1.Series["EX"].Points.AddXY(dt.Rows[i]["MaHocVien"], dt.Rows[i]["Diem"]);
		}
	}
	catch (Exception exp)
	{
		MessageBox.Show("Có lỗi xảy ra: " + exp.Message);
	}*/
		}

		//hàm load dữ liệu lên biểu đồ cột
		private void loaddulieulenbieudocot()
		{
			try
			{
				// Lấy giá trị môn học từ ComboBox
				string monhoc = cmbMonhoc.Text.Trim();

				con = new SqlConnection(chuoiketnoi);
				DataTable dt = new DataTable();

				// Tạo SqlDataAdapter với câu truy vấn SQL để lấy dữ liệu điểm và số lượng học viên dựa trên môn học

				//Dùng câu này sẽ bị lỗi  Subquery returned more than 1 value. This is not
				//permitted when the subquery follows =, !=, <,<, >,>= or when the subquery is used as an expression.
				//khi một truy vấn con (subquery) trong SQL Server trả về nhiều hơn một giá trị 

				//dùng in hoặc top 1 để sửa
				/*string sql = "SELECT Diem, COUNT(MaHocVien) AS SoLuongHocVien " +
					"FROM DanhSachDiem " +
					"WHERE Mamonhoc = (SELECT MaMonHoc FROM MONHOC WHERE TenMonHoc = N'" + monhoc + "') " +
					"GROUP BY Diem " +
					"HAVING COUNT(MaHocVien) > 0";*/


				// Tạo SqlDataAdapter với câu truy vấn SQL để lấy dữ liệu điểm và số lượng học viên dựa trên môn học
				string sql = "SELECT Diem, COUNT(MaHocVien) AS SoLuongHocVien " +
					"FROM DanhSachDiem " +
					"WHERE Mamonhoc IN (SELECT MaMonHoc FROM MONHOC WHERE TenMonHoc = N'" + monhoc + "') " +
					"GROUP BY Diem " +
					"HAVING COUNT(MaHocVien) > 0";

				SqlDataAdapter da = new SqlDataAdapter(sql, con);

				// Mở kết nối tới cơ sở dữ liệu
				con.Open();
				// Đổ dữ liệu từ SqlDataAdapter vào DataTable
				da.Fill(dt);
				// Hiển thị thông báo khi dữ liệu được đổ thành công
				//MessageBox.Show("Đổ thành công");

				// Xóa tiêu đề biểu đồ nếu đã có
				chartCot.Titles.Clear();
				// Thêm tiêu đề cho biểu đồ
				chartCot.Titles.Add("Biểu đồ phổ điểm thi");

				// Thiết lập tiêu đề cho trục X của biểu đồ
				chartCot.ChartAreas["ChartArea1"].AxisX.Title = "Điểm";
				// Thiết lập tiêu đề cho trục Y của biểu đồ
				chartCot.ChartAreas["ChartArea1"].AxisY.Title = "Số Lượng Học Viên";
				// Thiết lập giá trị tối thiểu cho trục X
				chartCot.ChartAreas["ChartArea1"].AxisX.Minimum = 0;
				// Thiết lập khoảng cách giữa các giá trị trên trục X
				chartCot.ChartAreas["ChartArea1"].AxisX.Interval = 1;

				// Xóa các dòng lưới trên trục X và Y
				chartCot.ChartAreas["ChartArea1"].AxisX.MajorGrid.LineWidth = 0;
				chartCot.ChartAreas["ChartArea1"].AxisX.MinorGrid.LineWidth = 0;
				chartCot.ChartAreas["ChartArea1"].AxisY.MajorGrid.LineWidth = 0;
				chartCot.ChartAreas["ChartArea1"].AxisY.MinorGrid.LineWidth = 0;

				// Xóa series "SoLuongHocVien" nếu đã tồn tại
				if (chartCot.Series.IndexOf("SoLuongHocVien") != -1)
					chartCot.Series.Remove(chartCot.Series["SoLuongHocVien"]);

				// Thêm một series mới vào biểu đồ
				chartCot.Series.Add("SoLuongHocVien");

				// Đặt kiểu biểu đồ cho series "SoLuongHocVien" là biểu đồ cột
				chartCot.Series["SoLuongHocVien"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
				// Đặt kiểu vẽ của các cột là hình trụ
				chartCot.Series["SoLuongHocVien"]["DrawingStyle"] = "Cylinder";

				// Thiết lập màu cho chú thích
				chartCot.Series["SoLuongHocVien"].Color = Color.DarkGreen;
				// Thiết lập tên cho chú thích
				chartCot.Series["SoLuongHocVien"].LegendText = "Số Lượng Học Viên";
			
				// Thêm dữ liệu vào biểu đồ từ DataTable
				for (int i = 0; i < dt.Rows.Count; i++)
				{
					//sử dụng 1 trong 2 cách sau
					//C1:Sử dụng AddXY:
					//Nó tạo ra một đối tượng DataPoint mới bên trong phương thức và thiết lập giá trị X và Y của nó bằng các tham số được cung cấp.
					//nhưng Không cho phép thiết lập các thuộc tính bổ sung của DataPoint, như màu sắc hoặc nhãn.
					//chart1.Series["SoLuongHocVien"].Points.AddXY(dt.Rows[i]["Diem"].ToString(), Convert.ToDouble(dt.Rows[i]["SoLuongHocVien"]));

					//C2:Sử dụng Add với đối tượng DataPoint:
					//Tạo đối tượng DataPoint
					DataPoint point = new DataPoint();
					//Thiết lập nhãn trục X
					point.AxisLabel = dt.Rows[i]["Diem"].ToString();
					//Thiết lập giá trị trục Y
					point.YValues = new double[] { Convert.ToDouble(dt.Rows[i]["SoLuongHocVien"]) };

					// Thiết lập màu cho cột
					point.Color = Color.DarkGreen;
					// Thiết lập nhãn để hiển thị số trên cột
					point.Label = dt.Rows[i]["SoLuongHocVien"].ToString();
					

					//để thêm một điểm dữ liệu vào biểu đồ cột.
					chartCot.Series["SoLuongHocVien"].Points.Add(point);
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

		//hàm load dữ liệu lên biểu dồ tròn
		private void loaddulieulenbieudotron()
		{
			try
			{
				// Lấy giá trị môn học từ ComboBox
				string monhoc = cmbMonhoc.Text.Trim();

				con = new SqlConnection(chuoiketnoi);
				DataTable dt = new DataTable();

				// Tạo SqlDataAdapter với câu truy vấn SQL để lấy dữ liệu trang thái và tiến độ dựa trên môn học
				string sql = "SELECT TrangThai, COUNT(MaHocVien) AS TienDO " +
							 "FROM DanhSachDiem " +
							 "WHERE MaMonHoc IN (SELECT MaMonHoc FROM MONHOC WHERE TenMonHoc = N'" + monhoc + "') " +
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
				chart2.Titles.Add("Biểu đồ tiến độ học tập");

				// Xóa series "TrangThai" nếu đã tồn tại
				if (chart2.Series.IndexOf("TrangThai") != -1)
					chart2.Series.Remove(chart2.Series["TrangThai"]);

				// Thêm một series mới vào biểu đồ
				chart2.Series.Add("TrangThai");

				// Đặt kiểu biểu đồ cho series "TrangThai" là biểu đồ tròn
				chart2.Series["TrangThai"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;

				// Thêm dữ liệu vào biểu đồ từ DataTable và hiển thị nhãn dữ liệu
				for (int i = 0; i < dt.Rows.Count; i++)
				{
							//sử dụng 1 trong 2 cách sau
						//C1:Sử dụng AddXY:
							/*	string trangThai = dt.Rows[i]["TrangThai"].ToString();
								double tienDo = Convert.ToDouble(dt.Rows[i]["TienDO"]);

								// Thêm điểm dữ liệu vào series sử dụng AddXY
								int pointIndex = chart2.Series["TrangThai"].Points.AddXY(trangThai, tienDo);
								DataPoint point = chart2.Series["TrangThai"].Points[pointIndex];

								// Chỉ hiển thị tên trạng thái trên chú thích
								point.LegendText = trangThai;
								// Hiển thị số lượng học viên trên biểu đồ
								point.Label = tienDo.ToString();*/

						//C2:Sử dụng Add với đối tượng DataPoint:
					//Tạo đối tượng DataPoint:
					DataPoint point = new DataPoint();
					// Thiết lập nhãn cho điểm dữ liệu:
					point.AxisLabel = dt.Rows[i]["TrangThai"].ToString();
					//Thiết lập giá trị trục Y:
					point.YValues = new double[] { Convert.ToDouble(dt.Rows[i]["TienDO"]) };

					// Hiển thị chỉ số lượng học viên trên biểu đồ và chú thích
					//point.Label = $"{dt.Rows[i]["TrangThai"].ToString()}: {dt.Rows[i]["TienDO"].ToString()}"; 

					// Chỉ hiển thị tên trạng thái trên chú thích
					point.LegendText = dt.Rows[i]["TrangThai"].ToString(); 
					//hiển thị số trên biểu đồ
					point.Label = $"{dt.Rows[i]["TienDO"].ToString()}";

					//để thêm một điểm dữ liệu vào biểu đồ tròn.
					chart2.Series["TrangThai"].Points.Add(point);
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
