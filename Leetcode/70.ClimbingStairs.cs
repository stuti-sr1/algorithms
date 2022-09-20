using System;

public class ClimbStairsSolution {
    public static int ClimbStairs(int n) {
        int[] dp=new int[n+1];
        for (int i = 0; i <= n; i++)
        {
            dp[i]=0;
        }
        return Backtrack(n,dp);
    }
    public static int Backtrack(int n, int[] dp)
    {
        if(n==1 || n==2)
            return n;
        else if(n<1)
            return 0;
        else if(dp[n]!=0)
            return dp[n];
        dp[n]=Backtrack(n-1,dp)+Backtrack(n-2,dp);
        return dp[n];
    }
}