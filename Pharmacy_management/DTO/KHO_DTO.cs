using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KHO_DTO
    {
        public int IdHH { get; set; }
        public int IdLoaiHH { get; set; }
        public int IdNhaCC { get; set; }
        public string TenHH { get; set; }
        public DateTime NSX { get; set;}
        public DateTime HSD { get; set; }
        public Double Gia { get; set; }
        public int SoLuong { get; set; }
        public int? SoLuongCS1 { get; set; }
        public int? SoLuongCS2 { get; set; }
        public int? SoLuongCS3 { get; set; }
        public int? SoLuongCS4 { get; set; }
        public DateTime NgayNhap { get; set; }
    }
}
