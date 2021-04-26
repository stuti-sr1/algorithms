using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCollection
{
    public static class SignOfTheProductOfAnArray
    {
        public static int ArraySign(int[] nums)
        {
            int count = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0) return 0;                
                else if (nums[i] < 0) count++;                
            }
            return count % 2 == 0 ? 1 : -1;
        }
    }
}
