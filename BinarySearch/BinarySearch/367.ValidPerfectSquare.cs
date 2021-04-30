using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    public static class ValidPerfectSquare
    {
        public static bool IsPerfectSquare(int num)
        {
            if (num == 0 || num == 1) return true;
            long l = 0, h = (num) / 2 + 1, mid, current;
            while (l <= h)
            {
                mid = l + (h - l) / 2;
                current = mid * mid;
                if (current == num) return true;
                else if (current < num) { l = mid + 1; }
                else h = mid - 1;
            }
            return false;
        }
    }
}
