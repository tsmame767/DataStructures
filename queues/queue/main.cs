using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace queue
{
    public class main
    {
        static void Main()
        {
            queueopps<int> queue = new queueopps<int>(6);

            queue.enqueue(10);
            queue.enqueue(20);
            queue.enqueue(30);
            queue.enqueue(40);
            queue.enqueue(50);
            queue.enqueue(60);
            //queue.enqueue(70);

            queue.peek();
            queue.printQ();

            queue.dequeue();
            queue.peek();
            queue.printQ();

            queue.dequeue();
            queue.printQ();

            queue.dequeue();
            queue.printQ();

            queue.dequeue();
            queue.printQ();

            queue.dequeue();
            queue.printQ();

            queue.dequeue();
            queue.printQ();



            queue.peek();
            queue.enqueue(60);
            queue.printQ();


        }
    }
}
