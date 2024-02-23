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
    
    public partial class fmKhoHang : Form
    {
        public int idhhpp=0;
        public fmKhoHang()
        {
            InitializeComponent();
        }
        private void fmKhoHang_Load(object sender, EventArgs e)
        {
            dgvKhoHang.DataSource = KHO_BUL.LoadKho();

            cmbLoaiHangHoa.DataSource = LOAIHANGHOA_BUL.LoadLoaiHang();
            cmbLoaiHangHoa.ValueMember = "IdLoaiHH";
            cmbLoaiHangHoa.DisplayMember = "TenLoaiHH";

            cmbNhaCC.DataSource = NHACUNGCAP_BUL.LoadNhaCungCap();
            cmbNhaCC.ValueMember = "IdNhaCC";
            cmbNhaCC.DisplayMember = "TenNhaCC";
        }

        private void dgvKhoHang_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
            int r = dgvKhoHang.CurrentCell.RowIndex;
            idhhpp = Convert.ToInt32(dgvKhoHang.Rows[r].Cells[0].Value);
            txtIdHH.Text = dgvKhoHang.Rows[r].Cells[0].Value.ToString();
            cmbLoaiHangHoa.SelectedIndex = Convert.ToInt32(dgvKhoHang.Rows[r].Cells[1].Value) - 1;
            cmbNhaCC.SelectedIndex = Convert.ToInt32(dgvKhoHang.Rows[r].Cells[2].Value) - 1;
            txtTen.Text = dgvKhoHang.Rows[r].Cells[3].Value.ToString();
            dtpNSX.Value = Convert.ToDateTime(dgvKhoHang.Rows[r].Cells[4].Value);
            dtpHSD.Value = Convert.ToDateTime(dgvKhoHang.Rows[r].Cells[5].Value);
            txtSoTien.Text = dgvKhoHang.Rows[r].Cells[6].Value.ToString();
            txtSoLuong.Text = dgvKhoHang.Rows[r].Cells[7].Value.ToString();
            txtSoLuongcs1.Text = dgvKhoHang.Rows[r].Cells[8].Value.ToString();
            txtSoLuongcs2.Text = dgvKhoHang.Rows[r].Cells[9].Value.ToString();
            txtSoLuongcs3.Text = dgvKhoHang.Rows[r].Cells[10].Value.ToString();
            txtSoLuongcs4.Text = dgvKhoHang.Rows[r].Cells[11].Value.ToString();
            dtpNgayNhap.Value = Convert.ToDateTime(dgvKhoHang.Rows[r].Cells[12].Value);
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            KHO_DTO HangHoaDTO = new KHO_DTO();

            HangHoaDTO.IdHH = Convert.ToInt32(txtIdHH.Text);
            HangHoaDTO.IdLoaiHH = Convert.ToInt32(cmbLoaiHangHoa.SelectedValue);
            HangHoaDTO.IdNhaCC = Convert.ToInt32(cmbNhaCC.SelectedValue);
            HangHoaDTO.TenHH = txtTen.Text;
            HangHoaDTO.NSX = dtpNSX.Value;
            HangHoaDTO.HSD = dtpHSD.Value;
            HangHoaDTO.Gia = Convert.ToDouble(txtSoTien.Text);
            HangHoaDTO.SoLuong = Convert.ToInt32(txtSoLuong.Text);
            HangHoaDTO.SoLuongCS1 = Convert.ToInt32(txtSoLuongcs1.Text);
            HangHoaDTO.SoLuongCS2 = Convert.ToInt32(txtSoLuongcs2.Text);
            HangHoaDTO.SoLuongCS3 = Convert.ToInt32(txtSoLuongcs3.Text);
            HangHoaDTO.SoLuongCS4 = Convert.ToInt32(txtSoLuongcs4.Text);
            HangHoaDTO.NgayNhap = dtpNgayNhap.Value;

            if (KHO_BUL.ThemHangHoa(HangHoaDTO) == true)
            {
                KHO_BUL.ThemHangHoa(HangHoaDTO);
                dgvKhoHang.DataSource = KHO_BUL.LoadKho();
                MessageBox.Show("Thêm thành công", "Thông báo");
            }
            else
                MessageBox.Show("Thêm thất bại", "Thông báo");
        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            KHO_DTO HangHoaDTO = new KHO_DTO();

            HangHoaDTO.IdHH = Convert.ToInt32(txtIdHH.Text);
            HangHoaDTO.IdLoaiHH = Convert.ToInt32(cmbLoaiHangHoa.SelectedValue);
            HangHoaDTO.IdNhaCC = Convert.ToInt32(cmbNhaCC.SelectedValue);
            HangHoaDTO.TenHH = txtTen.Text;
            HangHoaDTO.NSX = dtpNSX.Value;
            HangHoaDTO.HSD = dtpHSD.Value;
            HangHoaDTO.Gia = Convert.ToDouble(txtSoTien.Text);
            HangHoaDTO.SoLuong = Convert.ToInt32(txtSoLuong.Text);
            HangHoaDTO.NgayNhap = dtpNgayNhap.Value;


            if (KHO_BUL.SuaHangHoa(HangHoaDTO))
            {
                dgvKhoHang.DataSource = KHO_BUL.LoadKho();
                MessageBox.Show("Cập nhật thành công thành công", "Thông báo");
            }
            else
                MessageBox.Show("Cập nhật thất bại", "Thông báo");
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            int IdHH = Convert.ToInt32(txtIdHH.Text);
            if (KHO_BUL.XoaHangHoa(IdHH))
            {
                dgvKhoHang.DataSource = KHO_BUL.LoadKho();
                MessageBox.Show("Xóa thành công", "Thông báo");
            }
            else
                MessageBox.Show("Xóa thất bại", "Thông báo");
        }

        private void btnTimKiem_Click_1(object sender, EventArgs e)
        {
            List<KHO_DTO> lstHangHoa;
            if (txtTuKhoa.Text.Trim() == "")
            {
                dgvKhoHang.DataSource = KHO_BUL.LoadKho();
                MessageBox.Show("Vui lòng nhập từ khóa", "Thông báo");
            }
            else
            {
                lstHangHoa = KHO_BUL.TimKiemHangHoa(txtTuKhoa.Text);
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

        private void btnPhanPhoi_Click(object sender, EventArgs e)
        {
            fmPhanPhoi fmpp = new fmPhanPhoi();
            fmpp.txtIdHH.Text = idhhpp.ToString(); 
            if (fmpp.ShowDialog() == DialogResult.OK)
            {
                dgvKhoHang.DataSource = KHO_BUL.LoadKho();
            }    
        }
    }
}
