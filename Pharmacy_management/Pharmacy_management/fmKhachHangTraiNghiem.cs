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
    public partial class fmKhachHangTraiNghiem : Form
    {
        public fmKhachHangTraiNghiem()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTimHangHoa_Click(object sender, EventArgs e)
        {
            List<KHO_DTO> lstHangHoa;
            if (txtTimKiemhangHoa.Text.Trim() == "")
            {
                dgvHangHoa.DataSource = KHO_BUL.LoadKho();
                MessageBox.Show("Vui lòng nhập từ khóa", "Thông báo");
            }
            else
            {
                lstHangHoa = KHO_BUL.TimKiemHangHoa(txtTimKiemhangHoa.Text);
                if (lstHangHoa != null)
                {
                    dgvHangHoa.DataSource = lstHangHoa;
                    MessageBox.Show("Tim thấy " + lstHangHoa.Count + " sản phẩm", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Không tim thấy", "Thông báo");
                }
            }
        }

        private void btnTimCoSo_Click(object sender, EventArgs e)
        {
            List<COSO_DTO> lstCoSo;
            if (txtTimCoSo.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập từ khóa", "Thông báo");
            }
            else
            {
                lstCoSo = COSO_BUL.TimCoSo(txtTimCoSo.Text);
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

        private void btnKhachHangDanhGia_Click(object sender, EventArgs e)
        {
            fmDanhGiaCuaKhachHang danhgia = new fmDanhGiaCuaKhachHang();
            danhgia.ShowDialog();
        }
    }
}
