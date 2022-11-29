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
    public class HoaDonChiTietServiec : iHoaDonChitiet
    {
        IHoaDonChiTietRepository ihoadonrep;
        public HoaDonChiTietServiec()
        {
            ihoadonrep = new HoaDonChiTietRepository();
        }
        public bool addHd(HoaDonChiTiet KhachHang)
        {
            ihoadonrep.Add(KhachHang);
            return true;
        }

        public List<HoaDonChiTiet> GetsList()
        {
            var khachhang = ihoadonrep.GetAllHDCT();
            return khachhang;
        }

        public bool removeHD(HoaDonChiTiet KhachHang)
        {
            ihoadonrep.Delete(KhachHang);
            return true;
        }

        public bool updateHD(HoaDonChiTiet KhachHang)
        {
            ihoadonrep.Update(KhachHang);
            return true;
        }
    }
}
