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
    public partial class frmXemCTHoaDon : Form
    {
        private string hoaDonHienTai;

        public frmXemCTHoaDon(string hoaDon)
        {
            this.hoaDonHienTai = hoaDon;
            InitializeComponent();
        }

        private void frmXemCTHoaDon_Load(object sender, EventArgs e)
        {
            SqlConnection con = SQLConnector.GetSqlConnection();
            String sql1 = "Select * from tblCTHOADON WHERE MaHoaDon = N'"+this.hoaDonHienTai +"' ";
            DataSet ds = new DataSet();
            SqlDataAdapter dap = new SqlDataAdapter(sql1, con);
            dap.Fill(ds);
            dgvCTHoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCTHoaDon.DataSource = ds.Tables[0];
            dgvCTHoaDon.Refresh();
        }
    }
}
