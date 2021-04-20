using System;
using System.Collections.Generic;
using System.Text;

namespace String
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "loonbalxballpoon";
            Console.WriteLine(MaxNumberOfBalloons(s));
            Console.ReadKey();
        }
        public static int MaxNumberOfBalloons(string text)
        {
            string word = "balloon";
            Dictionary<char, int> map = new Dictionary<char, int>();
            Dictionary<char, int> newmap = new Dictionary<char, int>();
            for (int i = 0; i < word.Length; i++)
            {
                if (!map.ContainsKey(word[i]))
                {
                    map[word[i]] = 1;
                }
                else map[word[i]]++;
            }
            for (int i = 0; i < text.Length; i++)
            {
                if (map.ContainsKey(text[i]))
                {
                    if (!newmap.ContainsKey(text[i]))
                    {
                        newmap[text[i]] = 1;
                    }
                    else newmap[text[i]]++;
                }
            }
            int mincount = int.MaxValue;
            foreach (var item in map)
            {
                if (newmap.ContainsKey(item.Key) && newmap[item.Key] >= item.Value)
                {
                    int t = newmap[item.Key] / item.Value;
                    mincount = Math.Min(mincount, t);
                }
                else return 0;
            }
            if (mincount==int.MaxValue)
            {
                return 0;
            }
            return mincount;
        }
    }
}
