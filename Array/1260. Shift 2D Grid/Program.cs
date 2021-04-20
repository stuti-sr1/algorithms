using System;
using System.Collections.Generic;

namespace _1260._Shift_2D_Grid
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] grid = new int[3][];
            grid[0] = new int[] { 1, 2, 3 };
            grid[1] = new int[] { 4, 5, 6 };
            grid[2] = new int[] { 7, 8, 9 };

            //int[][] grid = new int[1][];
            //grid[0] = new int[] { 1 };

            //int[][] grid = new int[7][];
            //grid[0] = new int[] { 1 };
            //grid[1] = new int[] { 2 };
            //grid[2] = new int[] { 3 };
            //grid[3] = new int[] { 4 };
            //grid[4] = new int[] { 7 };
            //grid[5] = new int[] { 6 };
            //grid[6] = new int[] { 5 };
            var t = ShiftGrid(grid, 3);
            Console.ReadKey();
        }

        public static IList<IList<int>> ShiftGrid(int[][] grid, int k)
        {
            int m = grid.Length;
            int n = grid[0].Length;
            k = k % (m * n);
            grid = Reverse(grid, 0, m * n - 1);
            grid = Reverse(grid, 0, k - 1);
            grid = Reverse(grid, k, m * n - 1);
            return grid;
        }
        public static int[][] Reverse(int[][] grid, int start, int end)
        {
            int m = grid.Length; int n = grid[0].Length;
            int temp;
            while (start < end)
            {
                int i = start / n;
                int j = start % n;
                int start1 = end / n;
                int end1 = end % n;
                temp = grid[i][j];
                grid[i][j] = grid[start1][end1];
                grid[start1][end1] = temp;
                start++;
                end--;
            }
            return grid;
        }



        public static IList<IList<int>> ShiftGrid1(int[][] grid, int k)
        {
            int m = grid.Length;
            int n = grid[0].Length;
            k = k % (m * n);
            List<int> list = new List<int>();
            for (int i = m - 1; i >= 0; i--)
            {
                for (int j = n - 1; j >= 0; j--)
                {
                    list.Add(grid[i][j]);
                }
            }
            list = Reverse1(list, 0, k - 1);
            list = Reverse1(list, k, list.Count - 1);
            IList<IList<int>> result = new List<IList<int>>();
            int l = 0;
            List<int> newList = new List<int>();
            while (l < list.Count)
            {
                newList.Add(list[l]);
                l++;
                if (l % n == 0)
                {
                    result.Add(newList);
                    newList = new List<int>();
                }
            }
            return result;
        }


        public static List<int> Reverse1(List<int> list, int start, int end)
        {
            int temp;
            while (start < end)
            {
                temp = list[start];
                list[start] = list[end];
                list[end] = temp;
                start++;
                end--;
            }
            return list;
        }
    }
}
