using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BUL
{
    public class TAIKHOAN_BUL
    {
        public static List<TAIKHOAN_DTO> LoadTaiKhoan()
        {
            return TAIKHOAN_DAL.LoadTaiKhoan();
        }
        public static bool ThemTaiKhoan(TAIKHOAN_DTO tkDTO)
        {
            return TAIKHOAN_DAL.ThemTaiKhoan(tkDTO);
        }
        public static bool SuaTaiKhoan(TAIKHOAN_DTO tkDTO)
        {
            return TAIKHOAN_DAL.SuaTaiKhoan(tkDTO);
        }
        public static bool XoaTaiKhoan(int IdTaiKhoan)
        {
            return TAIKHOAN_DAL.XoaTaiKhoan(IdTaiKhoan);
        }
        public static List<TAIKHOAN_DTO> TimTaiKhoan(string sChuoiTruyVan)
        {
            return TAIKHOAN_DAL.TimTaiKhoan(sChuoiTruyVan);
        }
        public static List<TAIKHOAN_DTO> LoadTaiKhoanCoSo()
        {
            return TAIKHOAN_DAL.LoadTaiKhoanCoSo();
        }
    }
}
