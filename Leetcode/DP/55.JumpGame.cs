using System;

public static class CanJumpSolution {
    public static bool CanJump(int[] nums) {
        return RecurCanJump(0,nums);
    }
    public static bool RecurCanJump(int index, int[] nums)
    {
        if(index >= nums.Length-1 ) return true;
        int furtherValue=Math.Min(index+nums[index],nums.Length);
        for (int i = index+1; i <= furtherValue; i++)
        {
            if(RecurCanJump(i,nums))
            {
                return true;
            }
        }
        return false;
    }
}