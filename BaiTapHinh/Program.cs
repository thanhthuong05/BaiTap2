using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapHinh
{
    class Program
    {
        static void Main(string[] args)
        {
            HinhTron ht = new HinhTron(5);
            Console.WriteLine("****** Thong tin hinh tron:");
            Console.WriteLine("Ban kinh: {0} - Dien tich: {1} - Chu vi: {2} , ",
                ht.getBanKinh(), ht.TinhDienTich(), ht.TinhChuVi());
            Console.ReadLine();
        }
    }
}
