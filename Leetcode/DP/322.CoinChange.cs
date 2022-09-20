using System;


public static class CoinChangeSolution {
    public static int CoinChange(int[] coins, int amount) {
        int[] dp=new int[amount+1];
        for (int i = 0; i < amount+1; i++)
        {
            dp[i]=amount+1;
        }
        dp[0]=0;
        int min=Helper(coins,amount,dp);
        return min<amount+1 ? min:-1;      
    }
    public static int Helper(int[] coins,int amount,int[] dp){
        foreach (var coin in coins)
        {
            for (int i = coin; i <= amount; i++)
            {
                dp[i]=Math.Min(dp[i],dp[i-coin]+1);
            }
        }
        return dp[amount];
    }
}

//TLE
// public static class CoinChangeSolution {
//     public static int CoinChange(int[] coins, int amount) {
//         int min=Helper(coins,amount,coins.Length-1);
//         return min<Int32.MaxValue ? min:-1;      
//     }
//     public static int Helper(int[] coins,int amount,int n){
//         if(amount == 0) return 0;
//         if(amount< 0 || n < 0) return Int32.MaxValue-1;
//         int one=Helper(coins,amount,n-1);
//         int two=1+Helper(coins,amount-coins[n],n);
//         return Math.Min(one,two);
//     }
// }