using System;
using System.Linq;
using System.Linq.Expressions;
using System.Collections.Generic;

public class PermutationsSolution {
    public static IList<IList<int>> Permute(int[] nums) {
        List<IList<int>> output=new List<IList<int>>();
        int first=0;
        backtrack(nums.ToList(), nums.Length,output,first);
        return output;
    }

    private static void backtrack(List<int> nums,int n, List<IList<int>> output, int first) {
        if(first==n)
        {
            output.Add(new List<int>( nums));
            return;
        }
        for (int i = first; i < n ; i++)
        {
            nums=Swap(nums,first,i);
            backtrack(nums,n,output,first+1);
            nums=Swap(nums,first,i);
        }        
    }

    private static List<int> Swap(List<int> nums, int first, int i)
    {
        int t=nums[first];
        nums[first]=nums[i];
        nums[i]=t;
        return nums;
    } 
}

// dfs also good solution
//public class Solution {
    // public IList<IList<int>> Permute(int[] nums) {
    //     var n = nums.Length;

    //     var result = new List<IList<int>>();
    //     if (n == 0) return result;

    //     DFS(nums, new bool[n], new List<int>(), result);

    //     return result;
    // }

    // private void DFS(int[] nums, bool[] isVisited, IList<int> oneResult, IList<IList<int>> result) {
    //     var n = nums.Length;

    //     if (oneResult.Count == n) {
    //         result.Add(new List<int>(oneResult));
    //     } else {
    //         for (int i = 0; i < n; i++) {
    //             if (isVisited[i]) continue;

    //             oneResult.Add(nums[i]);
    //             isVisited[i] = true;
    //             DFS(nums, isVisited, oneResult, result);
    //             isVisited[i] = false;
    //             oneResult.RemoveAt(oneResult.Count - 1);
    //         }
    //     }
    // }
//}