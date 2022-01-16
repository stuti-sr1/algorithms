using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayCollection
{
    public static class _154FindMinimuminRotatedSortedArrayII
    {
        public static int FindMin(int[] nums)
        {
            int l = 0;
            int h = nums.Length - 1;
            int mid;
            while (l < h)
            {
                mid = (h + l) / 2;
                if (nums[l] > nums[mid])
                {
                    l++;
                    h = mid;
                }
                else if (nums[h] < nums[mid]) l = mid + 1;
                else h--;
            }
            return nums[l];
        }
    }
}
