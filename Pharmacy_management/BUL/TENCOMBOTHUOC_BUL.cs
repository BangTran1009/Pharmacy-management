using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BUL
{
    public class TENCOMBOTHUOC_BUL
    {
        public static List<TENCOMBOTHUOC_DTO> LoadTenCBT()
        {
            return TENCOMBOTHUOC_DAL.LoadTenCBT();
        }
        public static bool ThemTenCombo(TENCOMBOTHUOC_DTO tcbDTO)
        {
            return TENCOMBOTHUOC_DAL.ThemTenCombo(tcbDTO);
        }
    }

}
