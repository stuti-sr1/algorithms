using System;

public static class UniquePathsSolution {
    public static int UniquePaths(int m, int n) {
        int[,] dp=new int[m+1,n+1];
        for (int i = 0; i < m+1; i++)
        {
            for (int j = 0; j < n+1; j++)
            {
                dp[i,j]=0;
            }
        }
        return CountPath(dp,0,m,n,0,0);
    }
    public static int CountPath(int[,] dp,int count,int m,int n,int row,int col)
    {
        if(dp[row,col]!=0) return dp[row,col];
        if(m-1 == row && n-1==col) return 1+count;        
        if(row<m-1)
        {
            dp[row+1,col]=CountPath(dp,count,m,n,row+1,col);
        }
        if(col<n-1)
        {
            dp[row,col+1]=CountPath(dp,count,m,n,row,col+1);
        }
        return dp[row+1,col]+dp[row,col+1];
    }
}