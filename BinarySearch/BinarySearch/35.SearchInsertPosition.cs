using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    public static class SearchInsertPosition
    {
        public static int SearchInsert(int[] nums, int target)
        {
            int len = nums.Length, l = 0, h = len - 1, mid;
            while (l <= h)
            {
                mid = l + (h - l) / 2;
                if (nums[mid] == target)
                {
                    return mid;
                }
                else if (nums[mid] > target) h = mid - 1;
                else l = mid + 1;
            }
            return l;
        }
    }
}
