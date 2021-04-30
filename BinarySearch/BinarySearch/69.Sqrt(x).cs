using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    public static class Sqrt
    {
        public static int MySqrt(int x)
        {
            if (x == 0 || x == 1) return x;
            long l = 0, h = (x) / 2 + 1, mid, current;
            while (l <= h)
            {
                mid = l + (h - l) / 2;
                current = mid * mid;
                if (current == x) return (int)mid;
                else if (current > x && ((mid - 1) * (mid - 1)) < x) return (int)mid - 1;
                else if (current < x) { l = mid + 1; }
                else h = mid - 1;
            }
            return -1;
        }
    }
}
