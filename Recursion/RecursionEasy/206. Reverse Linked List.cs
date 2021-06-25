using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursionEasy
{
    public static class Reverse_Linked_List
    {
        public static ListNode ReverseList(ListNode head)
        {
            if (head == null || head.next == null) return head;
            ListNode temp = ReverseList(head.next);
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
