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

namespace CuaHangBanHoa
{
    public partial class rptBaoCaoTrongNgay : Form
    {
        public rptBaoCaoTrongNgay()
        {
            InitializeComponent();
        }

        private void rptBaoCaoTrongNgay_Load(object sender, EventArgs e)
        {

            this.rpvBaoCao.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = SQLConnector.GetSqlConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SPDaBanTrongNgay";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
            cmd.Parameters.Add(new SqlParameter("@ngay", dtpNgay.Value.Date));
            DataSet ds = new DataSet();
            SqlDataAdapter dap = new SqlDataAdapter(cmd);
            dap.Fill(ds);
            rpvBaoCao.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
            rpvBaoCao.LocalReport.ReportPath = "rptTrongNgay.rdlc";
            if(ds.Tables[0].Rows.Count > 0)
            {
                ReportDataSource rds = new ReportDataSource();
                rds.Name = "DataSet1";
                rds.Value = ds.Tables[0];
                rpvBaoCao.LocalReport.DataSources.Clear();
                rpvBaoCao.LocalReport.DataSources.Add(rds);
                rpvBaoCao.RefreshReport();

            }
            else
            {
                rpvBaoCao.Clear();
                MessageBox.Show("Không có dữ liệu trong ngày này");
            }
        }
    }
}
