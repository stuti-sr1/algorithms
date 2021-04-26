using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCollection
{
    public static class NumberofGoodPairs
    {
        public static int NumIdenticalPairs(int[] nums)
        {
            int count = 0;
            int len = nums.Length;
            Dictionary<int, int> map = new Dictionary<int, int>();
            for (int i = 0; i < len; i++)
            {
                if (map.ContainsKey(nums[i]))
                {
                    map[nums[i]]++;
                }
                else
                {
                    map[nums[i]] = 1;
                }
            }
            foreach (var item in map)
            {
                if (item.Value == 1) continue;
                count += item.Value * (item.Value - 1) / 2;
            }
            return count;
        }

        public static int NumIdenticalPairs1(int[] nums)
        {
            int count = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] == nums[j] && i < j)
                    { count++; }
                }
            }
            return count;
        }
    }
}
