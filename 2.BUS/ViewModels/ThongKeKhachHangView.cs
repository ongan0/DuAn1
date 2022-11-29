using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.ViewModels
{
    public class ThongKeKhachHangView
    {
  
        public string MaKH { get; set; }
        public string TenKH { get; set; }
        public string MaHD { get; set; }
        public float? TongSoTien { get; set; }
        public ThongKeKhachHangView(string makh, string Tenkh, string MaHd,float? tongtien )
        {

            MaKH = makh;
            TenKH = Tenkh;
            MaHD = MaHd;
            TongSoTien = tongtien;
         
        }

    }
}
