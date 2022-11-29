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
    public class ChitietSpServiec : iChitietSpserviec
    {
        IChiTietSanPhamRepository ihoadonrep;
        public ChitietSpServiec()
        {
            ihoadonrep = new ChiTietSanPhamRepository();
        }
        public bool addHd(ChiTietSanPham KhachHang)
        {

            ihoadonrep.Add(KhachHang);
            return true;
        }

        public List<ChiTietSanPham> GetsList()
        {
            var khachhang = ihoadonrep.GetAllChiTietSp();
            return khachhang;
        }

        public bool removeHD(ChiTietSanPham KhachHang)
        {

            ihoadonrep.Delete(KhachHang);
            return true;
        }

        public bool updateHD(ChiTietSanPham KhachHang)
        {
            ihoadonrep.Update(KhachHang);
            return true;
        }
    }
}
