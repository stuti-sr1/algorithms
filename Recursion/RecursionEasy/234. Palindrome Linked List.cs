using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursionEasy
{
    public static class PalindromeLinkedList
    {
        public static bool IsPalindrome(ListNode head)
        {
            if (head == null || head.next == null) return true;
            ListNode slow = head;
            ListNode fast = head;
            while (!(fast == null || fast.next == null ))
            {
                slow = slow.next;
                fast = fast.next.next;             
            }
            ListNode newHead = Reverse_Linked_List1(slow);
            while (newHead != null)
            {
                if (head.val == newHead.val)
                {
                    head = head.next;
                    newHead = newHead.next;
                }
                else return false;
            }
            return true;
        }
        private static ListNode Reverse_Linked_List1(ListNode head)
        {
            if (head == null || head.next == null) return head;
            ListNode temp = Reverse_Linked_List1(head.next);
            head.next.next = head;
            head.next = null;
            return temp;
        }
    }
}
