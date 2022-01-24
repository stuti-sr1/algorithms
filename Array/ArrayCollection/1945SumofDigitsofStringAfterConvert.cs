using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayCollection
{
    public static class _1945SumofDigitsofStringAfterConvert
    {
        public static int GetLucky(string s, int k)
        {
            int sum = 0;
            int n;
            for (int i = 0; i < s.Length; i++)
            {
                n= s[i] - 'a' + 1;
                sum += getSum(n);
            }
            for (int i = 0; i < k-1; i++)
            {
                sum = getSum(sum);
            }
            return sum;
        }

        private static int getSum(int n)
        {
            int r = 0;
            while (n > 0)
            {
                r += n % 10;
                n /= 10;
            }
            return r;
        }
    }
}
