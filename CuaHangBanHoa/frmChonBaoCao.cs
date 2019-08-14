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
    public partial class frmChonBaoCao : Form
    {
        public frmChonBaoCao()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            rptBaoCaoTrongNgay rptBaoCaoTrongNgay = new rptBaoCaoTrongNgay();
            rptBaoCaoTrongNgay.Show();
        }

        private void btnTrongThang_Click(object sender, EventArgs e)
        {
            rptBaoCaoTrongThang rpt = new rptBaoCaoTrongThang();
            rpt.Show();
        }

        private void btnTop10_Click(object sender, EventArgs e)
        {
            rptTop10BanChay top10BanChay = new rptTop10BanChay();
            top10BanChay.Show();
        }
    }
}
