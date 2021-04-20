using System;
using System.Text;

namespace patternMatching
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(RepeatedStringMatch("abcd", "cdabcdab"));
        }
        public static int RepeatedStringMatch(string A, string B)
        {
            int q = 1;
            StringBuilder S = new StringBuilder(A);
            for (q = 1; S.Length < B.Length; q++)
            {
                S.Append(A);
            }
            if (S.ToString().IndexOf(B) >= 0) return q;
            if (S.Append(A).ToString().IndexOf(B) >= 0) return q + 1;
            return -1;
        }
    }
}
