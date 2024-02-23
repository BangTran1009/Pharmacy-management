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
    public partial class fmCSDoanhThu : Form
    {
        public fmCSDoanhThu()
        {
            InitializeComponent();
        }

        private void fmCSDoanhThu_Load(object sender, EventArgs e)
        {

        }

        private void btnXemDoanhThu_Click(object sender, EventArgs e)
        {
            List<HOADONTONGHOP_DTO> lstHDTH = HOADON_BUL.HoaDonTongHopCS(dtpTuNgay.Text.ToString(), dtpDenNgay.Text.ToString());
            dgvHoaDon.DataSource = lstHDTH;
            int tongchi = 0;
            int tongthu = 0;
            if (lstHDTH != null)
            {
                for (int i = 0; i < lstHDTH.Count; i++)
                {
                    tongthu += lstHDTH[i].TongTien;
                }
            }
            List<LUONGNHANVIEN_DTO> lstLNV= NHANVIEN_BUL.LuongNhanVien();
            dgvLuongNhanVien.DataSource = lstLNV;
            if (lstLNV != null)
            {
                for (int i = 0; i < lstLNV.Count; i++)
                {
                    tongchi += lstLNV[i].Luong;
                }
            }
            txtTongChi.Text = tongthu.ToString();
            txtTongThu.Text = tongchi.ToString();
            txtDoanhThu.Text =(tongthu-tongchi).ToString();
        }
    }
}
