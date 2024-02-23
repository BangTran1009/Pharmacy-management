using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ThemHoaDon_DTO
    {
        public string TenHH { get; set; }   
        public int SL { get; set; }
        public int gia { get; set; }
        public int TongTien { get; set; }
        public ThemHoaDon_DTO(string ten, int sl, int gia, int tongtien)
        {
            this.TenHH = ten;
            this.SL = sl;
            this.gia = gia;
            this.TongTien = tongtien;
        }
    }
}
