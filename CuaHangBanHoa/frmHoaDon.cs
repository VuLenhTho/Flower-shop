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
    public partial class frmHoaDon : Form
    {
        public frmHoaDon()
        {
            InitializeComponent();
        }
        private void loadHoaDon(SqlConnection con)
        {
            String sql1 = "Select * from tblHOADON";
            DataSet ds = new DataSet();
            SqlDataAdapter dap = new SqlDataAdapter(sql1, con);
            dap.Fill(ds);
            dgvHoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHoaDon.DataSource = ds.Tables[0];
            dgvHoaDon.Refresh();
        }

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            SqlConnection con = SQLConnector.GetSqlConnection();
            loadHoaDon(con);
        }
        private void huyThemXoa()
        {
            btnOK.Enabled = false;
            btnHuy.Enabled = false;

            txtDiaChi.Enabled = false;
            txtMaHoaDon.Enabled = false;
            txtKhachHang.Enabled = false;
            dtpNgayXuat.Enabled = false;
            txtMaNV.Enabled = false;
            txtSDT.Enabled = false;
            txtTongTien.Enabled = false;

            txtMaHoaDon.Clear();
            txtKhachHang.Clear();
            txtDiaChi.Clear();
            txtMaNV.Clear();
            txtSDT.Clear();            
            txtTongTien.Clear();
        }
        private void batThemXoa()
        {
            btnOK.Enabled = true;
            btnHuy.Enabled = true;

            txtDiaChi.Enabled = true;
            txtMaHoaDon.Enabled = true;
            txtKhachHang.Enabled = true;
            dtpNgayXuat.Enabled = true;
            txtMaNV.Enabled = true;
            txtSDT.Enabled = true;
            txtTongTien.Enabled = true;

            txtMaHoaDon.Clear();
            txtKhachHang.Clear();
            txtDiaChi.Clear();
            txtMaNV.Clear();
            txtSDT.Clear();
            txtTongTien.Clear();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            SqlConnection con = SQLConnector.GetSqlConnection();
            String sql = "Select * from tblHOADON";

            if (txtTimKiem.Text != "")
            {
                if (cbboxThuoctinhtim.Text.Equals("Khách hàng"))
                {
                    sql += " WHERE TenKH = N'" + txtTimKiem.Text + "'";
                }
                if (cbboxThuoctinhtim.Text.Equals("Mã hóa đơn"))
                {
                    sql += " WHERE MaHoaDon= N'" + txtTimKiem.Text + "'";
                }
                if (cbboxThuoctinhtim.Text.Equals("Mã NV"))
                {
                    sql += " WHERE MaNV = N'" + txtTimKiem.Text + "'";
                }
                if (cbboxThuoctinhtim.Text.Equals("Ngày xuất"))
                {
                    sql += " WHERE NgayXuat = N'" + txtTimKiem.Text + "'";
                }
                
            }
            else if (cbboxThuoctinhtim.Text.Equals(""))
            {
                MessageBox.Show("Thiếu thuộc tính tìm kiếm!");

            }
            else if (!cbboxThuoctinhtim.Text.Equals("Khách hàng") && !cbboxThuoctinhtim.Text.Equals("Mã hóa đơn") 
                && !cbboxThuoctinhtim.Text.Equals("Mã NV") && !cbboxThuoctinhtim.Text.Equals("Ngày xuất") )
            {
                MessageBox.Show("Sai thuộc tính tìm kiếm!");

            }

            try
            {
                DataSet ds = new DataSet();
                SqlDataAdapter dap = new SqlDataAdapter(sql, con);
                dap.Fill(ds);
                dgvHoaDon.DataSource = ds.Tables[0];
                dgvHoaDon.Refresh();
            }
            catch
            {
                MessageBox.Show("Sai giá trị tìm kiếm!");
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            lbChucNang.ForeColor = Color.Red;
            lbChucNang.Text = "Thêm Mới Dữ Liệu:";
            batThemXoa();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            lbChucNang.ForeColor = Color.Blue;
            lbChucNang.Text = "Sửa Dữ Liệu:";
            batThemXoa();
            txtKhachHang.Text = dgvHoaDon.CurrentRow.Cells["TenKH"].Value.ToString();
            txtMaHoaDon.Text = dgvHoaDon.CurrentRow.Cells["MaHoaDon"].Value.ToString();
            txtDiaChi.Text = dgvHoaDon.CurrentRow.Cells["DiaChiKhach"].Value.ToString();
            txtMaNV.Text = dgvHoaDon.CurrentRow.Cells["MaNV"].Value.ToString();
            dtpNgayXuat.Text = dgvHoaDon.CurrentRow.Cells["NgayXuat"].Value.ToString();
            txtSDT.Text = dgvHoaDon.CurrentRow.Cells["SDTKhach"].Value.ToString();
            txtTongTien.Text = dgvHoaDon.CurrentRow.Cells["TongTien"].Value.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Hóa đơn sẽ bị xóa?", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dlr == DialogResult.Cancel)
            {
                return;
            }
            SqlConnection con = SQLConnector.GetSqlConnection();
            string error = "";
            foreach (DataGridViewRow row in dgvHoaDon.SelectedRows)
            {
                string maHoaDon = row.Cells["MaHoaDon"].Value.ToString();
                if (maHoaDon.Equals(""))
                {
                    continue;
                }                
                String sql = "DELETE FROM tblHOADON WHERE MaHoaDon = N'" + maHoaDon + "'";
                String sql1 = "DELETE FROM tblCTHOADON WHERE MaHoaDon = N'" + maHoaDon + "'";                
                try
                {
                    SqlCommand cmd = new SqlCommand(sql1, con);
                    cmd.ExecuteNonQuery();
                    SqlCommand cmd1 = new SqlCommand(sql, con);
                    cmd1.ExecuteNonQuery();
                }
                catch
                {
                    error += " " + maHoaDon + ", ";
                }               
            }
            loadHoaDon(con);
            if (!error.Equals(""))
            {
                error = "Những hóa đơn không thể xóa: " + error;
                MessageBox.Show(error, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtKhachHang.Text == "" || txtMaHoaDon.Text == "" || txtDiaChi.Text == "" || txtMaNV.Text == "" || dtpNgayXuat.Text == "" || txtSDT.Text == "" || txtTongTien.Text == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
                return;
            }
            SqlConnection con = SQLConnector.GetSqlConnection();
            if (lbChucNang.Text.Equals("Thêm Mới Dữ Liệu:"))
            {
                String sql = "INSERT INTO tblHOADON(MaHoaDon,NgayXuat,TenKH,MaNV,SDTKhach,DiaChiKhach,TongTien)VALUES " +
                    "(N'" + txtMaHoaDon.Text + "',N'" + dtpNgayXuat.Text + "',N'" + txtKhachHang.Text + "','" + txtMaNV.Text + 
                    "',N'" + txtSDT.Text + "',N'" + txtDiaChi.Text + "',N'" + txtTongTien.Text + "')";
                SqlCommand cmd = new SqlCommand(sql, con);
                try
                {
                    cmd.ExecuteNonQuery();
                    loadHoaDon(con);
                    MessageBox.Show("Thêm mới thành công!");
                }
                catch
                {
                    MessageBox.Show("Thêm mới thất bại! Vui lòng kiểm tra lại thông tin đã nhập!");
                }
                finally
                {
                    con.Close();
                }
            }
            else if (lbChucNang.Text.Equals("Sửa Dữ Liệu:"))
            {
                String maHoaDonBanDau = dgvHoaDon.CurrentRow.Cells["MaHoaDon"].Value.ToString();
                if ( maHoaDonBanDau.Equals(""))
                {
                    MessageBox.Show("Không có hóa đơn nào được chọn!");
                    return;
                }
                String sql = "UPDATE tblHOADON SET NgayXuat = N'" + dtpNgayXuat.Text + "',MaHoaDon = N'" + txtMaHoaDon.Text + "'," +
                    "TenKH =N'" + txtKhachHang.Text + "',MaNV=N'" + txtMaNV.Text + "',SDTKhach =N'" + txtSDT.Text + "',DiaChiKhach=N'" + txtDiaChi.Text + "',TongTien=N'" + txtTongTien.Text + "' " +
                    "WHERE MaHoaDon = N'" + maHoaDonBanDau + "'";
                SqlCommand cmd = new SqlCommand(sql, con);
                try
                {
                    cmd.ExecuteNonQuery();
                    loadHoaDon(con);
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
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            lbChucNang.ForeColor = Color.Black;
            lbChucNang.Text = "Thêm, sửa dữ liệu:";
            huyThemXoa();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string maHoaDon = dgvHoaDon.CurrentRow.Cells["MaHoaDon"].Value.ToString();
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
