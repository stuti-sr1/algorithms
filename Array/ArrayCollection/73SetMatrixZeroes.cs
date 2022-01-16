using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayCollection
{
    public static class _73SetMatrixZeroes
    {
        public static void SetZeroes(int[][] matrix)
        {
            int r = matrix.Length;
            int c = matrix[0].Length;
            HashSet<int> x = new HashSet<int>();
            HashSet<int> y = new HashSet<int>();
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    if (matrix[i][j] == 0)
                    {
                        x.Add(i);
                        y.Add(j);
                    }
                }
            }
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    if (x.Contains(i) || y.Contains(j))
                        matrix[i][j] = 0;
                }
            }
        }

        //public static bool SetZeroes(int[][] matrix)
        //{
        //    {
        //        int r = matrix.Length;
        //        int c = matrix[0].Length;
        //        HashSet<int> x = new HashSet<int>();
        //        HashSet<int> y = new HashSet<int>();
        //        for (int i = 0; i < r; i++)
        //        {
        //            for (int j = 0; j < c; j++)
        //            {
        //                if (matrix[i][j] == 0)
        //                {
        //                    x.Add(i);
        //                    y.Add(j);
        //                }
        //            }
        //        }
        //        foreach(int t in x)
        //        {
        //            for (int j = 0; j < c; j++)
        //            {
        //                matrix[t][j] = 0;
        //            }
        //        }
        //        foreach (int t in y)
        //        {
        //            for (int j = 0; j < r; j++)
        //            {
        //                matrix[j][t] = 0;
        //            }
        //        }
        //        Console.WriteLine();
        //        return false;
        //    }
        //}
    }
}
