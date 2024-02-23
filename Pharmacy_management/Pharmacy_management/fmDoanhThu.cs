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
    public partial class fmDoanhThu : Form
    {
        List<int> chartdoanhthu = new List<int>();
        public fmDoanhThu()
        {
            InitializeComponent();
        }

        private void fmDoanhThu_Load(object sender, EventArgs e)
        {
            cmbCoSo.DataSource = COSO_BUL.LoadCoSo();
            cmbCoSo.DisplayMember = "IdNhaThuoc";
            cmbCoSo.ValueMember = "IdNhaThuoc";
        }

        private void btnXemDoanhThu_Click(object sender, EventArgs e)
        {
            int tongthu = 0;
            int tongchi = 0;
            List<HOADONTONGHOP_DTO> hdth = HOADON_BUL.HoaDonTongHop(dtpTuNgay.Text.ToString(), dtpDenNgay.Text.ToString(),cmbCoSo.Text.ToString()) ;
            if (hdth!=null)
            {
                for (int i = 0; i < hdth.Count; i++)
                    tongthu += hdth[i].TongTien;
            }
            List<LUONGNHANVIEN_DTO> lstLNV = NHANVIEN_BUL.LuongNhanVienCS(cmbCoSo.Text);
            if (lstLNV!=null)
                for (int i=0; i < lstLNV.Count; i++)
                {
                    tongchi += lstLNV[i].Luong;
                }
            List<TIENNHAPHANG_DTO> lstTNH = KHO_BUL.NhapHang(cmbCoSo.Text);
            if (lstTNH !=null)
            {
                for(int i=0; i<lstTNH.Count;i++)
                {
                    tongchi += lstTNH[i].TongTien;
                }
            }
            txtTongThu.Text = tongthu.ToString();
            txtTongChi.Text=tongchi.ToString();
            txtDoanhThu.Text = (tongthu - tongchi).ToString();
            dgvHoaDon.DataSource = hdth;
            dgvLuongNhanVien.DataSource = lstLNV;
            dgvTienNhapHang.DataSource = lstTNH;

            for (int j = 1; j < 5; j++)
            {
                tongthu = 0;
                tongchi = 0;
                hdth = HOADON_BUL.HoaDonTongHop(dtpTuNgay.Text.ToString(), dtpDenNgay.Text.ToString(), j.ToString());
                if (hdth != null)
                {
                    for (int i = 0; i < hdth.Count; i++)
                        tongthu += hdth[i].TongTien;
                }
                lstLNV = NHANVIEN_BUL.LuongNhanVienCS(j.ToString());
                if (lstLNV != null)
                    for (int i = 0; i < lstLNV.Count; i++)
                    {
                        tongchi += lstLNV[i].Luong;
                    }
                lstTNH = KHO_BUL.NhapHang(j.ToString());
                if (lstTNH != null)
                {
                    for (int i = 0; i < lstTNH.Count; i++)
                    {
                        tongchi += lstTNH[i].TongTien;
                    }
                }
                int lai = tongthu - tongchi;
                chartdoanhthu.Add(lai);
                hdth = new List<HOADONTONGHOP_DTO>();
                lstLNV = new List<LUONGNHANVIEN_DTO>();
                lstTNH = new List<TIENNHAPHANG_DTO>();
            }
        }   

        private void btnDanhGia_Click(object sender, EventArgs e)
        {
            fmChart chart = new fmChart(chartdoanhthu);
            chart.Show();
        }

        private void btnChiTietLuong_Click(object sender, EventArgs e)
        {
            fmChiTietLuong ctluong = new fmChiTietLuong();
            ctluong.Show();
        }

        private void btnChiTietHoaDon_Click(object sender, EventArgs e)
        {
            fmChiTietHoaDon cthoadon = new fmChiTietHoaDon();
            cthoadon.Show();
        }

        private void btnChiTietHang_Click(object sender, EventArgs e)
        {
            fmChiTietTienHang ctien =new fmChiTietTienHang();
            ctien.Show();
        }
    }
}
