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
    public class KHACHHANG_BUL
    {
        public static List<KHACHHANG_DTO> LoadKhachHang()
        {
            return KHACHHANG_DAL.LoadKhachHang();
        }
        public static DataTable LoadKhachHangTB()
        {
            return KHACHHANG_DAL.LoadKhachHangTB();
        }
        public static bool ThemKhachHang(KHACHHANG_DTO KhDTO)
        {
            return KHACHHANG_DAL.ThemKhachHang(KhDTO);
        }
        public static bool CapNhatKhachHang(KHACHHANG_DTO KhDTO)
        {
            return KHACHHANG_DAL.CapNhatKhachHang(KhDTO);
        }
        public static bool XoaKhachHang(int SDT)
        {
            return KHACHHANG_DAL.XoaNhanVien(SDT);
        }
        public static List<KHACHHANG_DTO> TimKhachHang(string tuKhoa)
        {
            return KHACHHANG_DAL.TimKhachHang(tuKhoa);
        }
    }
}
