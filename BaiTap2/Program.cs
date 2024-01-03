using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap2
{
    class Acccount
    {
        private string id;
        private string name;
        private int balance;

        public Acccount(string id, string name, int balance)
        {
            this.id = id;
            this.name = name;
            this.balance = balance;
        }
        public string getID()
        {
            return id;
        }
        public string getName()
        {
            return name;
        }
        public int getBalance()
        {
            return balance;
        }
        public void credit(int amount)
        {
            if (amount > 0)
                balance += amount;
        }
        public void debit(int amount)
        {
            if (amount <= balance)
                balance -= amount;
            else
                Console.WriteLine("So tien vuot qua so du. Rut tien khong thanh cong");

        }
        public void tranFerTo(Acccount acc, int amount)
        {
            if (amount <= balance)
            {
                balance -= amount;
                acc.balance += amount;
            }
            else
            {
                Console.WriteLine("So tien vuot so du. Chuyen khoan khong thanh cong:");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Acccount my = new Acccount("900111", "Le Van Ti", 600);
            Acccount myFriend = new Acccount("900112", "Tran Van Ti", 30);
            Console.WriteLine("---------Thong tin 2 tai khoan ban dau-------");
            Console.WriteLine("My Account: [ id;{0}, name : {1}, blance: {2}",
            my.getID(), my.getName(), my.getBalance());
            Console.WriteLine("My Friend Account: [ id;{0}, name : {1}, blance: {2}",
           myFriend.getID(), myFriend.getName(), myFriend.getBalance());

            // RUT TIEN 

            my.debit(200);
            my.tranFerTo(myFriend, 450);

            //ket qua sau khi thuc hien mot so hanh vi(nap, rut, chuyen khoan)

            Console.WriteLine("---------Thong tin 2 tai khoan ban dau-------");
            Console.WriteLine("My Account: [ id;{0}, name : {1}, blance: {2}",
            my.getID(), my.getName(), my.getBalance());
            Console.WriteLine("My Friend Account: [ id;{0}, name : {1}, blance: {2}",
            myFriend.getID(), myFriend.getName(), myFriend.getBalance());
            Console.ReadLine();
        }
    }
}