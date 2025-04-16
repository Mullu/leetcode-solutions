using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class BinaryTreeTransverseImpl
    {
        public static void PreOrderTransversal(Node root)
        {
            if (root == null) return;

            Console.Write(root.Data + " ");

            PreOrderTransversal(root.Left);
            PreOrderTransversal(root.Right);
        }
    }
}
