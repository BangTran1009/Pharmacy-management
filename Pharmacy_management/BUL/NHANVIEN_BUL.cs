using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;
using DTO;

namespace BUL
{
    public class NHANVIEN_BUL
    {
        public static List<NHANVIEN_DTO> LoadNhanVien()
        {
            return NHANVIEN_DAL.LoadNhanVien();
        }
        public static bool ThemNhanVien(NHANVIEN_DTO nvDTO)
        {
            bool ketQua = NHANVIEN_DAL.ThemNhanVien(nvDTO);
            return ketQua;
        }
        public static bool CapNhatNhanVien(NHANVIEN_DTO nvDTO)
        {
            bool ketQua = NHANVIEN_DAL.CapNhapNhanVien(nvDTO);
            return ketQua;
        }
        public static bool XoaNhanVien(int IdNV)
        {
            bool ketQua = NHANVIEN_DAL.XoaNhanVien(IdNV);
            return ketQua;
        }
        public static List<NHANVIEN_DTO> TimNhanVien(string sChuoiTruyVan)
        {
            return NHANVIEN_DAL.TimNhanVien(sChuoiTruyVan);
        }
        public static List<NHANVIEN_DTO> LoadNhanVienCoSo()
        {
            return NHANVIEN_DAL.LoadNhanVienCoSo();
        }
        public static NHANVIEN_DTO NhanVienHienTai()
        {
            return NHANVIEN_DAL.NhanVienHienTai();
        }

        public static List<LUONGNHANVIEN_DTO> LuongNhanVienCS(string id)
        {
            return NHANVIEN_DAL.LuongNhanVienCS(id);
        }
        public static List<LUONGNHANVIEN_DTO> LuongNhanVien()
        {
            return NHANVIEN_DAL.LuongNhanVien();
        }
        public static DataTable LuongNhanVienTB()
        {
            return NHANVIEN_DAL.LuongNhanVienTB();
        }
    }
}
