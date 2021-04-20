using System;
using System.Collections.Generic;

namespace beautifulArray
{
    class Program
    {
        //For every i<j, there is no k with i<k<j such that A[k] * 2 = A[i] + A[j].
        //Given N, return any beautiful array A.  (It is guaranteed that one exists.)
        static Dictionary<int, int[]> map;
        
        static void Main(string[] args)
        {
            int N = 5;
            map = new Dictionary<int, int[]>();
            Console.WriteLine(FunA(N));
            Console.ReadKey();
        }
        private static int[] FunA(int N)
        {
            if (map.ContainsKey(N)) return map[N].GetValue();
            int[] arr = new int[N];
            if (N == 1)
            {
                arr[0] = 1;
            }
            else
            {
                int t = 0;
                int odd = FunA((N + 1) / 2);
                int even = FunA(N / 2);
                for (int i = 0; i < odd; i++)
                {
                    arr[t++] = 2 * i - 1;
                }
                for (int i = 0; i < even; i++)
                {
                    arr[t++] = 2 * i;
                }
            }
            map.Add(N, arr);
            return arr;
        }
    }
}
