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
    public partial class fmTaiKhoan : Form
    {
        public fmTaiKhoan()
        {
            InitializeComponent();
        }
        private void fmTaiKhoan_Load(object sender, EventArgs e)
        {
            dgvTaiKhoan.DataSource = TAIKHOAN_BUL.LoadTaiKhoan();

            cmbLoaiTaiKhoan.DataSource = LOAITAIKHOAN_BUL.LoadLoaiTK();
            cmbLoaiTaiKhoan.DisplayMember = "TenLoaiTK";
            cmbLoaiTaiKhoan.ValueMember = "IdLoaiTK";
        }

        private void dgvTaiKhoan_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvTaiKhoan.CurrentCell.RowIndex;

            txtTenTaiKhoan.Text = dgvTaiKhoan.Rows[r].Cells[0].Value.ToString();
            txtMatKhau.Text = dgvTaiKhoan.Rows[r].Cells[1].Value.ToString();
            cmbLoaiTaiKhoan.SelectedIndex = Convert.ToInt32(dgvTaiKhoan.Rows[r].Cells[2].Value) - 1;
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            TAIKHOAN_DTO tkDTO = new TAIKHOAN_DTO();

            tkDTO.TaiKhoan = Convert.ToInt32(txtTenTaiKhoan.Text);
            tkDTO.MatKhau = txtMatKhau.Text;
            tkDTO.LoaiTK = Convert.ToInt32(cmbLoaiTaiKhoan.SelectedValue);

            if (TAIKHOAN_BUL.ThemTaiKhoan(tkDTO))
            {
                TAIKHOAN_BUL.ThemTaiKhoan(tkDTO);
                dgvTaiKhoan.DataSource = TAIKHOAN_BUL.LoadTaiKhoan();
                MessageBox.Show("Thêm thành công", "Thông báo");
            }
            else
                MessageBox.Show("Thêm thất bại", "Thông báo");
        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            TAIKHOAN_DTO tkDTO = new TAIKHOAN_DTO();

            tkDTO.TaiKhoan = Convert.ToInt32(txtTenTaiKhoan.Text);
            tkDTO.MatKhau = txtMatKhau.Text;
            tkDTO.LoaiTK = Convert.ToInt32(cmbLoaiTaiKhoan.SelectedValue);

            if (TAIKHOAN_BUL.SuaTaiKhoan(tkDTO))
            {
                dgvTaiKhoan.DataSource = TAIKHOAN_BUL.LoadTaiKhoan();
                MessageBox.Show("Cập nhật thành công thành công", "Thông báo");
            }
            else
                MessageBox.Show("Cập nhật thất bại", "Thông báo");
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            int IdTaiKhoan = Convert.ToInt32(txtTenTaiKhoan.Text);
            if (TAIKHOAN_BUL.XoaTaiKhoan(IdTaiKhoan))
            {
                dgvTaiKhoan.DataSource = TAIKHOAN_BUL.LoadTaiKhoan();
                MessageBox.Show("Xóa thành công", "Thông báo");
            }
            else
                MessageBox.Show("Xóa thất bại", "Thông báo");
        }

        private void btnTimKiem_Click_1(object sender, EventArgs e)
        {
            List<TAIKHOAN_DTO> lstTaiKhoan;
            if (txtTuKhoa.Text.Trim() == "")
            {
                dgvTaiKhoan.DataSource = TAIKHOAN_BUL.LoadTaiKhoan();
                MessageBox.Show("Vui lòng nhập từ khóa", "Thông báo");
            }
            else
            {
                string sChuoiTruyVan = String.Format(@"Select * From TAIKHOAN where IdNV like '%{0}'", txtTuKhoa.Text);
                lstTaiKhoan = TAIKHOAN_BUL.TimTaiKhoan(sChuoiTruyVan);
                if (lstTaiKhoan != null)
                {
                    dgvTaiKhoan.DataSource = lstTaiKhoan;
                    MessageBox.Show("Tim thấy " + lstTaiKhoan.Count + " tài khoản", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Không tim thấy", "Thông báo");
                }
            }
        }
    }
}
