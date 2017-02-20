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
        {
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
