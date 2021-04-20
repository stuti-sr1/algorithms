using System;
using System.Collections.Generic;
using System.Linq;

namespace _1029.TwoCityScheduling
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[,] stones = new int[,] { { 10, 20 }, { 30, 200 }, { 400, 50 }, { 30, 20 } };
            int[][] stones = new int[4][];
            stones[0] = new int[2] { 10, 20 };
            stones[1] = new int[2] { 30, 200 };
            stones[2] = new int[2] { 400, 50 };
            stones[3] = new int[2] { 30, 20 };
            //stones = new int[,] { { 259, 770 }, { 448, 54 }, { 926, 667 }, { 184, 139 }, { 840, 118 }, { 577, 469 } };
            //stones = new int[,] { { 945,563},{ 598,753},{ 558,341},{ 372,54},{ 39,522},{ 249,459},{ 536,264},{ 491,125},{ 367,118},{ 34,665},{ 472,410},{ 109,995},{ 147,436},{ 814,112},{ 45,545},{ 561,308},{ 491,504},{ 113,548},{ 626,104},{ 556,206},{ 538,592},{ 250,460},{ 718,134},{ 809,221},{ 893,641},{ 404,964},{ 980,751},{ 111,935} };
            int ans = TwoCitySchedCost2(stones);
            Console.WriteLine(ans);
            Console.ReadKey();
        }
        public static int TwoCitySchedCost2(int[][] costs)
        {
            int n = costs.GetLength(0);
            var sort = costs.OrderByDescending(x => x[1] - x[0]).ToArray();
            int sum = 0;
            for (int i = 0; i < n/2; i++)
            {
                sum += sort[i][0] + sort[n-i-1][1];
            }
            //foreach (var item in sort)
            //{
            //    if (count < n / 2) sum += item[0];
            //    else sum += item[1];
            //    count++;
            //}
            return sum;
        }
        public static int TwoCitySchedCost1(int[,] costs)
        {
            int n = costs.GetLength(0);
            Dictionary<int, Cost> diff1 = new Dictionary<int, Cost>();
            for (int i = 0; i < n; i++)
            {
                int diff = costs[i, 1] - costs[i, 0];
                diff1[i] = new Cost(diff, costs[i, 1], costs[i, 0]);
            }
            var t = diff1.OrderByDescending(x => x.Value.diff);
            int sum = 0;
            int count = 0;
            foreach (var item in t)
            {
                if (count < n / 2) sum += item.Value.B;
                else sum += item.Value.A;
                count++;
            }
            return sum;
        }
        public static int TwoCitySchedCost(int[,] costs)
        {
            int n = costs.GetLength(0);
            Dictionary<int, int> diff1 = new Dictionary<int, int>();
            for (int i = 0; i < n; i++)
            {
                diff1[i] = costs[i, 1] - costs[i, 0];
            }
            var list = diff1.Values.ToList();
            list = list.OrderByDescending(x => x).ToList();
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                int p = diff1.Where(x => x.Value == list[i]).FirstOrDefault().Key;
                if (i < n / 2)
                {
                    sum += costs[p, 0];
                }
                else
                {
                    sum += costs[p, 1];
                }
            }
            return sum;
        }
    }
    public class Cost
    {
        public int diff { get; set; }
        public int A { get; set; }
        public int B { get; set; }
        public Cost(int diff, int A, int B)
        {
            this.diff = diff;
            this.A = A;
            this.B = B;
        }
    }
}
