using System;
using System.Collections.Generic;

namespace _1313._Decompress_Run_Length_Encoded_List
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 4 };
            int t = P(3, 2);
            Console.WriteLine(DecompressRLElist(nums));
            Console.ReadKey();
        }
        public static int P(int m, int n)
        {
            int[][] indices = new int[2][];
            indices[0] = new int[] { 0, 1 };
            indices[1] = new int[] { 1, 1 };
            int[] rows = new int[n];
            int[] cols = new int[m];
            foreach (int[] indice in indices)
            {
                rows[indice[0]]++;
                cols[indice[1]]++;
            }
            int row_odd = 0;
            int row_even = 0;
            int col_odd = 0;
            int col_even = 0;
            foreach (int row in rows)
            {
                if (row % 2 == 0)
                {
                    row_even++;
                }
                else
                {
                    row_odd++;
                }
            }
            foreach (int col in cols)
            {
                if (col % 2 == 0)
                {
                    col_even++;
                }
                else
                {
                    col_odd++;
                }
            }
            return row_odd * m - col_odd * row_odd + row_even * m - col_even * row_even;
        }
        public static int[] DecompressRLElist(int[] nums)
        {
            if (nums.Length % 2 != 0 || nums.Length < 2) return null;
            List<int> res = new List<int>();
            for (int i = 0; i < nums.Length; i += 2)
            {
                for (int j = 0; j < nums[i]; j++)
                {
                    res.Add(nums[i + 1]);
                }
            }
            return res.ToArray();
        }
    }
}
