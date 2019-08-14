namespace CuaHangBanHoa
{
    partial class FrmHome
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHome));
            this.panelTop = new System.Windows.Forms.Panel();
            this.lbXinChao = new System.Windows.Forms.Label();
            this.lb1 = new System.Windows.Forms.Label();
            this.lbTieuDe = new System.Windows.Forms.Label();
            this.panelBot = new System.Windows.Forms.Panel();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.btnDangnhap = new System.Windows.Forms.Button();
            this.btnBaoCao = new System.Windows.Forms.Button();
            this.btnDuLieu = new System.Windows.Forms.Button();
            this.btnXemHoaDon = new System.Windows.Forms.Button();
            this.btnTaoHoaDon = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.grBoxTimKiem = new System.Windows.Forms.GroupBox();
            this.btnXoaBoLoc = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTenSp = new System.Windows.Forms.TextBox();
            this.txtGiaTu = new System.Windows.Forms.TextBox();
            this.txtGiaDen = new System.Windows.Forms.TextBox();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.lbGiaDen = new System.Windows.Forms.Label();
            this.lbGiaTu = new System.Windows.Forms.Label();
            this.lbTenSP = new System.Windows.Forms.Label();
            this.lbMaSP = new System.Windows.Forms.Label();
            this.lbtimkiem = new System.Windows.Forms.Label();
            this.dgvDanhSachSanPham = new System.Windows.Forms.DataGridView();
            this.MaHoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenHoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DVTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelTop.SuspendLayout();
            this.panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.grBoxTimKiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachSanPham)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.LightBlue;
            this.panelTop.Controls.Add(this.lbXinChao);
            this.panelTop.Controls.Add(this.lb1);
            this.panelTop.Controls.Add(this.lbTieuDe);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1265, 80);
            this.panelTop.TabIndex = 1;
            this.panelTop.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTop_Paint);
            // 
            // lbXinChao
            // 
            this.lbXinChao.AutoSize = true;
            this.lbXinChao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbXinChao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbXinChao.Location = new System.Drawing.Point(1073, 9);
            this.lbXinChao.Name = "lbXinChao";
            this.lbXinChao.Size = new System.Drawing.Size(0, 18);
            this.lbXinChao.TabIndex = 2;
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Location = new System.Drawing.Point(1030, 9);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(0, 13);
            this.lb1.TabIndex = 1;
            // 
            // lbTieuDe
            // 
            this.lbTieuDe.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbTieuDe.AutoSize = true;
            this.lbTieuDe.Font = new System.Drawing.Font("Times New Roman", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.lbTieuDe.ForeColor = System.Drawing.Color.Red;
            this.lbTieuDe.Location = new System.Drawing.Point(482, 13);
            this.lbTieuDe.Name = "lbTieuDe";
            this.lbTieuDe.Size = new System.Drawing.Size(315, 40);
            this.lbTieuDe.TabIndex = 0;
            this.lbTieuDe.Text = "Quản Lý Cửa Hàng";
            this.lbTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelBot
            // 
            this.panelBot.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panelBot.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBot.ForeColor = System.Drawing.Color.Green;
            this.panelBot.Location = new System.Drawing.Point(0, 642);
            this.panelBot.Name = "panelBot";
            this.panelBot.Size = new System.Drawing.Size(1265, 54);
            this.panelBot.TabIndex = 2;
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panelLeft.Controls.Add(this.btnDangnhap);
            this.panelLeft.Controls.Add(this.btnBaoCao);
            this.panelLeft.Controls.Add(this.btnDuLieu);
            this.panelLeft.Controls.Add(this.btnXemHoaDon);
            this.panelLeft.Controls.Add(this.btnTaoHoaDon);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelLeft.Location = new System.Drawing.Point(1046, 80);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(219, 562);
            this.panelLeft.TabIndex = 0;
            // 
            // btnDangnhap
            // 
            this.btnDangnhap.Location = new System.Drawing.Point(37, 358);
            this.btnDangnhap.Name = "btnDangnhap";
            this.btnDangnhap.Size = new System.Drawing.Size(152, 47);
            this.btnDangnhap.TabIndex = 4;
            this.btnDangnhap.Text = "Đăng &Xuất";
            this.btnDangnhap.UseVisualStyleBackColor = true;
            this.btnDangnhap.Click += new System.EventHandler(this.btnDangnhap_Click);
            // 
            // btnBaoCao
            // 
            this.btnBaoCao.Location = new System.Drawing.Point(37, 277);
            this.btnBaoCao.Name = "btnBaoCao";
            this.btnBaoCao.Size = new System.Drawing.Size(152, 47);
            this.btnBaoCao.TabIndex = 3;
            this.btnBaoCao.Text = "Tạo &Báo Cáo";
            this.btnBaoCao.UseVisualStyleBackColor = true;
            this.btnBaoCao.Click += new System.EventHandler(this.btnBaoCao_Click);
            // 
            // btnDuLieu
            // 
            this.btnDuLieu.Location = new System.Drawing.Point(37, 193);
            this.btnDuLieu.Name = "btnDuLieu";
            this.btnDuLieu.Size = new System.Drawing.Size(152, 47);
            this.btnDuLieu.TabIndex = 2;
            this.btnDuLieu.Text = "&Dữ Liệu";
            this.btnDuLieu.UseVisualStyleBackColor = true;
            this.btnDuLieu.Click += new System.EventHandler(this.btnDuLieu_Click);
            // 
            // btnXemHoaDon
            // 
            this.btnXemHoaDon.Location = new System.Drawing.Point(37, 112);
            this.btnXemHoaDon.Name = "btnXemHoaDon";
            this.btnXemHoaDon.Size = new System.Drawing.Size(152, 47);
            this.btnXemHoaDon.TabIndex = 1;
            this.btnXemHoaDon.Text = "&Hóa Đơn Gần Đây";
            this.btnXemHoaDon.UseVisualStyleBackColor = true;
            this.btnXemHoaDon.Click += new System.EventHandler(this.btnXemHoaDon_Click);
            // 
            // btnTaoHoaDon
            // 
            this.btnTaoHoaDon.Location = new System.Drawing.Point(37, 31);
            this.btnTaoHoaDon.Name = "btnTaoHoaDon";
            this.btnTaoHoaDon.Size = new System.Drawing.Size(152, 47);
            this.btnTaoHoaDon.TabIndex = 0;
            this.btnTaoHoaDon.Text = "&Tạo Hóa Đơn";
            this.btnTaoHoaDon.UseVisualStyleBackColor = true;
            this.btnTaoHoaDon.Click += new System.EventHandler(this.btnTaoHoaDon_Click_1);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 80);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.grBoxTimKiem);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvDanhSachSanPham);
            this.splitContainer1.Size = new System.Drawing.Size(1046, 562);
            this.splitContainer1.SplitterDistance = 260;
            this.splitContainer1.TabIndex = 5;
            // 
            // grBoxTimKiem
            // 
            this.grBoxTimKiem.Controls.Add(this.btnXoaBoLoc);
            this.grBoxTimKiem.Controls.Add(this.btnTimKiem);
            this.grBoxTimKiem.Controls.Add(this.txtTenSp);
            this.grBoxTimKiem.Controls.Add(this.txtGiaTu);
            this.grBoxTimKiem.Controls.Add(this.txtGiaDen);
            this.grBoxTimKiem.Controls.Add(this.txtMaSP);
            this.grBoxTimKiem.Controls.Add(this.lbGiaDen);
            this.grBoxTimKiem.Controls.Add(this.lbGiaTu);
            this.grBoxTimKiem.Controls.Add(this.lbTenSP);
            this.grBoxTimKiem.Controls.Add(this.lbMaSP);
            this.grBoxTimKiem.Controls.Add(this.lbtimkiem);
            this.grBoxTimKiem.Dock = System.Windows.Forms.DockStyle.Left;
            this.grBoxTimKiem.Location = new System.Drawing.Point(0, 0);
            this.grBoxTimKiem.Name = "grBoxTimKiem";
            this.grBoxTimKiem.Size = new System.Drawing.Size(260, 562);
            this.grBoxTimKiem.TabIndex = 0;
            this.grBoxTimKiem.TabStop = false;
            // 
            // btnXoaBoLoc
            // 
            this.btnXoaBoLoc.Location = new System.Drawing.Point(139, 315);
            this.btnXoaBoLoc.Name = "btnXoaBoLoc";
            this.btnXoaBoLoc.Size = new System.Drawing.Size(84, 38);
            this.btnXoaBoLoc.TabIndex = 5;
            this.btnXoaBoLoc.Text = "Xó&a bộ lọc";
            this.btnXoaBoLoc.UseVisualStyleBackColor = true;
            this.btnXoaBoLoc.Click += new System.EventHandler(this.btnXoaBoLoc_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(25, 315);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(84, 38);
            this.btnTimKiem.TabIndex = 4;
            this.btnTimKiem.Text = "Tì&m kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtTenSp
            // 
            this.txtTenSp.Location = new System.Drawing.Point(111, 118);
            this.txtTenSp.Name = "txtTenSp";
            this.txtTenSp.Size = new System.Drawing.Size(127, 20);
            this.txtTenSp.TabIndex = 1;
            // 
            // txtGiaTu
            // 
            this.txtGiaTu.Location = new System.Drawing.Point(111, 178);
            this.txtGiaTu.Name = "txtGiaTu";
            this.txtGiaTu.Size = new System.Drawing.Size(127, 20);
            this.txtGiaTu.TabIndex = 2;
            // 
            // txtGiaDen
            // 
            this.txtGiaDen.Location = new System.Drawing.Point(111, 238);
            this.txtGiaDen.Name = "txtGiaDen";
            this.txtGiaDen.Size = new System.Drawing.Size(127, 20);
            this.txtGiaDen.TabIndex = 3;
            // 
            // txtMaSP
            // 
            this.txtMaSP.Location = new System.Drawing.Point(111, 58);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(127, 20);
            this.txtMaSP.TabIndex = 0;
            // 
            // lbGiaDen
            // 
            this.lbGiaDen.AutoSize = true;
            this.lbGiaDen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGiaDen.Location = new System.Drawing.Point(12, 242);
            this.lbGiaDen.Name = "lbGiaDen";
            this.lbGiaDen.Size = new System.Drawing.Size(32, 16);
            this.lbGiaDen.TabIndex = 4;
            this.lbGiaDen.Text = "Đến";
            // 
            // lbGiaTu
            // 
            this.lbGiaTu.AutoSize = true;
            this.lbGiaTu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGiaTu.Location = new System.Drawing.Point(12, 182);
            this.lbGiaTu.Name = "lbGiaTu";
            this.lbGiaTu.Size = new System.Drawing.Size(48, 16);
            this.lbGiaTu.TabIndex = 3;
            this.lbGiaTu.Text = "Giá Từ";
            // 
            // lbTenSP
            // 
            this.lbTenSP.AutoSize = true;
            this.lbTenSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenSP.Location = new System.Drawing.Point(10, 122);
            this.lbTenSP.Name = "lbTenSP";
            this.lbTenSP.Size = new System.Drawing.Size(97, 16);
            this.lbTenSP.TabIndex = 2;
            this.lbTenSP.Text = "Tên Sản Phẩm";
            // 
            // lbMaSP
            // 
            this.lbMaSP.AutoSize = true;
            this.lbMaSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaSP.Location = new System.Drawing.Point(12, 64);
            this.lbMaSP.Name = "lbMaSP";
            this.lbMaSP.Size = new System.Drawing.Size(92, 16);
            this.lbMaSP.TabIndex = 1;
            this.lbMaSP.Text = "Mã Sản Phẩm";
            // 
            // lbtimkiem
            // 
            this.lbtimkiem.AutoSize = true;
            this.lbtimkiem.Font = new System.Drawing.Font("Times New Roman", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.lbtimkiem.Location = new System.Drawing.Point(3, 16);
            this.lbtimkiem.Name = "lbtimkiem";
            this.lbtimkiem.Size = new System.Drawing.Size(153, 19);
            this.lbtimkiem.TabIndex = 0;
            this.lbtimkiem.Text = "Tìm sản phẩm theo:";
            // 
            // dgvDanhSachSanPham
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Red;
            this.dgvDanhSachSanPham.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDanhSachSanPham.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDanhSachSanPham.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvDanhSachSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachSanPham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHoa,
            this.TenHoa,
            this.DVTinh,
            this.GiaBan});
            this.dgvDanhSachSanPham.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgvDanhSachSanPham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDanhSachSanPham.Location = new System.Drawing.Point(0, 0);
            this.dgvDanhSachSanPham.Name = "dgvDanhSachSanPham";
            this.dgvDanhSachSanPham.ReadOnly = true;
            this.dgvDanhSachSanPham.Size = new System.Drawing.Size(782, 562);
            this.dgvDanhSachSanPham.TabIndex = 0;
            // 
            // MaHoa
            // 
            this.MaHoa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.MaHoa.DataPropertyName = "MaHoa";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Red;
            this.MaHoa.DefaultCellStyle = dataGridViewCellStyle2;
            this.MaHoa.FillWeight = 120F;
            this.MaHoa.HeaderText = "Mã Sản Phẩm";
            this.MaHoa.Name = "MaHoa";
            this.MaHoa.ReadOnly = true;
            this.MaHoa.Width = 91;
            // 
            // TenHoa
            // 
            this.TenHoa.DataPropertyName = "TenHoa";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Red;
            this.TenHoa.DefaultCellStyle = dataGridViewCellStyle3;
            this.TenHoa.FillWeight = 120F;
            this.TenHoa.HeaderText = "Tên Sản Phẩm";
            this.TenHoa.Name = "TenHoa";
            this.TenHoa.ReadOnly = true;
            this.TenHoa.Width = 300;
            // 
            // DVTinh
            // 
            this.DVTinh.DataPropertyName = "DVTinh";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Red;
            this.DVTinh.DefaultCellStyle = dataGridViewCellStyle4;
            this.DVTinh.FillWeight = 120F;
            this.DVTinh.HeaderText = "Đơn vị tính";
            this.DVTinh.Name = "DVTinh";
            this.DVTinh.ReadOnly = true;
            this.DVTinh.Width = 120;
            // 
            // GiaBan
            // 
            this.GiaBan.DataPropertyName = "GiaBan";
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle5.Format = "N0";
            dataGridViewCellStyle5.NullValue = null;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Red;
            this.GiaBan.DefaultCellStyle = dataGridViewCellStyle5;
            this.GiaBan.FillWeight = 120F;
            this.GiaBan.HeaderText = "Giá Bán";
            this.GiaBan.Name = "GiaBan";
            this.GiaBan.ReadOnly = true;
            this.GiaBan.Width = 200;
            // 
            // FrmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1265, 696);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelBot);
            this.Controls.Add(this.panelTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sky Garden";
            this.Load += new System.EventHandler(this.FrmHome_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelLeft.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.grBoxTimKiem.ResumeLayout(false);
            this.grBoxTimKiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachSanPham)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lbTieuDe;
        private System.Windows.Forms.Panel panelBot;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Button btnBaoCao;
        private System.Windows.Forms.Button btnDuLieu;
        private System.Windows.Forms.Button btnXemHoaDon;
        private System.Windows.Forms.Button btnTaoHoaDon;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox grBoxTimKiem;
        private System.Windows.Forms.Label lbGiaDen;
        private System.Windows.Forms.Label lbGiaTu;
        private System.Windows.Forms.Label lbTenSP;
        private System.Windows.Forms.Label lbMaSP;
        private System.Windows.Forms.Label lbtimkiem;
        private System.Windows.Forms.TextBox txtTenSp;
        private System.Windows.Forms.TextBox txtGiaTu;
        private System.Windows.Forms.TextBox txtGiaDen;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.DataGridView dgvDanhSachSanPham;
        private System.Windows.Forms.Button btnDangnhap;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnXoaBoLoc;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Label lbXinChao;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenHoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn DVTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaBan;
    }
}

