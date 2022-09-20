using System;

public class RobSolution {
    public static int Rob(int[] nums) {
        int n=nums.Length;
        int[] dp=new int[n+1];
        for (int i = 0; i <= n; i++)
        {
            dp[i]=-1;
        }
        return Backtrack(nums,dp,n);        
    }

     public static int Backtrack(int[] nums,int[] dp,int n) {
        if(dp[n] >-1) 
            return dp[n];
        else if(n==1) 
        {
            dp[n] = nums[0];
            return dp[n];
        }
        else if(n<1)
            return 0;
        dp[n]=Math.Max(Backtrack(nums,dp,n-1),nums[n-1]+Backtrack(nums,dp,n-2));
        return dp[n];
     }
}