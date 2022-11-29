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
    public class KhachHangServiec : iKhachHangServiecc
    {
        IKhachHangRepository _iKhacHangRepositori;
        public KhachHangServiec()
        {
            _iKhacHangRepositori = new KhachHangRepository();
        }
        public bool addKH(KhachHang KhachHang)
        {
            _iKhacHangRepositori.Add(KhachHang);
            return true;
        }

        public List<KhachHang> GetsList()
        {
            var khachhang = _iKhacHangRepositori.GetAllKh();
            return khachhang;
        }

        public bool removeKH(KhachHang KhachHang)
        {
            _iKhacHangRepositori.Delete(KhachHang);
            return true;
        }

        public bool updateKH(KhachHang KhachHang)
        {
            _iKhacHangRepositori.Update(KhachHang);
            return true;
        }
    }
}
