using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] A = { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
            //int[] A = { -2, 1 };
            //int[] A = { 1, 2 };
            int[] A = { -1, -2 };
            Console.WriteLine(MaxSubArray1(A));
            Console.ReadKey();
        }
        public static int MaxSubArray1(int[] nums)
        {
            if (nums.Length == 1) return nums[0];
            int[] dp = new int[nums.Length];
            dp[0] = nums[0];
            int max = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                dp[i] = nums[i] + (dp[i - 1] >= 0 ? dp[i - 1] : 0);
                max = Math.Max(max, dp[i]);
            }
            return max;
        }
        public static int MaxSubArray(int[] nums)
        {
            if (nums.Length == 1) return nums[0];
            int max = int.MinValue;
            int sum = int.MinValue;
            for (int i = 0; i < nums.Length; i++)
            {
                if (sum < nums[i] && sum <= 0) sum = nums[i];
                else sum += nums[i];
                max = Math.Max(max, sum);
            }
            return max;
        }
    }
}
