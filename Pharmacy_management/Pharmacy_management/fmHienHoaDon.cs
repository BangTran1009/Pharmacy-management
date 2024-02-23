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
    public partial class fmHienHoaDon : Form
    {
        private List<HOADON_DTO> lstHoaDon;
        private List<HoaDonChiTiet_DTO> lstCTHoaDon;
        private KHACHHANG_DTO kh;
        private NHANVIEN_DTO nv;
        private int tongtien;
        private int khuyenmai;
        private int thanhtoan;
        public fmHienHoaDon()
        {
            InitializeComponent();
        }
        public fmHienHoaDon(List<HOADON_DTO> lstHoaDon, KHACHHANG_DTO kh, NHANVIEN_DTO nv,List<HoaDonChiTiet_DTO> lstCTHoaDon, int tongtien, int khuyenmai, int thanhtoan)
        {
            InitializeComponent();
            this.kh = kh;
            this.nv = nv;
            this.lstHoaDon = lstHoaDon;
            this.lstCTHoaDon = lstCTHoaDon;
            this.tongtien = tongtien;
            this.khuyenmai = khuyenmai;
            this.thanhtoan = thanhtoan;

        }

        private void fmHienHoaDon_Load(object sender, EventArgs e)
        {
           for(int i=0;i<lstCTHoaDon.Count;i++)
            {
                dgvCTHoaDon.Rows.Add(lstCTHoaDon[i].TenHH, lstCTHoaDon[i].SL, lstCTHoaDon[i].Gia, lstCTHoaDon[i].ThanhTien);
            }    
            
            lbTongTien.Text = tongtien.ToString();
            lbKhuyenMai.Text = khuyenmai.ToString();
            lbThanhToan.Text = thanhtoan.ToString();
            lbTenKhachHang.Text = kh.TenKH;
            lbTenNhanVien.Text = nv.TenNV;
            lbSdtKh.Text = kh.SDT;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void fmHienHoaDon_FormClosed(object sender, FormClosedEventArgs e)
        { 
        }

        private void fmHienHoaDon_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void fmHienHoaDon_Leave(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            int len = dgvCTHoaDon.Rows.Count - 1;
            int v = 0;
            while (len > 0)
            {
                dgvCTHoaDon.Rows.RemoveAt(v);
                len = len - 1;
            }
            this.Close();
        }
    }
}
