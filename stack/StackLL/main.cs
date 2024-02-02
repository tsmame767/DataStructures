using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackLL
{
    internal class main
    {
        static void Main()
        {

            stack<int> stk = new stack<int>(5);
            stk.push(10);
            stk.push(20);
            stk.push(30);
            stk.push(55);
            stk.peek();
            stk.printstackll();
            stk.pop();
            stk.push(40);
            stk.push(50);
            stk.peek();
            stk.printstackll();

            //Console.WriteLine($"toptop}");
        }
    }
}
