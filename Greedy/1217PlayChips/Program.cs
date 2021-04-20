using System;

namespace _1217PlayChips
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] s = new int[] { 1, 2, 3 };
            s = new int[] { 2, 2, 2, 3, 3 };
            s = new int[] { 1, 2, 2, 2, 2 };
            int ans = MinCostToMoveChips(s);
            Console.WriteLine(ans);
            Console.ReadKey();
        }
        public static int MinCostToMoveChips(int[] chips)
        {
            int odd = 0, even = 0;
            for (int i = 0; i < chips.Length; i++)
            {
                var t = chips[i] % 2 == 0 ? even++ : odd++;
            }
            return Math.Min(odd, even);
        }
    }
}
