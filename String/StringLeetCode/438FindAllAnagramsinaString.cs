using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringLeetCode
{
    public static class _438FindAllAnagramsinaString
    {
        public static IList<int> FindAnagrams(string s, string p)
        {
            List<int> res = new List<int>();
            if (s.Length < p.Length) return res;
            int len = p.Length;

            int[] count = new int[26];
            foreach (char c in p.ToCharArray())
            {
                count[c - 'a']++;
            }
            StringBuilder newP = new StringBuilder();
            for (int i = 0; i < 26; i++)
            {
                newP.Append(count[i]);
            }
            int[] newCount = new int[26];
            StringBuilder newStr;
            for (int i = 0; i < s.Length; i++)
            {
                if (Math.Abs(i - len) < 0) break;
                newCount[s[i] - 'a']++;
                if (i >= len)
                    newCount[s[i - len] - 'a']--;
                newStr = new StringBuilder();
                for (int j = 0; j < 26; j++)
                {
                    newStr.Append(newCount[j]);
                }
                if (newStr.ToString() == newP.ToString())
                    res.Add(i - len + 1);
            }
            return res;
        }

        //public static IList<int> FindAnagrams(string s, string p)
        //{
        //    List<int> res = new List<int>();
        //    if (s.Length < p.Length) return res;
        //    int len = p.Length;
        //    string original = GetNewStringBuilder(p);

        //    int[] newCount = new int[26];
        //    for (int i = 0; i < len; i++)
        //    {
        //        newCount[s[i] - 'a']++;
        //    }

        //    StringBuilder newStr = new StringBuilder();
        //    for (int j = 0; j < 26; j++)
        //    {
        //        newStr.Append('#');
        //        newStr.Append(newCount[j]);
        //    }
        //    if (newStr.ToString() == original) res.Add(0);

        //    for (int i = len; i < s.Length; i++)
        //    {
        //        if (Math.Abs(i - len) < 0) break;
        //        newCount[s[i] - 'a']++;
        //        newCount[s[i - len] - 'a']--;
        //        newStr = new StringBuilder();
        //        for (int j = 0; j < 26; j++)
        //        {
        //            newStr.Append('#');
        //            newStr.Append(newCount[j]);
        //        }
        //        if (newStr.ToString() == original)
        //            res.Add(i - len + 1);
        //    }
        //    return res;
        //}


        public static IList<int> FindAnagrams1(string s, string p)
        {
            string original = GetNewStringBuilder(p);
            List<int> res = new List<int>();
            int len = p.Length;
            for (int i = 0; i < s.Length; i++)
            {
                if (i + len > s.Length) break;
                string t = s.Substring(i, len);
                string newValue = GetNewStringBuilder(t);
                if (newValue == original)
                    res.Add(i);
            }
            return res;
        }

        private static string GetNewStringBuilder(string p)
        {
            int[] count = new int[26];
            foreach (char c in p.ToCharArray())
            {
                count[c - 'a']++;
            }
            StringBuilder newStr = new StringBuilder();
            for (int i = 0; i < 26; i++)
            {
                newStr.Append('#');
                newStr.Append(count[i]);
            }
            return newStr.ToString();
        }
    }
}
