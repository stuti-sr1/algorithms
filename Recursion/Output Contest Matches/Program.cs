using System;
using System.Collections.Generic;

namespace Output_Contest_Matches
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FindContestMatch(2));
            Console.WriteLine("Hello World!");
        }
        public static string FindContestMatch(int n)
        {
            if (n % 2 != 0) return string.Empty;
            Dictionary<int, int> map = new Dictionary<int, int>();

        }
    }
}
