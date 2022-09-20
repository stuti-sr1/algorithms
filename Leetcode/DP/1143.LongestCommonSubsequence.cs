using System;
using System.Collections.Generic;

public static class LCSSolution {
    public static int LongestCommonSubsequence(string text1, string text2) {
        int l1=text1.Length;
        int l2=text2.Length;

        int[,] dp=new int[l1+1,l2+1];
        for (int row = 0; row <= l1; row++)
        {
            for (int col = 0; col <= l2; col++)
            {
                 if(row==0 || col==0) dp[row,col]=0;
                else
                {
                    if(text1[row-1]==text2[col-1])
                    {
                        dp[row,col]=  1 + dp[row-1,col-1];
                    }
                    else 
                        dp[row,col]=Math.Max(dp[row,col-1],dp[row-1,col]);
                }
            }
        }
       // Console.WriteLine("length :"+l1+" "+l2);
       int row1=0 , col1=0;

        for ( row1 = 0; row1 <= l1; row1++)
        {
            for ( col1 = 0; col1 <= l2; col1++)
            {
                Console.Write(dp[row1,col1]);
            }
            Console.WriteLine();
        }

        return dp[l1,l2];// dp[l1,l2];
    }
}