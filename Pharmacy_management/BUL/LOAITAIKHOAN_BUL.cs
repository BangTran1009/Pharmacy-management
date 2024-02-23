using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BUL
{
    public class LOAITAIKHOAN_BUL
    {
        public static List<LOAITAIKHOAN_DTO> LoadLoaiTK()
        {
            return LOAITAIKHOAN_DAL.LoadLoaiTK();
        }
    }
}
