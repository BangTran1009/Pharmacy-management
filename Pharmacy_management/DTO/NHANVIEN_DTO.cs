using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NHANVIEN_DTO
    {
        public int IdNV { get; set; }
        public string TenNV { get; set; }
        public string SdtNV { get; set; }
        public DateTime NgSinhNV { get; set; }
        public string DiaChiNV { get; set; }
        public int Ca { get; set; }
        public int ViTri { get; set; }
        public int IdNhaThuoc { get; set; }
        public int Luong { get; set; }
        public NHANVIEN_DTO()
        {

        }

        public NHANVIEN_DTO(string ten, int vitri, int idcs, int Luong)
        {
            this.TenNV = ten;
            this.ViTri = vitri;
            this.IdNhaThuoc = idcs;
            this.Luong = Luong;
        }

    }
    
}
