using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;

namespace DAL
{
    public class LOAIHANGHOA_DAL
    {
        public static List<LOAIHANGHOA_DTO> LoadLoaiHang()
        {
            string sChuoiTruyVan = @"Select * From LOAIHANGHOA";
            DataTable dt = DbContext.TruyVanDataTable(sChuoiTruyVan);
            LOAIHANGHOA_DTO LoaiHHDTO;
            if (dt != null && dt.Rows.Count > 0)
            {
                List<LOAIHANGHOA_DTO> lstLoaiHHDTO = new List<LOAIHANGHOA_DTO>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    LoaiHHDTO = new LOAIHANGHOA_DTO();
                    LoaiHHDTO.IdLoaiHH = Convert.ToInt32(dt.Rows[i]["IdLHH"]);
                    LoaiHHDTO.TenLoaiHH = dt.Rows[i]["TenLHangHoa"].ToString();

                    lstLoaiHHDTO.Add(LoaiHHDTO);
                }
                return lstLoaiHHDTO;
            }
            return null;
        }
    }
}
