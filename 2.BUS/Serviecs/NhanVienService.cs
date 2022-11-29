using _1.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.Serviecs
{
    public class NhanVienService
    {
        NhanVienRepository nhanVienRepository = new NhanVienRepository();
        public int checkTaiKhoan(string gmail, string matkhau)
        {
           return nhanVienRepository.checkTaiKhoan(gmail,matkhau);
        }
        public bool checkTT(string gmail, string sdt,string matkhau)
        {
            return nhanVienRepository.checkTT(gmail, sdt,matkhau);
        }
    }
}
