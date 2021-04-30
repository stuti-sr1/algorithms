using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    public static class ArrangingCoins
    {    
        //O(logN)
        public static int ArrangeCoins(int n)
        {
            long l = 0, h = n, mid;
            long current;
            while (l <= h)
            {
                mid = l + (h - l) / 2;
                current = mid * (mid + 1) / 2;
                if (current == n)
                {
                    return (int)mid;
                }
                else if (current > n) h = mid - 1;
                else l = mid + 1;
            }
            return (int)h;
        }

        //O(N)
        //public static int ArrangeCoins(int n)
        //{
        //    for (int i = 1; i <= n/2; i++)
        //    {
        //        int current = i * (i + 1) / 2;
        //        if (current == n) return i;
        //        else if (current > n) return i - 1;
        //    }
        //    return -1;
        //}
    }
}