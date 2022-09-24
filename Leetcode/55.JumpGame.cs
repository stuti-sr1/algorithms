using System;

public class CanJumpSolution {
    public bool CanJump(int[] nums) {
        int lastIndexPos=nums.Length-1;
        for (int i = lastIndexPos; i >=0; i--)
        {
            if(nums[i]+i >= lastIndexPos)
                lastIndexPos=i;
        }
        return lastIndexPos==0;
    }
}

//https://www.youtube.com/watch?v=Zb4eRjuPHbM&ab_channel=NickWhite