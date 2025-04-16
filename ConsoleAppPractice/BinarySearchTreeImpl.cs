using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class Node
    {
        public Node Left { get; set; }
        public Node Right { get; set; }
        public int Data {  get; set; }
    }
     class BinarySearchTreeImpl
    {
        public static Node Insert(Node root, int value)
        {
            if (root == null)
            {
                root = new Node();
                root.Data = value;
            }

            if (value < root.Data)
            {
                root.Left = Insert(root.Left, value);
            }
            else
            {
                root.Right = Insert(root.Right, value);
            }

            return root;
        }
    }
}
