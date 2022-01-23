using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayCollection
{
    public static class _57InsertInterval
    {
        public static int[][] Insert(int[][] intervals, int[] newInterval)
        {
            int[] temp = new int[2] { newInterval[0], newInterval[1] };
            List<int[]> res = new List<int[]>();
            foreach (var interval in intervals)
            {
                if (temp[0] > interval[1])
                {
                    res.Add(interval);
                }
                else if (temp[1] < interval[0])
                {
                    res.Add(temp);
                    temp = new int[] { interval[0], interval[1] };
                }
                else
                {
                    temp[0] = Math.Min(temp[0], interval[0]);
                    temp[1] = Math.Max(temp[1], interval[1]);
                }
            }
            res.Add(temp);
            return res.ToArray();
        }
        //second approach

        public static int[][] Insert2(int[][] intervals, int[] newInterval)
        {
            List<int[]> array = new List<int[]>();
            int[] temp = new int[2] { array[0][0], array[0][1] };
            List<int[]> res = new List<int[]>();
            for (int i = 1; i < array.Count; i++)
            {
                if (temp[1] >= array[i][0])
                {
                    temp[1] = Math.Max(temp[1], array[i][1]);
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

        //third approach

        public static int[][] Insert3(int[][] intervals, int[] newInterval)
        {
            List<int[]> array = new List<int[]>();
            bool flag = false;
            foreach (var interval in intervals)
            {
                if (interval[0] >= newInterval[0] && flag == false)
                {
                    flag = true;
                    array.Add(new int[] { newInterval[0], newInterval[1] });
                }
                array.Add(new int[] { interval[0], interval[1] });
            }
            if (intervals.Length + 1 != array.Count)
            {
                array.Add(new int[] { newInterval[0], newInterval[1] });
            }

            int[] temp = new int[2] { array[0][0], array[0][1] };
            List<int[]> res = new List<int[]>();
            for (int i = 1; i < array.Count; i++)
            {
                if (temp[1] >= array[i][0])
                {
                    temp[1] = Math.Max(temp[1], array[i][1]);
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

        //public static int[][] Insert(int[][] intervals, int[] newInterval)
        //{    
        //    var t = intervals.ToList();
        //    t.Add(new int[] { newInterval[0], newInterval[1] });
        //    var array = t.OrderBy(x => x[0]).ToArray();
        //    int[] temp = new int[2] { array[0][0], array[0][1] };
        //    List<int[]> res = new List<int[]>();
        //    for (int i = 1; i < array.Length; i++)
        //    {
        //        if (temp[1] >= array[i][0])
        //        {
        //            temp[1] = Math.Max(temp[1], array[i][1]);
        //        }
        //        else
        //        {
        //            res.Add(temp);
        //            temp = new int[2] { array[i][0], array[i][1] };
        //        }
        //    }
        //    res.Add(temp);
        //    return res.ToArray();
        //}
    }
}
