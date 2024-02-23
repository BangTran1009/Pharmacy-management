using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;

namespace DAL
{
    public class NHACUNGCAP_DAL
    {
        public static List<NHACUNGCAP_DTO> LoadNhaCungCap()
        {
            string sChuoiTruyVan = @"Select * From NHACUNGCAP";
            DataTable dt = DbContext.TruyVanDataTable(sChuoiTruyVan);
            NHACUNGCAP_DTO NhaCungCapDTO;
            if (dt != null && dt.Rows.Count > 0)
            {
                List<NHACUNGCAP_DTO> lstNhaCungCapDTO = new List<NHACUNGCAP_DTO>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    NhaCungCapDTO = new NHACUNGCAP_DTO();
                    NhaCungCapDTO.IdNhaCC = Convert.ToInt32(dt.Rows[i]["IdNhaCC"]);
                    NhaCungCapDTO.TenNhaCC = dt.Rows[i]["TenNhaCC"].ToString();

                    lstNhaCungCapDTO.Add(NhaCungCapDTO);
                }
                return lstNhaCungCapDTO;
            }
            return null;
        }
    }
}
