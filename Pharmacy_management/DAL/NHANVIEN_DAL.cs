using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;

namespace DAL
{
    public class NHANVIEN_DAL
    {
        public static List<NHANVIEN_DTO> LoadNhanVien()
        {
            string sChuoiTruyVan = @"Select * From NHANVIEN";
            DataTable dt = DbContext.TruyVanDataTable(sChuoiTruyVan);
            NHANVIEN_DTO nvDTO;
            if (dt != null && dt.Rows.Count > 0)
            {
                List<NHANVIEN_DTO> lstNhanVienDTO = new List<NHANVIEN_DTO>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    nvDTO = new NHANVIEN_DTO();
                    nvDTO.IdNV = Convert.ToInt32(dt.Rows[i]["IdNV"]);
                    nvDTO.TenNV = dt.Rows[i]["TenNV"].ToString();
                    nvDTO.SdtNV = dt.Rows[i]["SdtNV"].ToString();
                    nvDTO.NgSinhNV = Convert.ToDateTime(dt.Rows[i]["NgaySinhNV"].ToString());
                    nvDTO.DiaChiNV = dt.Rows[i]["DiaChiNV"].ToString();
                    nvDTO.Ca = Convert.ToInt32(dt.Rows[i]["Ca"]);
                    nvDTO.ViTri = Convert.ToInt32(dt.Rows[i]["ViTri"]);
                    nvDTO.IdNhaThuoc = Convert.ToInt32(dt.Rows[i]["IdCS"]);
                    nvDTO.Luong = Convert.ToInt32(dt.Rows[i]["Luong"]);

                    lstNhanVienDTO.Add(nvDTO);
                }
                return lstNhanVienDTO;
            }
            return null;
        }

        public static bool ThemNhanVien(NHANVIEN_DTO nvDTO)
        {
            string sChuoiTruyVan = string.Format("Insert into NHANVIEN(IdNV, TenNV, SdtNV, NgaySinhNV, DiaChiNV, Ca, ViTri, IdCS, Luong) " +
                                               "values ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}')",
                                                nvDTO.IdNV, nvDTO.TenNV, nvDTO.SdtNV, nvDTO.NgSinhNV, nvDTO.DiaChiNV, nvDTO.Ca, nvDTO.ViTri, nvDTO.IdNhaThuoc, nvDTO.Luong);
            bool ketQua = DbContext.TruyVanExecuteNonQuery(sChuoiTruyVan);
            return ketQua;
        }

        public static bool CapNhapNhanVien(NHANVIEN_DTO nvDTO)
        {
            string sChuoiTruyVan = string.Format("Update NHANVIEN set TenNV = '{0}', SdtNV = '{1}', NgaySinhNV = '{2}'," +
                                                                " DiaChiNV = '{3}', Ca = '{4}', ViTri = '{5}', IdCS = '{6}'," +
                                                                " Luong = '{7}' where IdNV = '{8}'",
                                                            nvDTO.TenNV, nvDTO.SdtNV, nvDTO.NgSinhNV, nvDTO.DiaChiNV,
                                                            nvDTO.Ca, nvDTO.ViTri, nvDTO.IdNhaThuoc, nvDTO.Luong, nvDTO.IdNV);
            return DbContext.TruyVanExecuteNonQuery(sChuoiTruyVan);
        }

        public static bool XoaNhanVien(int IdNV)
        {
            string sChuoiTruyVan = string.Format("Delete from TAIKHOAN where IdNV = {0} Update COSO set IdNQL=NULL where IdNQL = {0} Delete from NHANVIEN where IdNV = {0}", IdNV);
            return DbContext.TruyVanExecuteNonQuery(sChuoiTruyVan);
        }
        public static List<NHANVIEN_DTO> TimNhanVien(string sChuoiTruyVan)
        {
            DataTable dt = DbContext.TruyVanDataTable(sChuoiTruyVan);
            NHANVIEN_DTO nvDTO;
            if (dt != null && dt.Rows.Count > 0)
            {
                List<NHANVIEN_DTO> lstNhanVienDTO = new List<NHANVIEN_DTO>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    nvDTO = new NHANVIEN_DTO();

                    nvDTO.IdNV = Convert.ToInt32(dt.Rows[i]["IdNV"]);
                    nvDTO.TenNV = dt.Rows[i]["TenNV"].ToString();
                    nvDTO.SdtNV = dt.Rows[i]["SdtNV"].ToString();
                    nvDTO.NgSinhNV = Convert.ToDateTime(dt.Rows[i]["NgaySinhNV"].ToString());
                    nvDTO.DiaChiNV = dt.Rows[i]["DiaChiNV"].ToString();
                    nvDTO.Ca = Convert.ToInt32(dt.Rows[i]["Ca"]);
                    nvDTO.ViTri = Convert.ToInt32(dt.Rows[i]["ViTri"]);
                    nvDTO.IdNhaThuoc = Convert.ToInt32(dt.Rows[i]["IdCS"]);
                    nvDTO.Luong = Convert.ToInt32(dt.Rows[i]["Luong"]);

                    lstNhanVienDTO.Add(nvDTO);
                }
                return lstNhanVienDTO;
            }
            return null;
        }
        public static List<NHANVIEN_DTO> LoadNhanVienCoSo()
        {
            string sChuoiTruyVan = @"Select * From NHANVIEN Where IdCS=(Select IdCS From NHANVIEN Where IdNV='" + USERAUTHENTICATED_DAL.username + "')";
            DataTable dt = DbContext.TruyVanDataTable(sChuoiTruyVan);
            NHANVIEN_DTO nvDTO;
            if (dt != null && dt.Rows.Count > 0)
            {
                List<NHANVIEN_DTO> lstNhanVienDTO = new List<NHANVIEN_DTO>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    nvDTO = new NHANVIEN_DTO();
                    nvDTO.IdNV = Convert.ToInt32(dt.Rows[i]["IdNV"]);
                    nvDTO.TenNV = dt.Rows[i]["TenNV"].ToString();
                    nvDTO.SdtNV = dt.Rows[i]["SdtNV"].ToString();
                    nvDTO.NgSinhNV = Convert.ToDateTime(dt.Rows[i]["NgaySinhNV"].ToString());
                    nvDTO.DiaChiNV = dt.Rows[i]["DiaChiNV"].ToString();
                    nvDTO.Ca = Convert.ToInt32(dt.Rows[i]["Ca"]);
                    nvDTO.ViTri = Convert.ToInt32(dt.Rows[i]["ViTri"]);
                    nvDTO.IdNhaThuoc = Convert.ToInt32(dt.Rows[i]["IdCS"]);
                    nvDTO.Luong = Convert.ToInt32(dt.Rows[i]["Luong"]);

                    lstNhanVienDTO.Add(nvDTO);
                }
                return lstNhanVienDTO;
            }
            return null;
        }
        public static List<LUONGNHANVIEN_DTO> LuongNhanVienCS(string id)
        {
            string sChuoiTruyVan = @"Select * From NHANVIEN Where IdCS='" + id + "'";
            DataTable dt = DbContext.TruyVanDataTable(sChuoiTruyVan);
            LUONGNHANVIEN_DTO nvDTO;
            if (dt != null && dt.Rows.Count > 0)
            {
                List<LUONGNHANVIEN_DTO> lstNhanVienDTO = new List<LUONGNHANVIEN_DTO>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    nvDTO = new LUONGNHANVIEN_DTO();
                    nvDTO.TenNV = dt.Rows[i]["TenNV"].ToString();
                    nvDTO.IdCS = Convert.ToInt32(dt.Rows[i]["IdCS"]);
                    nvDTO.Luong = Convert.ToInt32(dt.Rows[i]["Luong"]);

                    lstNhanVienDTO.Add(nvDTO);
                }
                return lstNhanVienDTO;
            }
            return null;
        }
        public static List<LUONGNHANVIEN_DTO> LuongNhanVien()
        {
            string sChuoiTruyVan = @"Select * From NHANVIEN Where IdNV='" + USERAUTHENTICATED_DAL.username + "'";
            DataTable dt = DbContext.TruyVanDataTable(sChuoiTruyVan);
            LUONGNHANVIEN_DTO nvDTO;
            if (dt != null && dt.Rows.Count > 0)
            {
                List<LUONGNHANVIEN_DTO> lstNhanVienDTO = new List<LUONGNHANVIEN_DTO>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    nvDTO = new LUONGNHANVIEN_DTO();
                    nvDTO.TenNV = dt.Rows[i]["TenNV"].ToString();
                    nvDTO.IdCS = Convert.ToInt32(dt.Rows[i]["IdCS"]);
                    nvDTO.Luong = Convert.ToInt32(dt.Rows[i]["Luong"]);

                    lstNhanVienDTO.Add(nvDTO);
                }
                return lstNhanVienDTO;
            }
            return null;
        }
        public static NHANVIEN_DTO NhanVienHienTai()
        {
            string sChuoiTruyVan = @"Select * From NHANVIEN Where IdNV='" + USERAUTHENTICATED_DAL.username + "'";
            DataTable dt = DbContext.TruyVanDataTable(sChuoiTruyVan);
            NHANVIEN_DTO nvDTO;
            if (dt != null)
            {
                nvDTO = new NHANVIEN_DTO();
                nvDTO.IdNV = Convert.ToInt32(dt.Rows[0]["IdNV"]);
                nvDTO.TenNV = dt.Rows[0]["TenNV"].ToString();
                nvDTO.SdtNV = dt.Rows[0]["SdtNV"].ToString();
                nvDTO.NgSinhNV = Convert.ToDateTime(dt.Rows[0]["NgaySinhNV"].ToString());
                nvDTO.DiaChiNV = dt.Rows[0]["DiaChiNV"].ToString();
                nvDTO.Ca = Convert.ToInt32(dt.Rows[0]["Ca"]);
                nvDTO.ViTri = Convert.ToInt32(dt.Rows[0]["ViTri"]);
                nvDTO.IdNhaThuoc = Convert.ToInt32(dt.Rows[0]["IdCS"]);
                nvDTO.Luong = Convert.ToInt32(dt.Rows[0]["Luong"]);

                return nvDTO;
            }
            return null;
        }
        public static DataTable LuongNhanVienTB()
        {
            string sChuoiTruyVan = @"select TenNV, IdCS, Luong  from NHANVIEN";
            DataTable dt = DbContext.TruyVanDataTable(sChuoiTruyVan);
            return dt;
        }
    }
}
