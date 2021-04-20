using System;
using System.Collections.Generic;

namespace numberOfShip
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] topRight = { 4,4 };
            int[] bottomLeft = { 0, 0 };
            Sea sea = new Sea();
            Console.WriteLine(CountShips(sea, topRight, bottomLeft));
            Console.ReadKey();
        }
        public static int CountShips(Sea sea, int[] topRight, int[] bottomLeft)
        {
            if (!sea.HasShips(topRight, bottomLeft)) return 0;
            if (topRight[0] == bottomLeft[0] && topRight[1] == bottomLeft[1]) return 1;

            int midx = (topRight[0] + bottomLeft[0]) / 2;
            int midy = (topRight[1] + bottomLeft[1]) / 2;
            return CountShips(sea, new int[] { midx, midy }, bottomLeft)
                 + CountShips(sea, new int[] { midx, topRight[1] }, new int[] { bottomLeft[0], midy + 1 })
                 + CountShips(sea, topRight, new int[] { midx + 1, midy + 1 })
                 + CountShips(sea, new int[] { topRight[0], midy }, new int[] { midx + 1, bottomLeft[1] });
        }
    }

    public class Sea
    {
        List<int[]> list;
        public Sea()
        {
            list = new List<int[]>();
            list.Add(new int[] { 1, 1 });
            list.Add(new int[] { 2, 2 });
            list.Add(new int[] { 3, 3 });
            list.Add(new int[] { 5, 5 });
        }
        public bool HasShips(int[] topRight, int[] bottomLeft)
        {
            int low = bottomLeft[1];
            int top = topRight[1];
            int left = bottomLeft[0];
            int right = topRight[0];
            foreach (var item in list)
            {
                if ((item[0] <= top && item[0] >= low && item[0] >= left && item[0] <= right) &&
                    (item[1] <= top && item[1] >= low && item[1] >= left && item[1] <= right))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
