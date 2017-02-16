using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class BinaryTree
    {
        Node root;
        int count = 0;
        public BinaryTree()
        {
            root = null;
        }
        public void AddNode(int number)
        {
            if (root == null)
            {
                root = new Node(number);
            }
            else
            {
                root.InsertNode(ref root, number);
            }
            count++;
        }
        public void Display()
        {
            root.TakeInNumber(root);
        }
    }
}
