using System;

namespace _566reshaper
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] nums = new int[2][];
            nums[0] = new int[] { 1, 2 };
            nums[1] = new int[] { 3, 4 };
            Console.WriteLine(MatrixReshape(nums, 1, 4));
            Console.ReadKey();

        }
        public static int[][] MatrixReshape(int[][] nums, int r, int c)
        {
            int[][] res = new int[r][];
            for (int i = 0; i < r; i++)
            {
                res[i] = new int[c];
            }
            if (nums.Length == 0 || r * c != nums.Length * nums[0].Length)
                return nums;
            int count = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums[0].Length; j++)
                {
                    res[count / c][count % c] = nums[i][j];
                    count++;
                }
            }
            return res;
        }

    }
}
