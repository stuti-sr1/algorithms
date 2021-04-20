using System;
using System.Collections.Generic;

namespace ConsoleApp113._Roman_to_Integer
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(RomanToInt("III"));
            //Console.WriteLine(RomanToInt("IV"));
            Console.WriteLine(RomanToInt("MCMXCIV"));
            Console.ReadKey();
        }
        public static int RomanToInt(string s)
        {
            Dictionary<char, int> map = new Dictionary<char, int>();
            map.Add('I', 1);
            map.Add('V', 5);
            map.Add('X', 10);
            map.Add('L', 50);
            map.Add('C', 100);
            map.Add('D', 500);
            map.Add('M', 1000);
            int len = s.Length - 1;
            int[] value = new int[len];
            int last_value = map[s[len]];
            int current_value;
            int res = last_value;
            for (int i = len - 1; i >= 0; i--)
            {
                current_value = map[s[i]];
                if (last_value > current_value)
                {
                    res -= current_value;
                }
                else
                    res += current_value;
                last_value = current_value;
            }
            return res;
        }
    }
}
