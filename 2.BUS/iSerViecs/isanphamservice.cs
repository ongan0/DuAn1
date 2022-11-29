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
    public interface isanphamservice
    {
        bool addHd(SanPham KhachHang);
        bool removeHD(SanPham KhachHang);
        bool updateHD(SanPham KhachHang);
        List<SanPham> GetsList();
    }
}
