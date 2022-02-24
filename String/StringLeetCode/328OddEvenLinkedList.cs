using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringLeetCode
{
    public static class _328OddEvenLinkedList
    {
        public static ListNode OddEvenList(ListNode head)
        {
            if (head == null) return head;

            ListNode odd = head;
            ListNode even = head.next;
            ListNode evenhead = even;
            while (even != null && even.next != null)
            {
                odd.next = even.next;
                odd = odd.next;
                even.next = odd.next;
                even = even.next;  
            }
            odd.next = evenhead;
            return head;
        }
        public static ListNode OddEvenList1(ListNode head)
        {
            ListNode current = head;

            ListNode oddhead = current;
            if (current == null) return head;
            current = current.next;
            ListNode evenhead = current;
            ListNode evenstart = current;
            if (current == null) return head;
            current = current.next;
            int count = 1;
            while (current != null)
            {
                if (count % 2 == 1)
                {
                    oddhead.next = current;
                    oddhead = oddhead.next;
                }
                else
                {
                    evenhead.next = current;
                    evenhead = evenhead.next;
                }
                current = current.next;
                count++;
            }
            evenhead.next = null;
            oddhead.next = evenstart;
            return head;
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
