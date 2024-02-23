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
    public partial class fmPhanPhoi : Form
    {
        public fmPhanPhoi()
        {
            InitializeComponent();
        }
        private void btnPhanPhoi_Click(object sender, EventArgs e)
        {
            KHO_DTO HangHoaDTO = new KHO_DTO();
            
            HangHoaDTO.IdHH = Convert.ToInt32(txtIdHH.Text);
            HangHoaDTO.SoLuongCS1 = Convert.ToInt32(txtSoLuongcs1.Text);
            HangHoaDTO.SoLuongCS2 = Convert.ToInt32(txtSoLuongcs2.Text);
            HangHoaDTO.SoLuongCS3 = Convert.ToInt32(txtSoLuongcs3.Text);
            HangHoaDTO.SoLuongCS4 = Convert.ToInt32(txtSoLuongcs4.Text);
            if (KHO_BUL.PhanPhoiHangHoa(HangHoaDTO))
            {
                fmKhoHang kh = new fmKhoHang();
                kh.dgvKhoHang.DataSource = KHO_BUL.LoadKho();
                MessageBox.Show("Phân phối thành công thành công", "Thông báo");
            }
            else
                MessageBox.Show("Phân phối thất bại", "Thông báo");
        }
    }
}
