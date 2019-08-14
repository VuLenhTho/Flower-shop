namespace CuaHangBanHoa
{
    partial class frmChonBaoCao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChonBaoCao));
            this.btnTrongNgay = new System.Windows.Forms.Button();
            this.btnTrongThang = new System.Windows.Forms.Button();
            this.btnTop10 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnTrongNgay
            // 
            this.btnTrongNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrongNgay.ForeColor = System.Drawing.Color.Blue;
            this.btnTrongNgay.Location = new System.Drawing.Point(42, 165);
            this.btnTrongNgay.Name = "btnTrongNgay";
            this.btnTrongNgay.Size = new System.Drawing.Size(221, 58);
            this.btnTrongNgay.TabIndex = 0;
            this.btnTrongNgay.Text = "Báo Cáo Doanh Thu Trong Ngày";
            this.btnTrongNgay.UseVisualStyleBackColor = true;
            this.btnTrongNgay.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnTrongThang
            // 
            this.btnTrongThang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrongThang.ForeColor = System.Drawing.Color.Blue;
            this.btnTrongThang.Location = new System.Drawing.Point(297, 165);
            this.btnTrongThang.Name = "btnTrongThang";
            this.btnTrongThang.Size = new System.Drawing.Size(217, 58);
            this.btnTrongThang.TabIndex = 1;
            this.btnTrongThang.Text = "Báo Cáo Doanh Thu Trong Tháng";
            this.btnTrongThang.UseVisualStyleBackColor = true;
            this.btnTrongThang.Click += new System.EventHandler(this.btnTrongThang_Click);
            // 
            // btnTop10
            // 
            this.btnTop10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTop10.ForeColor = System.Drawing.Color.Blue;
            this.btnTop10.Location = new System.Drawing.Point(548, 165);
            this.btnTop10.Name = "btnTop10";
            this.btnTop10.Size = new System.Drawing.Size(224, 58);
            this.btnTop10.TabIndex = 2;
            this.btnTop10.Text = "Top 10 Sản Phẩm Bán Chạy Trong Tháng";
            this.btnTop10.UseVisualStyleBackColor = true;
            this.btnTop10.Click += new System.EventHandler(this.btnTop10_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Sienna;
            this.label1.Location = new System.Drawing.Point(283, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "Chọn Kiểu Báo Cáo";
            // 
            // frmChonBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTop10);
            this.Controls.Add(this.btnTrongThang);
            this.Controls.Add(this.btnTrongNgay);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmChonBaoCao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chọn báo cáo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTrongNgay;
        private System.Windows.Forms.Button btnTrongThang;
        private System.Windows.Forms.Button btnTop10;
        private System.Windows.Forms.Label label1;
    }
}