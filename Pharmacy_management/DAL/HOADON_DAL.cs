using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;
namespace DAL
{
   public class HOADON_DAL
    {
        public static List<HOADON_DTO> LoadHoaDon()
        {
            string sChuoiTruyVan = @"Select * From HOADON";
            DataTable dt = DbContext.TruyVanDataTable(sChuoiTruyVan);
            HOADON_DTO hdDTO;
            if (dt != null && dt.Rows.Count > 0)
            {
                List<HOADON_DTO> lstHoaDonDTO = new List<HOADON_DTO>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    hdDTO = new HOADON_DTO();
                    hdDTO.IdHD = Convert.ToInt32(dt.Rows[i]["IdHD"]);
                    hdDTO.IdHH = Convert.ToInt32(dt.Rows[i]["IdHH"]);
                    hdDTO.SdtKH = dt.Rows[i]["SdtKH"].ToString();
                    hdDTO.IdNV = Convert.ToInt32(dt.Rows[i]["IdNV"]);
                    hdDTO.IdCS = Convert.ToInt32(dt.Rows[i]["IdCS"]);
                    hdDTO.NgayMua = Convert.ToDateTime(dt.Rows[i]["NgayMua"].ToString());
                    hdDTO.TongTien = Convert.ToInt32(dt.Rows[i]["TongTien"]);
                    hdDTO.SL = Convert.ToInt32(dt.Rows[i]["SL"]);

                    lstHoaDonDTO.Add(hdDTO);
                }
                return lstHoaDonDTO;
            }
            return null;
        }
        public static DataTable LoadHoaDonTB()
        {
            string sChuoiTruyVan = @"select distinct Q.IdHD,nv.TenNV, kh.TenKH,hd.NgayMua,Q.TongTien
	from HOADON as hd,(select IdHD, SUM(TongTien) as TongTien from HOADON group by IdHD)Q,NHANVIEN as nv,KHACHHANG as kh
	where Q.IdHD = hd.IdHD and hd.IdNV = nv.IdNV and hd.SdtKH=kh.SdtKH ";
            DataTable dt = DbContext.TruyVanDataTable(sChuoiTruyVan);
            return dt;
        }
        public static List<HOADON_DTO> LoadHoaDonCoSo()
        {
            string sChuoiTruyVan = @"Select * From HOADON Where IdCS='" + USERAUTHENTICATED_DAL.username + "'";
            DataTable dt = DbContext.TruyVanDataTable(sChuoiTruyVan);
            HOADON_DTO hdDTO;
            if (dt != null && dt.Rows.Count > 0)
            {
                List<HOADON_DTO> lstHoaDonDTO = new List<HOADON_DTO>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    hdDTO = new HOADON_DTO();
                    hdDTO.IdHD = Convert.ToInt32(dt.Rows[i]["IdHD"]);
                    hdDTO.IdHH = Convert.ToInt32(dt.Rows[i]["IdHH"]);
                    hdDTO.SdtKH = dt.Rows[i]["SdtKH"].ToString();
                    hdDTO.IdNV = Convert.ToInt32(dt.Rows[i]["IdNV"]);
                    hdDTO.IdCS = Convert.ToInt32(dt.Rows[i]["IdCS"]);
                    hdDTO.NgayMua = Convert.ToDateTime(dt.Rows[i]["NgayMua"].ToString());
                    hdDTO.TongTien = Convert.ToInt32(dt.Rows[i]["TongTien"]);
                    hdDTO.SL = Convert.ToInt32(dt.Rows[i]["SL"]);

                    lstHoaDonDTO.Add(hdDTO);
                }
                return lstHoaDonDTO;
            }
            return null;
        }
        public static List<HOADON_DTO> LoadHoaDonCoSoTheoId(string IdHD)
        {
            string sChuoiTruyVan = @"Select * From HOADON Where IdHD= '"+IdHD+"'";
            DataTable dt = DbContext.TruyVanDataTable(sChuoiTruyVan);
            HOADON_DTO hdDTO;
            if (dt != null && dt.Rows.Count > 0)
            {
                List<HOADON_DTO> lstHoaDonDTO = new List<HOADON_DTO>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    hdDTO = new HOADON_DTO();
                    hdDTO.IdHD = Convert.ToInt32(dt.Rows[i]["IdHD"]);
                    hdDTO.IdHH = Convert.ToInt32(dt.Rows[i]["IdHH"]);
                    hdDTO.SdtKH = dt.Rows[i]["SdtKH"].ToString();
                    hdDTO.IdNV = Convert.ToInt32(dt.Rows[i]["IdNV"]);
                    hdDTO.IdCS = Convert.ToInt32(dt.Rows[i]["IdCS"]);
                    hdDTO.NgayMua = Convert.ToDateTime(dt.Rows[i]["NgayMua"].ToString());
                    hdDTO.TongTien = Convert.ToInt32(dt.Rows[i]["TongTien"]);
                    hdDTO.SL = Convert.ToInt32(dt.Rows[i]["SL"]);

                    lstHoaDonDTO.Add(hdDTO);
                }
                return lstHoaDonDTO;
            }
            return null;
        }

        public static bool ThemHoaDon(HOADON_DTO hdDTO)
        {
            string sChuoiTruyVan = string.Format("Insert into HOADON(IdHD, IdHH, SdtKH, IdNV, IdCS, NgayMua, TongTien, SL) " +
                                               "values ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}')",
                                                hdDTO.IdHD, hdDTO.IdHH, hdDTO.SdtKH, hdDTO.IdNV, hdDTO.IdCS, hdDTO.NgayMua, hdDTO.TongTien, hdDTO.SL);
            bool ketQua = DbContext.TruyVanExecuteNonQuery(sChuoiTruyVan);
            return ketQua;
        }
        public static int GetId()
        {
            string sChuoiTruyVan = @"Select MAX(IdHD) From HOADON";
            int getId = Convert.ToInt32(DbContext.TruyVanExecuteScalar(sChuoiTruyVan));
            return getId;
        }
        public static List<HOADONTONGHOP_DTO> HoaDonTongHop(string tungay, string denngay, string id)
        {
            string sChuoiTruyVan = @"select distinct Q.IdHD,nv.TenNV, kh.TenKH,hd.NgayMua,Q.TongTien
	from HOADON as hd,(select IdHD, SUM(TongTien) as TongTien from HOADON group by IdHD)Q,NHANVIEN as nv,KHACHHANG as kh
	where Q.IdHD = hd.IdHD and hd.IdNV = nv.IdNV and hd.SdtKH=kh.SdtKH and hd.NgayMua between '" + tungay + "' and '" + denngay + "' and nv.IdCS ='" + id + "' ";
            DataTable dt = DbContext.TruyVanDataTable(sChuoiTruyVan);
            HOADONTONGHOP_DTO hdthDTO;
            if (dt != null && dt.Rows.Count > 0)
            {
                List<HOADONTONGHOP_DTO> lstHoaDonDTO = new List<HOADONTONGHOP_DTO>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    hdthDTO = new HOADONTONGHOP_DTO();
                    hdthDTO.IdHD = Convert.ToInt32(dt.Rows[i]["IdHD"]);
                    hdthDTO.TenNV = (dt.Rows[i]["TenNV"]).ToString();
                    hdthDTO.TenKH = (dt.Rows[i]["TenKH"]).ToString();
                    hdthDTO.NgayMua = Convert.ToDateTime(dt.Rows[i]["NgayMua"]);

                    hdthDTO.TongTien = Convert.ToInt32(dt.Rows[i]["TongTien"]);

                    lstHoaDonDTO.Add(hdthDTO);
                }
                return lstHoaDonDTO;
            }
            return null;
        }
        public static List<HOADONTONGHOP_DTO> HoaDonTongHopCS(string tungay, string denngay)
        {
            string sChuoiTruyVan = @"select distinct Q.IdHD,nv.TenNV, kh.TenKH,hd.NgayMua,Q.TongTien
	from HOADON as hd,(select IdHD, SUM(TongTien) as TongTien from HOADON group by IdHD)Q,NHANVIEN as nv,KHACHHANG as kh
	where Q.IdHD = hd.IdHD and hd.IdNV = nv.IdNV and hd.SdtKH=kh.SdtKH and hd.NgayMua between '" + tungay + "' and '" + denngay + "' and nv.IdCS ='" + USERAUTHENTICATED_DAL.username + "' ";
            DataTable dt = DbContext.TruyVanDataTable(sChuoiTruyVan);
            HOADONTONGHOP_DTO hdthDTO;
            if (dt != null && dt.Rows.Count > 0)
            {
                List<HOADONTONGHOP_DTO> lstHoaDonDTO = new List<HOADONTONGHOP_DTO>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    hdthDTO = new HOADONTONGHOP_DTO();
                    hdthDTO.IdHD = Convert.ToInt32(dt.Rows[i]["IdHD"]);
                    hdthDTO.TenNV = (dt.Rows[i]["TenNV"]).ToString();
                    hdthDTO.TenKH = (dt.Rows[i]["TenKH"]).ToString();
                    hdthDTO.NgayMua = Convert.ToDateTime(dt.Rows[i]["NgayMua"]);

                    hdthDTO.TongTien = Convert.ToInt32(dt.Rows[i]["TongTien"]);

                    lstHoaDonDTO.Add(hdthDTO);
                }
                return lstHoaDonDTO;
            }
            return null;
        }
        public static DataTable HoaDonTongHopTheoNgay(string ngay)
        {
            string sChuoiTruyVan = @"select distinct Q.IdHD,nv.TenNV, kh.TenKH,hd.NgayMua,Q.TongTien
	from HOADON as hd,(select IdHD, SUM(TongTien) as TongTien from HOADON group by IdHD)Q,NHANVIEN as nv,KHACHHANG as kh
	where Q.IdHD = hd.IdHD and hd.IdNV = nv.IdNV and hd.SdtKH=kh.SdtKH and hd.NgayMua = '" + ngay + "' ";
            DataTable dt = DbContext.TruyVanDataTable(sChuoiTruyVan);
            return dt;
        }



    }
}
