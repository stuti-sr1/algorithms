using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayCollection
{
    public static class _56MergeIntervals
    {
        public static int[][] Merge(int[][] intervals)
        {
            if (intervals.Length < 2) return intervals;
            var array = intervals.OrderBy(x => x[0]).ToArray();
            int[] temp = new int[2] { array[0][0], array[0][1] };
            List<int[]> res = new List<int[]>();
            for (int i = 1; i < array.Length; i++)
            {
                if (temp[1] >= array[i][0])
                {
                    temp[1] =Math.Max(temp[1], array[i][1]);
                }
                else
                {
                    res.Add(temp);
                    temp = new int[2] { array[i][0], array[i][1] };
                }
            }
            res.Add(temp);            
            return res.ToArray();
        }
    }
}
