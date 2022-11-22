using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace _3.PL
{
    public partial class FrmDangNhap : Form
    {
        public FrmDangNhap()
        {
            InitializeComponent();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tbt_TenDn_Click(object sender, EventArgs e)
        {
            tbt_TenDn.BackColor = Color.White;
            panel3.BackColor = Color.White;
            panel5.BackColor = SystemColors.Control;
            tbt_MatKhau.BackColor = SystemColors.Control;
        }

        private void tbt_MatKhau_Click(object sender, EventArgs e)
        {
            tbt_MatKhau.BackColor= Color.White;
            panel5.BackColor= Color.White;
            tbt_TenDn.BackColor = SystemColors.Control;
            panel3.BackColor = SystemColors.Control;
        }

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            tbt_MatKhau.UseSystemPasswordChar = false;
        }

        private void btn_QuenMK_Click(object sender, EventArgs e)
        {
            FrmQuenMK quenMK = new FrmQuenMK();
            quenMK.ShowDialog();
        }
    }
}
