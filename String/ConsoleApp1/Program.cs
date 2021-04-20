using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {


            string[] queries = { "bbb", "cc" }, words = { "a", "aa", "aaa", "aaaa" };
            Console.WriteLine(NumSmallerByFrequency(queries, words));
            Console.WriteLine(ToGoatLatin("I speak Goat Latin"));
            Console.ReadKey();
        }

        public static int[] NumSmallerByFrequency(string[] queries, string[] words)
        {
            int max = int.MinValue;
            Dictionary<char, int> map = new Dictionary<char, int>();
            Dictionary<char, int> mapq = new Dictionary<char, int>();
            foreach (string word in words)
            {
                int val = NewMethod(map, word);
                max = max < val ? val : max;
            }
            List<int> res = new List<int>();
            int count = 0;
            foreach (var query in queries)
            {
                count++;
                int val = NewMethod(mapq, query);
                if (max > val)
                {
                    res.Add(count);
                }
            }
            return res.ToArray();
        }

        private static int NewMethod(Dictionary<char, int> map, string word)
        {
            foreach (char item in word)
            {
                if (!map.ContainsKey(item))
                {
                    map[item] = 1;
                }
                else map[item]++;
            }
            int val = map.OrderBy(x => x.Key).FirstOrDefault().Value;
            CallFun(map);
            return val;
        }

        private static void CallFun(Dictionary<char, int> map)
        {
            for (int i = 0; i < 26; i++)
            {
                map[Convert.ToChar('a' + i)] = 0;
            }
        }

        public static string ToGoatLatin(string S)
        {
            string[] str = S.Split(" ");
            string newstr = string.Empty;
            int i = 1, k = 0;
            foreach (string item in str)
            {
                char t = item.ToString().ToLower()[0];
                if (t == 'a' || t == 'e' || t == 'i' || t == 'o' || t == 'u')
                {
                    newstr += item + "ma";
                }
                else
                {
                    newstr += item.Substring(1) + item[0] + "ma";
                }
                k = i;
                while (k > 0)
                {
                    newstr += 'a';
                    k--;
                }
                newstr += " ";
                i++;
                k = 0;
            }
            return newstr.TrimEnd();
        }
    }
}
