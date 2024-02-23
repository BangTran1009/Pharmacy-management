using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUL;
using DTO;

namespace Pharmacy_management
{
    public partial class fmQuenMatKhau : Form
    {
        public fmQuenMatKhau()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            List<TAIKHOAN_DTO> lstTaiKhoan;
            if (txtIDNhanVien.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập tài khoản cần tìm", "Thông báo");
            }
            else
            {
                string sChuoiTruyVan = String.Format(@"Select * From TAIKHOAN where IdNV like '%{0}'", txtIDNhanVien.Text);
                lstTaiKhoan = TAIKHOAN_BUL.TimTaiKhoan(sChuoiTruyVan);
                if (lstTaiKhoan != null)
                {
                    dgvTaiKhoan.DataSource = lstTaiKhoan;
                    MessageBox.Show("Tài khoản của của đã được tìm thấy", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Không tim thấy", "Thông báo");
                }
            }
        }
    }
}
