using System;

public class MaxPowerSolution {
    public int MaxPower(string s) {
        int maxCount=0;
        int count=0;
        for (int i = 1; i < s.Length; i++)
        {
            if(s[i] == s[i-1]) 
            {
                count++;
                maxCount=Math.Max(count,maxCount);
            }else count=0;
        }
        return maxCount+1;
    }
}