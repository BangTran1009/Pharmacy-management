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
    public partial class fmQuanLy : Form
    {
        public fmQuanLy()
        {
            InitializeComponent();
        }
        #region Eidt Form
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

        private void Home_Click(object sender, EventArgs e)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
        }

        private void lblNhanVien_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new fmNhanVien());
        }

        private void lblKhachHang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new fmKhachHang());
        }

        private void lblThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblKhoHang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new fmKhoHang());
        }

        private void lblCoSo_Click(object sender, EventArgs e)
        {
            OpenChildForm(new fmCoSo());
        }

        private void lblDoanhThu_Click(object sender, EventArgs e)
        {
            OpenChildForm(new fmDoanhThu());
        }

        private void lblTaiKhoan_Click(object sender, EventArgs e)
        {
            OpenChildForm(new fmTaiKhoan());
        }
        #endregion
    }
}
