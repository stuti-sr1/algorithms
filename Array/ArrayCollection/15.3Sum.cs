using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayCollection
{
    public static class _3Sum
    {
        public static IList<IList<int>> ThreeSum(int[] nums)
        {
            var res = new List<IList<int>>();
            HashSet<string> resStr = new HashSet<string>();
            Dictionary<int, int> map = new Dictionary<int, int>();

            List<int>  res1;
            for (int i = 0; i < nums.Length; i++)
            {
                if (!map.ContainsKey(-nums[i]))
                {
                    map.Add(-nums[i], i);
                }
            }
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    int target = nums[i] + nums[j];
                    if(map.ContainsKey(target))
                    {
                        int key = map[target];
                        if(key!=i && key!=j)
                        {
                            res1 = new List<int>();
                            res1.Add(-target);
                            res1.Add(nums[i]);
                            res1.Add(nums[j]);
                            res1.Sort();
                            string str= $"{res1[0]},{res1[1]},{res1[2]}";
                            if (!resStr.Contains(str))
                            {
                                resStr.Add(str);
                                res.Add(res1.ToList<int>());
                            }
                        }
                    }
                }
            }
            return res;
        }
        
    }
}
