using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayCollection
{
    public static class _495TeemoAttacking
    {
        public static int FindPoisonedDuration1(int[] timeSeries, int duration)
        {
            int count = 0;
            for (int i = 1; i < timeSeries.Length; i++)
            {
                count += Math.Min(duration, timeSeries[i] - timeSeries[i - 1]);
            }
            return count + duration;
        }

        //solved with merge interval
        public static int FindPoisonedDuration(int[] timeSeries, int duration)
        {
            List<int[]> intervals = new List<int[]>();
            foreach (var timeSerie in timeSeries)
            {
                intervals.Add(new int[] { timeSerie, timeSerie + duration - 1 });
            }
            int[] temp = new int[2] { intervals[0][0], intervals[0][1] };
            //List<int[]> res = new List<int[]>();
            int count = 0;
            for (int i = 1; i < intervals.Count; i++)
            {
                if (temp[1] < intervals[i][0])
                {
                    count += temp[1] - temp[0] + 1;
                    //res.Add(temp);
                    temp = new int[] { intervals[i][0], intervals[i][1] };
                }
                else
                {
                    temp[1] = Math.Max(temp[1], intervals[i][1]);
                }
            }
            //res.Add(temp);
            count += temp[1] - temp[0] + 1;
            return count;
        }
    }
}
