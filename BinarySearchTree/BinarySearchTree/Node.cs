using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Node
    {
        public int number;
        public Node rightBranch;
        public Node leftBranch;

        public Node(int number)
        {
            this.number = number;
            rightBranch = default(Node);
            leftBranch = default(Node);
        }
        public void InsertNode(ref Node root, int input)
        {//any time you add a node you set it as a branch of the last node
            if (root == null)
            {
                root = new Node(input);
            }
            else if (root.number > input)
            {
                InsertNode(ref root.leftBranch, input);
            }
            else if (root.number < input)
            {
                InsertNode(ref root.rightBranch, input);
            }
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
        public void TakeInNumber(Node node)
        {
            if (node == null)
                return;
            TakeInNumber(node.leftBranch);
            TakeInNumber(node.rightBranch);
            Console.WriteLine(" " + node.number);
            
        }
    }
}
