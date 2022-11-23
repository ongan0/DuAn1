using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.Models;

namespace _1.DAL.IRepositories
{
    public interface IKhuyenMaiRepository
    {
        bool Add(KhuyenMai khuyenMai);
        bool Update(KhuyenMai khuyenMai);

        bool Delete(KhuyenMai khuyenMai);

        KhuyenMai GetByMa(string ma);

        List<KhuyenMai> GetAll();
    }
}
