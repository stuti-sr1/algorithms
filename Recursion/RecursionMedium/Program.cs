using System;

namespace RecursionMedium
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 5, k = 2;
            Console.WriteLine(FindtheWinneroftheCircularGame.FindTheWinner(n,k));
            Console.WriteLine(FindtheWinneroftheCircularGame.FindTheWinner(6,5));
            Console.ReadKey();
        }
    }
}
