using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace CuaHangBanHoa
{
    public partial class frmHoa : Form
    {
        public frmHoa()
        {
            InitializeComponent();
        }

         
        private void huyThemXoa()
        {
            btnOK.Enabled = false;
            btnHuy.Enabled = false;
            txtMaHoa.Enabled = false;           
            txtTenHoa.Enabled = false;
            txtDonViTinh.Enabled = false;
            txtDonGiaNhap.Enabled = false;
            txtNCC.Enabled = false;
            txtGiaBan.Enabled = false;
            txtGiaBan.Clear();
            txtMaHoa.Clear();
            txtTenHoa.Clear();
            txtDonViTinh.Clear();
            txtDonGiaNhap.Clear();
            txtNCC.Clear();
            
        }
        private void batThemXoa()
        {
            btnOK.Enabled = true;
            txtMaHoa.Clear();
            txtTenHoa.Clear();
            txtDonViTinh.Clear();
            txtDonGiaNhap.Clear();
            txtNCC.Clear();
            txtGiaBan.Enabled = true;
            txtGiaBan.Clear();
            btnHuy.Enabled = true;
            txtMaHoa.Enabled = true;
            txtTenHoa.Enabled = true;
            txtDonViTinh.Enabled = true;
            txtDonGiaNhap.Enabled = true;
            txtNCC.Enabled = true;
        }


        private void LoadDGVDanhSachHoa(SqlConnection con)
        {
            String sql1 = "Select * from tblHOA";
            DataSet ds = new DataSet();
            SqlDataAdapter dap = new SqlDataAdapter(sql1, con);
            dap.Fill(ds);
            dgvDanhSachHoa.DataSource = ds.Tables[0];
            dgvDanhSachHoa.Refresh();          
        }

        private void frmHoa_Load(object sender, EventArgs e)
        {
            SqlConnection con = SQLConnector.GetSqlConnection();
            LoadDGVDanhSachHoa(con);
        }

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Huy_Click(object sender, EventArgs e)
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
            txtMaHoa.Text = dgvDanhSachHoa.CurrentRow.Cells["MaHoa"].Value.ToString();
            txtTenHoa.Text = dgvDanhSachHoa.CurrentRow.Cells["TenHoa"].Value.ToString();
            txtDonViTinh.Text = dgvDanhSachHoa.CurrentRow.Cells["DVTinh"].Value.ToString();
            txtDonGiaNhap.Text = dgvDanhSachHoa.CurrentRow.Cells["DonGiaNhap"].Value.ToString();
            txtGiaBan.Text = dgvDanhSachHoa.CurrentRow.Cells["GiaBan"].Value.ToString();
            txtNCC.Text = dgvDanhSachHoa.CurrentRow.Cells["MaNCC"].Value.ToString();
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Sản phẩm sẽ bị xóa?", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dlr == DialogResult.Cancel)
            {
                return;
            }
            string error = "";
            SqlConnection con = SQLConnector.GetSqlConnection();
            foreach (DataGridViewRow row in dgvDanhSachHoa.SelectedRows)
            {
                string maHoa = row.Cells["MaHoa"].Value.ToString();
                if (maHoa.Equals(""))
                {
                    continue;
                }
                
                String sql = "DELETE FROM tblHOA WHERE MaHoa = N'" + maHoa + "'";              
                try
                {
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.ExecuteNonQuery();                                      
                }
                catch
                {
                    error += " " +maHoa+ ", ";
                }               
            }
            LoadDGVDanhSachHoa(con);
            if (!error.Equals(""))
            {
                error = "Những sản phẩm không thể xóa: " + error;
                MessageBox.Show(error,"Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Xóa thành công!","Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtMaHoa.Text == "" || txtTenHoa.Text == "" || txtDonViTinh.Text == "" || txtDonGiaNhap.Text == "" || txtNCC.Text == "" || txtGiaBan.Text == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
                return;
            }
            SqlConnection con = SQLConnector.GetSqlConnection();
            if (lbChucNang.Text.Equals("Thêm Mới Dữ Liệu:"))
            { 
                String sql = "INSERT INTO tblHOA(MaHoa,TenHoa,DVTinh,DonGiaNhap,GiaBan,MaNCC)VALUES " +
                    "(N'" + txtMaHoa.Text + "',N'" + txtTenHoa.Text + "',N'" + txtDonViTinh.Text + "','" + 
                    txtDonGiaNhap.Text + "','" + txtGiaBan.Text + "',N'" + txtNCC.Text + "')";
                SqlCommand cmd = new SqlCommand(sql, con);
                try
                {
                    cmd.ExecuteNonQuery();
                    LoadDGVDanhSachHoa(con);
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
                String maBanDau = dgvDanhSachHoa.CurrentRow.Cells["MaHoa"].Value.ToString();
                if (maBanDau.Equals(""))
                {
                    MessageBox.Show("Không có hoa nào được chọn!");
                    return;
                }
                String sql = "UPDATE tblHOA SET MaHoa = N'" + txtMaHoa.Text + "',TenHoa = N'" + txtTenHoa.Text + "',DVTinh =N'" + txtDonViTinh.Text + "',DonGiaNhap=" + txtDonGiaNhap.Text + ",GiaBan=" + txtGiaBan.Text + ",MaNCC =N'" + txtNCC.Text + "' WHERE MaHoa = N'"+ maBanDau+"'";
                SqlCommand cmd = new SqlCommand(sql, con);
                try
                {
                    cmd.ExecuteNonQuery();
                    LoadDGVDanhSachHoa(con);
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

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            SqlConnection con = SQLConnector.GetSqlConnection();
            String sql = "Select * from tblHOA";
            if(txtTimKiem.Text != "")
            {
                if(cbboxThuoctinhtim.Text.Equals("Mã hoa"))
                {
                    sql += " WHERE MaHoa LIKE N'%" + txtTimKiem.Text + "%'";
                }
                if (cbboxThuoctinhtim.Text.Equals("Tên hoa"))
                {
                    sql += " WHERE TenHoa LIKE N'%" + txtTimKiem.Text + "%'";
                }
                if (cbboxThuoctinhtim.Text.Equals("Giá nhập"))
                {
                    sql += " WHERE DonGiaNhap= N'" + txtTimKiem.Text + "'";
                }
                if (cbboxThuoctinhtim.Text.Equals("Nhà cung cấp"))
                {
                    sql += " WHERE MaNCC= N'" + txtTimKiem.Text + "'";
                }   
            }
            else if (cbboxThuoctinhtim.Text.Equals(""))
            {
                MessageBox.Show("Thiếu thuộc tính tìm kiếm!");

            }
            else if (!cbboxThuoctinhtim.Text.Equals("Mã hoa") && !cbboxThuoctinhtim.Text.Equals("Tên hoa") && !cbboxThuoctinhtim.Text.Equals("Giá nhập") && !cbboxThuoctinhtim.Text.Equals("Nhà cung cấp"))
            {
                MessageBox.Show("Sai thuộc tính tìm kiếm!");
            }
            try
            {
                DataSet ds = new DataSet();
                SqlDataAdapter dap = new SqlDataAdapter(sql, con);
                dap.Fill(ds);
                dgvDanhSachHoa.DataSource = ds.Tables[0];
                dgvDanhSachHoa.Refresh();
            }
            catch
            {
                MessageBox.Show("Sai giá trị tìm kiếm!");
            }
        }







        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtMaHoa_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtTenHoa_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtDonViTinh_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtNCC_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDonGiaNhap_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
