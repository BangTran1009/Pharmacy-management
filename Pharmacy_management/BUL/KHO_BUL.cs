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
    public class KHO_BUL
    {
        public static List<KHO_DTO> LoadKho()
        {
            return KHO_DAL.LoadKho();
        }
        public static List<KHOCOSO_DTO> LoadKhoCoSo()
        {
            return KHO_DAL.LoadKhoCoSo();
        }
        public static List<KHOCOSO_DTO> LoadKhoTheoCoSo(string sChuoiTruyVan)
        {
            return KHO_DAL.LoadKhoTheoCoSo( sChuoiTruyVan);
        } 
        public static bool ThemHangHoa(KHO_DTO Hanghoa)
        {
            return KHO_DAL.ThemHangHoa(Hanghoa);
        }
        public static bool SuaHangHoa(KHO_DTO Hanghoa)
        {
           return KHO_DAL.SuaHangHoa(Hanghoa);
        }
        public static bool PhanPhoiHangHoa(KHO_DTO Hanghoa)
        {
            return KHO_DAL.PhanPhoiHangHoa(Hanghoa);
        }
        public static bool XoaHangHoa(int IdHH)
        {
            return KHO_DAL.XoaHangHoa(IdHH);
        }
        public static List<KHO_DTO> TimKiemHangHoa(string tuKhoa)
        {
            return KHO_DAL.TimKiemHangHoa(tuKhoa);
        }
        public static List<KHOCOSO_DTO> TimKiemHangHoaCoSo(string tuKhoa)
        {
            return KHO_DAL.TimKiemHangHoaCoSo(tuKhoa);
        }
        public static bool SuaHangHoaCoSo(KHOCOSO_DTO Hanghoa)
        {
            return KHO_DAL.SuaHangHoaCoSo(Hanghoa);
        }
        public static List<TIENNHAPHANG_DTO> NhapHang(string id)
        {
            return KHO_DAL.NhapHang(id);
        }
        public static DataTable Kho()
        {
            return KHO_DAL.Kho();   
        }
        public static bool UpdateHH(KHO_DTO HangHoa)
        {
            return KHO_DAL.UpdateHH(HangHoa);
        }

        public static List<KHO_DTO> TimKiemHangHoaCoSoTheoId(string tuKhoa)
        {
            return KHO_DAL.TimKiemHangHoaCoSoTheoId(tuKhoa);
        }
    }
}
