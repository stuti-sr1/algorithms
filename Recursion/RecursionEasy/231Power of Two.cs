using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursionEasy
{
    public static class Power_of_Two
    {
        public static bool IsPowerOfTwo(int n)
        {
            if (n == 0) return false;
            else return (CheckPowerOfTwo(n) == 1);
        }
        public static int CheckPowerOfTwo(int n)
        {
            if (n == 1) return 1;
            else if (n % 2 == 0) return CheckPowerOfTwo(n / 2);
            else return -1;
        }
    }
}
