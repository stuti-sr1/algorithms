using System;

namespace _1170._Compare_Strings_by_Frequency_of_the_Smallest_Character
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] queries = { "bba", "abaaaaaa", "aaaaaa", "bbabbabaab", "aba", "aa", "baab", "bbbbbb", "aab", "bbabbaabb" }, 
                words = { "aaabbb", "aab", "babbab", "babbbb", "b", "bbbbbbbbab", "a", "bbbbbbbbbb", "baaabbaab", "aa" };
            //string[] queries = { "bbb", "cc" }, words = { "a", "aa", "aaa", "aaaa" };
            Console.WriteLine(NumSmallerByFrequency(queries, words));
            Console.ReadKey();
        }
        public static int[] NumSmallerByFrequency(string[] queries, string[] words)
        {
            int[] fCount = new int[11];

            foreach (string word in words)
            {
                int count = getFCount(word);
                fCount[count]++;
            }

            int sum = 0;
            for (int i = 0; i < fCount.Length; i++)
            {
                sum += fCount[i];
                fCount[i] = sum;
            }
            int[] res = new int[queries.Length];
            for (int i = 0; i < queries.Length; i++)
            {
                int count = getFCount(queries[i]);
                res[i] = fCount[fCount.Length - 1] - fCount[count];
            }
            return res;
        }

        private static int getFCount(string word)
        {
            int[] count = new int[26];
            foreach (char item in word)
            {
                count[item - 'a']++;
            }
            for (int i = 0; i < count.Length; i++)
            {
                if (count[i] != 0)
                {
                    return count[i];
                }
            }
            return 0;
        }
    }
}
