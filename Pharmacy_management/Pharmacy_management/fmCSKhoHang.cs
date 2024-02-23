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
    public partial class fmCSKhoHang : Form
    {
        public fmCSKhoHang()
        {
            InitializeComponent();
            dgvKhoHang.DataSource = KHO_BUL.LoadKhoCoSo();
            cmbLoaiHangHoa.DataSource = LOAIHANGHOA_BUL.LoadLoaiHang();
            cmbLoaiHangHoa.ValueMember = "IdLoaiHH";
            cmbLoaiHangHoa.DisplayMember = "TenLoaiHH";

            cmbNhaCungCap.DataSource = NHACUNGCAP_BUL.LoadNhaCungCap();
            cmbNhaCungCap.ValueMember = "IdNhaCC";
            cmbNhaCungCap.DisplayMember = "TenNhaCC";
        }
        private void dgvKhoHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvKhoHang.CurrentCell.RowIndex;

            txtMaHangHoa.Text = dgvKhoHang.Rows[r].Cells[0].Value.ToString();
            cmbLoaiHangHoa.SelectedIndex = Convert.ToInt32(dgvKhoHang.Rows[r].Cells[1].Value) - 1;
            cmbNhaCungCap.SelectedIndex = Convert.ToInt32(dgvKhoHang.Rows[r].Cells[2].Value) - 1;
            txtTenHang.Text = dgvKhoHang.Rows[r].Cells[3].Value.ToString();
            dtpNSX.Value = Convert.ToDateTime(dgvKhoHang.Rows[r].Cells[4].Value);
            dtpHSD.Value = Convert.ToDateTime(dgvKhoHang.Rows[r].Cells[5].Value);
            txtSoTien.Text = dgvKhoHang.Rows[r].Cells[6].Value.ToString();
            txtSoLuong.Text = dgvKhoHang.Rows[r].Cells[7].Value.ToString();
            dtpNgayNhapHang.Value = Convert.ToDateTime(dgvKhoHang.Rows[r].Cells[8].Value);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            KHOCOSO_DTO HangHoaDTO = new KHOCOSO_DTO();

            HangHoaDTO.IdHH = Convert.ToInt32(txtMaHangHoa.Text);
            HangHoaDTO.IdLoaiHH = Convert.ToInt32(cmbLoaiHangHoa.SelectedValue);
            HangHoaDTO.IdNhaCC = Convert.ToInt32(cmbNhaCungCap.SelectedValue);
            HangHoaDTO.TenHH = txtTenHang.Text;
            HangHoaDTO.NSX = dtpNSX.Value;
            HangHoaDTO.HSD = dtpHSD.Value;
            HangHoaDTO.Gia = Convert.ToDouble(txtSoTien.Text);
            HangHoaDTO.SoLuong = Convert.ToInt32(txtSoLuong.Text);
            HangHoaDTO.NgayNhap = dtpNgayNhapHang.Value;


            if (KHO_BUL.SuaHangHoaCoSo(HangHoaDTO))
            {
                dgvKhoHang.DataSource = KHO_BUL.LoadKhoCoSo();
                MessageBox.Show("Thêm số lượng thuốc thành công thành công", "Thông báo");
            }
            else
                MessageBox.Show("Cập nhật thất bại", "Thông báo");
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            List<KHOCOSO_DTO> lstHangHoa;
            if (txtTimKiem.Text.Trim() == "")
            {
                dgvKhoHang.DataSource = KHO_BUL.LoadKhoCoSo();
                MessageBox.Show("Vui lòng nhập từ khóa", "Thông báo");
            }
            else
            {
                lstHangHoa = KHO_BUL.TimKiemHangHoaCoSo(txtTimKiem.Text);
                if (lstHangHoa != null)
                {
                    dgvKhoHang.DataSource = lstHangHoa;
                    MessageBox.Show("Tim thấy " + lstHangHoa.Count + " sản phẩm", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Không tim thấy", "Thông báo");
                }
            }
        }
    }
}
