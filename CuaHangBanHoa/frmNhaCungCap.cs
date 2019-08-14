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
    public partial class frmNhaCungCap : Form
    {
        public frmNhaCungCap()
        {
            InitializeComponent();
        }
        private void loadNCC(SqlConnection con)
        {
            String sql1 = "Select * from tblNCC";
            DataSet ds = new DataSet();
            SqlDataAdapter dap = new SqlDataAdapter(sql1, con);
            dap.Fill(ds);
            dgvNCC.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNCC.DataSource = ds.Tables[0];
            dgvNCC.Refresh();
        }

        private void frmNhaCungCap_Load(object sender, EventArgs e)
        {
            SqlConnection con = SQLConnector.GetSqlConnection();
            loadNCC(con);
        }

        private void huyThemXoa()
        {
            btnOK.Enabled = false;
            btnHuy.Enabled = false;

            txtDiaChi.Enabled = false;
            txtDienThoai.Enabled = false;
            txtMaNCC.Enabled = false;
            txtTenNCC.Enabled = false;
       
            txtDiaChi.Clear();
            txtTenNCC.Clear();
            txtDienThoai.Clear();
            txtMaNCC.Clear();
        }
        private void batThemXoa()
        {
            btnOK.Enabled = true;
            btnHuy.Enabled = true;

            txtDiaChi.Enabled = true;
            txtDienThoai.Enabled = true;
            txtMaNCC.Enabled = true;
            txtTenNCC.Enabled = true;

            txtDiaChi.Clear();
            txtTenNCC.Clear();
            txtDienThoai.Clear();
            txtMaNCC.Clear();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            SqlConnection con = SQLConnector.GetSqlConnection();
            String sql = "Select * from tblNCC";

            if (txtTimKiem.Text != "")
            {
                if (cbboxThuoctinhtim.Text.Equals("Tên NCC"))
                {
                    sql += " WHERE TenNCC = N'" + txtTimKiem.Text + "'";
                }
                if (cbboxThuoctinhtim.Text.Equals("Mã NCC"))
                {
                    sql += " WHERE MaNCC = N'" + txtTimKiem.Text + "'";
                }
                if (cbboxThuoctinhtim.Text.Equals("Địa chỉ"))
                {
                    sql += " WHERE DiaChi = N'" + txtTimKiem.Text + "'";
                }
                if (cbboxThuoctinhtim.Text.Equals("Điện thoại"))
                {
                    sql += " WHERE DienThoai = N'" + txtTimKiem.Text + "'";
                }

            }
            else if (cbboxThuoctinhtim.Text.Equals(""))
            {
                MessageBox.Show("Thiếu thuộc tính tìm kiếm!");

            }
            else if (!cbboxThuoctinhtim.Text.Equals("Tên NCC") && !cbboxThuoctinhtim.Text.Equals("Mã NCC")
                && !cbboxThuoctinhtim.Text.Equals("Địa chỉ") && !cbboxThuoctinhtim.Text.Equals("Điện thoại"))
            {
                MessageBox.Show("Sai thuộc tính tìm kiếm!");
            }

            try
            {
                DataSet ds = new DataSet();
                SqlDataAdapter dap = new SqlDataAdapter(sql, con);
                dap.Fill(ds);
                dgvNCC.DataSource = ds.Tables[0];
                dgvNCC.Refresh();
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
            txtMaNCC.Text = dgvNCC.CurrentRow.Cells["MaNCC"].Value.ToString();
            txtTenNCC.Text = dgvNCC.CurrentRow.Cells["TenNCC"].Value.ToString();
            txtDiaChi.Text = dgvNCC.CurrentRow.Cells["DiaChi"].Value.ToString();
            txtDienThoai.Text = dgvNCC.CurrentRow.Cells["DienThoai"].Value.ToString();
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Nhà cung cấp này sẽ bị xóa?", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dlr == DialogResult.Cancel)
            {
                return;
            }
            string error = "";
            SqlConnection con = SQLConnector.GetSqlConnection();

            foreach (DataGridViewRow row in dgvNCC.SelectedRows)
            {
                string maNCC = row.Cells["MaNCC"].Value.ToString();
                if (maNCC.Equals(""))
                {
                    continue;
                }
                String sql = "DELETE FROM tblNCC WHERE maNCC = N'" + maNCC + "'";               
                try
                {
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.ExecuteNonQuery();                                     
                }
                catch
                {
                    error += " " + maNCC + ", ";
                }
                
            }
            loadNCC(con);
            if (!error.Equals(""))
            {
                error = "Những nhà cung cấp không thể xóa: " + error;
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
            if (txtTenNCC.Text == "" || txtMaNCC.Text == "" || txtDiaChi.Text == "" || txtDienThoai.Text == "" )
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
                return;
            }
            SqlConnection con = SQLConnector.GetSqlConnection();
            if (lbChucNang.Text.Equals("Thêm Mới Dữ Liệu:"))
            {
                String sql = "INSERT INTO tblNCC(MaNCC, TenNCC, DiaChi, DienThoai)VALUES " +
                    "(N'" + txtMaNCC.Text + "',N'" + txtTenNCC.Text + "',N'" + txtDiaChi.Text + "',N'" + txtDienThoai.Text +"')";
                SqlCommand cmd = new SqlCommand(sql, con);
                try
                {
                    cmd.ExecuteNonQuery();
                    loadNCC(con);
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
                String maNCCBanDau = dgvNCC.CurrentRow.Cells["MaNCC"].Value.ToString();
                if (maNCCBanDau.Equals(""))
                {
                    MessageBox.Show("Không có nhà cung cấp nào được chọn!");
                    return;
                }
                String sql = "UPDATE tblNCC SET TenNCC = N'" + txtTenNCC.Text + "',MaNCC = N'" + txtMaNCC.Text + "'," +
                    "DiaChi =N'" + txtDiaChi.Text + "', DienThoai =N'" + txtDienThoai.Text + "' WHERE MaNCC = N'" + maNCCBanDau + "'";
                SqlCommand cmd = new SqlCommand(sql, con);
                try
                {
                    cmd.ExecuteNonQuery();
                    loadNCC(con);
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
