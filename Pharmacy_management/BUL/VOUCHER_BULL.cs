using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Data;

namespace BUL
{
    public class VOUCHER_BULL
    {
        public static DataTable LoadVC()
        {
            return VOUCHER_DAL.LoadVC();
        }
        public static bool ThemVC(VOUCHER_DTO vcDTO)
        {
            return VOUCHER_DAL.ThemVC(vcDTO);
        }
        public static string GetIdVC()
        {
            return VOUCHER_DAL.GetIdVC();
        }
    }
}
