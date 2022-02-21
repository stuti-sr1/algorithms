using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringLeetCode
{
    public static class _242ValidAnagram
    {
        public static bool IsAnagram(string s, string t)
        {
            if (s.Length != t.Length) return false;
            Dictionary<char, int> map = new Dictionary<char, int>();
            foreach (char str in s)
            {
                if (!map.ContainsKey(str))
                {
                    map.Add(str, 1);
                }
                else map[str]++;
            }

            foreach (char str in t)
            {
                if (!map.ContainsKey(str))
                {
                    return false;
                }
                else map[str]--;
                if (map[str] < 0) return false;
            }
            return true;
        }
    }
}
