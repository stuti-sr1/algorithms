using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursionEasy
{
    public static class Merge_Two_Sorted_Lists
    {
        public static ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            if (l1 == null && l2 == null) return null;
            else if (l1 == null) return l2;
            else if (l2 == null) return l1;
            ListNode temp = null;
            ListNode head = null;
            if (l1.val > l2.val)
            {
                head = l2;
                l2 = l2.next;
            }
            else
            {
                head = l1;
                l1 = l1.next;
            }
            temp = head;
            while (l1 != null && l2 != null)
            {
                if (l1.val > l2.val)
                {
                    temp.next = l2;
                    temp = temp.next;
                    l2 = l2.next;
                }
                else
                {
                    temp.next = l1;
                    temp = temp.next;
                    l1 = l1.next;
                }
            }
            if (l1 == null)
            {
                temp.next = l2;
            }
            else
            {
                temp.next = l1;
            }
            return head;
        }        
    }
}
