using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;

namespace DAL
{
    public class LOAINHANVIEN_DAL
    {
        public static List<VITRI_DTO> LoadLoaiNhanVien()
        {
            string sChuoiTruyVan = @"Select * From VITRI";
            DataTable dt = DbContext.TruyVanDataReader(sChuoiTruyVan);
            VITRI_DTO vtDTO;
            if (dt != null && dt.Rows.Count > 0)
            {
                List<VITRI_DTO> lstViTriDTO = new List<VITRI_DTO>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    vtDTO = new VITRI_DTO();
                    vtDTO.IdViTri = Convert.ToInt32(dt.Rows[i]["IDVT"]);
                    vtDTO.TenViTri = dt.Rows[i]["TenVT"].ToString();
                    lstViTriDTO.Add(vtDTO);
                }
                return lstViTriDTO;
            }
            return null;
        }
    }
}
