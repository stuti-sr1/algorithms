using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayCollection
{
    public static class _153FindMinimuminRotatedSortedArray
    {
        public static int FindMin(int[] nums)
        {
            int l = 0;
            int h = nums.Length - 1;
            if (nums[l] < nums[h]) return nums[l];
            int mid;
            while (l < h)
            {
                mid = (h + l) / 2;
                if (nums[mid] > nums[mid + 1]) return nums[mid + 1];
                else if (nums[mid - 1] > nums[mid]) return nums[mid];
                else if (nums[mid] < nums[l]) h = mid - 1;
                else if (nums[mid] > nums[h]) l = mid + 1;
            }
            return nums[l];
        }
    }
}
