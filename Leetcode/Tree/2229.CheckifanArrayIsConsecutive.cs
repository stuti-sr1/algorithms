using System;
using System.Collections.Generic;

public class IsConsecutiveSolution {
    public bool IsConsecutive(int[] nums) {
        int min = nums[0], max = nums[0];
          ISet<int> unique = new HashSet<int> { nums[0] };
          for (int i = 1; i < nums.Length; i++)
          {
              if (!unique.Add(nums[i]))
                return false;
              min = Math.Min(min, nums[i]);
              max = Math.Max(max, nums[i]);
              if (max - min + 1 > nums.Length)
                return false;            
          }
          return true;
    }

    // public bool IsConsecutive(int[] nums) {
    //     int n=nums.Length;
    //     int min=int.MaxValue;
    //     ISet<int> map=new HashMap<int>();
    //     for (int i = 0; i < n; i++)
    //     {
    //         if(min > nums[i]) min=nums[i];
    //         map.Add(nums[i]);
    //     }
    //     for (int i = min; i < min+n; i++)
    //     {
    //         if(!map.Contains(i)) return false;
    //     }
    //     return true;
    // }
}