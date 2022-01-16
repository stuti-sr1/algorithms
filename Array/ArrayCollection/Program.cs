using System;

namespace ArrayCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //int[] nums = { 3, 2, 4 };
            //TwoSum.TwoSum1(nums, 6);
            int[] nums = new int[] { 1, 1, 1, 1, 1, 4, 1, 1, 1, 1, 1, 7, 1, 1, 1, 1, 1 };// { 2, 7, 11, 15 };
            TwoSum.TwoSum1(nums, 11);



            int[] prices = new int[] { 7, 1, 5, 3, 6, 4 };// { 7, 6, 4, 3, 1 };// { 2, 1, 2, 1, 0, 1, 2};// 7, 6, 4, 3, 1 }; // 7, 1, 5, 3, 6, 4 };
            Console.WriteLine(BestTimetoBuyandSellStock.MaxProfit(prices));


            int[] nums1 = { 1, 2, 3, 4 };
            Console.WriteLine(ProductofArrayExceptSelf.ProductExceptSelf(nums1));


            int[] nums2 = { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
            Console.WriteLine(_53MaximumSubarray.MaxSubArray(nums2));


            int[] p = { 0, 1, 0 };
            int[] p1 = { 0, 0, 1 };
            int[] p2 = { 1, 1, 1 };
            int[] p3 = { 0, 0, 0 };
            int[][] board = { p, p1, p2, p3 };
            GameofLife.GameOfLife1(board);

            int[] p11 = { 1, 1, 1 };
            int[] p12 = { 1, 0, 1 };
            int[] p13 = { 1, 1, 1 };
            int[][] matrix = { p11, p12, p13 };
            _73SetMatrixZeroes.SetZeroes(matrix);


            int[] nums4 = {3, 4, 5, 1, 2};
            _153FindMinimuminRotatedSortedArray.FindMin(nums4);

            int[] nums3 = { 4, 5, 6, 7, 0, 1, 2 }; 
            int target = 0;
            SearchinRotatedSortedArray.Search(nums3,target);
            Console.ReadKey();
        }
    }
}
