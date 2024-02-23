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
using DAL;

namespace Pharmacy_management
{
    public partial class fmCSNhanVien : Form
    {
        public fmCSNhanVien()
        {
            InitializeComponent();
        }

        private void fmCSNhanVien_Load(object sender, EventArgs e)
        {
            dgvNhanVien.DataSource = NHANVIEN_BUL.LoadNhanVienCoSo();

            cmbCaLam.DataSource = CALAM_BUL.LoadCaLam();
            cmbCaLam.ValueMember = "Id";
            cmbCaLam.DisplayMember = "TenCa";

            cmbLoaiNhanVien.DataSource = LOAINHANVIEN_BUL.LoadLoaiNhanVien();
            cmbLoaiNhanVien.ValueMember = "IdViTri";
            cmbLoaiNhanVien.DisplayMember = "TenViTri";

            cmbCoSo.DataSource = COSO_BUL.LoadCoSo();
            cmbCoSo.ValueMember = "IdNhaThuoc";
            cmbCoSo.DisplayMember = "DiaChi";
        }

        private void dgvNhanVien_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvNhanVien.CurrentCell.RowIndex;

            txtID.Text = dgvNhanVien.Rows[r].Cells[0].Value.ToString();
            txtHoTen.Text = dgvNhanVien.Rows[r].Cells[1].Value.ToString();
            txtSDT.Text = dgvNhanVien.Rows[r].Cells[2].Value.ToString();
            dtpNgaySinh.Value = Convert.ToDateTime(dgvNhanVien.Rows[r].Cells[3].Value);
            txtDiaChi.Text = dgvNhanVien.Rows[r].Cells[4].Value.ToString();
            cmbCaLam.SelectedIndex = Convert.ToInt32(dgvNhanVien.Rows[r].Cells[5].Value) - 1;
            cmbLoaiNhanVien.SelectedIndex = Convert.ToInt32(dgvNhanVien.Rows[r].Cells[6].Value) - 1;
            cmbCoSo.SelectedIndex = Convert.ToInt32(dgvNhanVien.Rows[r].Cells[7].Value) - 1;
            txtLuong.Text = dgvNhanVien.Rows[r].Cells[8].Value.ToString();
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            NHANVIEN_DTO nvDTO = new NHANVIEN_DTO();

            nvDTO.IdNV = Convert.ToInt32(txtID.Text);
            nvDTO.TenNV = txtHoTen.Text;
            nvDTO.SdtNV = txtSDT.Text;
            nvDTO.NgSinhNV = dtpNgaySinh.Value;
            nvDTO.DiaChiNV = txtDiaChi.Text;
            nvDTO.ViTri = Convert.ToInt32(cmbLoaiNhanVien.SelectedValue);
            nvDTO.Ca = Convert.ToInt32(cmbCaLam.SelectedValue);
            nvDTO.IdNhaThuoc = Convert.ToInt32(cmbCoSo.SelectedValue);
            nvDTO.Luong = Convert.ToInt32(txtLuong.Text);

            if (NHANVIEN_BUL.ThemNhanVien(nvDTO) == true)
            {
                NHANVIEN_BUL.ThemNhanVien(nvDTO);
                dgvNhanVien.DataSource = NHANVIEN_BUL.LoadNhanVienCoSo();
                MessageBox.Show("Thêm thành công", "Thông báo");
            }
            else
                MessageBox.Show("Thêm thất bại", "Thông báo");
        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            NHANVIEN_DTO nvDTO = new NHANVIEN_DTO();
            nvDTO.IdNV = Convert.ToInt32(txtID.Text);
            nvDTO.TenNV = txtHoTen.Text;
            nvDTO.SdtNV = txtSDT.Text;
            nvDTO.NgSinhNV = dtpNgaySinh.Value;
            nvDTO.DiaChiNV = txtDiaChi.Text;
            nvDTO.Ca = Convert.ToInt32(cmbCaLam.SelectedValue);
            nvDTO.ViTri = Convert.ToInt32(cmbLoaiNhanVien.SelectedValue);
            nvDTO.IdNhaThuoc = Convert.ToInt32(cmbCoSo.SelectedValue);
            nvDTO.Luong = Convert.ToInt32(txtLuong.Text);

            if (NHANVIEN_BUL.CapNhatNhanVien(nvDTO))
            {
                dgvNhanVien.DataSource = NHANVIEN_BUL.LoadNhanVienCoSo();
                MessageBox.Show("Cập nhật thành công thành công", "Thông báo");
            }
            else
                MessageBox.Show("Cập nhật thất bại", "Thông báo");
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            int IdNV = Convert.ToInt32(txtID.Text);
            if (NHANVIEN_BUL.XoaNhanVien(IdNV))
            {
                dgvNhanVien.DataSource = NHANVIEN_BUL.LoadNhanVienCoSo();
                MessageBox.Show("Xóa thành công", "Thông báo");
            }
            else
                MessageBox.Show("Xóa thất bại", "Thông báo");
        }

        private void btnTimKiem_Click_1(object sender, EventArgs e)
        {
            List<NHANVIEN_DTO> lstNhanVien;
            if (txtTuKhoa.Text.Trim() == "")
            {
                dgvNhanVien.DataSource = NHANVIEN_BUL.LoadNhanVienCoSo();
                MessageBox.Show("Vui lòng nhập từ khóa", "Thông báo");
            }
            else
            {
                string sChuoiTruyVan = String.Format(@"Select * From NHANVIEN Where IdCS=(Select IdCS From NHANVIEN Where IdNV='{0}') and TenNV like '%{1}%' or IdNV like '%{1}%'", USERAUTHENTICATED_DAL.username, txtTuKhoa.Text);
                lstNhanVien = NHANVIEN_BUL.TimNhanVien(sChuoiTruyVan);
                if (lstNhanVien != null)
                {
                    dgvNhanVien.DataSource = lstNhanVien;
                    MessageBox.Show("Tim thấy " + lstNhanVien.Count + " nhân viên", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Không tim thấy", "Thông báo");
                }
            }
        }
    }
}
