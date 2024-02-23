using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KHOCOSO_DTO
    {
        public int IdHH { get; set; }
        public int IdLoaiHH { get; set; }
        public int IdNhaCC { get; set; }
        public string TenHH { get; set; }
        public DateTime NSX { get; set; }
        public DateTime HSD { get; set; }
        public Double Gia { get; set; }
        public int SoLuong { get; set; }
        public DateTime NgayNhap { get; set; }
    }
}
