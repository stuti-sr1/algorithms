using System;
using System.Collections.Generic;
using System.Linq;

namespace _1086._High_Five
{
    class Program
    {
        static void Main(string[] args)
        {
            var y = HighFive();
            //{{1,91],{1,92],{2,93],{2,97],{1,60],{2,77],{1,65],{1,87],{1,100],{2,100],{2,76]]
            Console.WriteLine("Hello World!");
        }
        public static int[,] HighFive()
        {
            int[,] items = { { 1, 91 }, { 1, 92 }, { 2, 93 }, { 2, 97 }, { 1, 60 }, { 2, 77 }, { 1, 65 }, { 1, 87 }, { 1, 100 }, { 2, 100 }, { 2, 76 } };
            Dictionary<int, List<int>> map = new Dictionary<int, List<int>>();
            List<int> list;
            for (int i = 0; i < items.GetLength(0); i++)
            {
                if (!map.ContainsKey(items[i, 0]))
                {
                    list = new List<int>();
                }
                else
                {
                    list = map[items[i, 0]];
                }
                list.Add(items[i, 1]);
                map[items[i, 0]] = list.OrderByDescending(x => x).ToList();
            }
            foreach (var item in map)
            {
                if (item.Value.Count >= 5)
                {
                    int sum = item.Value.Take(5).Sum() / 5;
                }
            }
            return null;
        }
    }
}
