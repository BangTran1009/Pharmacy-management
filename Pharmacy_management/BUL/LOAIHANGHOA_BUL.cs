using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BUL
{
    public class LOAIHANGHOA_BUL
    {
        public static List<LOAIHANGHOA_DTO> LoadLoaiHang()
        {
            return LOAIHANGHOA_DAL.LoadLoaiHang();
        }
    }
}
