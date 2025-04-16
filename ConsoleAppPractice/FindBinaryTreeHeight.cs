using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public  class FindBinaryTreeHeight
    {
        public class TreeNode
        {
            public int Val { get; set; }
            public TreeNode Left { get; set; }
            public TreeNode Right { get; set; }

            public TreeNode(int val)
            {
                Val = val;
            }
        }

        public static int FindHeight(TreeNode root)
        {

            if (root == null)
            {
                return 0;
            }
            else
            {
                int leftHeight = FindHeight(root.Left);
                int rightHeight = FindHeight(root.Right);

                return 1 + int.Max(leftHeight, rightHeight);
            }
        }
    }
}
