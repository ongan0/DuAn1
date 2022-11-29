using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.Models;
using _2.BUS.iSerViecs;
using _2.BUS.ViewModels;

namespace _2.BUS.Serviecs
{
    public class ThongKeKhachHangServiec : iThongKeKhachHangServiec
    {
        iHoaDonServiec iHoaDonServiec;
        iKhachHangServiecc iKhachHangServiecc;
        public ThongKeKhachHangServiec()
        {
            iHoaDonServiec = new HoaDonService();
            iKhachHangServiecc = new KhachHangServiec();
        }
        public List<ThongKeKhachHangView> GetAll()
        {
     
          var lstphamviews =
                (from a in iKhachHangServiecc.GetsList()
                 join b in iHoaDonServiec.GetsList() on a.IdKhachHang equals b.IdKhachHang
                
                 select new 
                 {
                      a.MaKH,
                      a.TenKH,
                      b.MaHD,
                      b.TongTien,
                 }).ToList();
                  var lisfinal = lstphamviews.GroupBy(c => c.MaKH)
                  .Select(g => new ThongKeKhachHangView(g.Key, 
                  g.Where(c => c.MaKH == g.Key).Select(c => c.TenKH).FirstOrDefault(),
                  g.Where(c => c.MaKH == g.Key).Select(c => c.MaHD).FirstOrDefault(),
                  g.Sum(c => c.TongTien))
                ).ToList();
            return lisfinal;
        }
    }
}
