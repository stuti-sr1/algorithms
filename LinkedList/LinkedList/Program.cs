using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            ListNode node = new ListNode(1);
            node.next = new ListNode(2);
            node.next.next = new ListNode(3);
            node.next.next.next = new ListNode(4);
            node.next.next.next.next = new ListNode(5);
            node.next.next.next.next.next = new ListNode(6);

             _19RemoveNthNodeFromEndofList.RemoveNthFromEnd(node,1);

            _143ReorderList.ReorderList(node);

            int[] nums = { 0, 1, 1, 0, 1, 2, 1, 2, 0, 0, 0, 1 };
            _75SortColors.SortColors(nums);
        }
    }
}
