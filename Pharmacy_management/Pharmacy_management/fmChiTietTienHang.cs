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
    public partial class fmChiTietTienHang : Form
    {
        public fmChiTietTienHang()
        {
            InitializeComponent();
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            (dgvHH.DataSource as DataTable).DefaultView.RowFilter = string.Format("TenHH LIKE '%{0}%' ", txtTimKiem.Text);

        }

        private void fmChiTietTienHang_Load(object sender, EventArgs e)
        {
            DataTable dt = KHO_BUL.Kho();
            dgvHH.DataSource = dt;
            txtTongLoaiHang.Text = dt.Rows.Count.ToString();
        }
    }
}
