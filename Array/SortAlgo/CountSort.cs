using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAlgo
{
    public class CountSort
    {
        //public static void CountSortFun(int[] nums)
        //{
        //    int len = nums.Length;
        //    int[] countArr = new int[10];
        //    int[] sortedArr = new int[len];
        //    int i;
        //    for (i = 0; i < 10; i++)
        //    {
        //        countArr[i] = 0;
        //    }
        //    for (i = 0; i < len; i++)
        //    {
        //        countArr[nums[i]]++;
        //    }
        //    for (i = 1; i < 10; i++)
        //    {
        //        countArr[i] += countArr[i-1];
        //    }
        //    for (i = 0; i < len; i++)
        //    {
        //        sortedArr[countArr[nums[i]] - 1] = nums[i];
        //        countArr[nums[i]]--;
        //    }
        //    nums = sortedArr;
        //    Console.ReadKey();
        //}

        public static void CountSortFun(int[] nums)
        {
            int max = Int32.MinValue;
            int i;
            int len = nums.Length;
            for (i = 0; i < len; i++)
            {
                max = max > nums[i] ? max : nums[i];
            }

            int[] countArr = new int[max + 1];
            int[] sortedArr = new int[len];

            for (i = 0; i < max; i++)
            {
                countArr[i] = 0;
            }
            for (i = 0; i < len; i++)
            {
                countArr[nums[i]]++;
            }
            for (i = 1; i < max+1; i++)
            {
                countArr[i] += countArr[i - 1];
            }
            for (i = 0; i < len; i++)
            {
                sortedArr[countArr[nums[i]] - 1] = nums[i];
                countArr[nums[i]]--;
            }
            int count = 0;
            for (i = 0; i < len; i++)
            {
                if (nums[i] != sortedArr[i]) count++;
            }
            Console.WriteLine( count);
            return;
        }
    }
}
