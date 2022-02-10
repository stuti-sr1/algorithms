using Lucene.Net.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public static class _23MergekSortedLists
    {
        // approach 1
        public static ListNode MergeKLists(ListNode[] lists)
        {
            if (lists == null || lists.Length < 1) return null; 
            return MergeAllLists(lists, 0, lists.Length - 1);
        }
        private static ListNode MergeAllLists(ListNode[] lists, int start, int end)
        {
            if (start == end) return lists[start];
            int mid = start + (end - start) / 2;
            ListNode left = MergeAllLists(lists, start, mid);
            ListNode right = MergeAllLists(lists, mid + 1, end);
            return MergeTwoLists(left, right);
        }

        // approach 2
        public static ListNode MergeKLists1(ListNode[] lists)
        {
            ListNode res = lists[0];
            for (int i = 1; i < lists.Length; i++)
            {
                res = MergeTwoLists(res, lists[i]);
            }
            return res;
        }

        private static ListNode MergeTwoLists(ListNode l1, ListNode l2)
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
