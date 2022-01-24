using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayCollection
{
    public static class _141LinkedListCycle
    {
        public static bool HasCycle(ListNode head)
        {
            var slow = head;
            var fast = head?.next;
            while (slow != null && fast != null)
            {
                if (slow == fast)
                    return true;

                slow = slow.next;
                fast = fast.next?.next;
            }
            return false;
        }
    }

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x)
        {
            val = x;
            next = null;
        }
    }
}
