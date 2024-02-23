using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BUL
{
    public class COSO_BUL
    {
        public static List<COSO_DTO> LoadCoSo()
        {
            return COSO_DAL.LoadCoSo();
        }
        public static bool ThemCoSo(COSO_DTO csDTO)
        {
            return COSO_DAL.ThemCoSo(csDTO);
        }
        public static bool SuaCoSo(COSO_DTO csDTO)
        {
            return COSO_DAL.SuaCoSo(csDTO);
        }
        public static bool XoaCoSo(int IdCoSo)
        {
            return COSO_DAL.XoaCoSo(IdCoSo);
        }
        public static List<COSO_DTO> TimCoSo(string tuKhoa)
        {
            return COSO_DAL.TimCoSo(tuKhoa);
        }
        public static COSO_DTO TimCoSoTheoId(string tuKhoa)
        {
            return COSO_DAL.TimCoSoTheoId(tuKhoa);
        }
    }
}
