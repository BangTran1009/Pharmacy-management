using BUL;
using DTO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Pharmacy_management
{
    public partial class fmCoSo : Form
    {
        public fmCoSo()
        {
            InitializeComponent();
        }

        private void fmCoSo_Load(object sender, EventArgs e)
        {
            dgvCoSo.DataSource = COSO_BUL.LoadCoSo();
        }

        private void dgvCoSo_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvCoSo.CurrentCell.RowIndex;
            txtIDCoSo.Text = dgvCoSo.Rows[r].Cells[0].Value.ToString();
            txtIDNguoiQuanLy.Text = dgvCoSo.Rows[r].Cells[1].Value.ToString();
            txtDiaChi.Text = dgvCoSo.Rows[r].Cells[2].Value.ToString();
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            COSO_DTO csDTO = new COSO_DTO();

            csDTO.IdNhaThuoc = Convert.ToInt32(txtIDCoSo.Text);
            csDTO.IDNguoiQL = Convert.ToInt32(txtIDNguoiQuanLy.Text);
            csDTO.DiaChi = txtDiaChi.Text;

            if (COSO_BUL.ThemCoSo(csDTO))
            {
                COSO_BUL.ThemCoSo(csDTO);
                dgvCoSo.DataSource = COSO_BUL.LoadCoSo();
                MessageBox.Show("Thêm thành công", "Thông báo");
            }
            else
                MessageBox.Show("Thêm thất bại", "Thông báo");
        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            COSO_DTO csDTO = new COSO_DTO();

            csDTO.IdNhaThuoc = Convert.ToInt32(txtIDCoSo.Text);
            csDTO.IDNguoiQL = Convert.ToInt32(txtIDNguoiQuanLy.Text);
            csDTO.DiaChi = txtDiaChi.Text;

            if (COSO_BUL.SuaCoSo(csDTO))
            {
                dgvCoSo.DataSource = COSO_BUL.LoadCoSo();
                MessageBox.Show("Cập nhật thành công thành công", "Thông báo");
            }
            else
                MessageBox.Show("Cập nhật thất bại", "Thông báo");
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            int IdCS = Convert.ToInt32(txtIDCoSo.Text);
            if (COSO_BUL.XoaCoSo(IdCS))
            {
                dgvCoSo.DataSource = COSO_BUL.LoadCoSo();
                MessageBox.Show("Xóa thành công", "Thông báo");
            }
            else
                MessageBox.Show("Xóa thất bại", "Thông báo");
        }

        private void btnTimKiem_Click_1(object sender, EventArgs e)
        {
            List<COSO_DTO> lstCoSo;
            if (txtTuKhoa.Text.Trim() == "")
            {
                dgvCoSo.DataSource = COSO_BUL.LoadCoSo();
                MessageBox.Show("Vui lòng nhập từ khóa", "Thông báo");
            }
            else
            {
                lstCoSo = COSO_BUL.TimCoSo(txtTuKhoa.Text);
                if (lstCoSo != null)
                {
                    dgvCoSo.DataSource = lstCoSo;
                    MessageBox.Show("Tim thấy " + lstCoSo.Count + " cơ sở", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Không tim thấy", "Thông báo");
                }
            }
        }
    }
}
