using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree tree = new BinarySearchTree();

            tree.AddNode(10);
            tree.AddNode(8);
            tree.AddNode(3);
            tree.AddNode(7);
            tree.AddNode(1);
            tree.AddNode(4);
            tree.AddNode(5);
            tree.AddNode(2);
            tree.AddNode(9);
            tree.AddNode(6);

            tree.Display();
            Console.ReadLine();
        }
    }
}
