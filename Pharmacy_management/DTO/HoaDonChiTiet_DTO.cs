using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HoaDonChiTiet_DTO
    {
        public string TenHH;
        public int SL;
        public int Gia;
        public int ThanhTien;
        public HoaDonChiTiet_DTO(string ten, int sl, int gia, int tien)
        {
            this.TenHH = ten;
            this.SL = sl;
            this.Gia = gia;
            this.ThanhTien = tien;
        }
    }
   
}
