using System;
using System.Collections.Generic;
using System.Linq;

namespace _937._Reorder_Data_in_Log_Files
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] logs = { "dig1 8 1 5 1", "let1 art can", "dig2 3 6", "let2 own kit dig", "let3 art zero" };
            string[] logs = { "a1 9 2 3 1","g1 act car","zo4 4 7","ab1 off key dog","a8 act zoo","a2 act car"};
            var t = ReorderLogFiles(logs);
            foreach (var item in t)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
        public static string[] ReorderLogFiles(string[] logs)
        {
            List<string> mapLetter = new List<string>();
            List<string> mapDigit = new List<string>();
            foreach (var item in logs)
            {
                int len = item.Length;
                if (item[len-1] >= 48 && item[len-1] <=57 )
                {
                    mapDigit.Add(item);
                }
                else
                {
                    mapLetter.Add(item);
                }
            }
            mapLetter = mapLetter.OrderBy(x => x).ToList();
            var t = mapLetter.OrderBy(x => x.Split(" ",2)).ToList();
            mapLetter.AddRange(mapDigit);
            string[] res = mapLetter.ToArray();
            return res;
        }

    }
}
