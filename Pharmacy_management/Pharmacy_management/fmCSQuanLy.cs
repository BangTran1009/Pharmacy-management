using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy_management
{
    public partial class fmCSQuanLy : Form
    {
        public fmCSQuanLy()
        {
            InitializeComponent();
        }
        #region Edit From

        private Form currentFormChild;

        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_Body.Controls.Add(childForm);
            panel_Body.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void Home_Click_1(object sender, EventArgs e)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
        }
        private void lblNhanVien_Click(object sender, EventArgs e)
        {
            OpenChildForm(new fmCSNhanVien());
        }

        private void lblKhoHang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new fmCSKhoHang());
        }

        private void lblTaiKhoan_Click(object sender, EventArgs e)
        {
            OpenChildForm(new fmCSTaiKhoan());
        }

        private void lblThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblDoanhThu_Click(object sender, EventArgs e)
        {
            OpenChildForm(new fmCSDoanhThu());
        }
        #endregion

        private void panel_Top_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
