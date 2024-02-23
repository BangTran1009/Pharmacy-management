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
    public partial class fmChart : Form
    {
        private List<int> dt;
        public fmChart()
        {
            InitializeComponent();
        }
        public fmChart(List<int> dt)
        {
            InitializeComponent();
            this.dt = dt;
        }
        private void fmChart_Load(object sender, EventArgs e)
        {

            chartDoanhThu.Series["Doanh thu"].Points.AddXY("Cơ sở 1",dt[0]);
            chartDoanhThu.Series["Doanh thu"].Points.AddXY("Cơ sở 2", dt[1]);
            chartDoanhThu.Series["Doanh thu"].Points.AddXY("Cơ sở 3", dt[2]);
            chartDoanhThu.Series["Doanh thu"].Points.AddXY("Cơ sở 4", dt[3]);

        }
    }
}
