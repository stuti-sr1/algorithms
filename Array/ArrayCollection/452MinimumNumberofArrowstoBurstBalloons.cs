using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayCollection
{
    public static class _452MinimumNumberofArrowstoBurstBalloons
    {
        public static int FindMinArrowShots(int[][] points)
        {
            var intervals = points.OrderBy(x => x[0]).ToArray();
            int arrow = 1;
            int end = intervals[0][1];
            for (int i = 1; i < intervals.Length; i++)
            {
                if (intervals[i][0] > end)
                {
                    arrow++;
                    end = intervals[i][1];
                }
                else
                {
                    end = Math.Min(end, intervals[i][1]);
                }
            }
            return arrow;
        }        
    }
}
