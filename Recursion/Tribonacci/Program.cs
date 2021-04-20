using System;

namespace Tribonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Tribonacci(25));
            Console.ReadKey();
        }
        public static int Tribonacci(int n)
        {
            if (n == 0) return 0;
            if (n == 1 || n == 2) return 1;
            int[] dp = new int[n+1];
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
            dp[n] = TribonacciDP(n - 1,dp) + TribonacciDP(n - 2,dp) + TribonacciDP(n - 3,dp);
            return dp[n];
        }
        public static int Tribonacci1(int n, int[] dp)
        {
            if (n == 0) return 0;
            if (n == 1 || n == 2) return 1;
            return Tribonacci(n - 1) + Tribonacci(n - 2) + Tribonacci(n - 3);
        }
    }
}
