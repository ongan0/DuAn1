using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.Models;
using _1.DAL.IRepositories;

namespace _1.DAL.Repositories
{
    public class KhuyenMaiRepository : IKhuyenMaiRepository
    {
        private QLBHContext _qLBHContext;
        private List<KhuyenMai> _khuyenMaiList;

        public KhuyenMaiRepository()
        {
            _khuyenMaiList = new List<KhuyenMai>();
            _qLBHContext = new QLBHContext();
        }
        public bool Add(KhuyenMai khuyenMai)
        {
            _qLBHContext.KhuyenMais.Add(khuyenMai);
            _qLBHContext.SaveChanges();
            return true;
        }

        public bool Delete(KhuyenMai khuyenMai)
        {
            _qLBHContext.KhuyenMais.Remove(khuyenMai);
            _qLBHContext.SaveChanges();
            return true;
        }

        public List<KhuyenMai> GetAll()
        {
            _khuyenMaiList = _qLBHContext.KhuyenMais.ToList();
            return _khuyenMaiList;
        }

        public KhuyenMai GetByMa(string ma)
        {
            throw new NotImplementedException();
        }

        public bool Update(KhuyenMai khuyenMai)
        {
            _qLBHContext.KhuyenMais.Update(khuyenMai);
            _qLBHContext.SaveChanges();
            return true;
        }
    }
}
