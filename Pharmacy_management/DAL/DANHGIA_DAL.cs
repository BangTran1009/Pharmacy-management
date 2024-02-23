using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;

namespace DAL
{
    public class DANHGIA_DAL
    {
        public static List<DANHGIA_DTO> LoadDanhGia()
        {
            string sChuoiTruyVan = @"Select * From DANHGIA";
            DataTable dt = DbContext.TruyVanDataTable(sChuoiTruyVan);
            DANHGIA_DTO dgDTO;
            if (dt != null && dt.Rows.Count > 0)
            {
                List<DANHGIA_DTO> lstDanhGiaDTO = new List<DANHGIA_DTO>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dgDTO = new DANHGIA_DTO();
                    dgDTO.TenKhachHang = dt.Rows[i]["TenKhachHang"].ToString();
                    dgDTO.NgayDanhGia = Convert.ToDateTime(dt.Rows[i]["NgayDanhGia"].ToString());
                    dgDTO.NoiDung = dt.Rows[i]["NoiDung"].ToString();

                    lstDanhGiaDTO.Add(dgDTO);
                }
                return lstDanhGiaDTO;
            }
            return null;
        }

        public static bool ThemDanhGia(DANHGIA_DTO dgDTO)
        {
            string sChuoiTruyVan = string.Format("Insert into DANHGIA(TenKhachHang, NgayDanhGia, NoiDung) " +
                                               "values ('{0}', '{1}', '{2}')",
                                                dgDTO.TenKhachHang, dgDTO.NgayDanhGia, dgDTO.NoiDung);
            bool ketQua = DbContext.TruyVanExecuteNonQuery(sChuoiTruyVan);
            return ketQua;
        }
    }
}
