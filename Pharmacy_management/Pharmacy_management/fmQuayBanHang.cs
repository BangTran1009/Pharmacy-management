using BUL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Pharmacy_management
{
    public partial class fmQuayBanHang : Form
    {
        KHACHHANG_DTO KH =new KHACHHANG_DTO();
        NHANVIEN_DTO nvHienTai = new NHANVIEN_DTO();
        VOUCHER_DTO voucher = new VOUCHER_DTO();    
        List<HOADON_DTO> HOAdon = new List<HOADON_DTO>();
        List<HoaDonChiTiet_DTO> CTHoaDon = new List<HoaDonChiTiet_DTO>();
        int indexVC = 0;
        public fmQuayBanHang()
        {
            InitializeComponent();
        }
        private void fmQuayBanHang2_Load_1(object sender, EventArgs e)
        {
            dgvKhachHang.DataSource = KHACHHANG_BUL.LoadKhachHangTB();
            dgvDanhsachHHCB.DataSource = KHO_BUL.Kho();
            cmbChonCombo.DataSource = TENCOMBOTHUOC_BUL.LoadTenCBT();
            cmbChonCombo.ValueMember = "IdTenCB";
            cmbChonCombo.DisplayMember = "TenCB";
            dgvDanhSachThuoc.DataSource = KHO_BUL.Kho();
            dgvVoucher.DataSource = VOUCHER_BULL.LoadVC();
        }

        #region KHACHHANG

        private void txtTimKiemKh_TextChanged(object sender, EventArgs e)
        {
            dgvKhachHang.DataSource = KHACHHANG_BUL.LoadKhachHangTB();
            (dgvKhachHang.DataSource as DataTable).DefaultView.RowFilter = string.Format("SdtKH  LIKE '%{0}%' ", txtTimKiemKh.Text);

        }
        
        private void btnThemKh_Click(object sender, EventArgs e)
        {

            fmThemKhachHang ThemKH = new fmThemKhachHang();
            ThemKH.Show();

        }

        int indexKH = 0;
        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexKH = dgvKhachHang.CurrentCell.RowIndex;
        }

        private void btnChonKH_Click(object sender, EventArgs e)
        {
            KH.SDT = (dgvKhachHang.Rows[indexKH].Cells[0].Value).ToString();
            KH.TenKH = (dgvKhachHang.Rows[indexKH].Cells[1].Value).ToString();
            KH.NgaySinh = Convert.ToDateTime(dgvKhachHang.Rows[indexKH].Cells[2].Value);
            KH.DiaChi = (dgvKhachHang.Rows[indexKH].Cells[3].Value).ToString();
            KH.Diem = Convert.ToInt32(dgvKhachHang.Rows[indexKH].Cells[4].Value);
        }
        #endregion

        #region HANGHOA

        private void txtTuKhoa_TextChanged(object sender, EventArgs e)
        {
            (dgvDanhSachThuoc.DataSource as DataTable).DefaultView.RowFilter = string.Format("TenHH LIKE '%{0}%' ", txtTuKhoa.Text);
        }

        int indexHH = 0;
        private void dgvDanhSachThuoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexHH = dgvDanhSachThuoc.CurrentCell.RowIndex;
        }

        int idHD = HOADON_BUL.GetId();
        private void btnThemVaoHoaDon_Click(object sender, EventArgs e)
        {
            if (txtSL.Text == "") MessageBox.Show("Hay nhap so luong", "Thông báo");
            else
            {
                HOADON_DTO hoadon = new HOADON_DTO();
                NHANVIEN_DTO nv = NHANVIEN_BUL.NhanVienHienTai();

                int gia = Convert.ToInt32(dgvDanhSachThuoc.Rows[indexHH].Cells[6].Value);
                gia = Convert.ToInt32(gia + 0.05 * gia);

                hoadon.IdHD = idHD + 1;
                hoadon.IdHH = Convert.ToInt32(dgvDanhSachThuoc.Rows[indexHH].Cells[0].Value);
                hoadon.SdtKH = KH.SDT;
                hoadon.IdNV = nv.IdNV;
                hoadon.IdCS = nv.IdNhaThuoc;
                hoadon.NgayMua = DateTime.Today;
                hoadon.SL = Convert.ToInt32(txtSL.Text);


                hoadon.TongTien = Convert.ToInt32(hoadon.SL * (gia + gia * 0.05));

                string tenHH = (dgvDanhSachThuoc.Rows[indexHH].Cells[3].Value).ToString();
                HoaDonChiTiet_DTO ctHD=new HoaDonChiTiet_DTO (tenHH, hoadon.SL, gia, hoadon.TongTien);
                CTHoaDon.Add(ctHD);
                dgvHoaDon.Rows.Add(tenHH, hoadon.SL, gia, hoadon.TongTien);

                if (txtTongTien.Text == "") txtTongTien.Text = "0";
                txtTongTien.Text = (Convert.ToInt32(txtTongTien.Text) + hoadon.TongTien).ToString();
                txtTongCVC.Text = txtTongTien.Text;
                HOAdon.Add(hoadon);

                txtSL.Text = "";
                txtTuKhoa.Text = "";
            }
        }

        private void btnChonCombo_Click(object sender, EventArgs e)
        {
            string sChuoiTruyVan = @"select * from COMBOTHUOC,TENCOMBOTHUOC where COMBOTHUOC.IdTenCB=TENCOMBOTHUOC.IdTenCB and TENCOMBOTHUOC.IdTenCB=(select IdTenCB from TENCOMBOTHUOC where TENCOMBOTHUOC.TenCB='" + cmbChonCombo.Text + "')";
            List<COMBOTHUOC_DTO> lstCB = COMBOTHUOC_BUL.TimCB(sChuoiTruyVan);
            HOADON_DTO hdDTO = new HOADON_DTO();
            for (int i = 0; i < lstCB.Count; i++)
            {

                hdDTO.IdHD = idHD + 1;
                hdDTO.IdHH = lstCB[i].IdHH;
                
                hdDTO.SdtKH = KH.SDT;

                nvHienTai = NHANVIEN_BUL.NhanVienHienTai();
                hdDTO.IdNV = nvHienTai.IdNV;
                hdDTO.IdCS = nvHienTai.IdNhaThuoc;
                hdDTO.NgayMua = DateTime.Today;
                hdDTO.SL = lstCB[i].SL;

                List<KHO_DTO> hh = KHO_BUL.TimKiemHangHoaCoSoTheoId(hdDTO.IdHH.ToString());
                int gia = Convert.ToInt32(hh[0].Gia);
                gia = Convert.ToInt32(gia + gia * 0.05);
                hdDTO.TongTien = hdDTO.SL * gia;


                dgvHoaDon.Rows.Add(hh[0].TenHH.ToString(), hdDTO.SL.ToString(), gia.ToString(), hdDTO.TongTien.ToString());
                HoaDonChiTiet_DTO ctHD = new HoaDonChiTiet_DTO(hh[0].TenHH, hdDTO.SL, gia, hdDTO.TongTien);
                CTHoaDon.Add(ctHD);
                
                if (txtTongTien.Text == "")
                    txtTongTien.Text = "0";
                hdDTO.IdHH = hh[0].IdHH;
                txtTongTien.Text = (Convert.ToInt32(txtTongTien.Text) + hdDTO.TongTien).ToString();
                txtTongCVC.Text = txtTongTien.Text;
                HOAdon.Add(hdDTO);
                hdDTO = new HOADON_DTO();
            }
            

        }

        #endregion

        #region COMBO
        int idCB = COMBOTHUOC_BUL.Getidcb();
        int indexCB = 0;
        private void btnThemHHCB_Click(object sender, EventArgs e)
        {
            COMBOTHUOC_DTO cb = new COMBOTHUOC_DTO();
            cb.IdCBT = idCB + 1;
            cb.IdTenCB = idCB + 1;
            cb.IdHH = Convert.ToInt32(dgvDanhSachThuoc.Rows[indexCB].Cells[0].Value);
            cb.SL = Convert.ToInt32(txtSLCB.Text);
            TENCOMBOTHUOC_DTO tencb = new TENCOMBOTHUOC_DTO();
            tencb.TenCB = txtTenCB.Text;
            tencb.IdTenCB = idCB + 1;

            if (COMBOTHUOC_BUL.ThemCombo(cb, tencb))
                COMBOTHUOC_BUL.ThemCombo(cb, tencb);
            txtSLCB.Text = "";

        }

        private void btnThemTenCB_Click(object sender, EventArgs e)
        {
        }
       
        private void dgvDanhsachHHCB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexCB = dgvDanhsachHHCB.CurrentCell.RowIndex;
        }

        private void bntThemCB_Click(object sender, EventArgs e)
        {
            COMBOTHUOC_BUL.Getidcb();
            cmbChonCombo.DataSource = TENCOMBOTHUOC_BUL.LoadTenCBT();
            cmbChonCombo.ValueMember = "IdTenCB";
            cmbChonCombo.DisplayMember = "TenCB";
            MessageBox.Show("Thêm thành công", "Thông báo");
        }

        private void txtTimKienCB_TextChanged(object sender, EventArgs e)
        {
            (dgvDanhsachHHCB.DataSource as DataTable).DefaultView.RowFilter = string.Format("TenHH  LIKE '%{0}%' ", txtTimKienCB.Text);
        }

        #endregion

        #region HOADON

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            List<KHO_DTO> UpHangHoa =new List<KHO_DTO>();
            for (int i = 0; i < HOAdon.Count; i++)
            {
                if (HOADON_BUL.ThemHoaDon(HOAdon[i]))
                {
                    HOADON_BUL.ThemHoaDon(HOAdon[i]);
                    UpHangHoa = KHO_BUL.TimKiemHangHoaCoSoTheoId(HOAdon[i].IdHH.ToString());
                    UpHangHoa[0].SoLuong = UpHangHoa[0].SoLuong - HOAdon[i].SL;
                    if (HOAdon[i].IdCS == 1)
                    {
                        
                        UpHangHoa[0].SoLuongCS1 = UpHangHoa[0].SoLuongCS1 - HOAdon[i].SL;
                    }
                    if (HOAdon[i].IdCS == 2)
                    {
                        UpHangHoa[0].SoLuongCS2 = UpHangHoa[0].SoLuongCS2 - HOAdon[i].SL;

                    }
                    if (HOAdon[i].IdCS == 3)
                    {
                        UpHangHoa[0].SoLuongCS3 = UpHangHoa[0].SoLuongCS3 - HOAdon[i].SL;
                    }
                    KHO_BUL.UpdateHH(UpHangHoa[0]);
                    UpHangHoa = new List<KHO_DTO>();
                }
                
            }
            MessageBox.Show("Thêm thành công!!", "Thông Báo");
            int ttien = Convert.ToInt32(txtTongCVC.Text);
            if (txtKhuyenmai.Text=="")
            {
                txtKhuyenmai.Text = "0";
            }
            int kmai= Convert.ToInt32(txtKhuyenmai.Text);
            int ttoan = Convert.ToInt32(txtTongTien.Text);
            fmHienHoaDon hienHD = new fmHienHoaDon(HOAdon, KH, nvHienTai, CTHoaDon,
                Convert.ToInt32(txtTongCVC.Text),
                Convert.ToInt32(txtKhuyenmai.Text),
                Convert.ToInt32(txtTongTien.Text));
            hienHD.Show();
            idHD = HOADON_BUL.GetId();
            KH = new KHACHHANG_DTO();
            nvHienTai = new NHANVIEN_DTO();
            HOAdon = new List<HOADON_DTO>();
            CTHoaDon = new List<HoaDonChiTiet_DTO>();
            int len = dgvHoaDon.Rows.Count - 1;
            int v= 0;
            while(len>0)
            {
                dgvHoaDon.Rows.RemoveAt(v);
                len = len - 1;
            }


        }

        private void bntXoa_Click(object sender, EventArgs e)
        {
            dgvHoaDon.Rows.RemoveAt(indexHD);
            txtTongTien.Text =( Convert.ToInt32(txtTongTien.Text) - HOAdon[indexHD].TongTien).ToString();
            txtTongCVC.Text = txtTongTien.Text;
            HOAdon.RemoveAt(indexHD);
           

        }

        int indexHD = 0;
        private void dgvHoaDon_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            indexHD = dgvHoaDon.CurrentCell.RowIndex;
        }
        #endregion

        #region VOUCHER
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dgvVoucher.DataSource = VOUCHER_BULL.LoadVC();
            (dgvVoucher.DataSource as DataTable).DefaultView.RowFilter = string.Format("IdVC  LIKE '%{0}%' ", txtTimVC.Text);
        }

        private void btnChonVC_Click(object sender, EventArgs e)
        {
            voucher.IdVC =Convert.ToString( dgvVoucher.Rows[indexVC].Cells[0].Value);
            voucher.NgayHH = Convert.ToDateTime(dgvVoucher.Rows[indexVC].Cells[1].Value);
            voucher.Giamgia = Convert.ToDouble(dgvVoucher.Rows[indexVC].Cells[2].Value);
            DateTime ngaymua = Convert.ToDateTime((Convert.ToDateTime(HOAdon[0].NgayMua)).ToString("MM / dd / yyyy"));
            DateTime ngayhh = Convert.ToDateTime((Convert.ToDateTime(voucher.NgayHH)).ToString("MM / dd / yyyy"));
            if (DateTime.Compare(ngaymua, ngayhh) <0)
            {
                int tien = Convert.ToInt32(txtTongTien.Text);
                txtKhuyenmai.Text = Convert.ToInt32(tien * voucher.Giamgia).ToString();
                txtTongTien.Text = Convert.ToInt32(tien - Convert.ToInt32( tien * voucher.Giamgia)).ToString();
                dgvVoucher.Rows.RemoveAt(indexVC);
            }
            else
                MessageBox.Show("Voucher đã hết hạn!! ","Thông báo");
        }

        private void dgvVoucher_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexVC=dgvVoucher.CurrentCell.RowIndex;
        }

        private void btnThemVC_Click(object sender, EventArgs e)
        {
            fmThemVC ThemVC = new fmThemVC();
            ThemVC.Show();
        }
        #endregion
    }
}
