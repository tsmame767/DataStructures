using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BST
{
    public class node<T> 
    {
        public T Data;
        public node<T> right;
        public node<T> left;

        public node(T data)
        {
            Data = data;
            right = left = null;

        }
    }
}
