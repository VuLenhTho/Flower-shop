using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CuaHangBanHoa
{
    public partial class test : Form
    {
        public test()
        {
            InitializeComponent();
        }

        private void test_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = Properties.Settings.Default.QLBanHoaConnectionString;
            string sql = "Select * from tblHOA";
            DataSet ds = new DataSet();
            SqlDataAdapter dap = new SqlDataAdapter(sql,con);
            dap.Fill(ds);
            dgv.DataSource = ds.Tables[0];
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.Refresh();
        }
    }
}
