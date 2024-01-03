using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap3
{
    class phanso
    {
        private int tuso, mauso;

        public phanso()
        {
            tuso = 0;
            mauso = 1;
        }
        public phanso(int tuso, int mauso)
        {
            this.tuso = tuso;
            this.mauso = mauso;
        }
        public void settuso(int tuso)
        {
            this.tuso = tuso;
        }
        public int gettuso()
        {
            return tuso;
        }
        public void setMauso(int mauso)
        {
            this.mauso = mauso;
        }
        public int getMauso()
        {
            return mauso;
        }
        public void toiGian()
        {
            int uscln = TimUSCLN(tuso, mauso);
            tuso = tuso / uscln;
            mauso = mauso / uscln;
        }
        private int TimUSCLN(int a, int b)
        {
            int x = Math.Abs(a);
            int y = Math.Abs(b);
            while (x != y)
            {
                if (x > y)
                    x = x - y;
                else
                    y = y - x;
            }
            return x;
        }
        public phanso cong(phanso ps)
        {
            phanso kq = new phanso();
            kq.tuso = tuso * ps.mauso + ps.tuso * mauso;
            kq.mauso = mauso * ps.mauso;
            return kq;
        }
        public phanso tru(phanso ps)
        {
            phanso kq = new phanso();
            kq.tuso = tuso * ps.mauso - ps.tuso * mauso;
            kq.mauso = mauso * ps.mauso;
            return kq;
        }
        public phanso nhan(phanso ps)
        {
            phanso kq = new phanso();
            kq.tuso = tuso * ps.mauso;
            kq.mauso = mauso * ps.mauso;
            return kq;
        }
        public phanso chia(phanso ps)
        {
            phanso kq = new phanso();
            kq.tuso = tuso * ps.mauso + ps.tuso * mauso;
            kq.mauso = mauso * ps.mauso;
            return kq;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //câu a
            phanso p1 = new phanso();
            Console.WriteLine("******Nhap thong tin phan so thu 1: ");
            Console.Write("Nhap tu so");
            int tuso = int.Parse(Console.ReadLine());
            Console.Write("Nhap mau so; ");
            int mauso = int.Parse(Console.ReadLine());
            phanso p2 = new phanso(tuso, mauso);
            p2.toiGian();
            phanso tong = p1.cong(p2);
            Console.WriteLine("Tong hai phan so PS1{0/{1}, PS2[{2}/{3}] = KQ[{4}/{5}]",
            p1.gettuso(), p1.getMauso(), p2.gettuso(), p2.getMauso());
            Console.ReadLine();
    }
    }
}