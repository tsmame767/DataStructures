using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BST
{
    public class BST<T> where T : IComparable<T>
    {

        public node<T> root;

        public BST() 
        {
            root = null;        
        }

        public void insert(T data)
        {

            node<T> newnode = new node<T>(data);
            if (root == null)
            {
                root = newnode;
                return;
            }

            node<T> temp = root;

            while (true)
            {
                if (data.CompareTo(temp.Data) < 0)
                {
                    if (temp.left == null)
                    {
                        temp.left = newnode;
                        return;
                    }
                    temp = temp.left;

                }
                else if (data.CompareTo(temp.Data) > 0)
                {

                    if (temp.right == null)
                    {
                        temp.right=newnode;
                        return;
                    }
                    temp = temp.right;
                    
                }
                else
                {
                    Console.WriteLine("data exists");
                }
            }
            
        }

        public void preorder()
        {


        }

        public void postorder()
        {


        }

        public List<T> Inorder(node<T> root1)
        {/*
            if (root == null)
            {
                return;
            }
            Inorder(root.left);
            Console.Write(root.Data + "->");
            Inorder(root.right);
            */

            List<T> result = new List<T>();
            Stack<node<T>> stack = new Stack<node<T>>();

            while (root != null || stack.Count > 0)
            {
                // Traverse left subtree until reaching the leftmost node
                while (root != null)
                {
                    stack.Push(root);
                    root = root.left;
                }

                // Process the current node
                node<T> current = stack.Pop();
                result.Add(current.Data);

                // Move to the right subtree
                root = current.right;
            }

            return result;
        }
    }
}
