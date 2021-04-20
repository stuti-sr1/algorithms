using System;
using System.Collections.Generic;
using System.Linq;

namespace MaxBalloonBurst
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] nums = { 3, 1, 5, 8 };
            //int[] nums = { 9 };
            //int[] nums = { 9, 76, 64, 21 };
            int[] nums = { 9, 76, 64, 21, 97, 60 };
            Console.WriteLine(MaxCoins(nums));
            Console.ReadKey();
        }

        public static int MaxCoins(int[] nums)
        {
            if (nums == null || nums.Length == 0) return 0;
            if (nums.Length == 1) return nums[0];
            int sum = 0;
            int sum1 = 0;
            int sum2 = 0;
            if ()
            {
                sum1 = MaxCoins();
            }
            sum2 = MaxCoins();
            return Math.Max(sum1, sum2);
        }

        public static int MaxCoinsDP(int[] nums, int index)
        {
            if (nums == null || nums.Length == 0) return 0;
            if (nums.Length == 1) return nums[0];
            int sum1 = 0;
            int sum2 = 0;
            if (index >= 0 && index < nums.Length)
            {
                sum1 = MaxCoins();
            }
            sum2 = MaxCoins();
            return Math.Max(sum1, sum2);
        }



        //public static int MaxCoins(int[] nums)
        //{
        //    if (nums == null || nums.Length == 0) return 0;
        //    if (nums.Length == 1) return nums[0];
        //    List<int> list = new List<int>(nums);
        //    int sum = 0;
        //    int count = nums.Length;
        //    int min = int.MaxValue;
        //    while (count > 0)
        //    {
        //        if (count == 2)
        //        {
        //            min = Math.Min(list[0], list[1]);
        //            sum += list[0] * list[1];
        //            list.Remove(min);
        //            count--;
        //        }
        //        else if (count == 1)
        //        {
        //            sum += list[0];
        //            count--;
        //        }
        //        else
        //        {
        //            min = GetMin(list);
        //            int index = list.IndexOf(min);
        //            sum += min * list[index - 1] * list[index + 1];
        //            list.Remove(min);
        //            count--;
        //        }
        //        min = int.MaxValue;
        //    }
        //    return sum;
        //}

        //private static int GetMin(List<int> list)
        //{
        //    int min = int.MaxValue;
        //    for (int i = 1; i < list.Count - 1; i++)
        //    {
        //        min = min > list[i] ? list[i] : min;
        //    }
        //    return min;
        //}


    }
}
