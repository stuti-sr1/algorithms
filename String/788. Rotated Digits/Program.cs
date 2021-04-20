using System;

namespace _788._Rotated_Digits
{
    class Program
    {
        //dp[i] = 0, invalid number
        //dp[i] = 1, valid and same number
        //dp[i] = 2, valid and different number
        static void Main(string[] args)
        {
            Console.WriteLine(RotatedDigits(857));
            Console.ReadKey();
        }
        public static int RotatedDigits(int N)
        {
            int[] dp = new int[N + 1];
            int count = 0;
            for (int i = 0; i <= N; i++)
            {
                if (i < 10)
                {
                    if (i == 0 || i == 1 || i == 8) dp[i] = 1;
                    else if (i == 2 || i == 5 || i == 6 || i == 9)
                    {
                        dp[i] = 2;
                        count++;
                    }
                }
                else
                {
                    int a = dp[i / 10];
                    int b = dp[i % 10];
                    if (a == 1 && b == 1) dp[i] = 1;
                    else if (a >= 1 && b >= 1)
                    {
                        dp[i] = 2;
                        count++;
                    }
                }
            }
            return count;
        }
    }
}
