using System;

namespace KMPSearchPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] txt = "ABABDABACDABABCABAB".ToCharArray();
            string pat = "ABABCABAB";
            KMPSearch(pat, txt);
            Console.ReadKey();
        }

        private static void KMPSearch(string pat, char[] txt)
        {
            int[] prefix = ComputeLPSArray(pat.ToString());
            int M = pat.Length;
            int N = txt.Length;
            int i = 0, j = 0;
            while (i < N)
            {
                if (pat[j] == txt[j])
                {
                    i++;
                    j++;
                }
                if (j == M)
                {
                    Console.Write("Found pattern at index" + (i - j));
                    return;
                }
                else if (i < N && pat[j] != txt[i])
                {
                    if (j != 0)
                    {
                        j = prefix[j - 1];
                    }
                    else i++;
                }
            }
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
