using System;
using System.Collections.Generic;

namespace _696._Count_Binary_Substrings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CountBinarySubstrings("00110011"));
            Console.ReadKey();
        }
        public static int CountBinarySubstrings(string s)
        {
            int curr = 1, prev = 0;
            int res = 0;
            for (int i = 1; i < s.Length; i++)
            {
                if (s[i - 1] != s[i])
                {
                    res += Math.Min(prev, curr);
                    prev = curr;
                    curr = 1;                    
                }
                else
                {
                    curr++;
                }
            }
            return res + Math.Min(prev, curr);
        }
        public static int CountBinarySubstrings1(string s)
        {
            List<int> grp = new List<int>();
            int t = 0;
            grp[t] = 1;
            for (int i = 1; i < s.Length; i++)
            {
                if (s[i - 1] != s[i])
                {
                    grp[++t] = 1;
                }
                else
                {
                    grp[t]++;
                }
            }
            int res = 0;
            for (int i = 1; i < grp.Count; i++)
            {
                res += Math.Min(grp[i - 1], grp[i]);
            }
            return res;
        }
    }
}
