using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace CuaHangBanHoa
{
    public partial class frmChiTietHoaDon : Form
    {
        public frmChiTietHoaDon()
        {
            InitializeComponent();
        }

        private void loadCTHoaDon(SqlConnection con)
        {
            String sql1 = "Select * from tblCTHOADON";
            DataSet ds = new DataSet();
            SqlDataAdapter dap = new SqlDataAdapter(sql1, con);
            dap.Fill(ds);
            dgvCTHoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCTHoaDon.DataSource = ds.Tables[0];
            dgvCTHoaDon.Refresh();
        }

        private void frmChiTietHoaDon_Load(object sender, EventArgs e)
        {
            SqlConnection con = SQLConnector.GetSqlConnection();
            loadCTHoaDon(con);
        }
        private void huyThemXoa()
        {
            btnOK.Enabled = false;
            btnHuy.Enabled = false;
            txtMaHoa.Enabled = false;
            txtMaHoaDon.Enabled = false;
            txtSoLuong.Enabled = false;
            txtThanhTien.Enabled = false;
            txtMaHoa.Clear();
            txtMaHoaDon.Clear();
            txtSoLuong.Clear();
            txtThanhTien.Clear();

        }
        private void batThemXoa()
        {
            btnOK.Enabled = true;
            txtMaHoa.Clear();
            txtMaHoaDon.Clear();
            txtSoLuong.Clear();
            txtThanhTien.Clear();
            btnHuy.Enabled = true;
            txtMaHoa.Enabled = true;
            txtMaHoaDon.Enabled = true;
            txtSoLuong.Enabled = true;
            txtThanhTien.Enabled = true;
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
                SqlConnection con = SQLConnector.GetSqlConnection();
                String sql = "Select * from tblCTHOADON";

                if (txtTimKiem.Text != "")
                {
                    if (cbboxThuoctinhtim.Text.Equals("Mã hoa"))
                    {
                        sql += " WHERE MaHoa= N'" + txtTimKiem.Text + "'";
                    }
                    if (cbboxThuoctinhtim.Text.Equals("Mã hóa đơn"))
                    {
                        sql += " WHERE MaHoaDon= N'" + txtTimKiem.Text + "'";
                    }
                    if (cbboxThuoctinhtim.Text.Equals("Số lượng"))
                    {
                        sql += " WHERE SoLuong= N'" + txtTimKiem.Text + "'";
                    }
                    if (cbboxThuoctinhtim.Text.Equals("Thành tiền"))
                    {
                        sql += " WHERE ThanhTien = N'" + txtTimKiem.Text + "'";
                    }
                }
                else if (cbboxThuoctinhtim.Text.Equals(""))
                {
                    MessageBox.Show("Thiếu thuộc tính tìm kiếm!");

                }
                else if (!cbboxThuoctinhtim.Text.Equals("Mã hoa") && !cbboxThuoctinhtim.Text.Equals("Mã hóa đơn") && !cbboxThuoctinhtim.Text.Equals("Giá bán") && !cbboxThuoctinhtim.Text.Equals("Số lượng") && !cbboxThuoctinhtim.Text.Equals("Thành tiền"))
                {
                    MessageBox.Show("Sai thuộc tính tìm kiếm!");

                }

                try
                {
                    DataSet ds = new DataSet();
                    SqlDataAdapter dap = new SqlDataAdapter(sql, con);
                    dap.Fill(ds);
                    dgvCTHoaDon.DataSource = ds.Tables[0];
                    dgvCTHoaDon.Refresh();
                }
                catch
                {
                    MessageBox.Show("Sai giá trị tìm kiếm!");
                }

             
        }

        private void btnOK_Click_1(object sender, EventArgs e)
        {
            if (txtMaHoa.Text == "" || txtMaHoaDon.Text == "" || txtSoLuong.Text == "" || txtThanhTien.Text == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
                return;
            }
            SqlConnection con = SQLConnector.GetSqlConnection();
            if (lbChucNang.Text.Equals("Thêm Mới Dữ Liệu:"))
            {
                String sql = "INSERT INTO tblCTHOADON(MaHoaDon,MaHoa,SoLuong,ThanhTien)VALUES (N'" + txtMaHoaDon.Text + "',N'" + txtMaHoa.Text + "',N'" + txtSoLuong.Text + "',N'" + txtThanhTien.Text + "')";
                SqlCommand cmd = new SqlCommand(sql, con);
                try
                {
                    cmd.ExecuteNonQuery();
                    loadCTHoaDon(con);
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
                String maHoaBanDau = dgvCTHoaDon.CurrentRow.Cells["MaHoa"].Value.ToString();
                String maHoaDonBanDau = dgvCTHoaDon.CurrentRow.Cells["MaHoaDon"].Value.ToString();
                if (maHoaBanDau.Equals("") || maHoaDonBanDau.Equals(""))
                {
                    MessageBox.Show("Không có hóa đơn nào được chọn!");
                    return;
                }
                String sql = "UPDATE tblCTHOADON SET MaHoa = N'" + txtMaHoa.Text + "',MaHoaDon = N'" + txtMaHoaDon.Text + "'," +
                    "SoLuong =N'" + txtSoLuong.Text + "',ThanhTien =N'" + txtThanhTien.Text + "' " +
                    "WHERE MaHoa = N'" + maHoaBanDau + "' AND MaHoaDon = N'" + maHoaDonBanDau + "'";
                SqlCommand cmd = new SqlCommand(sql, con);
                try
                {
                    cmd.ExecuteNonQuery();
                    loadCTHoaDon(con);
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

        private void btnHuy_Click_1(object sender, EventArgs e)
        {
            lbChucNang.ForeColor = Color.Black;
            lbChucNang.Text = "Thêm, sửa dữ liệu:";
            huyThemXoa();
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            lbChucNang.ForeColor = Color.Red;
            lbChucNang.Text = "Thêm Mới Dữ Liệu:";
            batThemXoa();
        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            lbChucNang.ForeColor = Color.Blue;
            lbChucNang.Text = "Sửa Dữ Liệu:";
            batThemXoa();
            txtMaHoa.Text = dgvCTHoaDon.CurrentRow.Cells["MaHoa"].Value.ToString();
            txtMaHoaDon.Text = dgvCTHoaDon.CurrentRow.Cells["MaHoaDon"].Value.ToString();
            txtSoLuong.Text = dgvCTHoaDon.CurrentRow.Cells["SoLuong"].Value.ToString();
            txtThanhTien.Text = dgvCTHoaDon.CurrentRow.Cells["ThanhTien"].Value.ToString();
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bản ghi này sẽ bị xóa?", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dlr == DialogResult.Cancel)
            {
                return;
            }
            string error ="";
            SqlConnection con = SQLConnector.GetSqlConnection();
            foreach (DataGridViewRow row in dgvCTHoaDon.SelectedRows)
            {
                string maHoa = row.Cells["MaHoa"].Value.ToString();
                string maHoaDon = dgvCTHoaDon.CurrentRow.Cells["MaHoaDon"].Value.ToString();
                if (maHoa.Equals("") && maHoaDon.Equals(""))
                {
                    continue;
                }
                String sql = "DELETE FROM tblCTHOADON WHERE MaHoa = N'" + maHoa + "' AND MaHoaDon = N'" + maHoaDon + "'";                
                try
                {
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.ExecuteNonQuery();
                }
                catch
                {
                    error += " " + maHoaDon + ", ";
                }
               
            }
            loadCTHoaDon(con);
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

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
