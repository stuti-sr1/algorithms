﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayCollection
{
    public static class ProductofArrayExceptSelf
    {
        public static int[] ProductExceptSelf(int[] nums)
        {
            int[] left = new int[nums.Length];
            int[] right = new int[nums.Length];
            left[0] = 1;
            right[nums.Length - 1] = 1;
            for (int i = 1; i < nums.Length; i++)
            {
                left[i] = left[i - 1] * nums[i - 1];
            }
            for (int i = nums.Length - 2; i >= 0; i--)
            {
                right[i] = right[i + 1] * nums[i + 1];
            }
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = left[i] * right[i];
            }
            return nums;
        }
    }
}
