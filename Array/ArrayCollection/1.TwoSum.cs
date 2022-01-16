using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayCollection
{
    public static class TwoSum
    {
        public static int[] TwoSum1(int[] nums, int target)
        {
            Dictionary<int,int> map = new Dictionary<int, int>();
            int[] res = new int[2];
            for(int i=0;i<nums.Length;i++)
            {
                if (map.ContainsKey(target - nums[i]))
                {
                    res[1] = i;
                    res[0] = map[target - nums[i]];                    
                    return res;
                }
                map[nums[i]] = i;
            }
            return res;
        }
    }
}

