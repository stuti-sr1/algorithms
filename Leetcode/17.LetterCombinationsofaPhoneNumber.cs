using System;
using System.Collections.Generic;
using System.Text;

public class LetterCombinationsSolution {
    public static IList<string> output;
    public static IList<string> LetterCombinations(string digits) {
        output=new List<string>();   
        int n=digits.Length;  
        if(n==0) return output;
        Dictionary<int,string> map=new Dictionary<int,string>();
        map[2]="abc";
        map[3]="def";
        map[4]="ghi";
        map[5]="jkl";
        map[6]="mno";
        map[7]="pqrs";
        map[8]="tuv";
        map[9]="wxyz";    
        List<string> nums=new List<string>();
        foreach (char c in digits.ToCharArray())
        {
            nums.Add(map[int.Parse(c.ToString())]);
        }
        StringBuilder current=new StringBuilder();
        backtrack(nums,current,n,0);
        return output;        
    }

    private static void backtrack(List<string> nums,StringBuilder current,int n,int count)
    {
        if(count == n)
        {
            output.Add(current.ToString());
            return;
        }
        foreach (char num in nums[count])
        {
            current.Append(num);
            backtrack(nums,current,n,count+1);
            current.Remove(count,1);
        }
    }
}