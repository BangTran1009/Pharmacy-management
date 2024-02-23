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
    public partial class fmChiTietLuong : Form
    {
        public fmChiTietLuong()
        {
            InitializeComponent();
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fmChiTietLuong_Load(object sender, EventArgs e)
        {
            DataTable lshd = NHANVIEN_BUL.LuongNhanVienTB();
            dgvChiTietLuong.DataSource = lshd;
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            
            (dgvChiTietLuong.DataSource as DataTable).DefaultView.RowFilter = string.Format("TenNV LIKE '%{0}%' ", txtTimKiem.Text);

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
