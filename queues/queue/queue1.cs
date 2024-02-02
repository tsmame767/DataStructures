using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace queue
{
    public class queueopps<T>
    {
        public T[] elements;
        public int front;
        public int rear;
        public int maxsize;

        public queueopps(int size)
        {
            maxsize = size;
            elements = new T[maxsize];
            front = -1;
            rear = -1;
        }

        public void enqueue(T data)
        {
            if (Isfull())
            {
                Console.WriteLine("Queue is full");
            }
            else
            {
                if (front == -1)
                {
                    front = 0;
                }
                
                elements[++rear] = data;
                
            }

        }

        public void dequeue()
        {
            if(Isempty())
            {
                Console.WriteLine("Queue is Empty");
            }
            else
            {
                ++front;
                if (front == maxsize - 1 && rear == maxsize - 1)
                {
                    front = -1;
                    rear = -1;
                }
                
                
                    
                

            }

        }

        public void peek()
        {

        }

        public bool Isempty()
        {
            if(rear==-1 && front == -1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Isfull()
        {
            if (rear == maxsize - 1 && front == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void printQ()
        {
            for(int i = front; i < rear+1; i++) {

                if (i == -1)
                {
                    Console.WriteLine("empty queue");
                    break;
                }
                    Console.Write(elements[i] + " ");
            }
            Console.WriteLine($"front: {front} rear: {rear} ");
        }
    }
}
