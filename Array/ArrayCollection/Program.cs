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


            int[] nums4 = { 3, 4, 5, 1, 2 };
            _153FindMinimuminRotatedSortedArray.FindMin(nums4);

            int[] nums3 = { 4, 5, 6, 7, 0, 1, 2 };
            int target = 0;
            SearchinRotatedSortedArray.Search(nums3, target);

            int[] nums5 = { -1, 0, 1, 2, -1, -4 };// { 4, 5, 6, 7, 0, 1, 2 };
            var t = _3Sum.ThreeSum(nums5);

            int[] nums6 = { 1, 3, 3 };// { 2, 2, 2, 0, 1 };// { 4, 5, 6, 7, 0, 1, 2 };
            int t1 = _154FindMinimuminRotatedSortedArrayII.FindMin(nums6);


            int[] height1 = { 4, 2, 0, 3, 2, 5 };// { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 };
            t1 = _42TrappingRainWater.Trap(height1);

            //p = new int[] { 1, 5 };
            ////p1 = new int[] { 6, 9 };
            //int[][] intervals = {p };
            //int[] newInterval = { 2, 7 };


            //p = new int[] { 1, 2 };
            //p1 = new int[] { 3, 5 };
            //p2 = new int[] { 6, 7 };
            //p3 = new int[] { 8, 10 };
            //int[] p4 = new int[] { 12, 16 };
            //int[][] intervals = { p, p1, p2, p3, p4 };
            //int[] newInterval = { 4, 8 };
            //t = _57InsertInterval.Insert(intervals, newInterval);


            //p = new int[] { 1, 4 };// { 1, 3 };
            //p1 = new int[] { 2, 3 };// { 2,6};
            //                        //p2 = new int[] { 8, 10 };
            //                        //p3 = new int[] { 15,18 };

            //intervals = { p, p1 };//, p2, p3};
            //t = _56MergeIntervals.Merge(intervals);

            int[] flowerbed = new int[] { 1, 0, 0, 0, 0, 1 };
            _605CanPlaceFlowers.CanPlaceFlowers(flowerbed, 2);

            _202HappyNumber.IsHappy(19);

            int[] asteroids = { 5, 10, -5 };// 10, 2, -5 };
            _735AsteroidCollision.AsteroidCollision(asteroids);

            _1945SumofDigitsofStringAfterConvert.GetLucky("zbax", 2);

            int[] num = { 0, 0 };// 3, 30, 34, 5, 9 };
            Console.WriteLine(_179LargestNumber.LargestNumber(num));

            p = new int[] { 1, 2 };
            p1 = new int[] { 2, 3 };
            p2 = new int[] { 3, 4 };
            p3 = new int[] { 1, 3 };
            int[][] intervals = { p, p, p };// { p, p1, p2, p3 };
            Console.WriteLine(_435Non_overlappingIntervals.EraseOverlapIntervals(intervals));

            p = new int[] { 1, 2 };
            p1 = new int[] { 2, 3 };
            p2 = new int[] { 3, 4 };
            p3 = new int[] { 4, 5 };
            int[][] points = { p, p1, p2, p3 };

            // [[3,9],[7,12],[3,8],[6,8],[9,10],[2,9],[0,9],[3,9],[0,6],[2,8]]
            Console.WriteLine(_452MinimumNumberofArrowstoBurstBalloons.FindMinArrowShots(points));

            //matrix = [[1,2,3],[4,5,6],[7,8,9]]
            p = new int[] { 1, 2, 3 };
            p1 = new int[] { 4, 5, 6 };
            p2 = new int[] { 7, 8, 9 };
            int[][] matrix1 = { p, p1, p2 };
            _54SpiralMatrix.SpiralOrder(matrix1);

            _59SpiralMatrixII.GenerateMatrix(3);

            _48RotateImage.Rotate(matrix1);
            Console.ReadKey();
        }
    }
}
