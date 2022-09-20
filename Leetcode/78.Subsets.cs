using System;
using System.Collections.Generic;

public class SubsetsSolution {
    public static List<IList<int>> output;
    public static IList<IList<int>> Subsets(int[] nums) {
        output=new List<IList<int>>();
        backtrack(nums,new List<int>(),0);
        return output;      
    }

    public static void backtrack(int[] nums, List<int> res, int index)
    {
        output.Add(new List<int>(res));            
        for (int i = index; i < nums.Length; i++)
        {
            res.Add(nums[i]);
            backtrack(nums, res,i+1);
            res.Remove(nums[i]);
        }
    }
}