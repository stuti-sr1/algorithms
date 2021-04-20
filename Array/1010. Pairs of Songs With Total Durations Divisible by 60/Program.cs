using System;
using System.Collections.Generic;

namespace _1010._Pairs_of_Songs_With_Total_Durations_Divisible_by_60
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = { 30, 20, 150, 100, 40 };
            Console.WriteLine(NumPairsDivisibleBy60(A));
            Console.ReadKey();
        }
        public static int NumPairsDivisibleBy60(int[] time)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();
            for (int i = 0; i < 60; i++)
            {
                map[i] = 0;
            }
            int res = 0;
            for (int i = 0; i < time.Length; i++)
            {
                int b = (60 - time[i] % 60) % 60;                
                res +=map[b];
                map[time[i] % 60]++;
            }
            return res;
        }
    }
}
