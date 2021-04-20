using System;
using System.Collections.Generic;

namespace _1160._Find_Words_That_Can_Be_Formed_by_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = { "hello", "world", "leetcode" };// { "cat", "bt", "hat", "tree" };
            string chars = "welldonehoneyr";// "atach";
            Console.WriteLine(CountCharacters(words, chars));
            Console.ReadKey();
        }

        public static int CountCharacters(string[] words, string chars)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();
            for (int i = 0; i < chars.Length; i++)
            {
                if (!map.ContainsKey(chars[i]))
                {
                    map[chars[i]] = 1;
                }
                else map[chars[i]]++;
            }
            int count = 0;
            foreach (var items in words)
            {
                if (items.Length > chars.Length)
                {
                    continue;
                }
                else
                {
                    var mapCopy = new Dictionary<int, int>();
                    for (int i = 0; i < items.Length; i++)
                    {
                        if (!mapCopy.ContainsKey(items[i]))
                        {
                            mapCopy[items[i]] = 1;
                        }
                        else mapCopy[items[i]]++;
                    }
                    bool flag = true;

                    foreach (var item in mapCopy)
                    {
                        if (map.ContainsKey(item.Key) && item.Value <= map[item.Key])
                        {
                            continue;
                        }
                        else
                        {
                            flag = false;
                            break;
                        }
                    }
                    if (flag)
                    {
                        count += items.Length;
                    }
                }
            }
            return count;
        }
        public static int CountCharacters1(string[] words, string chars)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();
            for (int i = 0; i < chars.Length; i++)
            {
                if (!map.ContainsKey(chars[i]))
                {
                    map[chars[i]] = 1;
                }
                else map[chars[i]]++;
            }
            int count = 0;
            foreach (var items in words)
            {
                if (items.Length > chars.Length)
                {
                    continue;
                }
                else
                {
                    Dictionary<int, int> mapCopy = new Dictionary<int, int>(map);
                    bool flag = true;
                    foreach (var item in items)
                    {
                        if (mapCopy.ContainsKey(item) && mapCopy[item] > 0)
                        {
                            mapCopy[item]--;
                        }
                        else
                        {
                            flag = false;
                            break;
                        }
                    }
                    if (flag)
                    {
                        count += items.Length;
                    }
                }
            }
            return count;
        }
    }
}
