using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUL;
using DAL;
using System.Data.SqlClient;

namespace Pharmacy_management
{
    public partial class fmDoiMatKhau : Form
    {
        public fmDoiMatKhau()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            SqlConnection conn = DbContext.KetNoi();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_AuthoLogin";
            cmd.Parameters.AddWithValue("@UserName", Convert.ToInt32(txtTenTaiKhoan.Text));
            cmd.Parameters.AddWithValue("@Password", txtMatKhauCu.Text);
            cmd.Connection = conn;
            USERAUTHENTICATED_DAL.username = txtTenTaiKhoan.Text;
            object kq = cmd.ExecuteScalar();
            int code = Convert.ToInt32(kq);

            TAIKHOAN_DTO tkDTO = new TAIKHOAN_DTO();

            tkDTO.TaiKhoan = Convert.ToInt32(txtTenTaiKhoan.Text);
            tkDTO.MatKhau = txtMatKhauMoi.Text;
            if (code == 1)
                tkDTO.LoaiTK = 1;
            else if (code == 2)
                tkDTO.LoaiTK = 2;
            else
                tkDTO.LoaiTK = 3;

            if (TAIKHOAN_BUL.SuaTaiKhoan(tkDTO) && txtMatKhauMoi.Text == txtMaKhauXacNhan.Text)
            {
                MessageBox.Show("Cập nhật thành công thành công", "Thông báo");
            }
            else
                MessageBox.Show("Tài khoàn không tồn tại", "Thông báo");
        }
    }
}
