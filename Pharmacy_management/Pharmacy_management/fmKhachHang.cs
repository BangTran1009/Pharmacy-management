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
    public partial class fmKhachHang : Form
    {
        public fmKhachHang()
        {
            InitializeComponent();
        }

        private void fmKhachHang_Load(object sender, EventArgs e)
        {
            dgvKhachHang.DataSource = KHACHHANG_BUL.LoadKhachHang();
        }

        private void dgvKhachHang_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvKhachHang.CurrentCell.RowIndex;

            txtSDT.Text = dgvKhachHang.Rows[r].Cells[0].Value.ToString();
            txtHoTen.Text = dgvKhachHang.Rows[r].Cells[1].Value.ToString();
            dtpNgaySinh.Value = Convert.ToDateTime(dgvKhachHang.Rows[r].Cells[2].Value);
            txtDiaChi.Text = dgvKhachHang.Rows[r].Cells[3].Value.ToString();
            txtDiem.Text = dgvKhachHang.Rows[r].Cells[4].Value.ToString();
        }

        private void btnThem_Click_1(object sender, EventArgs e)
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
                dgvKhachHang.DataSource = KHACHHANG_BUL.LoadKhachHang();
                MessageBox.Show("Thêm thành công", "Thông báo");
            }
            else
                MessageBox.Show("Thêm thất bại", "Thông báo");
        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            KHACHHANG_DTO KhDTO = new KHACHHANG_DTO();

            KhDTO.SDT = txtSDT.Text;
            KhDTO.TenKH = txtHoTen.Text;
            KhDTO.NgaySinh = dtpNgaySinh.Value;
            KhDTO.DiaChi = txtDiaChi.Text;
            KhDTO.Diem = Convert.ToInt32(txtDiem.Text);

            if (KHACHHANG_BUL.CapNhatKhachHang(KhDTO))
            {
                dgvKhachHang.DataSource = KHACHHANG_BUL.LoadKhachHang();
                MessageBox.Show("Cập nhật thành công thành công", "Thông báo");
            }
            else
                MessageBox.Show("Cập nhật thất bại", "Thông báo");
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            int SDT = Convert.ToInt32(txtSDT.Text);
            if (KHACHHANG_BUL.XoaKhachHang(SDT))
            {
                dgvKhachHang.DataSource = KHACHHANG_BUL.LoadKhachHang();
                MessageBox.Show("Xóa thành công", "Thông báo");
            }
            else
                MessageBox.Show("Xóa thất bại", "Thông báo");
        }

        private void btnTimKiem_Click_1(object sender, EventArgs e)
        {
            List<KHACHHANG_DTO> lstKhachHang;
            if (txtTuKhoa.Text.Trim() == "")
            {
                dgvKhachHang.DataSource = KHACHHANG_BUL.LoadKhachHang();
                MessageBox.Show("Vui lòng nhập từ khóa", "Thông báo");
            }
            else
            {
                lstKhachHang = KHACHHANG_BUL.TimKhachHang(txtTuKhoa.Text);
                if (lstKhachHang != null)
                {
                    dgvKhachHang.DataSource = lstKhachHang;
                    MessageBox.Show("Tìm thấy " + lstKhachHang.Count + " khách hàng", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Không tìm thấy", "Thông báo");
                }
            }
        }

        private void btnXemDanhGia_Click(object sender, EventArgs e)
        {
            fmXemDanhGiaKhachHang Xem = new fmXemDanhGiaKhachHang();
            Xem.ShowDialog();
        }
    }
}
