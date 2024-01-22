using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LienKetDanhSachDon
{
    class Node
    {
        private int info;
        private Node next;

        public Node(int x)
        {
            info = x;
            next = null;
        }
        public int Info
        {
            set { this.info = value; }
            get { return info; }
        }
        public Node Next
        {
            set { this.next = value; }
            get { return next; }
        }
    }
    class SingleLinklist
    {
        private Node Head;
        public SingleLinklist()
        {
            Head = null;
        }
        public void AddHead(int x)
        {
            Node p = new Node(x);
            p.Next = Head;
            Head = p;
        }
        public void Addlast(int x)
        {
            Node p = new Node(x);
            if (Head == null)
            {
                Head = p;
            }    
            else
            {
                Node q = Head;
                while(q.Next != null)
                {
                }
                q.Next = p;
            }    
        }
        public void DaleteHead()
        {
            if (Head != null)
            {
                Node p = Head;
                Head = Head.Next;
                p.Next = null;
            }    
        }
        public void DaleteLast()
        {
            if (Head != null)
            {
                {
                    Node p = Head;
                    Node q = null;
                    while (p.Next != null)
                    {
                        q = p;
                        p = p.Next;
                    }
                    q.Next = null;
                }
            }
        }
        public void Dalatenode(int x)
        {
            if (Head != null)
            {
                Node p = Head;
                Node q = null;
                while (p != null && p.Info != x)
                {
                    q = p;
                    p = p.Next;
                }
                if (p != null)
                {
                    if (p == Head)
                        DaleteHead();
                    else
                    {
                        q.Next = p.Next;
                        p.Next = null;
                    }
                }
            }
        }
        public void ProcessList()
        {
            Node p = Head;
            while ( p != null)
            {
                Console.Write($"{p.Info} ");
                p = p.Next;
            }    
        }
        public Node FinMax()
        {
            Node max = Head;
            Node p = Head.Next;
            while(p != null)
            {
                if (p.Info > max.Info)
                {
                    max = p;
                }
                p = p.Next;
            }
            return max;
        }
        public float Avg()
        {
            float sum = 0;
            int count = 0;
            Node p = Head;
            while(p != null)
            {
                sum += p.Info;
                count++;

                p = p.Next;
            }
            return sum / count;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            SingleLinklist ds = new SingleLinklist();
            ds.AddHead(6);
            ds.AddHead(5);
            ds.AddHead(9);
            ds.AddHead(10);
            ds.AddHead(15);
            Console.WriteLine("Danh sách lien ket: ");
            ds.ProcessList();




            ds.DaleteHead();
            Console.WriteLine("\nDanh sach lien ket sau khi xoa nut dau:");
            ds.ProcessList();


            ds.DaleteHead();
            Console.WriteLine("\n Danh sach sau khi xoa nut cuoi: ");
            ds.ProcessList();

            Console.Write("\n Nhap gia x can xoa: ");
            int x = int.Parse(Console.ReadLine());
            ds.Dalatenode(x);
            Console.WriteLine("\n Danh sach sau khi xoa nut co gia tri x:");
            ds.ProcessList();

            Console.WriteLine($"\n Gia tri nut lon nhat :{ds.FinMax().Info}");
            Console.WriteLine($"\n Gia tri chung cua danh sach: : {ds.Avg()}");
            Console.ReadLine();

        }
        static void NhapDanhSach(SingleLinklist ds)
        {
            string chon = "y";
            int x;
            while (chon != "n")
            {
                Console.Write("Nhap gia tri nut:");
                x = int.Parse(Console.ReadLine());
                ds.AddHead(x);
                Console.Write("Tiep tuc (y/n)?");
                chon = Console.ReadLine();
            }    
        }
    }
}
