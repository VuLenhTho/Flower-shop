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
    public partial class FrmHome : Form
    {
        public FrmHome()
        {
            InitializeComponent();
        }

        public static bool login = false;

        private void btnTaoHoaDon_Click_1(object sender, EventArgs e)
        {
            frmTaoHoaDon taoHoaDon = new frmTaoHoaDon();
            taoHoaDon.Show();
        }

        private void FrmHome_Load(object sender, EventArgs e)
        {
            if (!login)
            {                
                btnDangnhap.Enabled = false;
            }
            else
            {
                lbXinChao.Text = "Xin chào admin!";                
                btnDangnhap.Enabled = true;
            }
            SqlConnection con = SQLConnector.GetSqlConnection();
            String sql1 = "Select MaHoa,TenHoa,DVTinh,GiaBan from tblHOA";
            DataSet ds = new DataSet();
            SqlDataAdapter dap = new SqlDataAdapter(sql1, con);
            dap.Fill(ds);
            dgvDanhSachSanPham.DataSource = ds.Tables[0];           
            dgvDanhSachSanPham.Refresh();
            

        }
       

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            SqlConnection con = SQLConnector.GetSqlConnection();
            String sql = "Select MaHoa,TenHoa,DVTinh,GiaBan from tblHOA WHERE 1=1";
            if(txtMaSP.Text != "")
            {
                sql += " AND MaHoa LIKE N'%" + txtMaSP.Text + "%'";
            }
            if (txtTenSp.Text != "")
            {
                sql += " AND TenHoa LIKE N'%" + txtTenSp.Text + "%'";
            }
            if (txtGiaTu.Text != "")
            {
                sql += " AND GiaBan >= N'" + txtGiaTu.Text + "'";
            }
            if (txtGiaDen.Text != "")
            {
                sql += " AND GiaBan  <= N'" + txtGiaDen.Text + "'";
            }
            try
            {
                DataSet ds = new DataSet();
                SqlDataAdapter dap = new SqlDataAdapter(sql, con);
                dap.Fill(ds);
                dgvDanhSachSanPham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvDanhSachSanPham.DataSource = ds.Tables[0];
                dgvDanhSachSanPham.Refresh();
                
            }
            catch
            {
                MessageBox.Show("nhập sai thuộc tính tìm kiếm");
                return;
            }
            
        }

        private void btnXoaBoLoc_Click(object sender, EventArgs e)
        {
            txtMaSP.Clear();
            txtTenSp.Clear();
            txtGiaTu.Clear();
            txtGiaDen.Clear();
        }

        private void btnDuLieu_Click(object sender, EventArgs e)
        {
            if (login)
            {               
                frmDuLieu duLieu = new frmDuLieu();
                duLieu.ShowDialog();               
            }
            else
            {
                this.Hide();
                frmDangNhap dangNhap = new frmDangNhap();
                dangNhap.ShowDialog();
                this.Close();
            }
        }

        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            if (login)
            {
                login = false;
                MessageBox.Show("Đã đăng xuất","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lbXinChao.Text = "";
                btnDangnhap.Enabled = false;
            }
            else
            {
                MessageBox.Show("Chưa đăng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnXemHoaDon_Click(object sender, EventArgs e)
        {
            frmHoaDonGanDay hDTrongNgay = new frmHoaDonGanDay();
            hDTrongNgay.Show();
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            if (login)
            {                
                frmChonBaoCao chonBaoCao = new frmChonBaoCao();
                chonBaoCao.ShowDialog();              
            }
            else
            {
                this.Hide();
                frmDangNhap dangNhap = new frmDangNhap();
                dangNhap.ShowDialog();
                this.Close();
            }
            
        }

        private void panelTop_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
