using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    public static class TheKWeakestRowsInAMatrix
    {
        public static int[] KWeakestRows(int[][] mat, int k)
        {
            IDictionary<int, int> map = new Dictionary<int, int>();
            int i = 0;
            foreach (var matRow in mat)
            {
                map[i++] = BinarySearchFun(matRow);
            }
            return map.OrderBy(x => x.Value).Select(y => y.Key).Take(k).ToArray();
        }

        private static int BinarySearchFun(int[] matRow)
        {
            int mid = 0, l = 0, h = matRow.Length-1;
            int len = h;
            while (l <= h)
            {
                mid = l + (h - l) / 2;
                if (matRow[mid] == 1 && (mid == len || matRow[mid + 1] == 0))
                {
                    return mid + 1;
                }
                else if (matRow[mid] == 1) l = mid + 1;
                else h = mid - 1;
            }
            return mid;
        }
        //public static int[] KWeakestRows(int[][] mat, int k)
        //{
        //    IDictionary<int, int> map = new Dictionary<int, int>();
        //    int i = 0;
        //    foreach (var matRow in mat)
        //    {
        //        int soldierCount = 0;
        //        foreach (int col in matRow)
        //        {
        //            if (col == 1) soldierCount++;
        //            else break;
        //        }
        //        map[i++] = soldierCount;
        //    }
        //    return map.OrderBy(x => x.Value).Select(y => y.Key).Take(k).ToArray();
        //}
    }
}
