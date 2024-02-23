using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;

namespace DAL
{
    public class TENCOMBOTHUOC_DAL
    {
        public static List<TENCOMBOTHUOC_DTO> LoadTenCBT()
        {
            string sChuoiTruyVan = @"Select * From TENCOMBOTHUOC";
            DataTable dt = DbContext.TruyVanDataTable(sChuoiTruyVan);
            TENCOMBOTHUOC_DTO tcbDTO;
            if (dt != null && dt.Rows.Count > 0)
            {
                List<TENCOMBOTHUOC_DTO> lstTenCBT = new List<TENCOMBOTHUOC_DTO>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    tcbDTO = new TENCOMBOTHUOC_DTO();
                    tcbDTO.IdTenCB = Convert.ToInt32(dt.Rows[i]["IdTenCB"]);
                    tcbDTO.TenCB = dt.Rows[i]["TenCB"].ToString();
                    lstTenCBT.Add(tcbDTO);
                }
                return lstTenCBT;
            }
            return null;
        }

        public static bool ThemTenCombo(TENCOMBOTHUOC_DTO tcbDTO)
        {
            string sChuoiTruyVan = string.Format("Insert into TENCOMBOTHUOC(IdTenCB, TenCB) " +
                                               "values ('{0}', '{1}')",
                                                tcbDTO.IdTenCB, tcbDTO.TenCB);
            bool ketQua = DbContext.TruyVanExecuteNonQuery(sChuoiTruyVan);
            return ketQua;
        }
    } 
}
