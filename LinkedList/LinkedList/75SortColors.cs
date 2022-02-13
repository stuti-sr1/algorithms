using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public static class _75SortColors
    {
        public static void SortColors(int[] nums)
        {
            int len = nums.Length;
            int low = 0;
            int temp;
            int mid = 0;
            int high = len - 1;
            while (mid <= high)
            {
                switch (nums[mid])
                {
                    case 0:
                        temp = nums[low];
                        nums[low] = nums[mid];
                        nums[mid] = temp;
                        low++;
                        mid++;
                        break;
                    case 1:
                        mid++;
                        break;
                    case 2:
                        temp = nums[mid];
                        nums[mid] = nums[high];
                        nums[high] = temp;
                        high--;
                        break;
                }
            }
            return;
        }
    }
}
