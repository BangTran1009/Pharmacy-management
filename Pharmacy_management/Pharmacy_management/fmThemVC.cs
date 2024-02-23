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
    public partial class fmThemVC : Form
    {
        public fmThemVC()
        {
            InitializeComponent();
        }
        string idvc = "";
        private void btnThem_Click(object sender, EventArgs e)
        {
            VOUCHER_DTO vc = new VOUCHER_DTO();
            vc.IdVC = txtIdVC.Text;
            vc.NgayHH = Convert.ToDateTime(dtpNgayHH.Value);
            vc.Giamgia = Convert.ToDouble(txtGiamgi.Text);
            VOUCHER_BULL.ThemVC(vc);
            MessageBox.Show("Thêm thành công!!", "Thông Báo");
            txtGiamgi.Text = "";
            txtIdVC.Text = GetId();
        }
        public string GetId()
        {
            string idvc = VOUCHER_BULL.GetIdVC();
            string Id = "";
            if (idvc[2] == '0')
            {
                Id = "VC0" + (Convert.ToInt32(idvc[3].ToString()) + 1).ToString();

            }
            else

            {
                int id = Convert.ToInt32((idvc[2] + idvc[3]).ToString()) + 1;
                Id = "VC" + id.ToString();
            }
            return Id;
        }
        private void fmThemVC_Load(object sender, EventArgs e)
        {
           
            txtIdVC.Text = GetId();
            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
