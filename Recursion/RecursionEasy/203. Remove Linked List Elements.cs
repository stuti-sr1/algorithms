using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursionEasy
{
    public static class RemoveLinkedListElements
    {
        public static ListNode RemoveElements(ListNode head, int val)
        {
            if (head == null) return head;
            ListNode currentHead = head;
            ListNode newHead = head;
            head = head.next;
            while (head != null)
            {
                if (head.val == val) 
                    currentHead.next = head.next;
                else 
                    currentHead = head;
                head = head.next;
            }
            if (newHead != null && newHead.val == val)
            {
                newHead = newHead.next;
            }
            return newHead;
        }
    }
}
