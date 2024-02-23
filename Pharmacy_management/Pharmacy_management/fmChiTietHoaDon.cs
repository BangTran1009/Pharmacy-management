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
    public partial class fmChiTietHoaDon : Form
    {
        public fmChiTietHoaDon()
        {
            InitializeComponent();
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fmChiTietHoaDon_Load(object sender, EventArgs e)
        {
           

        }

        private void txtTongHoaDon_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            
            DataTable lshd = HOADON_BUL.HoaDonTongHopTheoNgay(dtmLocNgay.Text.ToString());
            dgvChiTietHoaDon.DataSource = lshd;
            if ( lshd !=null)
            txtTongHoaDon.Text = lshd.Rows.Count.ToString();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            (dgvChiTietHoaDon.DataSource as DataTable).DefaultView.RowFilter = string.Format("TenKH LIKE '%{0}%' ", txtTimKiem.Text);

        }
    }
}
