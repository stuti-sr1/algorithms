using System;
using System.Collections.Generic;

namespace _647._Palindromic_Substrings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CountSubstrings("aabaa"));
            Console.ReadKey();
        }
        public static int CountSubstrings(string s)
        {
            List<string> res = new List<string>();
            CountSubstringsDP(res, s);
            return count;
            //return res.Count;
        }
        static int count = 0;
        private static void CountSubstringsDP(List<string> res, string cur)
        {
            int len = cur.Length;
            for (int i = 0; i < len-1; i++)
            {
                IsPalindrome(cur, i, i);
                IsPalindrome(cur, i, i + 1);
            }
        }

        public static void IsPalindrome(string s, int i, int j)
        {
            while (i >= 0 && j < s.Length && s[i] == s[j])
            {    //Check for the palindrome string 
                count++;    //Increment the count if palindromin substring found
                i--;    //To trace string in left direction
                j++;    //To trace string in right direction
            }
        }
    }
}
