using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;

namespace DAL
{
    public class CALAM_DAL
    {
        public static List<CALAM_DTO> LoadCaLam()
        {
            string sChuoiTruyVan = @"Select * From CALAM";
            DataTable dt = DbContext.TruyVanDataReader(sChuoiTruyVan);
            CALAM_DTO clDTO;
            if (dt != null && dt.Rows.Count > 0)
            {
                List<CALAM_DTO> lstCaLamDTO = new List<CALAM_DTO>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    clDTO = new CALAM_DTO();
                    clDTO.Id = Convert.ToInt32(dt.Rows[i]["IdC"]);
                    clDTO.TenCa = dt.Rows[i]["TenC"].ToString();
                    lstCaLamDTO.Add(clDTO);
                }
                return lstCaLamDTO;
            }
            return null;
        }
    }
}
