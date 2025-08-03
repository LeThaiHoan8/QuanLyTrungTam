using Microsoft.Reporting.WinForms;
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
	public partial class frmInAdminPhanQuyen : Form
	{
		string strCon = "Data Source=LAPTOP-HK1PT9J5;Initial Catalog=quanlykhoahoc;Integrated Security=True";
		SqlConnection sqlCon = null;
		public frmInAdminPhanQuyen()
		{
			InitializeComponent();
		}

		private void frmInAdminPhanQuyen_Load(object sender, EventArgs e)
		{

			// Kiểm tra kết nối SQL
			if (sqlCon == null)
			{
				sqlCon = new SqlConnection(strCon);
			}

			// Câu lệnh SQL để lấy dữ liệu
			string sql = "SELECT * FROM USERS";


			// Tạo SqlDataAdapter để thực hiện truy vấn và điền dữ liệu vào DataSet
			SqlDataAdapter adapter = new SqlDataAdapter(sql, sqlCon);
			DataSet ds = new DataSet();
			adapter.Fill(ds, "USERS");

			// Cấu hình ReportViewer
			this.reportViewer1.LocalReport.ReportEmbeddedResource = "APP_demo.ReportAdmin.rdlc";

			// Tạo ReportDataSource và gán dữ liệu từ DataSet
			ReportDataSource rds = new ReportDataSource();
			rds.Name = "DataSetAdmin";
			rds.Value = ds.Tables["USERS"];

			// Thêm ReportDataSource vào ReportViewer
			this.reportViewer1.LocalReport.DataSources.Clear();
			this.reportViewer1.LocalReport.DataSources.Add(rds);

			// Làm mới báo cáo
			this.reportViewer1.RefreshReport();
		

		}
    }
}
