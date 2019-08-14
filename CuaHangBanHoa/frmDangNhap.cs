using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuaHangBanHoa
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
        }

        private bool Login(string userName, string Password)
        {
            SqlConnection con = SQLConnector.GetSqlConnection();
            string sql = "SELECT UserName,Password FROM tblADMIN";
            SqlCommand cmd = new SqlCommand(sql, con);
            using (DbDataReader reader = cmd.ExecuteReader())
            {
                if (reader.HasRows)
                {

                    while (reader.Read())
                    {
                        int tkOr = reader.GetOrdinal("UserName");
                        string taiKhoan = reader.GetString(tkOr);
                        int mkOr = reader.GetOrdinal("Password");
                        string matKhau = reader.GetString(mkOr);

                        if (taiKhoan.Equals(userName) && matKhau.Equals(Password))
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if(Login(txtTaiKhoan.Text, txtMatKhau.Text) == true)
            {
                this.Hide();
                FrmHome.login = true;
                FrmHome home = new FrmHome();
                home.ShowDialog();
                this.Close();
            }
            else
            {
                lbTieuDe.Text = "Đăng nhập thất bại";
            }

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmHome home = new FrmHome();
            home.ShowDialog();
            this.Close();
        }

        private void txtMatKhau_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnDangNhap_Click(sender, e);
            }
        }

        private void lbTieuDe_Click(object sender, EventArgs e)
        {

        }

        private void frmDangNhap_Enter(object sender, EventArgs e)
        {
           
        }

        private void txtTaiKhoan_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        
    }
}
