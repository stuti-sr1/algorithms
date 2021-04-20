using System;
using System.Collections.Generic;
using System.Linq;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 8, 1, 2, 2, 3 };
            Console.WriteLine(SmallerNumbersThanCurrent(nums));
            Console.ReadKey();
        }
        public static int[] SmallerNumbersThanCurrent(int[] nums)
        {
            int[] freq = new int[100]; int[] res = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                freq[nums[i]]++;
            }
            for (int i = 0; i < 100; i++)
            {
                freq[i] = i == 0 ? 0 : freq[i] + freq[i - 1];
            }
            for (int i = 0; i < nums.Length; i++)
            {
                if (freq[nums[i]] == 0)
                {
                    res[i] = freq[nums[i]];
                }
                else
                {
                    res[i] = freq[nums[i] - 1];
                }
                //res[i] = freq[nums[i]] == 0 ? freq[nums[i]] : freq[nums[i] - 1];
            }
            return null;
        }


        public static int[] SmallerNumbersThanCurrent1(int[] nums)
        {
            int[] newArr = nums.OrderBy(x => x).ToArray();
            Dictionary<int, int> map = new Dictionary<int, int>();
            for (int i = 0; i < newArr.Length; i++)
            {
                if (!map.ContainsKey(newArr[i]))
                {
                    map[newArr[i]] = i;
                }
            }
            for (int i = 0; i < nums.Length; i++)
            {
                newArr[i] = map[nums[i]];
            }
            return newArr;
        }
    }
}
