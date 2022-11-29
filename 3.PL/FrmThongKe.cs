using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using _1.DAL.Models;
using _2.BUS.Serviecs;
using _2.BUS.iSerViecs;

namespace _3.PL
{
    public partial class FrmThongKe : Form
    {
        private Form activeForm;
        public FrmThongKe()
        {
            InitializeComponent();
    
            loadngay();
            loadnam();
            loadthang();
         

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
        public string[] Getnam()
        {
            string[] TempNs = new string[2030 - 2010];
            for (int i = 0; i < TempNs.Length; i++)
            {
                TempNs[i] = Convert.ToString(2010 + i);
            }
            return TempNs;
        }
        public string[] Getngay()
        {
            string[] TempNs = new string[32 - 1];
            for (int i = 0; i < TempNs.Length; i++)
            {
                TempNs[i] = Convert.ToString(1 + i);
            }
            return TempNs;
        }
        void loadngay()
        {
            foreach (var x in Getngay())
            {
                cbb_ngay.Items.Add(x);
            }

        }
        void loadnam()
        {
            //var x = Convert.ToInt32(iHoaDonServiec.GetsList().First().NgayTao.ToString("yyyy"));
            //var y = Convert.ToInt32(iHoaDonServiec.GetsList().Last().NgayTao.ToString("yyyy"));
            //for (int i = x; i <= y; i++)
            //{
            //    cbb_nam.Items.Add(i);
            //}
            foreach (var x in Getnam())
            {
                cbb_nam.Items.Add(x);
            }

        }
        void loadthang()
        {

            for (int i = 1; i < 13; i++)
            {
                cbb_thang.Items.Add(i);
            }

        }
  
        private void MnSKhachhang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormThongKeKhachHang());
        }
        private void MnSNhanVien_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormThongKeNV());
        }
    }
}
