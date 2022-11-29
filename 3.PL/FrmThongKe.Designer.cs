namespace _3.PL
{
    partial class FrmThongKe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmThongKe));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MnSKhachhang = new System.Windows.Forms.ToolStripMenuItem();
            this.MnSNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_kh = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.ptp_excel = new System.Windows.Forms.PictureBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dtg_show = new System.Windows.Forms.DataGridView();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.cbb_nam = new System.Windows.Forms.ComboBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.cbb_thang = new System.Windows.Forms.ComboBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.cbb_ngay = new System.Windows.Forms.ComboBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lb_sokhachhang = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.lb_sohdchuathanhtoan = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.lb_sohd = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.lb_doanhthu = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            this.panel_kh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptp_excel)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_show)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnSKhachhang,
            this.MnSNhanVien});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1303, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MnSKhachhang
            // 
            this.MnSKhachhang.Name = "MnSKhachhang";
            this.MnSKhachhang.Size = new System.Drawing.Size(174, 24);
            this.MnSKhachhang.Text = "Thống Kê Khách Hàng ";
            this.MnSKhachhang.Click += new System.EventHandler(this.MnSKhachhang_Click);
            // 
            // MnSNhanVien
            // 
            this.MnSNhanVien.Name = "MnSNhanVien";
            this.MnSNhanVien.Size = new System.Drawing.Size(162, 24);
            this.MnSNhanVien.Text = "Thống Kê Nhân Viên ";
            this.MnSNhanVien.Click += new System.EventHandler(this.MnSNhanVien_Click);
            // 
            // panel_kh
            // 
            this.panel_kh.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel_kh.Controls.Add(this.label7);
            this.panel_kh.Controls.Add(this.ptp_excel);
            this.panel_kh.Controls.Add(this.groupBox5);
            this.panel_kh.Controls.Add(this.groupBox6);
            this.panel_kh.Controls.Add(this.groupBox7);
            this.panel_kh.Controls.Add(this.groupBox8);
            this.panel_kh.Controls.Add(this.panel6);
            this.panel_kh.Controls.Add(this.panel7);
            this.panel_kh.Controls.Add(this.panel8);
            this.panel_kh.Controls.Add(this.panel9);
            this.panel_kh.Location = new System.Drawing.Point(0, 31);
            this.panel_kh.Name = "panel_kh";
            this.panel_kh.Size = new System.Drawing.Size(1292, 739);
            this.panel_kh.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(61, 311);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(156, 28);
            this.label7.TabIndex = 19;
            this.label7.Text = "Xuất File Excel ";
            // 
            // ptp_excel
            // 
            this.ptp_excel.BackColor = System.Drawing.SystemColors.Info;
            this.ptp_excel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ptp_excel.Image = ((System.Drawing.Image)(resources.GetObject("ptp_excel.Image")));
            this.ptp_excel.Location = new System.Drawing.Point(245, 302);
            this.ptp_excel.Name = "ptp_excel";
            this.ptp_excel.Size = new System.Drawing.Size(92, 48);
            this.ptp_excel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptp_excel.TabIndex = 18;
            this.ptp_excel.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dtg_show);
            this.groupBox5.Location = new System.Drawing.Point(51, 365);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(1179, 334);
            this.groupBox5.TabIndex = 17;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Sản Phẩm ";
            // 
            // dtg_show
            // 
            this.dtg_show.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_show.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column5,
            this.Column4,
            this.Column6});
            this.dtg_show.Location = new System.Drawing.Point(22, 48);
            this.dtg_show.Name = "dtg_show";
            this.dtg_show.RowHeadersWidth = 51;
            this.dtg_show.RowTemplate.Height = 29;
            this.dtg_show.Size = new System.Drawing.Size(1151, 277);
            this.dtg_show.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.cbb_nam);
            this.groupBox6.Location = new System.Drawing.Point(776, 210);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(286, 63);
            this.groupBox6.TabIndex = 15;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Năm ";
            // 
            // cbb_nam
            // 
            this.cbb_nam.FormattingEnabled = true;
            this.cbb_nam.Location = new System.Drawing.Point(35, 26);
            this.cbb_nam.Name = "cbb_nam";
            this.cbb_nam.Size = new System.Drawing.Size(228, 28);
            this.cbb_nam.TabIndex = 2;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.cbb_thang);
            this.groupBox7.Location = new System.Drawing.Point(409, 210);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(253, 63);
            this.groupBox7.TabIndex = 16;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Tháng ";
            // 
            // cbb_thang
            // 
            this.cbb_thang.FormattingEnabled = true;
            this.cbb_thang.Location = new System.Drawing.Point(34, 26);
            this.cbb_thang.Name = "cbb_thang";
            this.cbb_thang.Size = new System.Drawing.Size(195, 28);
            this.cbb_thang.TabIndex = 1;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.cbb_ngay);
            this.groupBox8.Location = new System.Drawing.Point(73, 210);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(243, 63);
            this.groupBox8.TabIndex = 14;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Ngày ";
            // 
            // cbb_ngay
            // 
            this.cbb_ngay.FormattingEnabled = true;
            this.cbb_ngay.Location = new System.Drawing.Point(22, 26);
            this.cbb_ngay.Name = "cbb_ngay";
            this.cbb_ngay.Size = new System.Drawing.Size(199, 28);
            this.cbb_ngay.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel6.Controls.Add(this.lb_sokhachhang);
            this.panel6.Controls.Add(this.label10);
            this.panel6.Location = new System.Drawing.Point(952, 39);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(251, 144);
            this.panel6.TabIndex = 13;
            // 
            // lb_sokhachhang
            // 
            this.lb_sokhachhang.AutoSize = true;
            this.lb_sokhachhang.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_sokhachhang.Location = new System.Drawing.Point(120, 86);
            this.lb_sokhachhang.Name = "lb_sokhachhang";
            this.lb_sokhachhang.Size = new System.Drawing.Size(22, 25);
            this.lb_sokhachhang.TabIndex = 8;
            this.lb_sokhachhang.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(22, 11);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(211, 31);
            this.label10.TabIndex = 7;
            this.label10.Text = "Tổng Khách Hàng ";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel7.Controls.Add(this.label11);
            this.panel7.Controls.Add(this.lb_sohdchuathanhtoan);
            this.panel7.Controls.Add(this.label13);
            this.panel7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel7.Location = new System.Drawing.Point(649, 39);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(252, 144);
            this.panel7.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Black", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(44, 36);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(169, 25);
            this.label11.TabIndex = 7;
            this.label11.Text = "Chưa Thanh Toán ";
            // 
            // lb_sohdchuathanhtoan
            // 
            this.lb_sohdchuathanhtoan.AutoSize = true;
            this.lb_sohdchuathanhtoan.Font = new System.Drawing.Font("Segoe UI Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_sohdchuathanhtoan.Location = new System.Drawing.Point(113, 86);
            this.lb_sohdchuathanhtoan.Name = "lb_sohdchuathanhtoan";
            this.lb_sohdchuathanhtoan.Size = new System.Drawing.Size(21, 25);
            this.lb_sohdchuathanhtoan.TabIndex = 6;
            this.lb_sohdchuathanhtoan.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI Black", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(67, 11);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(124, 25);
            this.label13.TabIndex = 5;
            this.label13.Text = "Số Hóa Đơn  ";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel8.Controls.Add(this.lb_sohd);
            this.panel8.Controls.Add(this.label15);
            this.panel8.Location = new System.Drawing.Point(363, 39);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(238, 144);
            this.panel8.TabIndex = 12;
            // 
            // lb_sohd
            // 
            this.lb_sohd.AutoSize = true;
            this.lb_sohd.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_sohd.Location = new System.Drawing.Point(107, 86);
            this.lb_sohd.Name = "lb_sohd";
            this.lb_sohd.Size = new System.Drawing.Size(22, 25);
            this.lb_sohd.TabIndex = 4;
            this.lb_sohd.Text = "0";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(46, 11);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(148, 31);
            this.label15.TabIndex = 3;
            this.label15.Text = "Số Hóa Đơn ";
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel9.Controls.Add(this.label16);
            this.panel9.Controls.Add(this.lb_doanhthu);
            this.panel9.Controls.Add(this.label18);
            this.panel9.Location = new System.Drawing.Point(70, 39);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(237, 144);
            this.panel9.TabIndex = 10;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(163, 86);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(56, 25);
            this.label16.TabIndex = 2;
            this.label16.Text = "VND ";
            // 
            // lb_doanhthu
            // 
            this.lb_doanhthu.AutoSize = true;
            this.lb_doanhthu.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_doanhthu.Location = new System.Drawing.Point(49, 86);
            this.lb_doanhthu.Name = "lb_doanhthu";
            this.lb_doanhthu.Size = new System.Drawing.Size(22, 25);
            this.lb_doanhthu.TabIndex = 1;
            this.lb_doanhthu.Text = "0";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label18.Location = new System.Drawing.Point(49, 11);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(138, 31);
            this.label18.TabIndex = 0;
            this.label18.Text = "Doanh Thu ";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã Hóa Đơn ";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tên Sản Phẩm ";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Số Lượng ";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Đơn Giá ";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Tổng Tiền ";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Số Điện Thoại Khách Hàng";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 125;
            // 
            // FrmThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1303, 774);
            this.Controls.Add(this.panel_kh);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmThongKe";
            this.Text = "FrmThongKe";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel_kh.ResumeLayout(false);
            this.panel_kh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptp_excel)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_show)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MnSKhachhang;
        private System.Windows.Forms.ToolStripMenuItem MnSNhanVien;
        private System.Windows.Forms.Panel panel_kh;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox ptp_excel;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dtg_show;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ComboBox cbb_nam;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.ComboBox cbb_thang;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.ComboBox cbb_ngay;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lb_sokhachhang;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lb_sohdchuathanhtoan;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label lb_sohd;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lb_doanhthu;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}