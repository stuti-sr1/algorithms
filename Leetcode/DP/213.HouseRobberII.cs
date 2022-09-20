using System;

public static class RobIISolution {

    public static int Rob(int[] nums) {
        int n=nums.Length;
        if(n==1) return nums[0];
        return  Math.Max(Backtrack(nums,0,n-2),Backtrack(nums,1,n-1));        
    }

    public static int Backtrack(int[] nums, int start,int end) {
        int max1=0;
        int max2=0;
        for (int i = start; i <= end; i++)
        {
            int temp=max1;
            max1=Math.Max(nums[i]+max2,max1);
            max2=temp;            
        }
        return max1;   
     }
//doesn't work
    // public static int Rob(int[] nums) {
    //     int n=nums.Length;
    //     if(n==1) return nums[0];
    //     int[] dp=new int[n+1];
    //     for (int i = 0; i <= n; i++) dp[i]=-1; 
    //     return  Math.Max(Backtrack(nums,dp,0,n-2),Backtrack(nums,dp,1,n-1));        
    // }

    // public static int Backtrack(int[] nums,int[] dp, int n,int end) {
    //     if(n == end)  return nums[n];        
    //     if(dp[n] >-1)  return dp[n];        
    //     else if(n>end) return 0;        
    //     dp[n] = Math.Max(Backtrack(nums,dp,n+1,end),nums[n]+Backtrack(nums,dp,n+2,end));
    //     return dp[n];
    //  }
}