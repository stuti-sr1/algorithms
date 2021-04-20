using System;
using System.Collections.Generic;
using System.Linq;

namespace _973._K_Closest_Points_to_Origin
{
    class Program
    {
        static void Main(string[] args)
        {
            f();
            int[][] a = new int[2][];// { { 1, 3 },{-2, 2} };
            a[0] = new int[] { 0, 1 };//{ 1, 3 };
            a[1] = new int[] { 1, 0 };//{ -2, 2 };
            //a[0] = new int[] { 3, 3 };
            //a[1] = new int[] { 5, -1 };
            //a[2] = new int[] { -2, 4 };
            int k = 2;
            Console.WriteLine(KClosest(a, k));
            Console.ReadKey();
        }
        public static int[][] KClosest(int[][] points, int K)
        {
            Dictionary<int[], double> map = new Dictionary<int[], double>();
            for (int i = 0; i < points.GetLength(0); i++)
            {
                double v = (int)(Math.Pow(points[i][0], 2) + Math.Pow(points[i][1], 2));
                map[points[i]] = v;
            }
            return map.OrderBy(x => x.Value).Select(x => x.Key).Take(K).ToArray();
        }
        public static void f()
        {
            int N = 5;
            List<int> res = new List<int>();
            res.Add(1);
            while (res.Count < N)
            {
                List<int> temp = new List<int>();
                for (int i = 1; i <= res.Count; i++)
                {
                    if (i * 2 - 1 <= N)
                        temp.Add(i * 2 - 1);
                }
                for (int i = 1; i <= res.Count; i++)
                {
                    if (i * 2  <= N)
                        temp.Add(i * 2);
                }
                res = temp;
            }
            int y = 0;
            //return res.ToArray;
        }

    }
}
