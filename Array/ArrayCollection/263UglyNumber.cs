using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayCollection
{
    public static class _263UglyNumber
    {
        //2, 3, and 5.
        
        public static bool IsUgly(int n)
        {
            if (n <= 0)
                return false;
            if (n == 1)
                return true;
            while (n % 2 == 0) n = n / 2;
            while (n % 3 == 0) n = n / 3;
            while (n % 5 == 0) n = n / 5;
            return n == 1;
        }
        public static bool IsUgly1(int n)
        {
            while (n % 2 == 0)
            {
                n /= 2;
            }
            int i = 3;
            while (n > 1)
            {
                if (i > 5) break;
                while (n % i == 0) n /= i;

                i += 2;
            }
            if (n > 2) return false;
            return true;
        }

    }
}
