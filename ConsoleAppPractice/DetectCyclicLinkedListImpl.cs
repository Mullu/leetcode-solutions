using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class DetectCyclicLinkedListImpl
    {
        // Change these Boolean values to control whether you see 
        // the expected result and/or hints.
        public static Boolean ShowExpectedResult = false;
        public static Boolean ShowHints = false;

        public class ListNode
        {
            public int Val;
            public ListNode Next;

            public ListNode(int val)
            {
                this.Val = val;
                this.Next = null;
            }
        }

        // Return true or false depending on if there's a 
        // cycle in the Linked List 
        public static bool HasCycle(ListNode head)
        {
            var nodes = new HashSet<ListNode>();
            ListNode current = head;

            while (current != null)
            {
                if (nodes.Contains(current))
                {
                    return true;
                }
                else
                {
                    nodes.Add(current);
                }
            }

            return false;
        }
    }
}
