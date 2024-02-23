using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class DbContext
    {
        // Phương thức dùng để mở kết nối CSDL
        public static SqlConnection KetNoi()
        {
            string sChuoiKetNoi = @"Server=DESKTOP-4E1TOCV\SQLEXPRESS;Database=QLCNT;Trusted_Connection=True;";
            SqlConnection conn = new SqlConnection(sChuoiKetNoi);
            conn.Open();
            return conn;
        }

        //Phương thức ngắt kết nối
        public static void NgatKetNoi(SqlConnection conn)
        {
            conn.Close();
        }

        // Phương thức truy vấn đến CSDL trả về DataTable <==> Select
        public static DataTable TruyVanDataTable(string sChuoiTruyVan)
        {
            SqlConnection conn = KetNoi();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(sChuoiTruyVan, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                NgatKetNoi(conn);
                return dt;
            }
            catch (Exception ex)
            {
                //KetNoi().Close();
                NgatKetNoi(conn);
                return null;
            }
        }

        // C2 Dùng DataReader
        public static DataTable TruyVanDataReader(string sChuoiTruyVan)
        {
            SqlConnection conn = KetNoi();
            try
            {
                SqlCommand cmd = new SqlCommand(sChuoiTruyVan, conn);
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                NgatKetNoi(conn);
                return dt;
            }
            catch (Exception ex)
            {
                NgatKetNoi(conn);
                return null;
            }
        }

        // Phương thức thực hiện các câu lênh giống như Update, Inserst, Delete
        public static bool TruyVanExecuteNonQuery(string sChuoiTruyVan)
        {
            SqlConnection conn = KetNoi();
            try
            {
                SqlCommand cmd = new SqlCommand(sChuoiTruyVan, conn);
                //ExecuteNonQuery nó sẽ trả về số dòng bị ảnh hưởng bởi Delete, Update,..
                int iCMD = cmd.ExecuteNonQuery();
                NgatKetNoi(conn);
                if (iCMD > 0)
                {
                    return true;
                }
                else
                    return false;
            }
            catch (Exception ex)
            {
                NgatKetNoi(conn);
                return false;
            }
        }

        // Phương thức trả về một giá trị
        public static string TruyVanExecuteScalar(string sChuoiTruyVan)
        {
            SqlConnection conn = KetNoi();
            try
            {
                SqlCommand cmd = new SqlCommand(sChuoiTruyVan, conn);
                string sKQ = cmd.ExecuteScalar().ToString();
                NgatKetNoi(conn);
                return sKQ;
            }
            catch (Exception ex)
            {
                NgatKetNoi(conn);
                return null;
            }
        }
    }
}
