using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;

namespace DAL
{
    public class KHO_DAL
    {
        public static List<KHO_DTO> LoadKho()
        {
            string sChuoiTruyVan = @"Select * From KHO";
            DataTable dt = DbContext.TruyVanDataTable(sChuoiTruyVan);
            KHO_DTO KhoDTO;
            if (dt != null && dt.Rows.Count > 0)
            {
                List<KHO_DTO> lstKhoDTO = new List<KHO_DTO>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    KhoDTO = new KHO_DTO();
                    KhoDTO.IdHH = Convert.ToInt32(dt.Rows[i]["IdHH"]);
                    KhoDTO.IdLoaiHH = Convert.ToInt32(dt.Rows[i]["IdLHH"]);
                    KhoDTO.IdNhaCC = Convert.ToInt32(dt.Rows[i]["IdNhaCC"]);
                    KhoDTO.TenHH = dt.Rows[i]["TenHH"].ToString();
                    KhoDTO.NSX = Convert.ToDateTime(dt.Rows[i]["NSX"].ToString());
                    KhoDTO.HSD = Convert.ToDateTime(dt.Rows[i]["HSD"].ToString());
                    KhoDTO.Gia = Convert.ToDouble(dt.Rows[i]["Gia"]);
                    KhoDTO.SoLuong = Convert.ToInt32(dt.Rows[i]["SL"]);
                    KhoDTO.SoLuongCS1 = Convert.ToInt32(dt.Rows[i]["SLCS1"]);
                    KhoDTO.SoLuongCS2 = Convert.ToInt32(dt.Rows[i]["SLCS2"]);
                    KhoDTO.SoLuongCS3 = Convert.ToInt32(dt.Rows[i]["SLCS3"]);
                    KhoDTO.SoLuongCS4 = Convert.ToInt32(dt.Rows[i]["SLCS4"]);
                    KhoDTO.NgayNhap = Convert.ToDateTime(dt.Rows[i]["NgayN"].ToString());

                    lstKhoDTO.Add(KhoDTO);
                }
                return lstKhoDTO;
            }
            return null;
        }

        public static bool ThemHangHoa(KHO_DTO HangHoa)
        {
            string sChuoiTruyVan = string.Format("Insert into KHO(IdHH, IdLHH, IdNhaCC, TenHH, NSX, HSD, Gia, SL, SLCS1, SLCS2, SLCS3, SLCS4, NgayN)" +
                                                " values ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}')",
                                                HangHoa.IdHH, HangHoa.IdLoaiHH, HangHoa.IdNhaCC, HangHoa.TenHH, HangHoa.NSX,
                                                HangHoa.HSD, HangHoa.Gia, HangHoa.SoLuong, HangHoa.SoLuongCS1, HangHoa.SoLuongCS2, HangHoa.SoLuongCS3, HangHoa.SoLuongCS4, HangHoa.NgayNhap);
            bool ketQua = DbContext.TruyVanExecuteNonQuery(sChuoiTruyVan);
            return ketQua;
        }
        public static bool SuaHangHoa(KHO_DTO HangHoa)
        {
            string sChuoiTruyVan = string.Format("Update KHO set IdLHH = '{0}', IdNhaCC = '{1}', TenHH = '{2}'," +
                                                                " NSX = '{3}', HSD = '{4}', Gia = '{5}', SL= '{6}', NgayN = '{7}' where IdHH = '{8}'",
                                                            HangHoa.IdLoaiHH, HangHoa.IdNhaCC, HangHoa.TenHH, HangHoa.NSX,
                                                            HangHoa.HSD, HangHoa.Gia,HangHoa.SoLuong, HangHoa.NgayNhap, HangHoa.IdHH);

            return DbContext.TruyVanExecuteNonQuery(sChuoiTruyVan);

        }
        public static bool UpdateHH(KHO_DTO HangHoa)
        {
            string sChuoiTruyVan = string.Format("Update KHO set SL = '{0}', SLCS1 = '{1}', SLCS2 = '{2}'," +
                                                                " SLCS3 = '{3}', SLCS4 = '{4}' where IdHH like '{5}'",
                                                            HangHoa.SoLuong, HangHoa.SoLuongCS1, HangHoa.SoLuongCS2, HangHoa.SoLuongCS3,
                                                            HangHoa.SoLuongCS4,HangHoa.IdHH);

            return DbContext.TruyVanExecuteNonQuery(sChuoiTruyVan);

        }
        public static bool PhanPhoiHangHoa(KHO_DTO HangHoa)
        {
            string sChuoiTruyVan = string.Format("Update KHO set SLCS1 = '{0}'+(select  SLCS1 from KHO where IdHH = '{4}'), SLCS2 = '{1}'+(select  SLCS2 from KHO where IdHH = '{4}')," +
                                                                " SLCS3 = '{2}'+(select  SLCS3 from KHO where IdHH = '{4}'), SLCS4 = '{3}'+(select  SLCS4 from KHO where IdHH = '{4}'), SL=(select  SL from KHO where IdHH = '{4}')-'{0}'-'{1}'-'{2}'-'{3}' where IdHH='{4}'",
                                                            HangHoa.SoLuongCS1,HangHoa.SoLuongCS2,HangHoa.SoLuongCS3,HangHoa.SoLuongCS4, HangHoa.IdHH);

            return DbContext.TruyVanExecuteNonQuery(sChuoiTruyVan);

        }
        public static bool XoaHangHoa(int IdHH)
        {
            string sChuoiTruyVan = string.Format("Delete from KHO where IdHH = '{0}'", IdHH);
            return DbContext.TruyVanExecuteNonQuery(sChuoiTruyVan);
        }
        public static List<KHO_DTO> TimKiemHangHoa(string tuKhoa)
        {
            string sChuoiTruyVan = String.Format(@"Select * From KHO where TenHH like '%{0}%'", tuKhoa);
            DataTable dt = DbContext.TruyVanDataTable(sChuoiTruyVan);
            KHO_DTO KhoDTO;
            if (dt != null && dt.Rows.Count > 0)
            {
                List<KHO_DTO> lstKhoDTO = new List<KHO_DTO>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    KhoDTO = new KHO_DTO();
                    KhoDTO.IdHH = Convert.ToInt32(dt.Rows[i]["IdHH"]);
                    KhoDTO.IdLoaiHH = Convert.ToInt32(dt.Rows[i]["IdLHH"]);
                    KhoDTO.IdNhaCC = Convert.ToInt32(dt.Rows[i]["IdNhaCC"]);
                    KhoDTO.TenHH = dt.Rows[i]["TenHH"].ToString();
                    KhoDTO.NSX = Convert.ToDateTime(dt.Rows[i]["NSX"].ToString());
                    KhoDTO.HSD = Convert.ToDateTime(dt.Rows[i]["HSD"].ToString());
                    KhoDTO.Gia = Convert.ToDouble(dt.Rows[i]["Gia"]);
                    KhoDTO.SoLuong = Convert.ToInt32(dt.Rows[i]["SL"]);
                    KhoDTO.SoLuongCS1 = Convert.ToInt32(dt.Rows[i]["SLCS1"]);
                    KhoDTO.SoLuongCS2 = Convert.ToInt32(dt.Rows[i]["SLCS2"]);
                    KhoDTO.SoLuongCS3 = Convert.ToInt32(dt.Rows[i]["SLCS3"]);
                    KhoDTO.SoLuongCS4 = Convert.ToInt32(dt.Rows[i]["SLCS4"]);
                    KhoDTO.NgayNhap = Convert.ToDateTime(dt.Rows[i]["NgayN"].ToString());

                    lstKhoDTO.Add(KhoDTO);
                }
                return lstKhoDTO;
            }
            return null;
        }
        public static List<KHOCOSO_DTO> LoadKhoCoSo()
        {
            string sChuoiTruyVan = String.Format(@"select IdHH, IdLHH, IdNhaCC, TenHH, NSX, HSD, Gia, SLCS{0}, NgayN from KHO where SLCS{0} !=0 ", USERAUTHENTICATED_DAL.username);
            DataTable dt = DbContext.TruyVanDataTable(sChuoiTruyVan);
            KHOCOSO_DTO KhoDTO;
            if (dt != null && dt.Rows.Count > 0)
            {
                List<KHOCOSO_DTO> lstKhoDTO = new List<KHOCOSO_DTO>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    KhoDTO = new KHOCOSO_DTO();
                    KhoDTO.IdHH = Convert.ToInt32(dt.Rows[i]["IdHH"]);
                    KhoDTO.IdLoaiHH = Convert.ToInt32(dt.Rows[i]["IdLHH"]);
                    KhoDTO.IdNhaCC = Convert.ToInt32(dt.Rows[i]["IdNhaCC"]);
                    KhoDTO.TenHH = dt.Rows[i]["TenHH"].ToString();
                    KhoDTO.NSX = Convert.ToDateTime(dt.Rows[i]["NSX"].ToString());
                    KhoDTO.HSD = Convert.ToDateTime(dt.Rows[i]["HSD"].ToString());
                    KhoDTO.Gia = Convert.ToDouble(dt.Rows[i]["Gia"]);
                    KhoDTO.SoLuong = Convert.ToInt32(dt.Rows[i]["SLCS"+USERAUTHENTICATED_DAL.username+""]);
                    KhoDTO.NgayNhap = Convert.ToDateTime(dt.Rows[i]["NgayN"].ToString());

                    lstKhoDTO.Add(KhoDTO);
                }
                return lstKhoDTO;
            }
            return null;
        }
        public static List<KHOCOSO_DTO> LoadKhoTheoCoSo(string sChuoiTruyVan)
        {
            DataTable dt = DbContext.TruyVanDataTable(sChuoiTruyVan);
            KHOCOSO_DTO KhoDTO;
            if (dt != null && dt.Rows.Count > 0)
            {
                List<KHOCOSO_DTO> lstKhoDTO = new List<KHOCOSO_DTO>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    KhoDTO = new KHOCOSO_DTO();
                    KhoDTO.IdHH = Convert.ToInt32(dt.Rows[i]["IdHH"]);
                    KhoDTO.IdLoaiHH = Convert.ToInt32(dt.Rows[i]["IdLHH"]);
                    KhoDTO.IdNhaCC = Convert.ToInt32(dt.Rows[i]["IdNhaCC"]);
                    KhoDTO.TenHH = dt.Rows[i]["TenHH"].ToString();
                    KhoDTO.NSX = Convert.ToDateTime(dt.Rows[i]["NSX"].ToString());
                    KhoDTO.HSD = Convert.ToDateTime(dt.Rows[i]["HSD"].ToString());
                    KhoDTO.Gia = Convert.ToDouble(dt.Rows[i]["Gia"]);
                    KhoDTO.SoLuong = Convert.ToInt32(dt.Rows[i]["SLCS" + USERAUTHENTICATED_DAL.username + ""]);

                    KhoDTO.NgayNhap = Convert.ToDateTime(dt.Rows[i]["NgayN"].ToString());

                    lstKhoDTO.Add(KhoDTO);
                }
                return lstKhoDTO;
            }
            return null;
        }
        public static List<KHOCOSO_DTO> TimKiemHangHoaCoSo(string tuKhoa)
        {
            string sChuoiTruyVan = String.Format(@"Select * From KHO where TenHH like '%{0}%' or IdHH like '%{0}%'", tuKhoa);
            DataTable dt = DbContext.TruyVanDataTable(sChuoiTruyVan);
            KHOCOSO_DTO KhoDTO;
            if (dt != null && dt.Rows.Count > 0)
            {
                List<KHOCOSO_DTO> lstKhoDTO = new List<KHOCOSO_DTO>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    KhoDTO = new KHOCOSO_DTO();
                    KhoDTO.IdHH = Convert.ToInt32(dt.Rows[i]["IdHH"]);
                    KhoDTO.IdLoaiHH = Convert.ToInt32(dt.Rows[i]["IdLHH"]);
                    KhoDTO.IdNhaCC = Convert.ToInt32(dt.Rows[i]["IdNhaCC"]);
                    KhoDTO.TenHH = dt.Rows[i]["TenHH"].ToString();
                    KhoDTO.NSX = Convert.ToDateTime(dt.Rows[i]["NSX"].ToString());
                    KhoDTO.HSD = Convert.ToDateTime(dt.Rows[i]["HSD"].ToString());
                    KhoDTO.Gia = Convert.ToDouble(dt.Rows[i]["Gia"]);
                    KhoDTO.SoLuong = Convert.ToInt32(dt.Rows[i]["SL"]);
                    KhoDTO.NgayNhap = Convert.ToDateTime(dt.Rows[i]["NgayN"].ToString());

                    lstKhoDTO.Add(KhoDTO);
                }
                return lstKhoDTO;
            }
            return null;
        }
        public static List<KHO_DTO> TimKiemHangHoaCoSoTheoId(string tuKhoa)
        {
            string sChuoiTruyVan = String.Format(@"Select * From KHO where IdHH like '{0}'", tuKhoa);
            DataTable dt = DbContext.TruyVanDataTable(sChuoiTruyVan);
            KHO_DTO KhoDTO;
            if (dt != null && dt.Rows.Count > 0)
            {
                List<KHO_DTO> lstKhoDTO = new List<KHO_DTO>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    KhoDTO = new KHO_DTO();
                    KhoDTO.IdHH = Convert.ToInt32(dt.Rows[i]["IdHH"]);
                    KhoDTO.IdLoaiHH = Convert.ToInt32(dt.Rows[i]["IdLHH"]);
                    KhoDTO.IdNhaCC = Convert.ToInt32(dt.Rows[i]["IdNhaCC"]);
                    KhoDTO.TenHH = dt.Rows[i]["TenHH"].ToString();
                    KhoDTO.NSX = Convert.ToDateTime(dt.Rows[i]["NSX"].ToString());
                    KhoDTO.HSD = Convert.ToDateTime(dt.Rows[i]["HSD"].ToString());
                    KhoDTO.Gia = Convert.ToDouble(dt.Rows[i]["Gia"]);
                    KhoDTO.SoLuong = Convert.ToInt32(dt.Rows[i]["SL"]);
                    KhoDTO.NgayNhap = Convert.ToDateTime(dt.Rows[i]["NgayN"].ToString());

                    lstKhoDTO.Add(KhoDTO);
                }
                return lstKhoDTO;
            }
            return null;
        }
        public static bool SuaHangHoaCoSo(KHOCOSO_DTO HangHoa)
        {
            string sChuoiTruyVan = string.Format("Update KHO set SLCS{0} = '{1}'+ (select  SLCS{0} from KHO where IdHH = '{2}'), SL=(select  SL from KHO where IdHH = '{2}')-'{1}' where IdHH = '{2}'", USERAUTHENTICATED_DAL.username, HangHoa.SoLuong, HangHoa.IdHH);

            return DbContext.TruyVanExecuteNonQuery(sChuoiTruyVan);
        }
        public static List<TIENNHAPHANG_DTO> NhapHang(string id)
        {
            string sChuoiTruyVan = @"select k.TenHH, ncc.TenNhaCC,k.SL, 
								            k.SLCS1,cast (k.SLCS1*k.Gia as int) as TienCS1, 
								            k.SLCS2,cast (k.SLCS2*k.Gia as int) as TienCS2, 
								            k.SLCS3,cast (k.SLCS3*k.Gia as int) as TienCS3, 
								            k.SLCS4,cast (k.SLCS4*k.Gia as int) as TienCS4      
                                    from KHO as k, NHACUNGCAP as ncc 
                                    where k.IdNhaCC=ncc.IdNhaCC";
            DataTable dt = DbContext.TruyVanDataTable(sChuoiTruyVan);
            TIENNHAPHANG_DTO KhoDTO;
            if (dt != null && dt.Rows.Count > 0)
            {
                List<TIENNHAPHANG_DTO> lstKhoDTO = new List<TIENNHAPHANG_DTO>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    KhoDTO = new TIENNHAPHANG_DTO();
                    KhoDTO.TenHH = dt.Rows[i]["TenHH"].ToString();
                    KhoDTO.TenNCC = dt.Rows[i]["TenNhaCC"].ToString();

                    if (id == "1")
                    {
                        KhoDTO.SL = Convert.ToInt32(dt.Rows[i]["SLCS1"]);
                        KhoDTO.TongTien = Convert.ToInt32(dt.Rows[i]["TienCS1"]);
                        
                    }
                    else if (id == "2")
                    {
                        KhoDTO.SL = Convert.ToInt32(dt.Rows[i]["SLCS2"]);
                        KhoDTO.TongTien = Convert.ToInt32(dt.Rows[i]["TienCS2"]);
                    }
                    
                    else if (id == "3")
                    {
                        KhoDTO.SL = Convert.ToInt32(dt.Rows[i]["SLCS3"]);
                        KhoDTO.TongTien = Convert.ToInt32(dt.Rows[i]["TienCS3"]);
                    }
                        
                    else
                    {
                        KhoDTO.SL = Convert.ToInt32(dt.Rows[i]["SLCS4"]);
                        KhoDTO.TongTien = Convert.ToInt32(dt.Rows[i]["TienCS4"]);
                    }
                    lstKhoDTO.Add(KhoDTO);
                }
                return lstKhoDTO;
            }
            return null;
        }
        public static DataTable Kho()
        {
            string sChuoiTruyVan = @"Select * From KHO";
            DataTable dt = DbContext.TruyVanDataTable(sChuoiTruyVan);
            return dt;
        }
    } 
}
