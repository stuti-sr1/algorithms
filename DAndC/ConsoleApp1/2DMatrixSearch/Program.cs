using System;

namespace _2DMatrixSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] a = new int[,]{
                              {1, 4, 7, 11, 15},
                              {2, 5, 8, 12, 19},
                              {3, 6, 9, 16, 22},
                              {10, 13, 14, 17, 24},
                              {18, 21, 23, 26, 30}
                            };
            int k = 20;
            Console.WriteLine(SearchMatrix(a, k));
            Console.ReadKey();
        }

        //
        public static bool SearchMatrix(int[,] matrix, int target)
        {
            int row = matrix.GetLength(0);
            int col = matrix.GetLength(1);
            int i = row - 1,j = 0;
            while (i < row && i >= 0 && j < col && j >= 0)
            {
                if (matrix[i, j] == target) return true;                
                else if (matrix[i, j] > target)i--;                
                else j++;
            }
            return false;
        }

        //brute
        public static bool SearchMatrix1(int[,] matrix, int target)
        {
            int row = matrix.GetLength(0);
            int col = matrix.GetLength(1);
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (matrix[i, j] == target)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
