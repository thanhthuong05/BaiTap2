using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap01
{
    class HinhChuNhat
    {
        private double ChieuDai, ChieuRong;
        public HinhChuNhat()
        {
            ChieuDai = 2.0;
            ChieuRong = 3.0;
        }
        public HinhChuNhat(double ChieuDai, double ChieuRong)
        {
            this.ChieuDai = ChieuDai;
            this.ChieuRong = ChieuRong;
        }
        public void setChieuDai(double ChieuDai)
        {
            this.ChieuDai = ChieuDai;
        }
        public double getChieuDai()
        {
            return ChieuDai;
        }
        public void setChieuRong(double ChieuRong)
        {
            this.ChieuRong = ChieuRong;
        }
        public double getChieuRong()
        {
            return ChieuRong;
        }
        public double DienTich()
        {
            return ChieuRong * ChieuDai;
        }
        public double ChuVi()
        {
            return (ChieuRong + ChieuDai) * 2;
        }
    }
    class Program_BT01_
    {
        static void Main(string[] args)
        {
            HinhChuNhat r1, r2;
            r1 = new HinhChuNhat();
            Console.WriteLine("Thong tin hinh chu nhat thu nhat");
            Console.WriteLine("Chieu dai = {0}\nChieu rong = {1}\nChu vi = {2}\nDien tich = {3}",
                               r1.getChieuDai(), r1.getChieuRong(), r1.ChuVi(), r1.DienTich());

            Console.WriteLine("Thong tin hinh chu nhat thu hai");
            Console.Write("Nhap chieu dai = ");
            double chieudai = double.Parse(Console.ReadLine());
            Console.Write("Nhap chieu rong = ");
            double chieurong = double.Parse(Console.ReadLine());
            r2 = new HinhChuNhat(chieudai, chieurong);
            Console.WriteLine("Chieu dai = {0}\nChieu rong = {1}\nChu vi = {2}\nDien tich = {3}",
                               r2.getChieuDai(), r2.getChieuRong(), r2.ChuVi(), r2.DienTich());
            Console.ReadLine();
        }
    }
}