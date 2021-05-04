using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursionEasy
{
    public static class Tribonacci
    {
        public static int TribonacciFun(int n)
        {
            if (n == 0) return 0;
            if (n == 1 || n == 2) return 1;
            int[] dp = new int[n + 1];
            for (int i = 0; i < n + 1; i++)
            {
                dp[i] = -1;
            }
            return TribonacciDP(n, dp);
        }
        public static int TribonacciDP(int n, int[] dp)
        {
            if (n == 0) return 0;
            if (n == 1 || n == 2) return 1;
            if (dp[n] != -1) return dp[n];
            dp[n] = TribonacciDP(n - 1, dp) + TribonacciDP(n - 2, dp) + TribonacciDP(n - 3, dp);
            return dp[n];
        }
    }
}
