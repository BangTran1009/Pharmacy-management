using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
using System.Data;
namespace BUL
{
    public class HOADON_BUL
    {
        public static List<HOADON_DTO> LoadHoaDon()
        {
            return HOADON_DAL.LoadHoaDon();
        }
        public static List<HOADON_DTO> LoadHoaDonCoSo()
        {
            return HOADON_DAL.LoadHoaDonCoSo();
        }
        //public static List<HOADON_DTO> LoadHoaDonTheoCoSo(string id)
        //{
        //    return HOADON_DAL.LoadHoaDonTheoCoSo(id);
        //}
        public static bool ThemHoaDon(HOADON_DTO hdDTO)
        {
            bool ketQua = HOADON_DAL.ThemHoaDon(hdDTO);
            return ketQua;
        }
        public static int GetId()
        {
            int getId = HOADON_DAL.GetId();
            return getId;
        }
        public static List<HOADONTONGHOP_DTO> HoaDonTongHopCS(string tungay, string denngay)
        {
            return HOADON_DAL.HoaDonTongHopCS(tungay, denngay);
        }
        public static List<HOADONTONGHOP_DTO> HoaDonTongHop(string tungay, string denngay, string id)
        {
            return HOADON_DAL.HoaDonTongHop(tungay, denngay, id);
        }
        public static DataTable HoaDonTongHopTheoNgay(string ngay)
        {
            return HOADON_DAL.HoaDonTongHopTheoNgay(ngay);
        }
        public static DataTable LoadHoaDonTB()
        {
            return HOADON_DAL.LoadHoaDonTB();
        }
        public static List<HOADON_DTO> LoadHoaDonCoSoTheoId(string IdHD)
        {
            return HOADON_DAL.LoadHoaDonCoSoTheoId(IdHD);
        }
    }
}
