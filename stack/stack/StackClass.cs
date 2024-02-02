using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stack
{
    internal class StackClass<T>
    {
        private T[] element;
        private int maxsize;
        private int top; 

        public StackClass(int size)
        {
            maxsize = size;
            element = new T[maxsize];
            top = -1;
        }


        public void push(T data)
        {
            if (top != maxsize-1)
            {
                element[++top] = data; 
                //top++;
            }
            else
            {
                Console.WriteLine("stackoverflow");
            }
        }
        public void pop()
        {
            if (top == -1)
            {
                Console.WriteLine("stackunderflow");
            }
            else
            {
                top--;
            }
        }

        public void peek()
        {
            Console.WriteLine(element[top]);
        }

        public void printstack()
        {
            for(int i=0;i<top+1;i++)
            {
                Console.Write(element[i]+" ");
            }
            Console.WriteLine();
        }
    }
}
