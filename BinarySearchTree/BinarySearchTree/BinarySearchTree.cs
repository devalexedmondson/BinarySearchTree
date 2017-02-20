using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class BinarySearchTree
    {
        Node root;
        int count = 0;
        public BinarySearchTree()
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
        public bool search(Node node, int data)
        {
            if (node == null)
            {
                return false;
            }
            if (node.number == data)
            {
                return true;
            }
            else if (node.number < data)
            {
                return search(node.leftBranch, data);
            }
            else if (node.number > data)
            {
                return search(node.rightBranch, data);
            }
            return false;
        }
    }
}
