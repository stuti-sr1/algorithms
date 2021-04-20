using System;
using System.Collections.Generic;
using System.Linq;

namespace _609._Find_Duplicate_File_in_System
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] str = { "root/a 1.txt(abcd) 2.txt(efgh)", "root/c 3.txt(abcd)", "root/c/d 4.txt(efgh)", "root 4.txt(efgh)" };
            Console.WriteLine(FindDuplicate(str));
            Console.ReadKey();
        }
        public static IList<IList<string>> FindDuplicate(string[] paths)
        {
            IDictionary<string, List<string>> map = new Dictionary<string, List<string>>();
            foreach (var item in paths)
            {
                string[] str = item.Split(" ");
                int i = 1;
                while (i < str.Length)
                {
                    int startIndex = str[i].IndexOf("(");
                    int endIndex = str[i].IndexOf(")");
                    string key = str[i].Substring(startIndex + 1, endIndex - startIndex - 1);
                    List<string> list;
                    if (!map.ContainsKey(key))
                    {
                        list = new List<string>();
                    }
                    else
                    {
                        list = map[key];
                    }
                    list.Add(str[0] + "/" + str[i].Substring(0, startIndex));
                    map[key] = list;
                    i++;
                }
            }
            List<IList<string>> res = new List<IList<string>>();
            foreach (var items in map)
            {
                if (items.Value.Count > 1)
                {
                    res.Add(items.Value);
                }
            }
            return res;
        }
    }
}
