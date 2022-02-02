using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayCollection
{
    public static class _48RotateImage
    {
        public static void Rotate(int[][] matrix)
        {
            Print(matrix);
            Transpose(matrix);
            Print(matrix);
            reflect(matrix);
            Print(matrix);
            return;
        }

        private static void Print(int[][] matrix)
        {
            int n = matrix.Length;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrix[i][j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        private static void Transpose(int[][] matrix)
        {
            int n = matrix.Length;
            int temp;
            for (int i = 0; i < n; i++)
            {
                for (int j = i+1; j < n; j++)
                {
                    temp = matrix[i][j];
                    matrix[i][j] = matrix[j][i];
                    matrix[j][i] = temp;
                }
            }
            return;
        }

        private static void reflect(int[][] matrix)
        {
            //reflection over i(vertical line)
            int n = matrix.Length;
            int temp;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n / 2; j++)
                {
                    temp = matrix[i][j];
                    matrix[i][j] = matrix[i][n-j-1];
                    matrix[i][n-j-1] = temp;
                }
            }
            return;
        }

        public static void Rotate1(int[][] matrix)
        {
            int n = matrix.Length;
            int temp;
            for (int i = 0; i < (n + 1) / 2; i++)
            {
                for (int j = 0; j < n / 2; j++)
                {
                    //clockwise
                    temp = matrix[n - 1 - j][i];
                    matrix[n - 1 - j][i] = matrix[n - 1 - i][n - 1 - j];
                    matrix[n - 1 - i][n - 1 - j] = matrix[j][n - 1 - i];
                    matrix[j][n - 1 - i] = matrix[i][j];
                    matrix[i][j] = temp;

                    //anti clockwise
                    //temp = matrix[n - 1 - i][j];
                    //matrix[n - 1 - i][j] = matrix[n - 1 - i][n - 1 - j];
                    //matrix[n - 1 - i][n - 1 - j] = matrix[i][n - 1 - j];
                    //matrix[i][n - 1 - j] = matrix[i][j];
                    //matrix[i][j] = temp;
                }
            }
            return;
        }
    }
}
