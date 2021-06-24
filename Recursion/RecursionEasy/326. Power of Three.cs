using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursionEasy
{
    public static class Power_of_Three
    {
        public static bool IsPowerOfThree(int n)
        {
            if (n <= 0) return false;
            else return (CheckSum(n, 0) == 1);
            //else return CheckSum1(n);
        }

        private static int CheckSum(int n, int count)
        {
            double value = Math.Pow(3, count);
            if (value == n) return 1;
            else if (value > n) return -1;
            else return CheckSum(n, ++count);
        }
        //private static bool CheckSum1(int n)
        //{
        //    if (n == 1) return true;
        //    else if (n % 3 == 0) return CheckSum1(n / 3);
        //    return false;
        //}
    }
}
