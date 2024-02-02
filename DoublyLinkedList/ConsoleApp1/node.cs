using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class node<T>
    {
        public node<T> prev;
        public T Data;
        public node<T> next;

        public node(T data)
        {
            prev = null;
            Data = data;
            next = null;

        }
    }
}
