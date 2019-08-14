namespace CuaHangBanHoa
{
    partial class frmTaoHoaDon
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTaoHoaDon));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnXoaSp = new System.Windows.Forms.Button();
            this.btnXoaDuLieu = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTaoHD = new System.Windows.Forms.Button();
            this.btnTinhTien = new System.Windows.Forms.Button();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.llbsdtkhach = new System.Windows.Forms.Label();
            this.txtTenKhach = new System.Windows.Forms.TextBox();
            this.lbTenKhach = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvDanhSachMatHang = new System.Windows.Forms.DataGridView();
            this.MaHoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenHoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachMatHang)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnXoaSp);
            this.groupBox1.Controls.Add(this.btnXoaDuLieu);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnTaoHD);
            this.groupBox1.Controls.Add(this.btnTinhTien);
            this.groupBox1.Controls.Add(this.txtMaNV);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtDiaChi);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtSDT);
            this.groupBox1.Controls.Add(this.llbsdtkhach);
            this.groupBox1.Controls.Add(this.txtTenKhach);
            this.groupBox1.Controls.Add(this.lbTenKhach);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1172, 184);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnXoaSp
            // 
            this.btnXoaSp.Location = new System.Drawing.Point(838, 104);
            this.btnXoaSp.Name = "btnXoaSp";
            this.btnXoaSp.Size = new System.Drawing.Size(140, 40);
            this.btnXoaSp.TabIndex = 6;
            this.btnXoaSp.Text = "&Xóa Sản Phẩm";
            this.btnXoaSp.UseVisualStyleBackColor = true;
            this.btnXoaSp.Click += new System.EventHandler(this.btnXoaSp_Click);
            // 
            // btnXoaDuLieu
            // 
            this.btnXoaDuLieu.Location = new System.Drawing.Point(1003, 104);
            this.btnXoaDuLieu.Name = "btnXoaDuLieu";
            this.btnXoaDuLieu.Size = new System.Drawing.Size(156, 40);
            this.btnXoaDuLieu.TabIndex = 7;
            this.btnXoaDuLieu.Text = "&Nhập mới";
            this.btnXoaDuLieu.UseVisualStyleBackColor = true;
            this.btnXoaDuLieu.Click += new System.EventHandler(this.btnXoaDuLieu_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(437, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(263, 46);
            this.label7.TabIndex = 26;
            this.label7.Text = "Hóa đơn bán lẻ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(91, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 18);
            this.label5.TabIndex = 25;
            this.label5.Text = "ĐT: 0353113548";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(234, 18);
            this.label6.TabIndex = 24;
            this.label6.Text = "Số 10/4 đường G, HVNN Việt Nam";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(45, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 57);
            this.label1.TabIndex = 23;
            this.label1.Text = "Sky Garden";
            // 
            // btnTaoHD
            // 
            this.btnTaoHD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnTaoHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaoHD.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnTaoHD.Location = new System.Drawing.Point(1003, 41);
            this.btnTaoHD.Name = "btnTaoHD";
            this.btnTaoHD.Size = new System.Drawing.Size(156, 44);
            this.btnTaoHD.TabIndex = 5;
            this.btnTaoHD.Text = "Tạo &Hóa Đơn";
            this.btnTaoHD.UseVisualStyleBackColor = false;
            this.btnTaoHD.Click += new System.EventHandler(this.btnTaoHD_Click);
            // 
            // btnTinhTien
            // 
            this.btnTinhTien.Location = new System.Drawing.Point(838, 41);
            this.btnTinhTien.Name = "btnTinhTien";
            this.btnTinhTien.Size = new System.Drawing.Size(140, 40);
            this.btnTinhTien.TabIndex = 4;
            this.btnTinhTien.Text = "&Tính Tiền";
            this.btnTinhTien.UseVisualStyleBackColor = true;
            this.btnTinhTien.Click += new System.EventHandler(this.btnTinhTien_Click);
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(664, 84);
            this.txtMaNV.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(151, 24);
            this.txtMaNV.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(592, 84);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Mã NV:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(443, 84);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(2);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(144, 24);
            this.txtDiaChi.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(332, 84);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Địa chỉ:";
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(664, 41);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(2);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(151, 24);
            this.txtSDT.TabIndex = 1;
            // 
            // llbsdtkhach
            // 
            this.llbsdtkhach.AutoSize = true;
            this.llbsdtkhach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbsdtkhach.Location = new System.Drawing.Point(608, 41);
            this.llbsdtkhach.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.llbsdtkhach.Name = "llbsdtkhach";
            this.llbsdtkhach.Size = new System.Drawing.Size(45, 20);
            this.llbsdtkhach.TabIndex = 11;
            this.llbsdtkhach.Text = "SDT:";
            // 
            // txtTenKhach
            // 
            this.txtTenKhach.Location = new System.Drawing.Point(443, 41);
            this.txtTenKhach.Margin = new System.Windows.Forms.Padding(2);
            this.txtTenKhach.Name = "txtTenKhach";
            this.txtTenKhach.Size = new System.Drawing.Size(144, 24);
            this.txtTenKhach.TabIndex = 0;
            // 
            // lbTenKhach
            // 
            this.lbTenKhach.AutoSize = true;
            this.lbTenKhach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenKhach.Location = new System.Drawing.Point(332, 41);
            this.lbTenKhach.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTenKhach.Name = "lbTenKhach";
            this.lbTenKhach.Size = new System.Drawing.Size(98, 20);
            this.lbTenKhach.TabIndex = 9;
            this.lbTenKhach.Text = "Khách hàng:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtTongTien);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 573);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1172, 79);
            this.panel1.TabIndex = 1;
            // 
            // txtTongTien
            // 
            this.txtTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongTien.Location = new System.Drawing.Point(865, 5);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.ReadOnly = true;
            this.txtTongTien.Size = new System.Drawing.Size(294, 24);
            this.txtTongTien.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(768, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tổng tiền:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvDanhSachMatHang);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 184);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1172, 389);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi tiết mặt hàng";
            // 
            // dgvDanhSachMatHang
            // 
            this.dgvDanhSachMatHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachMatHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHoa,
            this.TenHoa,
            this.SoLuong,
            this.DonGia,
            this.ThanhTien});
            this.dgvDanhSachMatHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDanhSachMatHang.Location = new System.Drawing.Point(3, 20);
            this.dgvDanhSachMatHang.Name = "dgvDanhSachMatHang";
            this.dgvDanhSachMatHang.Size = new System.Drawing.Size(1166, 366);
            this.dgvDanhSachMatHang.TabIndex = 0;
            this.dgvDanhSachMatHang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSachMatHang_CellContentClick);
            // 
            // MaHoa
            // 
            this.MaHoa.DataPropertyName = "MaHoa";
            this.MaHoa.HeaderText = "Mã Sản Phẩm";
            this.MaHoa.Name = "MaHoa";
            // 
            // TenHoa
            // 
            this.TenHoa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.TenHoa.DataPropertyName = "TenHoa";
            this.TenHoa.HeaderText = "Tên Sản Phẩm";
            this.TenHoa.Name = "TenHoa";
            this.TenHoa.ReadOnly = true;
            this.TenHoa.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TenHoa.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.TenHoa.Width = 310;
            // 
            // SoLuong
            // 
            this.SoLuong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.SoLuong.DataPropertyName = "SoLuong";
            dataGridViewCellStyle1.Format = "N0";
            dataGridViewCellStyle1.NullValue = "0";
            this.SoLuong.DefaultCellStyle = dataGridViewCellStyle1;
            this.SoLuong.HeaderText = "Số Lượng ";
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.Width = 150;
            // 
            // DonGia
            // 
            this.DonGia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.DonGia.DataPropertyName = "DonGia";
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = "0";
            this.DonGia.DefaultCellStyle = dataGridViewCellStyle2;
            this.DonGia.HeaderText = "Đơn Giá";
            this.DonGia.Name = "DonGia";
            this.DonGia.ReadOnly = true;
            this.DonGia.Width = 250;
            // 
            // ThanhTien
            // 
            this.ThanhTien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ThanhTien.DataPropertyName = "ThanhTien";
            dataGridViewCellStyle3.Format = "N0";
            dataGridViewCellStyle3.NullValue = "0";
            this.ThanhTien.DefaultCellStyle = dataGridViewCellStyle3;
            this.ThanhTien.HeaderText = "Thành Tiền";
            this.ThanhTien.Name = "ThanhTien";
            this.ThanhTien.ReadOnly = true;
            this.ThanhTien.Width = 310;
            // 
            // frmTaoHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 652);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTaoHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TaoHoaDon";
            this.Load += new System.EventHandler(this.frmTaoHoaDon_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachMatHang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label llbsdtkhach;
        private System.Windows.Forms.TextBox txtTenKhach;
        private System.Windows.Forms.Label lbTenKhach;
        private System.Windows.Forms.DataGridView dgvDanhSachMatHang;
        private System.Windows.Forms.Button btnTinhTien;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnTaoHD;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnXoaDuLieu;
        private System.Windows.Forms.Button btnXoaSp;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenHoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
    }
}