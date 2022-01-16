using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayCollection
{
    public static class _53MaximumSubarray
    {
        public static int MaxSubArray(int[] nums)
        {
            if (nums.Length == 1) return nums[0];
            int[] dp = new int[nums.Length];
            dp[0] = nums[0];
            int max = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                dp[i] = nums[i] + (dp[i - 1] > 0 ? dp[i - 1] : 0);
                max = Math.Max(max, dp[i]);
            }
            return max;
        }
    }
}
