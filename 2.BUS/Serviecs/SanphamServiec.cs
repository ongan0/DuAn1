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
    public class SanphamServiec : isanphamservice
    {
        ISanPhamRepository isanpham;
        public SanphamServiec()
        {
            isanpham = new SanPhamRepository();
        }
        public bool addHd(SanPham KhachHang)
        {
            isanpham.Add(KhachHang);
            return true;
        }

        public List<SanPham> GetsList()
        {
            var khachhang = isanpham.GetAllSp();
            return khachhang;
         
        }

        public bool removeHD(SanPham KhachHang)
        {
            isanpham.Delete(KhachHang);
            return true;
        }

        public bool updateHD(SanPham KhachHang)
        {
            isanpham.Update(KhachHang);
            return true;
        }
    }
}
