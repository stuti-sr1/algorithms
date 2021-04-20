using System;
using System.Collections.Generic;

namespace KMPSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            //string pat = "ABABDABACDABABCABAB";
            //string pat = "abcabcabcabc";
            string pat = "babbabbabbabbab";
            //string pat = "ABABCABAB";
            Console.WriteLine(KMPSearch(pat));
            Console.ReadKey();
        }

        private static bool KMPSearch(string str)
        {
            int[] prefix = ComputeLPSArray(str);
            int len = prefix[str.Length - 1];
            int n = str.Length;
            return (len > 0 && n % (n - len) == 0);
        }

        private static int[] ComputeLPSArray(string pat)
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
