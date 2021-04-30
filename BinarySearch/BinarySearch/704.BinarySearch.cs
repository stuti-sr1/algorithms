using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    public static class _704
    {
        public static int Search(int[] nums, int target)
        {
            int l = 0, h = nums.Length - 1, mid = -1;
            while(l<=h)
            {
                mid = l + (h - l) / 2;
                if (nums[mid] == target) return mid;
                else if (nums[mid] > target) h = mid - 1;
                else l = mid + 1;
            }
            return -1;
        }
    }
}
