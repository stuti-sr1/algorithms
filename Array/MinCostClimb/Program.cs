using System;

namespace MinCostClimb
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] cost = { 1, 100, 1, 1, 1, 100, 1, 1, 100, 1 };
            //int[] cost = { 10, 15, 20 };
            Console.WriteLine(MinCostClimbingStairs(cost));
            Console.ReadKey();
        }

        public static int MinCostClimbingStairs(int[] cost)
        {
            int n = cost.Length;
            return Math.Min(MinCostClimbingStairsFun(cost, n - 1, n), MinCostClimbingStairsFun(cost, n - 2, n));
        }

        private static int MinCostClimbingStairsFun(int[] cost, int index, int n)
        {
            if (index == 0 || index == 1) { return cost[index]; }
            int v1 = MinCostClimbingStairsFun(cost, index - 1, n);
            int v2 = MinCostClimbingStairsFun(cost, index - 2, n);
            return cost[index] + Math.Min(v1, v2);
        }
    }
}
