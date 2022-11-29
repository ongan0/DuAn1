using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3.PL
{
    public partial class FrmTrangChu : Form
    {
        public FrmTrangChu()
        {
            InitializeComponent();
        }
        private Form currentFormChild;
    
        private void OpenChildForm(Form childFrom)
        {
            if(currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childFrom;
            childFrom.TopLevel = false;
            childFrom.FormBorderStyle = FormBorderStyle.None; 
            childFrom.Dock = DockStyle.Fill;
            panel_Body.Controls.Add(childFrom);
            panel_Body.Tag = childFrom;
            childFrom.BringToFront();
            childFrom.Show();
        }

        private void btn_BanHang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmBanHang());
            lb_TenTrang.Text = btn_BanHang.Text;
        }

        private void btn_HoaDon_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmHoaDon());
            lb_TenTrang.Text = btn_HoaDon.Text;
        }

        private void btn_KhachHang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmKhachHang());
            lb_TenTrang.Text = btn_KhachHang.Text;
        }

        private void btn_ThongKe_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmThongKe());
            lb_TenTrang.Text = btn_ThongKe.Text;
        }

        private void btn_NhanVien_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmNhanVien());
            lb_TenTrang.Text = btn_NhanVien.Text;
        }

        private void btn_QLKho_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmKhoHang());
            lb_TenTrang.Text = btn_QLKho.Text;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if(currentFormChild != null)
            {
                currentFormChild.Close();
            }
            lb_TenTrang.Text = "Trang chủ";
        }

        private void btn_DangXuat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn đăng xuất không?", "Đăng xuất", MessageBoxButtons.YesNo);
            if(result == DialogResult.Yes)
            {
                this.Hide();
                FrmDangNhap frmLogin = new FrmDangNhap();
                frmLogin.ShowDialog();
            }
        }
    }
}
