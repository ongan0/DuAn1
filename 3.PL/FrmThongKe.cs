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
    public partial class FrmThongKe : Form
    {
        private Form activeForm;
        public FrmThongKe()
        {
            InitializeComponent();
        }
        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panel_kh.Controls.Add(childForm);
            this.panel_kh.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();



        }
        private void MnSKhachhang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormThongKeKhachHang());
        }

        private void MnSHoaDon_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormThongKeHD());
        }

        private void MnSNhanVien_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormThongKeNV());
        }
    }
}
