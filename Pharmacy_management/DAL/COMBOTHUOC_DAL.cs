using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
namespace DAL
{
    public class COMBOTHUOC_DAL
    {
        public static List<COMBOTHUOC_DTO> LoadCB()
        {
            string sChuoiTruyVan = @"Select * From COMBOTHUOC";
            DataTable dt = DbContext.TruyVanDataTable(sChuoiTruyVan);
            COMBOTHUOC_DTO cbDTO;
            if (dt != null && dt.Rows.Count > 0)
            {
                List<COMBOTHUOC_DTO> lstTenCBT = new List<COMBOTHUOC_DTO>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    cbDTO = new COMBOTHUOC_DTO();
                    cbDTO.IdCBT = Convert.ToInt32(dt.Rows[i]["IdCBT"]);
                    cbDTO.IdHH = Convert.ToInt32(dt.Rows[i]["IdHH"]);
                    cbDTO.IdTenCB = Convert.ToInt32(dt.Rows[i]["IdTenCB"]);
                    cbDTO.SL = Convert.ToInt32(dt.Rows[i]["SL"]);

                    lstTenCBT.Add(cbDTO);
                }
                return lstTenCBT;
            }
            return null;
        }
        public static List<COMBOTHUOC_DTO> TimCB(string sChuoiTruyVan)
        {

            DataTable dt = DbContext.TruyVanDataTable(sChuoiTruyVan);
            COMBOTHUOC_DTO cbDTO;
            if (dt != null && dt.Rows.Count > 0)
            {
                List<COMBOTHUOC_DTO> lstCB = new List<COMBOTHUOC_DTO>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    cbDTO = new COMBOTHUOC_DTO();
                    cbDTO.IdCBT = Convert.ToInt32(dt.Rows[i]["IdCBT"]);
                    cbDTO.IdHH = Convert.ToInt32(dt.Rows[i]["IdHH"]);
                    cbDTO.IdTenCB = Convert.ToInt32(dt.Rows[i]["IdTenCB"]);
                    cbDTO.SL = Convert.ToInt32(dt.Rows[i]["SL"]);

                    lstCB.Add(cbDTO);
                }
                return lstCB;
            }
            return null;
        }
        
        public static bool ThemCombo(COMBOTHUOC_DTO cbDTO,TENCOMBOTHUOC_DTO tcbDTO)
        {
           
            string sChuoiTruyVan = string.Format(" Insert into TENCOMBOTHUOC(IdTenCB, TenCB) values ('{0}', '{1}') Insert into COMBOTHUOC(IdCBT, IdHH, IdTenCB, SL) " +
                                               "values ('{2}', '{3}', '{4}', '{5}') ",
                                                  tcbDTO.IdTenCB, tcbDTO.TenCB, cbDTO.IdCBT,cbDTO.IdHH,cbDTO.IdCBT,cbDTO.SL);
            bool ketQua = DbContext.TruyVanExecuteNonQuery(sChuoiTruyVan);
            return ketQua;
        }
        public static int Getidcb()
        {
            string sChuoiTruyVan = @"Select max(IdCBT) From COMBOTHUOC";
            int getId = Convert.ToInt32(DbContext.TruyVanExecuteScalar(sChuoiTruyVan));
            return getId;
        }
    }
}
