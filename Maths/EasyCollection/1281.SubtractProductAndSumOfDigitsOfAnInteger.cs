using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCollection
{
    public static class SubtractProductAndSumOfDigitsOfAnInteger
    {
        public static int SubtractProductAndSum(int n)
        {
            int r = 0;
            if (n == 0)
            {
                return 0;
            }
            int sum = 0;
            int prod = 1;
            while (n > 0)
            {
                r = n % 10;
                sum += r;
                prod *= r;
                n = n / 10;
            }
            return prod - sum;
        }
    }
}
