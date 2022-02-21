using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringLeetCode
{
    public static class _49GroupAnagrams
    {
        //optimized  O(NK)
        public static IList<IList<string>> GroupAnagrams(string[] strs)
        {
            Dictionary<string, List<string>> map = new Dictionary<string, List<string>>();
            IList<IList<string>> res = new List<IList<string>>();
            int[] count = new int[26];            
            foreach (string str in strs)
            {
                for (int i = 0; i < 26; i++)
                {
                    count[i] = 0;
                }
                foreach (char c in str.ToCharArray())
                {
                    count[c - 'a']++;
                }
                StringBuilder s = new StringBuilder();
                for (int i = 0; i < 26; i++)
                {
                    s.Append('#');
                    s.Append(count[i]);
                }
                if (!map.ContainsKey(s.ToString()))
                {
                    map.Add(s.ToString(), new List<string>());
                }
                map[s.ToString()].Add(str);
            }
            foreach (var item in map)
            {
                var res1 = item.Value;
                res.Add(res1.ToList<string>());
            }
            return res;
        }


        //O(NKlogK)
        public static IList<IList<string>> GroupAnagrams1(string[] strs)
        {
            Dictionary<string, List<string>> map = new Dictionary<string, List<string>>();
            IList<IList<string>> res = new List<IList<string>>();
            List<string> newList = null;
            string[] sortedStr = new string[strs.Length];
            for (int i = 0; i < strs.Length; i++)
            {
                char[] item = strs[i].ToCharArray();
                Array.Sort(item);
                sortedStr[i] =new string(item);
                if (!map.ContainsKey(sortedStr[i]))
                {
                    newList = new List<string>();
                    newList.Add(strs[i]);   
                    map.Add(sortedStr[i], newList);
                }
                else
                {
                    newList = map[sortedStr[i]];
                    newList.Add(strs[i]);
                    map[sortedStr[i]] = newList;
                }
            }
            foreach (var item in map)
            {
                var res1 = item.Value;
                res.Add(res1.ToList<string>());
            }
            return res;
        }
    }
}
