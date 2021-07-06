using System;

namespace RecursionMedium
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 5, k = 2;
            Console.WriteLine(FindtheWinneroftheCircularGame.FindTheWinner(n,k));

            ListNode l1 = new ListNode(2);
            l1.next = new ListNode(4);
            l1.next.next = new ListNode(3);
            ListNode l2 = new ListNode(5);
            l2.next = new ListNode(6);
            l2.next.next = new ListNode(4);
            Console.WriteLine(_2AddTwoNumbers.AddTwoNumber(l1, l2));

            Console.ReadKey();
        }
    }
}
