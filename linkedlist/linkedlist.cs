﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linkedlist
{
    internal class Node<T>
    {
        public T Data;
        public Node<T> next;

        public Node(T data)
        {
            Data = data;
            next = null;
        }

    }
}
