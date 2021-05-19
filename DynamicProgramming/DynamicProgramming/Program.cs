using System;

namespace DynamicProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] coins = { 1, 2, 5 };
            //int amount = 11;
            int[] coins = { 2};
            int amount = 3;
            Console.WriteLine(CoinChange.CoinChangeFun(coins, amount));
            Console.ReadKey();
        }
    }
}
