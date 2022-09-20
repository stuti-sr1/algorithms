using System;

public class MinCostClimbingStairsSolution {
    public static int MinCostClimbingStairs(int[] cost) {
        int n=cost.Length;
        int[] dp=new int[n+1];
        for (int i = 0; i <= n; i++)
        {
            dp[i]=0;
        }
        return Backtrack(n,dp,cost);
    }
    public static int Backtrack(int n,int[] dp,int[] cost)
    {
        if(n<=1)
        {
            return 0;
        }
        else if(n==1)
        {
            dp[n]=cost[0];
            return dp[n];
        }   
        else if(dp[n]!=0)
        {
            return dp[n];
        }     
        dp[n]=Math.Min(cost[n-1]+Backtrack(n-1,dp,cost),cost[n-2]+Backtrack(n-2,dp,cost));
        return dp[n];
    }
}