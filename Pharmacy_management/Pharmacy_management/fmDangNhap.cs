using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DAL;

namespace Pharmacy_management
{
    public partial class fmDangNhap : Form
    {
        public fmDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            SqlConnection conn = DbContext.KetNoi();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_AuthoLogin";
            cmd.Parameters.AddWithValue("@UserName", Convert.ToInt32(txtTaiKhoan.Text));
            cmd.Parameters.AddWithValue("@Password", txtMatKhau.Text);
            cmd.Connection = conn;
            USERAUTHENTICATED_DAL.username = txtTaiKhoan.Text;
            object kq = cmd.ExecuteScalar();
            int code = Convert.ToInt32(kq);
            if (rdbGiamDoc.Checked == true && code == 3)
            {
                fmQuanLy QL = new fmQuanLy();
                QL.ShowDialog();
            }
            else if (rdbNhanVien.Checked == true && code == 1)
            {
                fmQuayBanHang BH = new fmQuayBanHang();
                BH.ShowDialog();
            }
            else if (rdbQuanLy.Checked == true && code == 2)
            {
                fmCSQuanLy CSQL = new fmCSQuanLy();
                CSQL.ShowDialog();
            }
            else if (code == -1)
                MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void llblQuenMatKhau_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fmQuenMatKhau Quen = new fmQuenMatKhau();
            Quen.ShowDialog();
        }

        private void llblDoiMatKhau_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fmDoiMatKhau Doi = new fmDoiMatKhau();
            Doi.ShowDialog();
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            fmKhachHangTraiNghiem danhgia = new fmKhachHangTraiNghiem();
            danhgia.ShowDialog();
        }

        private void llblKhaiTruong_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fmTinTucKhaiTruong KhaiTruong = new fmTinTucKhaiTruong();
            KhaiTruong.ShowDialog();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fmTinTucSale KhaiTruong = new fmTinTucSale();
            KhaiTruong.ShowDialog();
        }
    }
}
