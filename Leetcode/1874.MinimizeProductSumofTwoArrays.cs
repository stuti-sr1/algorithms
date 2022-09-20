using System;

public static class MinProductSumSolution {
    public static int MinProductSum(int[] nums1, int[] nums2) {
        Array.Sort(nums1);
        Array.Sort(nums2);
        int sum=0;
        int l=nums1.Length ;
        for (int i = 0; i < l; i++)
        {
            sum+=nums1[i]*nums2[l-i-1];
        }
        return sum;
    }
}