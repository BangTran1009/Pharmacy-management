using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;

namespace DAL
{
    public class COSO_DAL
    {
        public static List<COSO_DTO> LoadCoSo()
        {
            string sChuoiTruyVan = @"Select * From COSO";
            DataTable dt = DbContext.TruyVanDataReader(sChuoiTruyVan);
            COSO_DTO csDTO;
            if (dt != null && dt.Rows.Count > 0)
            {
                List<COSO_DTO> lstCoSoDTO = new List<COSO_DTO>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    csDTO = new COSO_DTO();
                    csDTO.IdNhaThuoc = Convert.ToInt32(dt.Rows[i]["IdCS"]);
                    csDTO.IDNguoiQL = Convert.ToInt32(dt.Rows[i]["IdNQL"]);
                    csDTO.DiaChi = dt.Rows[i]["DiaChi"].ToString();
                    lstCoSoDTO.Add(csDTO);
                }
                return lstCoSoDTO;
            }
            return null;
        }

        public static bool ThemCoSo(COSO_DTO csDTO)
        {
            string sChuoiTruyVan = string.Format("Insert into COSO(IdCS, IdNQL, DiaChi)" +
                                               "values ('{0}', '{1}', '{2}')",
                                                csDTO.IdNhaThuoc, csDTO.IDNguoiQL, csDTO.DiaChi);
            bool ketQua = DbContext.TruyVanExecuteNonQuery(sChuoiTruyVan);
            return ketQua;
        }

        public static bool SuaCoSo(COSO_DTO csDTO)
        {
            string sChuoiTruyVan = string.Format("Update COSO set IdNQL = '{0}', DiaChi = '{1}' where IdCS = '{2}'",
                                                            csDTO.IDNguoiQL, csDTO.DiaChi, csDTO.IdNhaThuoc);
            return DbContext.TruyVanExecuteNonQuery(sChuoiTruyVan);
        }

        public static bool XoaCoSo(int IdCS)
        {
            string sChuoiTruyVan = string.Format("Delete from COSO where IdCS = '{0}'", IdCS);
            return DbContext.TruyVanExecuteNonQuery(sChuoiTruyVan);
        }
        public static List<COSO_DTO> TimCoSo(string tuKhoa)
        {
            string sChuoiTruyVan = String.Format(@"Select * From COSO where IdCS like '%{0}%' or DiaChi like '%{0}%'", tuKhoa);
            DataTable dt = DbContext.TruyVanDataReader(sChuoiTruyVan);
            COSO_DTO csDTO;
            if (dt != null && dt.Rows.Count > 0)
            {
                List<COSO_DTO> lstCoSoDTO = new List<COSO_DTO>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    csDTO = new COSO_DTO();
                    csDTO.IdNhaThuoc = Convert.ToInt32(dt.Rows[i]["IdCS"]);
                    csDTO.IDNguoiQL = Convert.ToInt32(dt.Rows[i]["IdNQL"]);
                    csDTO.DiaChi = dt.Rows[i]["DiaChi"].ToString();
                    lstCoSoDTO.Add(csDTO);
                }
                return lstCoSoDTO;
            }
            return null;
        }
        public static COSO_DTO TimCoSoTheoId(string tuKhoa)
        {
            string sChuoiTruyVan = String.Format(@"Select * From COSO where IdCS like '{0}' ", tuKhoa);
            DataTable dt = DbContext.TruyVanDataReader(sChuoiTruyVan);
            COSO_DTO csDTO;
            if (dt != null && dt.Rows.Count > 0)
            {
                csDTO = new COSO_DTO();
                csDTO.IdNhaThuoc = Convert.ToInt32(dt.Rows[0]["IdCS"]);
                csDTO.IDNguoiQL = Convert.ToInt32(dt.Rows[0]["IdNQL"]);
                csDTO.DiaChi = dt.Rows[0]["DiaChi"].ToString();
                return csDTO;
            }
            return null;
        }
    }
}
