using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;

namespace DAL
{
    public class KHACHHANG_DAL
    {
        public static List<KHACHHANG_DTO> LoadKhachHang()
        {
            string sChuoiTruyVan = @"Select * From KHACHHANG";
            DataTable dt = DbContext.TruyVanDataTable(sChuoiTruyVan);
            KHACHHANG_DTO khDTO;
            if (dt != null && dt.Rows.Count > 0)
            {
                List<KHACHHANG_DTO> lstKhachHangDTO = new List<KHACHHANG_DTO>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    khDTO = new KHACHHANG_DTO();
                    khDTO.SDT = dt.Rows[i]["SdtKH"].ToString();
                    khDTO.TenKH = dt.Rows[i]["TenKH"].ToString();
                    khDTO.NgaySinh = Convert.ToDateTime(dt.Rows[i]["NgaySinhKH"].ToString());
                    khDTO.DiaChi = dt.Rows[i]["DiaChiKH"].ToString();
                    khDTO.Diem = Convert.ToInt32(dt.Rows[i]["Diem"]);

                    lstKhachHangDTO.Add(khDTO);
                }
                return lstKhachHangDTO;
            }
            return null;
        }
        public static DataTable LoadKhachHangTB()
        {
            string sChuoiTruyVan = @"Select * From KHACHHANG";
            DataTable dt = DbContext.TruyVanDataTable(sChuoiTruyVan);
            
            return dt;
        }
        public static bool ThemKhachHang(KHACHHANG_DTO KhDTO)
        {
            string sChuoiTruyVan = string.Format("Insert into KHACHHANG(SdtKH, TenKH, NgaySinhKH, DiaChiKH, Diem) " +
                                               "values ('{0}', '{1}', '{2}', '{3}', '{4}')",
                                                KhDTO.SDT, KhDTO.TenKH, KhDTO.NgaySinh, KhDTO.DiaChi, KhDTO.Diem);
            bool ketQua = DbContext.TruyVanExecuteNonQuery(sChuoiTruyVan);
            return ketQua;
        }
        public static bool CapNhatKhachHang(KHACHHANG_DTO KhDTO)
        {
            string sChuoiTruyVan = string.Format("Update KHACHHANG set TenKH = '{0}', NgaySinhKH = '{1}', DiaChiKH = '{2}'," +
                                                                " Diem = '{3}' where SdtKH = '{4}'",
                                                            KhDTO.TenKH, KhDTO.NgaySinh, KhDTO.DiaChi, KhDTO.Diem, KhDTO.SDT);
            return DbContext.TruyVanExecuteNonQuery(sChuoiTruyVan);
        }
        public static bool XoaNhanVien(int SDT)
        {
            string sChuoiTruyVan = string.Format("Delete from KHACHHANG where SdtKH = '{0}'", SDT);
            return DbContext.TruyVanExecuteNonQuery(sChuoiTruyVan);
        }
        public static List<KHACHHANG_DTO> TimKhachHang(string tuKhoa)
        {
            string sChuoiTruyVan = String.Format(@"Select * From KHACHHANG where SdtKH like '{0}'", tuKhoa);
            DataTable dt = DbContext.TruyVanDataTable(sChuoiTruyVan);
            KHACHHANG_DTO khDTO;
            if (dt != null && dt.Rows.Count > 0)
            {
                List<KHACHHANG_DTO> lstKhachHangDTO = new List<KHACHHANG_DTO>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    khDTO = new KHACHHANG_DTO();
                    khDTO.SDT = dt.Rows[i]["SdtKH"].ToString();
                    khDTO.TenKH = dt.Rows[i]["TenKH"].ToString();
                    khDTO.NgaySinh = Convert.ToDateTime(dt.Rows[i]["NgaySinhKH"].ToString());
                    khDTO.DiaChi = dt.Rows[i]["DiaChiKH"].ToString();
                    khDTO.Diem = Convert.ToInt32(dt.Rows[i]["Diem"]);

                    lstKhachHangDTO.Add(khDTO);
                }
                return lstKhachHangDTO;
            }
            return null;
        }
    }
}
