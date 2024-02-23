using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;

namespace DAL
{
    public class VOUCHER_DAL
    {
        public static DataTable LoadVC()
        {
            string sChuoiTruyVan = @"Select * From VOUCHER";
            DataTable dt = DbContext.TruyVanDataTable(sChuoiTruyVan);
            return dt;
        }
        public static bool ThemVC(VOUCHER_DTO vcDTO)
        {
            string sChuoiTruyVan = string.Format("Insert into VOUCHER(IdVC, NgayHH,Giamgia) " +
                                               "values ('{0}', '{1}','{2}')",
                                                vcDTO.IdVC, vcDTO.NgayHH, vcDTO.Giamgia);
            bool ketQua = DbContext.TruyVanExecuteNonQuery(sChuoiTruyVan);
            return ketQua;
        }

     
        public static string GetIdVC ()
        {
            string sChuoiTruyVan = @"SELECT IdVC FROM VOUCHER WHERE IdVC not in (SELECT TOP (SELECT COUNT(1)-1 FROM VOUCHER) IdVC FROM VOUCHER)";
            string getId = DbContext.TruyVanExecuteScalar(sChuoiTruyVan);
            return getId;
        }

    }
}
