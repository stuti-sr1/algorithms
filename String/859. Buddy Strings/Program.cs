using System;
using System.Collections.Generic;
using System.Linq;

namespace _859._Buddy_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(BuddyStrings("abab","abab"));
            Console.ReadKey();
        }
        public static bool BuddyStrings(string A, string B)
        {
            int lenA = A.Length;
            int lenB = B.Length;
            if (lenA != lenB || lenA == 0 || lenB == 0) return false;
            if (A.Equals(B))
            {
                int[] counter = new int[26];
                for (int i = 0; i < lenA; ++i)
                    counter[A[i] - 'a']++;

                foreach (int c in counter)
                    if (c > 1) return true;
                return false;
            }
            int count = 0;
            List<char> listA = new List<char>();
            List<char> listB = new List<char>();
            for (int i = 0; i < lenA; i++)
            {
                if (A[i] != B[i])
                {
                    count++;
                    listA.Add(A[i]);
                    listB.Add(B[i]);
                }
            }
            if (count != 2)
            {
                return false;
            }
            else
            {
                var t1 = listA.Except(listB);
                var t2 = listB.Except(listA);
                return !t1.Any() && !t2.Any();
            }
        }
    }
}
