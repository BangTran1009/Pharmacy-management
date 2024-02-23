using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BUL
{
    public class COMBOTHUOC_BUL
    {
        public static List<COMBOTHUOC_DTO> LoadCB()
        {
            return COMBOTHUOC_DAL.LoadCB();
        }
        public static List<COMBOTHUOC_DTO> TimCB(string sChuoiTruyVan)
        {
            return COMBOTHUOC_DAL.TimCB(sChuoiTruyVan);
        }
        public static bool ThemCombo(COMBOTHUOC_DTO cbDTO, TENCOMBOTHUOC_DTO tcbDTO)
        {
            return COMBOTHUOC_DAL.ThemCombo(cbDTO, tcbDTO);
        }
        public static int Getidcb()
        {
            return COMBOTHUOC_DAL.Getidcb();
        }
    }
}
