using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public static class _206ReverseLinkedList
    {
        public static ListNode ReverseList(ListNode head)
        {
            if (head == null || head.next == null) return head;
            ListNode prev = null;
            ListNode current = head;
            return Recur(current, prev);
        }

        private static ListNode Recur(ListNode current, ListNode prev)
        {
            if (current == null) return prev;
            ListNode t = current.next;
            current.next = prev;
            return Recur(t, current);
        }

        //iterative
        public static ListNode ReverseList2(ListNode head)
        {
            ListNode prev = null;
            ListNode temp ;
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

        //temp or t is required for tail recursion
        public static ListNode ReverseList1(ListNode head)
        {
            if (head == null || head.next == null) return head;
            ListNode temp = ReverseList1(head.next);
            head.next.next = head;
            head.next = null;
            return temp;
        }
    }
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
}
