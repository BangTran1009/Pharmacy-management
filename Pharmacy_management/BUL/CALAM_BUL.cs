using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BUL
{
    public class CALAM_BUL
    {
        public static List<CALAM_DTO> LoadCaLam()
        {
            return CALAM_DAL.LoadCaLam();
        }
    }
}
