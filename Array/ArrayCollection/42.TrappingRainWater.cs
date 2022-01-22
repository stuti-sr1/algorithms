using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayCollection
{
    public static class _42TrappingRainWater
    {
        public static int Trap(int[] height)
        {
            int max = -1;
            int sum = 0;
            int[] l = new int[height.Length];
            int[] r = new int[height.Length];
            l[0] = 0;
            r[height.Length - 1] = 0;
            for (int i = 1; i < height.Length; i++)
            {
                max = Math.Max(max, height[i - 1]);
                l[i] = max;
            }
            max = -1;
            for (int j = height.Length - 2; j >= 0; j--)
            {
                max = Math.Max(max, height[j + 1]);
                r[j] = max;
            }
            int temp;
            for (int i = 0; i < height.Length - 1; i++)
            {
                temp = (Math.Min(l[i], r[i]) - height[i]);
                sum += temp > 0 ? temp : 0;
            }
            return sum;
        }
    }
}
