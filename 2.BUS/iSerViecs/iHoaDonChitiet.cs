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
    public interface iHoaDonChitiet
    {
        bool addHd(HoaDonChiTiet KhachHang);
        bool removeHD(HoaDonChiTiet KhachHang);
        bool updateHD(HoaDonChiTiet KhachHang);
        List<HoaDonChiTiet> GetsList();
    }
}
