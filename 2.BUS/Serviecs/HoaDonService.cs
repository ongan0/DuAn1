using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.Models;
using _2.BUS.iSerViecs;
using _2.BUS.ViewModels;
using _1.DAL.IRepositories;
using _1.DAL.Repositories;
namespace _2.BUS.Serviecs
{
    public class HoaDonService : iHoaDonServiec
    {
        IHoaDonRepository ihoadonrep;
        public HoaDonService()
        {
            ihoadonrep = new HoaDonRepository();
        }
        public bool addHd(HoaDon KhachHang)
        {
            ihoadonrep.Add(KhachHang);
            return true;
        }

        public List<HoaDon> GetsList()
        {
            var khachhang = ihoadonrep.GetAllHD();
            return khachhang;
        }

        public bool removeHD(HoaDon KhachHang)
        {
            ihoadonrep.Delete(KhachHang);
            return true;
        }

        public bool updateHD(HoaDon KhachHang)
        {
            ihoadonrep.Update(KhachHang);
            return true;
        }
    }
}
