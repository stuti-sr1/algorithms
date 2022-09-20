using System;
using System.Linq;
using System.Linq.Expressions;
using System.Collections.Generic;

public class PermutationsIISolution {

    public static IList<IList<int>> PermuteUnique(int[] nums) {
        List<IList<int>> output=new List<IList<int>>();
        int first=0;
        backtrack(nums.ToList(), nums.Length,output , first);
        return output;
    }

    private static void backtrack(List<int> nums,int n, List<IList<int>> output, int first)
    {
        if(first==n)
        {
            output.Add(new List<int>(nums));
        }    
        ISet<int> visited=new HashSet<int>();
        for (int i = first; i < n; i++)
        {     
            if(!visited.Add(nums[i]))
                continue;       
            int t=nums[first];
            nums[first]=nums[i];
            nums[i]=t;

            backtrack(nums,n,output,first+1);

            t=nums[first];
            nums[first]=nums[i];
            nums[i]=t;
        }
    } 
}


// public class PermutationsIISolution {
//     public static Dictionary<string,int> map;

//     public static IList<IList<int>> PermuteUnique(int[] nums) {
//         List<IList<int>> output=new List<IList<int>>();
//         map=new Dictionary<string,int>();
//         List<int> num=new List<int>();
//         foreach (int item in nums)
//         {
//             num.Add(item);
//         }
//         int first=0;
//         backtrack(num, num.Count,output,first);
//         return output;
//     }

//     private static void backtrack(List<int> num,int n, List<IList<int>> output, int first)
//     {
//         if(first==n)
//         {
//             string id = string.Join(", ", num); 
//             if(!map.ContainsKey(id))
//             {
//                 output.Add(new List<int>(num));
//                 map[id]=1;
//             }
//         }            
//         for (int i = first; i < n; i++)
//         {            
//             Swap(num,first,i);
//             backtrack(num,n,output,first+1);
//             Swap(num,first,i);
//         }
//     }

//     private static List<int> Swap(List<int> nums, int first, int i)
//     {
//         int t=nums[first];
//         nums[first]=nums[i];
//         nums[i]=t;
//         return nums;
//     } 
// }
