using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursionEasy
{
    public static class Power_of_Four
    {
        public static bool IsPowerOfFour(int n)
        {
            if (n <= 0) return false;
            else return CheckSum(n);
        }

        private static bool CheckSum(int n)
        {
            while (n % 4 == 0)
            {
                n = n / 4;
            }
            return n == 1;
        }
    }
}
