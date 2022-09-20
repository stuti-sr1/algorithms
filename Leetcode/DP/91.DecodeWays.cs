using System;
using System.Collections.Generic;

public static class NumDecodingsSolution {
    public static Dictionary<int,int> map;
    public static int NumDecodings(string s) {
        map=new Dictionary<int,int>();
        return RecurNumDecodings(0,s);
    }
    public static int RecurNumDecodings(int index, string s) {
        if(map.ContainsKey(index)) return map[index];
        if(index == s.Length ) return 1;
        if(s[index] == 0) return 0;
        if(index == s.Length-1 ) return 1;

        int ans=RecurNumDecodings(index+1,s);
        if((index+2)<s.Length && int.Parse(s.Substring(index,2))<=26)
        {
            ans+=RecurNumDecodings(index+2,s);
        }
        map[index]=ans;
        return ans;        
    }

    // public static int NumDecodings(string s) {
    //     int[] dp=new int[s.Length+1];
    //     for (int i = 0; i <= s.Length; i++)
    //     {
    //         dp[i]=-1;
    //     }
    //     int t= RecurNumDecodings(0,dp,s);
    //     return t;
    // }
    // public static int RecurNumDecodings(int index,int[] dp, string s) {
    //     if(dp[index] !=-1) return dp[index];
    //     if(index == s.Length ) return 1;
    //     if(s[index] == 0) return 0;
    //     if(index == s.Length-1 ) return 1;


    //     int ans=1+RecurNumDecodings(index+1,dp,s);
    //     Console.WriteLine(index +"   "+ans);


    //     if((index+2)<s.Length && int.Parse(s.Substring(index,index+2))<=26)
    //     {
    //         ans+=RecurNumDecodings(index+2,dp,s);
    //         Console.WriteLine(index+2+"   "+ans);
    //     }
    //     //Console.WriteLine(index+"   "+ans);
    //     dp[index]=ans;
    //     return ans;        
    // }
}