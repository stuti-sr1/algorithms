using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicProgramming
{
    public static class CoinChange
    {
        public static int CoinChangeFun(int[] coins, int amount)
        {
            int[] dp = new int[amount + 1];
            for (int i = 0; i < dp.Length; i++)
            {
                dp[i] = amount+1;
            }
            dp[0] = 0;
            foreach (int coin in coins)
            {
                for (int j = 0; j < dp.Length; j++)
                {
                    if (coin <= j)
                    {
                        dp[j] = Math.Min(dp[j], 1 + dp[j - coin]);
                    }
                }
            }
            return dp[amount] != amount + 1 ? dp[amount] : -1;
        }
    }
}
