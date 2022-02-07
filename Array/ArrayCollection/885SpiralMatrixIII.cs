using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayCollection
{
    public static class _885SpiralMatrixIII
    {
        //5,6,1,4
        public static int[][] SpiralMatrixIII(int rows, int cols, int rStart, int cStart)
        {
            List<int[]> res = new List<int[]>();
            res.Add(new int[] { rStart, cStart });
            int[] d1 = { 0, 1 };
            int[] d2 = { 1, 0 };
            int[] d3 = { 0, -1 };
            int[] d4 = { -1, 0 };
            int[][] direction = { d1, d2, d3, d4 };
            int len = 0;
            int d = 0;
            int r = rStart;
            int c = cStart;
            while (res.Count < rows * cols)
            {
                if (d == 0 || d == 2) len++;
                for (int i = 0; i < len; i++)
                {
                    r += direction[d][0];
                    c += direction[d][1];
                    if (r >= 0 && r < rows && c >= 0 && c < cols)
                    {
                        res.Add(new int[] { r, c });
                    }
                }
                d = (d + 1) % 4;
            }
            return res.ToArray();
        }
    }
}
