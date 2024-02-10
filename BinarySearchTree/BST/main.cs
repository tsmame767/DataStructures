using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BST
{
    public class main
    {
        static void Main()
        {
            BST<int> BST1 = new BST<int>();

            BST1.insert(5);
            BST1.insert(3);
            BST1.insert(2);
            BST1.insert(4);
            BST1.insert(10);
            BST1.insert(7);
            BST1.insert(20);

            List<int>newlist=BST1.Inorder(BST1.root);

            foreach(int i in newlist)
            {
                Console.WriteLine(i);
            }

            //Console.WriteLine($"{BST1.root.Data}-> { BST1.root.right.Data}-> {BST1.root.left.Data}-> {BST1.root.right.Data}-> {BST1.root.right.right.Data}-> {BST1.root.right.left.Data}");
        }
    }
}
