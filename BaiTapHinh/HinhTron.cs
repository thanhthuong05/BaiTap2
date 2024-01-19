using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapHinh
{
    class HinhTron
    {
        private double bankinh;
        public HinhTron()
        {
            bankinh = 1.0;
        }
        public HinhTron(double bankinh)
        {
            setBanKinh(bankinh);
        }
        public void setBanKinh(double bankinh)
        {
            this.bankinh = Math.Abs(bankinh);
        }
        public double getBanKinh()
        {
            return bankinh;
        }
        public double TinhDienTich()
        {
            return bankinh * bankinh * Math.PI;
        }
        public double TinhChuVi()
        {
          return  2 * bankinh * Math.PI;
        }
    }
}
