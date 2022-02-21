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
            Console.ReadKey();
        }
    }
}
