using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public static class _21MergeTwoSortedLists
    {
        public static ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            ListNode head = new ListNode(-1);
            ListNode prehead = head;
            while (l1 != null && l2 != null)
            {
                if (l1.val <= l2.val)
                {
                    prehead.next = l1;
                    l1 = l1.next;
                }
                else
                {
                    prehead.next = l2;
                    l2 = l2.next;
                }
                prehead = prehead.next;
            }
            prehead.next = l1 == null ? l2 : l1;
            return head.next;
        }
    }
}
