using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class main
    {

        static void Main()
        {

            DoublyLinkedList<int> obj = new DoublyLinkedList<int>();

            obj.Addnode(10);
            obj.Addnode(20);
            obj.Addnode(30);
            obj.Addmid(40);
            obj.Addfirst(50);

            obj.printll();

            obj.Remfirst();
            obj.Remlast();
            obj.Remmid();

            obj.printll();
        }
    }
}
