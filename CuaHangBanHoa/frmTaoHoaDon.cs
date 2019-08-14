using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.Data.Common;

namespace CuaHangBanHoa
{
    public partial class frmTaoHoaDon : Form
    {
        public frmTaoHoaDon()
        {
            InitializeComponent();
        }

     

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void frmTaoHoaDon_Load(object sender, EventArgs e1)
        {
            
        }
        private void DataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs anError)
        {

            MessageBox.Show("Error happened " + anError.Context.ToString());

            if (anError.Context == DataGridViewDataErrorContexts.Commit)
            {
                MessageBox.Show("Commit error");
            }
            if (anError.Context == DataGridViewDataErrorContexts.CurrentCellChange)
            {
                MessageBox.Show("Cell change");
            }
            if (anError.Context == DataGridViewDataErrorContexts.Parsing)
            {
                MessageBox.Show("parsing error");
            }
            if (anError.Context == DataGridViewDataErrorContexts.LeaveControl)
            {
                MessageBox.Show("leave control error");
            }

            if ((anError.Exception) is ConstraintException)
            {
                DataGridView view = (DataGridView)sender;
                view.Rows[anError.RowIndex].ErrorText = "an error";
                view.Rows[anError.RowIndex].Cells[anError.ColumnIndex].ErrorText = "an error";

                anError.ThrowException = false;
            }
        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            int soLuong;
            float donGia;                        
            float tongTien = 0;
            //lấy ra tên hoa và giá bán            
            for (int i = 0; i < dgvDanhSachMatHang.RowCount - 1; i = i + 1)
            {
                if (dgvDanhSachMatHang.Rows[i].Cells["SoLuong"].Value == null || dgvDanhSachMatHang.Rows[i].Cells["MaHoa"].Value == null)
                {
                    MessageBox.Show("chưa nhập đủ giá trị sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string maHoa = dgvDanhSachMatHang.Rows[i].Cells["MaHoa"].Value.ToString();
                SqlConnection con = SQLConnector.GetSqlConnection();
                string sql = "SELECT TenHoa,GiaBan FROM tblHOA WHERE MaHoa = '"+ maHoa +"' ";
                SqlCommand cmd = new SqlCommand(sql, con);
                using (DbDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            int tenHoaOr = reader.GetOrdinal("TenHoa");
                            dgvDanhSachMatHang.Rows[i].Cells["TenHoa"].Value = reader.GetString(tenHoaOr);
                            int giaBanOr = reader.GetOrdinal("GiaBan");
                            dgvDanhSachMatHang.Rows[i].Cells["DonGia"].Value = reader.GetDecimal(giaBanOr);                                                         
                        }
                    }
                }
            }
            for (int i = 0; i < dgvDanhSachMatHang.RowCount - 1; i = i + 1)
            {
                if(dgvDanhSachMatHang.Rows[i].Cells["DonGia"].Value == null)
                {
                    return;
                }
                // tính tiền
                string sl = dgvDanhSachMatHang.Rows[i].Cells["SoLuong"].Value.ToString();
                string dg = dgvDanhSachMatHang.Rows[i].Cells["DonGia"].Value.ToString();
                try
                {
                    soLuong = Int32.Parse(sl);
                    donGia = float.Parse(dg);
                }
                catch
                {
                    MessageBox.Show("Nhập sai giá trị số lượng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                dgvDanhSachMatHang.Rows[i].Cells["ThanhTien"].Value = soLuong * donGia;
                string tong = dgvDanhSachMatHang.Rows[i].Cells["ThanhTien"].Value.ToString();
                tongTien += float.Parse(tong);
            }
            txtTongTien.Text = tongTien.ToString() ;

        }
                

        private void dgvDanhSachMatHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       

        private void btnTaoHD_Click(object sender, EventArgs e)
        {
            if(txtDiaChi.Text == "" || txtMaNV.Text == "" || txtSDT.Text == "" || txtTenKhach.Text == "" || dgvDanhSachMatHang.RowCount <= 1)
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin hóa đơn!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            btnTinhTien_Click(sender, e);

            SqlConnection con = SQLConnector.GetSqlConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;                       
            cmd.Connection = con;
            SqlTransaction tran;
            tran = con.BeginTransaction();
            cmd.Transaction = tran;
            
            //thêm dl vào bảng hóa đơn
            DateTime date = DateTime.Now;
            long lastID = -1;

            string sql1 = "INSERT INTO tblHOADON(NgayXuat,TenKH,MaNV,SDTKhach,DiaChiKhach,TongTien) " +
               "VALUES(N'" + date.ToShortDateString() + "',N'" + txtTenKhach.Text + "',N'" + txtMaNV.Text 
               + "',N'" + txtSDT.Text + "',N'" + txtDiaChi.Text + "',N'"+txtTongTien.Text+"')";

            try
            {
                cmd.CommandText = sql1;
                cmd.ExecuteNonQuery();                
                //Lấy ra id cuối cùng trong bảng Hóa Đơn                
                string sql2 = "SELECT MAX(MaHoaDon) as lastID FROM tblHOADON ";
                cmd.CommandText = sql2;
                using (DbDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            int idIndex = reader.GetOrdinal("lastID");
                            lastID = reader.GetInt64(idIndex);
                        }
                    }
                }
            }
            catch
            {               
                MessageBox.Show("Có lỗi xảy ra, hãy kiểm tra lại thông tin hóa đơn","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);             
                return;
            }
            //thêm dl vào bảng chi tiết hóa đơn
            try
            {
                for (int i = 0; i < dgvDanhSachMatHang.RowCount - 1; i++)
                {
                    string maHoa = dgvDanhSachMatHang.Rows[i].Cells["MaHoa"].Value.ToString();
                    string soLuong = dgvDanhSachMatHang.Rows[i].Cells["SoLuong"].Value.ToString();
                    string thanhTien = dgvDanhSachMatHang.Rows[i].Cells["ThanhTien"].Value.ToString();
                    string sql = "INSERT INTO tblCTHOADON(MaHoaDon, MaHoa, SoLuong, ThanhTien) " +
                        "VALUES(" + lastID + ",N'" + maHoa + "',N'" + soLuong + "',N'" + thanhTien + "')";
                   
                        cmd.CommandText = sql;
                        cmd.ExecuteNonQuery();                        
                    }
                tran.Commit();
            }
            catch(Exception ex)
            {                
                MessageBox.Show("Có lỗi xảy ra, kiểm tra lại thông tin hóa đơn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //rollback dữ liệu sai
                try
                {
                    tran.Rollback();
                }
                catch (Exception ex2)
                {
                    Console.WriteLine(ex2.Message);
                }
                return;
            }
            
         
            MessageBox.Show("Tạo hóa đơn thành công!","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnXoaDuLieu_Click(object sender, EventArgs e)
        {
            txtDiaChi.Clear();
            txtMaNV.Clear();
            txtSDT.Clear();
            txtTenKhach.Clear();
            txtTongTien.Clear();
            dgvDanhSachMatHang.Rows.Clear();
        }

        private void btnXoaSp_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvDanhSachMatHang.SelectedRows)
            {
                try
                {
                    dgvDanhSachMatHang.Rows.Remove(row);
                }
                catch
                {
                    return;
                }
            }
        }
    }
    }

