using System;

namespace _14._Longest_Common_Prefix
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strs = { "flower", "flow", "flight" };
            Console.WriteLine(LongestCommonPrefix(strs));
        }
        public static string LongestCommonPrefix(string[] strs)
        {
            for (int i = 1; i < strs.Length; i++)
            {
                int[] prefix = ComputeLPSArray(strs[i-1],strs[i]);
            }

        }
        private static int[] ComputeLPSArray(string pat,string txt)
        {
            int M = pat.Length;
            int[] lps = new int[M];
            int j = 0, i = 1;
            lps[0] = 0;
            while (i < M && j < M)
            {
                if (pat[j] == pat[i])
                {
                    lps[i] = j + 1;
                    i++;
                    j++;
                }
                else
                {
                    if (j != 0)
                    {
                        j = lps[j - 1];
                    }
                    else
                    {
                        lps[i] = 0;
                        i++;
                    }
                }
            }
            return lps;
        }
    }
}
