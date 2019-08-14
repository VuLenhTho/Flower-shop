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
    public partial class frmTaiKhoan : Form
    {
        public frmTaiKhoan()
        {
            InitializeComponent();
        }

        private void loadADMIN(SqlConnection con)
        {
            String sql1 = "Select * from tblADMIN";
            DataSet ds = new DataSet();
            SqlDataAdapter dap = new SqlDataAdapter(sql1, con);
            dap.Fill(ds);
            dgvTk.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTk.DataSource = ds.Tables[0];
            dgvTk.Refresh();
        }

        private void frmTaiKhoan_Load(object sender, EventArgs e)
        {
            SqlConnection con = SQLConnector.GetSqlConnection();
            loadADMIN(con);
        }

        private void huyThemXoa()
        {
            btnOK.Enabled = false;
            btnHuy.Enabled = false;
            txtTK.Enabled = false;
            txtMK.Enabled = false;
            txtID.Enabled = false;
            txtMK.Clear();
            txtTK.Clear();
            txtID.Clear();
        }
        private void batThemXoa()
        {
            btnOK.Enabled = true;
            btnHuy.Enabled = true;
            txtTK.Enabled = true;
            txtMK.Enabled = true;
            txtID.Enabled = true;
            txtID.Clear();
            txtMK.Clear();
            txtTK.Clear();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtTK.Text == "" || txtMK.Text == "" )
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
                return;
            }
            SqlConnection con = SQLConnector.GetSqlConnection();          
            String IDBanDau = dgvTk.CurrentRow.Cells["ID"].Value.ToString();
                if (IDBanDau.Equals(""))
                {
                    MessageBox.Show("Không có ID nào được chọn!");
                    return;
                }
                String sql = "UPDATE tblADMIN SET ID = N'" + txtID.Text + "',UserName = N'" + txtTK.Text + "'," +
                    "Password =N'" + txtMK.Text + "' WHERE ID =N'"+IDBanDau+"'";
                SqlCommand cmd = new SqlCommand(sql, con);
                try
                {
                    cmd.ExecuteNonQuery();
                    loadADMIN(con);
                    MessageBox.Show("Sửa thành công!");
                }
                catch
                {
                    MessageBox.Show("Sửa thất bại! Vui lòng kiểm tra lại thông tin đã nhập!");
                }
                finally
                {
                    con.Close();
                }
            
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {          
            huyThemXoa();
        }

        

        private void btnSua_Click(object sender, EventArgs e)
        {
            lbChucNang.ForeColor = Color.Blue;
            lbChucNang.Text = "Sửa Dữ Liệu:";
            batThemXoa();
            txtMK.Text = dgvTk.CurrentRow.Cells["Password"].Value.ToString();
            txtTK.Text = dgvTk.CurrentRow.Cells["UserName"].Value.ToString();            
            txtID.Text = dgvTk.CurrentRow.Cells["ID"].Value.ToString();            
        }
      

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
