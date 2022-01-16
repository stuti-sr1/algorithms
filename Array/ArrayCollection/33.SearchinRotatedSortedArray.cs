using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayCollection
{
    public static class SearchinRotatedSortedArray
    {
        public static int Search(int[] nums, int target)
        {
            int l = 0;
            int h = nums.Length - 1;
            if (nums[l] == target) return l;
            else if (nums[h] == target) return h;
            int mid;
            while (l < h)
            {
                mid = l + (h - l) / 2;
                if (nums[mid] == target) return mid;
                else if (nums[l] <= nums[mid])
                {
                    if (nums[l] <= target && target < nums[mid])
                        h = mid - 1;
                    else l = mid + 1;
                }
                else
                {
                    if (nums[mid] < target && target <= nums[h])
                        l = mid + 1;
                    else h = mid - 1; ;
                }
            }
            return nums[l] == target ? l : -1;
        }

        internal static void Search(int nums3, int target)
        {
            throw new NotImplementedException();
        }
    }
}
