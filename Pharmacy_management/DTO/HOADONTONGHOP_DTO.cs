using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HOADONTONGHOP_DTO
    {
        public int IdHD { get; set; }  
        public string TenKH { get; set; }
        public string TenNV { get; set; }
        public DateTime NgayMua { get; set; }
        public int TongTien { get; set; }
    }
}
