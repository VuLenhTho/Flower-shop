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
    public partial class frmHoaDonGanDay : Form
    {
        string hoaDonDangChon;

        public frmHoaDonGanDay()
        {
            InitializeComponent();
        }

        private string kiemTraComboBox(string sql)
        {
            if (cbboxThuoctinhtim.Text.Equals("Khách hàng"))
            {
                sql += " AND TenKH = N'" + txtTimKiem.Text + "'";
            }
            if (cbboxThuoctinhtim.Text.Equals("Mã hóa đơn"))
            {
                sql += " AND MaHoaDon= N'" + txtTimKiem.Text + "'";
            }
            if (cbboxThuoctinhtim.Text.Equals("Mã NV"))
            {
                sql += " AND MaNV = N'" + txtTimKiem.Text + "'";
            }
            if (cbboxThuoctinhtim.Text.Equals("Tổng tiền"))
            {
                sql += " AND TongTien = N'" + txtTimKiem.Text + "'";
            }
            return sql;
        }
        
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            SqlConnection con = SQLConnector.GetSqlConnection();
            DataSet ds = new DataSet();
            DateTime date = DateTime.Now;
            string sql = "";
            if (cbxTGTim.Text.Equals("Ngày"))
            {
                sql = "SELECT * FROM tblHOADON WHERE NgayXuat = '"+ date.ToString("yyyy-MM-dd")+"' ";
                if (txtTimKiem.Text != "")
                {
                    sql = kiemTraComboBox(sql);
                }
                else if (cbboxThuoctinhtim.Text.Equals(""))
                {
                    MessageBox.Show("Thiếu thuộc tính tìm kiếm!");
                    return;

                }
                else if (!cbboxThuoctinhtim.Text.Equals("Khách hàng") && !cbboxThuoctinhtim.Text.Equals("Mã hóa đơn")
                    && !cbboxThuoctinhtim.Text.Equals("Mã NV") && !cbboxThuoctinhtim.Text.Equals("Tổng tiền"))
                {
                    MessageBox.Show("Sai thuộc tính tìm kiếm!");
                    return;
                }            
               
            }            
            else if (cbxTGTim.Text.Equals("Tháng"))
            {
                
                sql = "SELECT * FROM tblHOADON WHERE MONTH(NgayXuat) = "+date.Month+"";
                if (txtTimKiem.Text != "")
                {
                    sql = kiemTraComboBox(sql);

                }
                else if (cbboxThuoctinhtim.Text.Equals(""))
                {
                    MessageBox.Show("Thiếu thuộc tính tìm kiếm!");
                    return;

                }
                else if (!cbboxThuoctinhtim.Text.Equals("Khách hàng") && !cbboxThuoctinhtim.Text.Equals("Mã hóa đơn")
                    && !cbboxThuoctinhtim.Text.Equals("Mã NV") && !cbboxThuoctinhtim.Text.Equals("Tổng tiền"))
                {
                    MessageBox.Show("Sai thuộc tính tìm kiếm!");
                    return;
                }                               
            }
            try
            {
                SqlDataAdapter dap = new SqlDataAdapter(sql, con);
                dap.Fill(ds);
                dgvDSHoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvDSHoaDon.DataSource = ds.Tables[0];
                dgvDSHoaDon.Refresh();
            }
            catch
            {
                MessageBox.Show("Sai giá trị tìm kiếm!");               
            }

        }

        private void frmHDTrongNgay_Load(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            SqlConnection con = SQLConnector.GetSqlConnection();
            string sql = "SELECT * FROM tblHOADON WHERE MONTH(NgayXuat) = " + date.Month + "";
            DataSet ds = new DataSet();
            SqlDataAdapter dap = new SqlDataAdapter(sql, con);
            dap.Fill(ds);
            dgvDSHoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDSHoaDon.DataSource = ds.Tables[0];
            dgvDSHoaDon.Refresh();
        }

        private void btnXemChiTiet_Click(object sender, EventArgs e)
        {
            try
            {
                string maHoaDon = dgvDSHoaDon.CurrentRow.Cells["MaHoaDon"].Value.ToString();
                frmXemCTHoaDon xemCTHoaDon = new frmXemCTHoaDon(maHoaDon);
                xemCTHoaDon.Show();
            }
            catch
            {
                MessageBox.Show("Không có hóa đơn nào được chọn!");
            }
            
        }
    }
}
