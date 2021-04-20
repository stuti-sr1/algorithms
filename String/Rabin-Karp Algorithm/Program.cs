using System;
using System.Collections.Generic;

namespace Rabin_Karp_Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            String txt = "GEEKS FOR GEEKS";
            String pat = "GEEK";
            int q = 101; //prime number
            Console.WriteLine(search(pat, txt, q));
            Console.ReadKey();
        }

        private static bool search(string pat, string txt, int q)
        {
            int hashcodePat = HashCodeRabin_Karp(pat, q);
            int lenPat = pat.Length;
            int lenTxt = txt.Length;
            if (lenPat > lenTxt) return false;
            for (int i = 0; i < lenTxt - lenPat; i++)
            {
                int hashcodeTxt = HashCodeRabin_Karp(txt.Substring(i, lenPat), q);
                if (hashcodePat == hashcodeTxt)
                {
                    bool flag = false;
                    for (int j = i; j < lenPat; j++)
                    {
                        if (pat[j - i] != txt[j]) return false;
                        else flag = true;
                    }
                    if (flag)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private static int HashCodeRabin_Karp(string pat, int q)
        {
            double res = 0;
            int code = 0;
            for (int i = 0; i < pat.Length; i++)
            {
                code =Convert.ToInt32(pat[i]);
                res += code * Math.Pow(q, i);
            }
            return Convert.ToInt32(res);
        }
    }
}
