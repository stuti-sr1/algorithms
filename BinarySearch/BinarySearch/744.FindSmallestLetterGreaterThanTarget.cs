using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    public static class FindSmallestLetterGreaterThanTarget
    {
        public static char NextGreatestLetter(char[] letters, char target)
        {
            int l = 0, mid, h = letters.Length - 1, n = letters.Length;
            while (l <= h)
            {
                mid = l + (h - l) / 2;
                if (letters[mid] <= target) l = mid + 1;
                else h = mid - 1;
            }
            return letters[l];
        }
        //public static char NextGreatestLetter(char[] letters, char target)
        //{
        //    int l = 0, mid, h = letters.Length - 1;
        //    if (letters[l] > target || letters[h] >= target) return letters[l];
        //    while (l <= h)
        //    {
        //        mid = l + (h - l) / 2;
        //        if (letters[mid] == target) return letters[mid + 1];
        //        else if (letters[mid] > target)
        //        {
        //            if (letters[mid + 1] < target) return letters[mid + 1];
        //            else l = mid + 1;

        //        }
        //        else h = mid - 1;
        //    }
        //    return letters[0];
        //}
    }
}
