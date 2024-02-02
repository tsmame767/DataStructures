using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class DoublyLinkedList<T>
    {
        node<T> head;

        public DoublyLinkedList()
        {
            head = null;
        }

        public void Addnode(T data)
        {
            node<T> newnode = new node<T>(data);

            if (head == null)
            {
                head = newnode;
            }
            else
            {
                node<T> temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = newnode;
                temp.next.prev = temp;
            }
        }
        public void Addfirst(T data)
        {
            node<T> newnode = new node<T>(data);

            newnode.next = head;
            head.prev = newnode;
            head = newnode;
        }

        public void Addmid(T data)
        {
            node<T> newnode = new node<T>(data);
            node<T> temp = head;

            Console.WriteLine("enter the position to add in mid: ");
            int index = Convert.ToInt32(Console.ReadLine());

            while ((index - 2) > 0)
            {
                temp = temp.next;
                index--;
            }
            newnode.prev = temp;
            newnode.next = temp.next;
            temp.next.prev = newnode;
            temp.next = newnode;

        }

        public void Remfirst()
        {
            head = head.next;
            head.prev = null;

        }

        public void Remlast()
        {
            node<T> temp = head;
            while (temp.next.next != null)
            {
                temp = temp.next;
            }
            temp.next.prev = null;
            temp.next = null;
        }
        public void Remmid()
        {
            node<T> temp = head;
            Console.WriteLine("enter the position to remove in mid: ");
            int index=Convert.ToInt32(Console.ReadLine());

            while ((index - 1) > 0)
            {
                temp = temp.next;
                index--;
            }
            temp.prev.next = temp.next;
            temp.next.prev = temp.prev;


        }

        public void printll()
        {
            node<T> temp = head;
            while (temp != null)
            {
                Console.Write($"{temp.Data}->");
                temp = temp.next;
            }
            Console.Write("null\n");

        }


    }
}
