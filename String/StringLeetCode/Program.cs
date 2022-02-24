using System;

namespace StringLeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            string v = _345ReverseVowelsofaString.ReverseVowels("leetcode");
            Console.WriteLine("Hello World!");

            string[] strs = { "eat", "tea", "tan", "ate", "nat", "bat" };
            var t = _49GroupAnagrams.GroupAnagrams(strs);

            var s = _438FindAllAnagramsinaString.FindAnagrams("abab", "ab");

            var t1 = _567PermutationinString.CheckInclusion("ab", "eidboaooo");


            // 1,2,3,4,5
            ListNode listNode = new ListNode(1);
            listNode.next = new ListNode(2);
            listNode.next.next = new ListNode(3);
            listNode.next.next.next = new ListNode(4);
            listNode.next.next.next.next = new ListNode(5);

            _328OddEvenLinkedList.OddEvenList(null);
            Console.ReadKey();
        }
    }
}
