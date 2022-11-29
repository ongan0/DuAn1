using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2.BUS.ViewModels;
namespace _2.BUS.iSerViecs
{
    internal interface iThongKeKhachHangServiec
    {
        List<ThongKeKhachHangView> GetAll();
    }
}
