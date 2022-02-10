using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public static class _19RemoveNthNodeFromEndofList
    {
        //one pass
        public static ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            ListNode dummy = new ListNode(-1);
            dummy.next = head;
            int count = 0;
            ListNode first = dummy;
            ListNode second = dummy;
            while (count <= n)
            {
                count++;
                first = first.next;
            }

            while (first != null)
            {
                first = first.next;
                second = second.next;
            }
            second.next = second.next.next;
            return dummy.next;
        }

        //twopass
        public static ListNode RemoveNthFromEnd1(ListNode head, int n)
        {
            ListNode dummy = new ListNode(-1);
            dummy.next = head;
            int count = 0;
            ListNode current = head;
            while (current != null)
            {
                count++;
                current = current.next;
            }
            count -= n;
            current = dummy;
            while (count > 0)
            {
                count--;
                current = current.next;
            }
            current.next = current.next.next;
            return dummy.next;
        }
    }
}
