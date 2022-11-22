using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Models
{
    [Table("KhuyenMai")]
    public class KhuyenMai
    {
        [Key]
        public Guid Id { get; set; }

        [Column("MaKM", TypeName = "varchar")]
        [StringLength(30)]
        public string MaKM { get; set; }
        public float Giam { get; set; }
        public int TrangThai { get; set; }

        public virtual ObservableCollectionListSource<HoaDon> HoaDons { get; } = new();
    }
}
