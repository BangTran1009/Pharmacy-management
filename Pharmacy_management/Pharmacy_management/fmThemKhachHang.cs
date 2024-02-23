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
    public partial class fmThemKhachHang : Form
    {
        public fmThemKhachHang()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            KHACHHANG_DTO KhDTO = new KHACHHANG_DTO();

            KhDTO.SDT = txtSDT.Text;
            KhDTO.TenKH = txtHoTen.Text;
            KhDTO.NgaySinh = dtpNgaySinh.Value;
            KhDTO.DiaChi = txtDiaChi.Text;
            KhDTO.Diem = Convert.ToInt32(txtDiem.Text);

            if (KHACHHANG_BUL.ThemKhachHang(KhDTO))
            {
                KHACHHANG_BUL.ThemKhachHang(KhDTO);
                MessageBox.Show("Thêm thành công", "Thông báo");
            }
            else
                MessageBox.Show("Thêm thất bại", "Thông báo");
        }

        private void fmThemKhachHang_Load(object sender, EventArgs e)
        {
            txtDiem.Text= "0";
        }
    }
}
