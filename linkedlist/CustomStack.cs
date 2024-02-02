using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linkedlist
{
    public class CustomStack
    {
        private LinkedOPP<int> stack=new LinkedOPP<int>();

        public void push(int newnum)
        {
            stack.Addnode(newnum);
        }

        public void pop()
        {
            stack.Removelast();
        }

        public void peek()
        {
            stack.PrintLastele();
        }
    }
}
