using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BUL
{
    public class LOAINHANVIEN_BUL
    {
        public static List<VITRI_DTO> LoadLoaiNhanVien()
        {
            return LOAINHANVIEN_DAL.LoadLoaiNhanVien();
        }
        public static bool ThemTaiKhoan(TAIKHOAN_DTO tkDTO)
        {
            bool ketQua = TAIKHOAN_DAL.ThemTaiKhoan(tkDTO);
            return ketQua;
        }
    }
}
