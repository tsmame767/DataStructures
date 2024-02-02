using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stack
{
    internal class main
    {
        static void Main()
        {
            StackClass<int> stk = new StackClass<int>(5);
            stk.push(1);
            stk.push(2);
            stk.push(4);
            stk.printstack();
            stk.pop();
            stk.printstack();
            stk.push(3);
            stk.push(4);
            stk.printstack();

        }
    }
}
