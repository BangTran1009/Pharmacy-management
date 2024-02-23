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

namespace Pharmacy_management
{
    public partial class fmDanhGiaCuaKhachHang : Form
    {
        public fmDanhGiaCuaKhachHang()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDanhGia_Click(object sender, EventArgs e)
        {
            DANHGIA_DTO dgDTO = new DANHGIA_DTO();

            dgDTO.TenKhachHang = txtTen.Text;
            dgDTO.NgayDanhGia = dtpNgayDanhGia.Value;
            dgDTO.NoiDung =txtNoiDung.Text;

            if (DANHGIA_BUL.ThemDanhGia(dgDTO))
                MessageBox.Show("Thêm thành công", "Thông báo");
            else
                MessageBox.Show("Thêm thất bại", "Thông báo");
        }
    }
}
