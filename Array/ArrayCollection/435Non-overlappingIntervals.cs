using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayCollection
{
    public static class _435Non_overlappingIntervals
    {
        //intervals = [[1,2],[2,3],[3,4],[1,3]]
        public static int EraseOverlapIntervals(int[][] t)
        {
            var intervals = t.OrderBy(x => x[0]).ToArray();
            int left = 0;
            int right = 1;
            int count = 0;
            while (right < intervals.Length)
            {
                if (intervals[left][1] <= intervals[right][0]) //non overlapping
                {
                    left = right;
                    right++;
                }
                else if (intervals[left][1] <= intervals[right][1]) // half overlapping
                {
                    right++;
                    count++;
                }
                else if (intervals[left][1] > intervals[right][1]) //full overlaping
                {
                    left = right;
                    right++;
                    count++;
                }
            }
            return count;
        }
    }
}
