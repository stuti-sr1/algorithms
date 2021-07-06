using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursionMedium
{
    public static class FindtheWinneroftheCircularGame
    {
        public static int FindTheWinner(int n, int k)
        {
            ListNode list = new ListNode(1);
            ListNode head = list;
            for (int i = 2; i <= n; i++)
            {
                list.next = new ListNode(i);
                list = list.next;
            }
            list.next = head;
            ListNode prev = list;
            return ReturnWinner(head, k, prev);
        }

        private static int ReturnWinner(ListNode head, int k,ListNode prev)
        {
            while (prev != head)
            {
                int count = 0;
                while (count < k-1)
                {
                    prev = head;
                    head = head.next;
                    count++;
                }
                if (head != null && prev != head)
                {
                    prev.next = head.next;
                    head = head.next;
                }
            }
            return head.value;
        }
    }
    public class ListNode
    {
        public int value { get; set; }
        public ListNode next { get; set; }
        public ListNode(int value = 0, ListNode node = null)
        {
            this.value = value;
            this.next = node;
        }
    }
}
