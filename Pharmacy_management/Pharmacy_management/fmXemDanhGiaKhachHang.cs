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
    public partial class fmXemDanhGiaKhachHang : Form
    {
        public fmXemDanhGiaKhachHang()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fmXemDanhGiaKhachHang_Load(object sender, EventArgs e)
        {
            dgvDanhGia.DataSource = DANHGIA_BUL.LoadDanhGia();
        }

        private void dgvDanhGia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvDanhGia.CurrentCell.RowIndex;

            txtTenKhachHang.Text = dgvDanhGia.Rows[r].Cells[0].Value.ToString();
            dtpNgayDanhGia.Value = Convert.ToDateTime(dgvDanhGia.Rows[r].Cells[1].Value);
            txtNoiDung.Text = dgvDanhGia.Rows[r].Cells[2].Value.ToString();
            
        }
    }
}
