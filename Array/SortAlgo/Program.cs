using System;

namespace SortAlgo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Count Sort!");
            int[] nums = new int[] { 1, 2, 3, 4, 5 };// 4, 2, 2, 8, 3, 3, 1 };
            CountSort.CountSortFun(nums);
        }

    }
}
