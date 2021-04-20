using System;

namespace Greedy
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "RLRRLLRLRL";
            s = "RLLLLRRRLR";
            s = "LLLLRRRR";
            int ans = BalancedStringSplit(s);
            Console.WriteLine(ans);
            Console.ReadKey();
        }
        public static int BalancedStringSplit(string s)
        {
            int count = 0, l = 0, r = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == 'L')
                {
                    l++;
                }
                else if (s[i] == 'R')
                {
                    r++;
                }
                if (l == r)
                {
                    count++;
                    l = 0;
                    r = 0;
                }
            }
            return count;
        }
    }
}
