using System;

namespace RecursionEasy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Tribonacci.TribonacciFun(25));

            TreeNode root = new TreeNode(10);
            root.left = new TreeNode(5);
            root.left.left = new TreeNode(3);
            root.left.right = new TreeNode(7);
            root.right = new TreeNode(15);
            root.right.right = new TreeNode(18);
            Console.WriteLine(sum_of_nodes_L_R.RangeSumBST(root, 7, 15));

            Console.WriteLine(Power_of_Two.IsPowerOfTwo(1));
            Console.WriteLine(Power_of_Three.IsPowerOfThree(45));
            Console.WriteLine(Power_of_Four.IsPowerOfFour(16));

            ListNode head = new ListNode(1);
            head.next = new ListNode(2);
            head.next.next = new ListNode(3);
            head.next.next.next = new ListNode(4);
            head.next.next.next.next = new ListNode(5);
            Console.WriteLine(Reverse_Linked_List.ReverseList(head));

            ListNode l1 = new ListNode(1);
            l1.next = new ListNode(3);
            l1.next.next = new ListNode(5);

            ListNode l2 = new ListNode(2);
            l2.next = new ListNode(4);
            l2.next.next = new ListNode(6);
            Console.WriteLine(Merge_Two_Sorted_Lists.MergeTwoLists(l1,l2));

            Console.ReadKey();
        }
    }
}
