using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BUL
{
    public class NHACUNGCAP_BUL
    {
        public static List<NHACUNGCAP_DTO> LoadNhaCungCap()
        {
            return NHACUNGCAP_DAL.LoadNhaCungCap();
        }
    }
}
