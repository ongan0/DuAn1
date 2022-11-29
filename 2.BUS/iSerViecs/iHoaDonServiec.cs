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
    public interface iHoaDonServiec
    {
        bool addHd(HoaDon KhachHang);
        bool removeHD(HoaDon KhachHang);
        bool updateHD(HoaDon KhachHang);
        List<HoaDon> GetsList();
    }
}
