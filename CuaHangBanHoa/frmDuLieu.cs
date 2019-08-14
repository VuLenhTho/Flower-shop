using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuaHangBanHoa
{
    public partial class frmDuLieu : Form
    {
        public frmDuLieu()
        {
            InitializeComponent();
        }

        private void btnHoa_Click(object sender, EventArgs e)
        {
            frmHoa hoa = new frmHoa();
            hoa.ShowDialog();

        }

        private void btnCTHoaDon_Click(object sender, EventArgs e)
        {
            frmChiTietHoaDon chiTietHoaDon = new frmChiTietHoaDon();
            chiTietHoaDon.ShowDialog();
        }
        

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            
            frmHoaDon hoaDon = new frmHoaDon();
            hoaDon.Show();
        }

        private void btnNhaCungCap_Click(object sender, EventArgs e)
        {
            frmNhaCungCap nhaCungCap = new frmNhaCungCap();
            nhaCungCap.Show();
        }

        private void frmDuLieu_Load(object sender, EventArgs e)
        {
            
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            frmNhanVien nhanVien = new frmNhanVien();
            nhanVien.Show();
        }

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            frmTaiKhoan taiKhoan = new frmTaiKhoan();
            taiKhoan.Show();
        }
    }
}
