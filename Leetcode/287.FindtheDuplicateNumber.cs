using System;

public class Solution {
    public int FindDuplicate(int[] nums) {
        while(nums[0] !=nums[nums[0]])
        {
            /*
            int temp= nums[0];
            nums[0]=nums[nums[0]];
            nums[nums[0]]=temp; 
            */
            //because num[0] value changes
            int temp=nums[nums[0]];
            nums[nums[0]]=nums[0];
            nums[0]=temp; 
        }
        return nums[0];
    }
}