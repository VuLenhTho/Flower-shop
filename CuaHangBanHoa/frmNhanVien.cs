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
    public partial class frmNhanVien : Form
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void loadNV(SqlConnection con)
        {
            String sql1 = "Select * from tblNHANVIEN";
            DataSet ds = new DataSet();
            SqlDataAdapter dap = new SqlDataAdapter(sql1, con);
            dap.Fill(ds);
            dgvHoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHoaDon.DataSource = ds.Tables[0];
            dgvHoaDon.Refresh();
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            SqlConnection con = SQLConnector.GetSqlConnection();
            loadNV(con);
        }

        private void huyThemXoa()
        {
            btnOK.Enabled = false;
            btnHuy.Enabled = false;

            txtDiaChi.Enabled = false;
            txtMaNV.Enabled = false;
            txtSDT.Enabled = false;
            txtTenNV.Enabled = false;
            dtpNgaySinh.Enabled = false;
            cbxGioiTinh.Enabled = false;

            txtTenNV.Clear();
            txtDiaChi.Clear();
            txtMaNV.Clear();
            txtSDT.Clear();
        }
        private void batThemXoa()
        {
            btnOK.Enabled = true;
            btnHuy.Enabled = true;

            txtDiaChi.Enabled = true;
            txtMaNV.Enabled = true;
            txtSDT.Enabled = true;
            txtTenNV.Enabled = true;
            dtpNgaySinh.Enabled = true;
            cbxGioiTinh.Enabled = true;

            txtTenNV.Clear();
            txtDiaChi.Clear();
            txtMaNV.Clear();
            txtSDT.Clear();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            SqlConnection con = SQLConnector.GetSqlConnection();
            String sql = "Select * from tblNHANVIEN";

            if (txtTimKiem.Text != "")
            {
                if (cbboxThuoctinhtim.Text.Equals("Tên NV"))
                {
                    sql += " WHERE TenNV = N'" + txtTimKiem.Text + "'";
                }
                if (cbboxThuoctinhtim.Text.Equals("Mã NV"))
                {
                    sql += " WHERE MaNV = N'" + txtTimKiem.Text + "'";
                }
                if (cbboxThuoctinhtim.Text.Equals("Giới Tính"))
                {
                    sql += " WHERE GioiTinh = N'" + txtTimKiem.Text + "'";
                }
                if (cbboxThuoctinhtim.Text.Equals("SDT"))
                {
                    sql += " WHERE SDT = N'" + txtTimKiem.Text + "'";
                }

            }
            else if (cbboxThuoctinhtim.Text.Equals(""))
            {
                MessageBox.Show("Thiếu thuộc tính tìm kiếm!");

            }
            else if (!cbboxThuoctinhtim.Text.Equals("Tên NV") && !cbboxThuoctinhtim.Text.Equals("Giới Tính")
                && !cbboxThuoctinhtim.Text.Equals("Mã NV") && !cbboxThuoctinhtim.Text.Equals("SDT"))
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
            txtTenNV.Text = dgvHoaDon.CurrentRow.Cells["TenNV"].Value.ToString();
            txtDiaChi.Text = dgvHoaDon.CurrentRow.Cells["DiaChi"].Value.ToString();
            txtMaNV.Text = dgvHoaDon.CurrentRow.Cells["MaNV"].Value.ToString();
            dtpNgaySinh.Text = dgvHoaDon.CurrentRow.Cells["NgaySinh"].Value.ToString();
            txtSDT.Text = dgvHoaDon.CurrentRow.Cells["SDT"].Value.ToString();
            cbxGioiTinh.Text = dgvHoaDon.CurrentRow.Cells["GioiTinh"].Value.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Nhân viên này sẽ bị xóa?", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dlr == DialogResult.Cancel)
            {
                return;
            }
            SqlConnection con = SQLConnector.GetSqlConnection();
            string error = "";
            foreach (DataGridViewRow row in dgvHoaDon.SelectedRows)
            {
                string maNV = row.Cells["MaNV"].Value.ToString();
                if (maNV.Equals(""))
                {
                    continue;
                }
                String sql = "DELETE FROM tblNHANVIEN WHERE MaNV = N'" + maNV + "'";
                try
                {
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.ExecuteNonQuery();                    
                }
                catch
                {
                    error += " " + maNV + ", ";
                }
               
            }
            loadNV(con);
            if (!error.Equals(""))
            {
                error = "Những nhân viên không thể xóa: " + error;
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
            if (txtSDT.Text == "" || dtpNgaySinh.Text == "" || txtDiaChi.Text == "" || txtMaNV.Text == "" || cbxGioiTinh.Text == "" || txtTenNV.Text == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
                return;
            }
            SqlConnection con = SQLConnector.GetSqlConnection();
            if (lbChucNang.Text.Equals("Thêm Mới Dữ Liệu:"))
            {
                String sql = "INSERT INTO tblNHANVIEN(MaNV, TenNV, SDT, DiaChi, NgaySinh, GioiTinh)VALUES " +
                    "(N'" + txtMaNV.Text + "',N'" + txtTenNV.Text + "',N'" + txtSDT.Text + "',N'" + txtDiaChi.Text +
                    "',N'" + dtpNgaySinh.Text + "',N'" + cbxGioiTinh.Text + "')";
                SqlCommand cmd = new SqlCommand(sql, con);
                try
                {
                    cmd.ExecuteNonQuery();
                    loadNV(con);
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
                String maNVBanDau = dgvHoaDon.CurrentRow.Cells["MaNV"].Value.ToString();
                if (maNVBanDau.Equals(""))
                {
                    MessageBox.Show("Không có nhân viên nào được chọn!");
                    return;
                }
                String sql = "UPDATE tblNHANVIEN SET TenNV = N'" + txtTenNV.Text + "',NgaySinh = N'" + dtpNgaySinh.Text + "'," +
                    "GioiTinh =N'" + cbxGioiTinh.Text + "',MaNV=N'" + txtMaNV.Text + "',SDT =N'" + txtSDT.Text + "',DiaChi =N'" + txtDiaChi.Text + "'" +
                    "WHERE MaNV = N'" + maNVBanDau + "'";
                SqlCommand cmd = new SqlCommand(sql, con);
                try
                {
                    cmd.ExecuteNonQuery();
                    loadNV(con);
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
    }
}
