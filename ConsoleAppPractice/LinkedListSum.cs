using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class LinkedListSum
    {
        // Change these Boolean values to control whether you see 
        // the expected result and/or hints.
        public static Boolean ShowExpectedResult = false;
        public static Boolean ShowHints = false;

        public class ListNode
        {
            public int val;
            public ListNode next;

            public ListNode(int val)
            {
                this.val = val;
                this.next = null;
            }

            public override string ToString()
            {
                return val.ToString();
            }
        }

        // Return the sum of the contents in the linked list
        public static int Sum(ListNode head)
        {
            ListNode listNode = head;
            int sum = 0;
         
            while (head != null)
            {
                sum += head.val;
                head = head.next;
            }

            return sum;
        }

    }

}
