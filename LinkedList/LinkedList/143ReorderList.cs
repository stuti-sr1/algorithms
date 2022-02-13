using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public static class _143ReorderList
    {
        public static void ReorderList(ListNode head)
        {
            if (head == null) return;
            ListNode fast = head;
            ListNode slow = head;
            while (fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast?.next?.next;
            }

            ListNode b = ReverseList(slow);
            ListNode a = head;
            while (b.next != null)
            {
                ListNode t1 = a.next;
                ListNode t2 = b.next;
                a.next = b;
                b.next = t1;
                a = t1;
                b = t2;
            }
            return;
        }

        private static ListNode ReverseList(ListNode head)
        {
            ListNode prev = null;
            ListNode temp;
            ListNode current = head;
            while (current != null)
            {
                temp = current.next;
                current.next = prev;
                prev = current;
                current = temp;
            }
            return prev;
        }
    }
}
