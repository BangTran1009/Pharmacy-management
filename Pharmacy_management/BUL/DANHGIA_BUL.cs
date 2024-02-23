using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BUL
{
    public class DANHGIA_BUL
    {
        public static List<DANHGIA_DTO> LoadDanhGia()
        {
            return DANHGIA_DAL.LoadDanhGia();
        }
        public static bool ThemDanhGia(DANHGIA_DTO dgDTO)
        {
            return DANHGIA_DAL.ThemDanhGia(dgDTO);
        }
    }
}
