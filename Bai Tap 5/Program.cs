using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_Tap_5
{
    class Program
    {
        static void Main(string[] args)
        {
            menu();
        }
        static void menu()
        {
            QuanLyCD quanlyCD = new QuanLyCD(3);
            int chon = 0;
            do
            {
                Console.WriteLine("*******Chuong trinh quan ly***********");
                Console.WriteLine("1. Them CD");
                Console.WriteLine("2. Tinh gia thanh binh: ");
                Console.WriteLine("3. Sap xep CD giam dan them gia thanh: ");
                Console.WriteLine("4. Sap xep CD tang dan theo tua CD");
                Console.WriteLine("5. Xuat toan bo CD");
                Console.WriteLine("0. Thoat chuong trinh");
                Console.WriteLine("-----------------------------");
                Console.Write("ban chon: ");
                chon = int.Parse(Console.ReadLine());
                switch (chon)
                {
                    case 1:
                        CD cd = new CD();
                        Console.Write("Nhap ma CD:");
                        cd.MaCD = int.Parse(Console.ReadLine());
                        Console.Write("Nhap tua CD:");
                        cd.TuaCD = Console.ReadLine();
                        Console.Write("Nhap ca si:");
                        cd.CaSi = Console.ReadLine();
                        Console.Write("Nhap so bai hat:");
                        cd.SoBaiHat = int.Parse(Console.ReadLine());
                        Console.Write("Nhap gia thanh:");
                        cd.DonGia = int.Parse(Console.ReadLine());
                        quanlyCD.ThemCD(cd);
                        break;
                    case 2:
                        double kq = quanlyCD.TinhGiaTB();
                        Console.WriteLine("Gia thanh trung binh : (0: #.##0.00) ", kq);
                        break;
                    case 3:
                        quanlyCD.SapXepGiamThemGiaThanh();
                        Console.WriteLine("da sap xep theo gia thanh giam dan: ");
                        break;
                    case 4:quanlyCD.SapXepTangTheoTuaCD();
                        Console.WriteLine(" Da sap xep tang theo tua CD: ");
                        break;
                    case 5:
                        quanlyCD.Xuat();
                        break;
                }

            } while (chon!=0);
        }
    }
}
