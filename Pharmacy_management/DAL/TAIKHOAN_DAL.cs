using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;

namespace DAL
{
    public class TAIKHOAN_DAL
    {
        public static List<TAIKHOAN_DTO> LoadTaiKhoan()
        {
            string sChuoiTruyVan = @"Select * From TAIKHOAN";
            DataTable dt = DbContext.TruyVanDataReader(sChuoiTruyVan);
            TAIKHOAN_DTO tkDTO;
            if (dt != null && dt.Rows.Count > 0)
            {
                List<TAIKHOAN_DTO> lstTaiKhoanDTO = new List<TAIKHOAN_DTO>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    tkDTO = new TAIKHOAN_DTO();
                    tkDTO.TaiKhoan = Convert.ToInt32(dt.Rows[i]["IdNV"]);
                    tkDTO.MatKhau = dt.Rows[i]["MK"].ToString();
                    tkDTO.LoaiTK = Convert.ToInt32(dt.Rows[i]["IdLoaiTK"]);
                    lstTaiKhoanDTO.Add(tkDTO);
                }
                return lstTaiKhoanDTO;
            }
            return null;
        }
        public static bool ThemTaiKhoan(TAIKHOAN_DTO tkDTO)
        {
            string sChuoiTruyVan = string.Format("Insert into TAIKHOAN(IdNV , MK, IdLoaiTK) " +
                                               "values ('{0}', '{1}', '{2}')",
                                                tkDTO.TaiKhoan, tkDTO.MatKhau, tkDTO.LoaiTK);
            bool ketQua = DbContext.TruyVanExecuteNonQuery(sChuoiTruyVan);
            return ketQua;
        }
        public static bool SuaTaiKhoan(TAIKHOAN_DTO tkDTO)
        {
            string sChuoiTruyVan = string.Format("Update TAIKHOAN set MK = '{0}', IdLoaiTK = '{1}' where IdNV = '{2}'",
                                                            tkDTO.MatKhau, tkDTO.LoaiTK, tkDTO.TaiKhoan);
            return DbContext.TruyVanExecuteNonQuery(sChuoiTruyVan);
        }

        public static bool XoaTaiKhoan(int IdTaiKhoan)
        {
            string sChuoiTruyVan = string.Format("Delete from TAIKHOAN where IdNV = '{0}'", IdTaiKhoan);
            return DbContext.TruyVanExecuteNonQuery(sChuoiTruyVan);
        }
        public static List<TAIKHOAN_DTO> TimTaiKhoan(string sChuoiTruyVan)
        {
            DataTable dt = DbContext.TruyVanDataReader(sChuoiTruyVan);
            TAIKHOAN_DTO tkDTO;
            if (dt != null && dt.Rows.Count > 0)
            {
                List<TAIKHOAN_DTO> lstTaiKhoanDTO = new List<TAIKHOAN_DTO>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    tkDTO = new TAIKHOAN_DTO();
                    tkDTO.TaiKhoan = Convert.ToInt32(dt.Rows[i]["IdNV"]);
                    tkDTO.MatKhau = dt.Rows[i]["MK"].ToString();
                    tkDTO.LoaiTK = Convert.ToInt32(dt.Rows[i]["IdLoaiTK"]);
                    lstTaiKhoanDTO.Add(tkDTO);
                }
                return lstTaiKhoanDTO;
            }
            return null;
        }
        public static List<TAIKHOAN_DTO> LoadTaiKhoanCoSo()
        {
            string sChuoiTruyVan = @"Select TAIKHOAN.IdNV, MK, IdLoaiTK from TAIKHOAN, NHANVIEN where TAIKHOAN.IdNV=NHANVIEN.IdNV and NHANVIEN.IdCS='" + USERAUTHENTICATED_DAL.username + "'";
            DataTable dt = DbContext.TruyVanDataTable(sChuoiTruyVan);
            TAIKHOAN_DTO tkDTO;
            if (dt != null && dt.Rows.Count > 0)
            {
                List<TAIKHOAN_DTO> lstTaiKhoanDTO = new List<TAIKHOAN_DTO>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    tkDTO = new TAIKHOAN_DTO();
                    tkDTO.TaiKhoan = Convert.ToInt32(dt.Rows[i]["IdNV"]);
                    tkDTO.MatKhau = dt.Rows[i]["MK"].ToString();
                    tkDTO.LoaiTK = Convert.ToInt32(dt.Rows[i]["IdLoaiTK"]);
                    lstTaiKhoanDTO.Add(tkDTO);
                }
                return lstTaiKhoanDTO;
            }
            return null;
        }
    }
}
