using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackLL
{
    internal class stack<T>
    {
        public Snode<T> Head;
        public int maxsize;
        public int top;

        public stack(int size)
        {
            Head = null;
            maxsize = size;
            top = -1;

        }
        public bool isfull()
        {
            if (top != maxsize-1 || top<maxsize )
            {
                return false;
            }
            return true;
        }

        public bool isempty()
        {
            if (top == -1)
            {
                return true;
            }
            return false;
        }
        public void push(T data)
        {

            if (isfull())
            {
                Console.WriteLine("stackoverflow");
            }
            else
            {
                Snode<T> newnode = new Snode<T>(data);

                if (Head == null)
                {
                    Head = newnode;
                }
                else
                {
                    Snode<T> temp = Head;
                    while (temp.Next != null)
                    {
                        temp = temp.Next;
                    }
                    temp.Next = newnode;
                }
                top++;
            }
            Console.WriteLine($"top: {top}");

        }

        public void pop()
        {
            Snode<T> temp = Head;
            if (isempty())
            {
                Console.WriteLine("stackunderflow");
            }
            else
            {
                temp = Head;
                while (temp.Next.Next != null)
                {
                    temp = temp.Next;
                }
                temp.Next = null;
                top--;
            }
            Console.WriteLine($"top: {top} with Data: {temp.Data}");
        }

        public void peek()
        {
            Snode<T> temp = Head;
            int Index = top ;
            while (Index > 0)
            {
                temp = temp.Next;
                Index--;
            }
            Console.WriteLine($"Current Top :{temp.Data}");
        }

        public void printstackll()
        {
            Snode<T> temp = Head;
            while (temp != null)
            {
                Console.Write($"{temp.Data}->");
                temp = temp.Next;
            }
            Console.Write("NULL\n");
        }
    }
}
