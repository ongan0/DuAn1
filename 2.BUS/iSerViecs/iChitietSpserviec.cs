using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.Models;
using _1.DAL.Repositories;
using _1.DAL.IRepositories;
namespace _2.BUS.iSerViecs
{
    public interface iChitietSpserviec
    {
        bool addHd(ChiTietSanPham KhachHang);
        bool removeHD(ChiTietSanPham KhachHang);
        bool updateHD(ChiTietSanPham KhachHang);
        List<ChiTietSanPham> GetsList();
    }
}
