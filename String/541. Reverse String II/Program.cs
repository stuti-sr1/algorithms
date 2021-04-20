using System;
using System.Collections.Generic;
using System.Text;

namespace _541._Reverse_String_II
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] list = { "test.email+alex@leetcode.com", "test.e.mail+bob.cathy@leetcode.com", "testemail+david@lee.tcode.com" };
            Console.WriteLine(NumUniqueEmails(list));

            string r = "aa", m = "aab";
            Console.WriteLine(CanConstruct(r, m));

            string s = "a"; int k = 1;
            Console.WriteLine(ReverseStr(s, k));
            Console.ReadKey();
        }
        public static bool CanConstruct(string ransomNote, string magazine)
        {
            Dictionary<int, int> map = new Dictionary<int, int>(26);
            foreach (var item in magazine)
            {
                if (!map.ContainsKey(item - 'a'))
                {
                    map[item - 'a'] = 1;
                }
                else map[item - 'a']++;
            }
            foreach (var item in ransomNote)
            {
                if (!map.ContainsKey(item - 'a'))
                {
                    return false;
                }
                else
                {
                    map[item - 'a']--;
                    if (map[item - 'a'] < 0)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        public static string ReverseStr(string s, int k)
        {
            StringBuilder str = new StringBuilder(s);
            for (int i = 0; i < s.Length; i++)
            {
                int start = i, end = i + k - 1;
                end = end >= s.Length ? s.Length - 1 : end;
                char temp;
                while (start < end)
                {
                    temp = str[start];
                    str[start] = s[end];
                    str[end] = temp;
                    start++;
                    end--;
                }
                i += 2 * k - 1;
            }
            return str.ToString();
        }

        public static int NumUniqueEmails(string[] emails)
        {
            HashSet<string> map = new HashSet<string>();
            foreach (var email in emails)
            {
                int i = email.IndexOf('@');
                string domain = email.Substring(i);
                string local = email.Substring(0, i);
                local = local.Replace(".", "");
                int j = local.IndexOf('+');
                if (j >= 0)
                {
                    local = local.Substring(0, j);
                }
                local = local + domain;
                map.Add(local);
            }
            return map.Count;
        }

        public static int NumUniqueEmails2(string[] emails)
        {
            Dictionary<string, int> map = new Dictionary<string, int>();
            foreach (var email in emails)
            {
                int i = email.IndexOf('@');
                string domain = email.Substring(i);
                string local = email.Substring(0, i);
                local = local.Replace(".", "");
                int j = local.IndexOf('+');
                if (j >= 0)
                {
                    local = local.Substring(0, j);
                }
                local = local + domain;
                if (!map.ContainsKey(local))
                {
                    map[local] = 1;
                }
            }
            return map.Count;
        }
        public static int NumUniqueEmails1(string[] emails)
        {
            Dictionary<string, int> map = new Dictionary<string, int>();
            foreach (var email in emails)
            {
                StringBuilder str = new StringBuilder();
                for (int i = 0; i < email.Length; i++)
                {
                    if (email[i] == '@')
                    {
                        str.Append(email.Substring(i));
                        break;
                    }
                    else if (email[i] == '+')
                    {
                        while (email[i] != '@')
                        {
                            i++;
                        }
                        i--;
                    }
                    else if (email[i] == '.')
                    {
                        continue;
                    }
                    else
                    {
                        str.Append(email[i]);
                    }
                }
                if (!map.ContainsKey(str.ToString()))
                {
                    map[str.ToString()] = 1;
                }
            }
            return map.Count;
        }
    }
}
