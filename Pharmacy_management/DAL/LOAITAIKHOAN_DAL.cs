using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;

namespace DAL
{
    public class LOAITAIKHOAN_DAL
    {
        public static List<LOAITAIKHOAN_DTO> LoadLoaiTK()
        {
            string sChuoiTruyVan = @"Select * From LOAITK";
            DataTable dt = DbContext.TruyVanDataTable(sChuoiTruyVan);
            LOAITAIKHOAN_DTO LoaitkDTO;
            if (dt != null && dt.Rows.Count > 0)
            {
                List<LOAITAIKHOAN_DTO> lstLoaiTaiKhoanDTO = new List<LOAITAIKHOAN_DTO>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    LoaitkDTO = new LOAITAIKHOAN_DTO();
                    LoaitkDTO.IdLoaiTK = Convert.ToInt32(dt.Rows[i]["IdLoaiTK"]);
                    LoaitkDTO.TenLoaiTK = dt.Rows[i]["TenLoaiTK"].ToString();

                    lstLoaiTaiKhoanDTO.Add(LoaitkDTO);
                }
                return lstLoaiTaiKhoanDTO;
            }
            return null;
        }
    } 
}
