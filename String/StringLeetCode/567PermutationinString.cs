using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringLeetCode
{
    public static class _567PermutationinString
    {
        public static bool CheckInclusion(string s1, string s2)
        {
            if (s1.Length > s2.Length) return false;
            int[] mapS1 = new int[26];
            int[] mapS2 = new int[26];
            StringBuilder strS1 = new StringBuilder();
            foreach (char item in s1)
            {
                mapS1[item - 'a']++;
            }
            foreach (int item in mapS1)
            {
                strS1.Append(item);
            }

            StringBuilder strS2;
            int lenS1 = s1.Length;
            for (int i = 0; i < s2.Length; i++)
            {
                mapS2[s2[i] - 'a']++;
                if (i >= lenS1)
                {
                    mapS2[s2[i - lenS1] - 'a']--;
                }
                strS2 = new StringBuilder();
                foreach (int item in mapS2)
                {
                    strS2.Append(item);
                }
                if (strS1.ToString() == strS2.ToString())
                {
                    return true;
                }
            }
            return false;
        }
        public static bool CheckInclusion1(string s1, string s2)
        {
            if (s1.Length > s2.Length) return false;
            int lenS1 = s1.Length;
            int[] mapS1 = new int[26];
            int[] mapS2 = new int[26];
            StringBuilder strS1 = new StringBuilder();
            StringBuilder strS2 = new StringBuilder();
            for (int i = 0; i < lenS1; i++)
            {
                mapS1[s1[i] - 'a']++;
                mapS1[s2[i] - 'a']++;
            }
            for (int i = 0; i < 26; i++)
            {
                strS1.Append(mapS1[i]);
                strS2.Append(mapS2[i]);
            }
            if (strS1.ToString() == strS2.ToString()) return true;            

            for (int i = lenS1; i < s2.Length; i++)
            {
                mapS2[s2[i] - 'a']++;
                mapS2[s2[i - lenS1] - 'a']--;                
                strS2 = new StringBuilder();
                foreach (int item in mapS2)
                {
                    strS2.Append(item);
                }
                if (strS1.ToString() == strS2.ToString())
                {
                    return true;
                }
            }
            return false;
        }
    }
}
