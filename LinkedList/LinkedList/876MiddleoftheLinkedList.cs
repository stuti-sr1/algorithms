using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public static class _876MiddleoftheLinkedList
    {
        public static ListNode MiddleNode(ListNode head)
        {
            ListNode fast = head;
            ListNode slow = head;
            while (fast != null && fast.next != null)
            {
                fast = fast?.next?.next;
                slow = slow.next;
            }
            return slow;
        }
    }
}
