using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackLL
{
    internal class Snode<T>
    {
        public T Data;
        public Snode<T> Next;

        public Snode(T data)
        {
            Data = data;
            Next = null;
        }
    }
}
