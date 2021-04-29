using System;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] mat = new int[5][];
            mat[0] = new int[] { 1, 1, 0, 0, 0 };
            mat[1] = new int[] { 1, 1, 1, 1, 0 };
            mat[2] = new int[] { 1, 0, 0, 0, 0 };
            mat[3] = new int[] { 1, 1, 0, 0, 0 };
            mat[4] = new int[] { 1, 1, 1, 1, 1 } ;
            var t = TheKWeakestRowsInAMatrix.KWeakestRows(mat, 3);
           // Console.WriteLine(TheKWeakestRowsInAMatrix.KWeakestRows(mat,3));
            Console.ReadKey();
        }
    }
}
