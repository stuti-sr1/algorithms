using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayCollection
{
    public static class _202HappyNumber
    {
        //space(log n)
        //time(log n)
        public static bool IsHappy(int n)
        {            
            HashSet<int> map = new HashSet<int>();
            while (n != 1 && !map.Contains(n))
            {
                map.Add(n);
                n = getSum(n);
            }
            if (map.Contains(n)) return false;
            if (n == 1) return true;
            else return false;
        }

        private static int getSum(int n)
        {
            int sum = 0;
            int r;
            while (n>0)
            {
                r = n % 10;
                sum += r * r;
                n /= 10;
            }
            return sum;
        }
    }
}
