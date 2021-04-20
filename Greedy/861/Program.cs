using System;

namespace _861ScoreAfterFlippingMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[][] groupSizes = new int[3][];
            //groupSizes[0] = new int[4] { 0, 0, 1, 1 };
            //groupSizes[1] = new int[4] { 1, 0, 1, 0 };
            //groupSizes[2] = new int[4] { 1, 1, 0, 0 };

            int[][] groupSizes = new int[2][];
            groupSizes[0] = new int[2] { 0, 1 };
            groupSizes[1] = new int[2] { 1, 1 };
            Console.WriteLine(MatrixScore(groupSizes));
            Console.ReadKey();
        }
        public static int MatrixScore(int[][] A)
        {
            int row = A.GetLength(0);
            int col = A[0].Length;
            Print(A, row, col);
            for (int i = 0; i < row; i++)
            {
                if (A[i][0] == 0) A[i] = FlipRow(A[i]);
            }
            Print(A, row, col);
            for (int i = 0; i < col; i++)
            {
                int count = 0;
                for (int j = 0; j < row; j++) { if (A[j][i] == 0) count++; }
                if (count > row / 2)
                {
                    for (int j = 0; j < row; j++)
                    {
                        A[j][i] = 1 - A[j][i];
                    }
                }
                count = 0;
            }
            Print(A, row, col);
            double sum = 0;
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (A[i][j] == 1)
                        sum += Math.Pow(2, col-1-j);
                }
            }
            return (int)(sum);
        }

        private static int[] FlipRow(int[] A)
        {
            for (int i = 0; i < A.Length; i++)
            {
                A[i] = 1 - A[i];
            }
            return A;
        }
        private static void Print(int[][] A,int row,int col)
        {
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write(A[i][j]);
                }
                Console.WriteLine();
            }
        }

    }
}
