using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DoanhThu
    {
        public int tongthu; 
        public int tongchi;
        public int doanhthu;
        public DoanhThu(int thu, int chi, int lai)
        {
            this.tongchi = chi;
            this.tongthu = thu;
            this.doanhthu = lai;
        }
    }
}
