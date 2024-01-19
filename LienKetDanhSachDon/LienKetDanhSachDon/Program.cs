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
        public void ProcessList()
        {
            Node p = Head;
            while ( p != null)
            {
                Console.Write($"{p.Info} ");
                p = p.Next;
            }    
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
            Console.WriteLine("Danh sách lien ket: ");
            ds.ProcessList();
            Console.ReadLine();

        }
    }
}
