using System;
using System.Collections.Generic;

namespace _1002._Find_Common_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] A = { "cool", "lock", "cook" };// { "bella", "label", "roller" };
            //string[] A = { "acabcddd", "bcbdbcbd", "baddbadb", "cbdddcac", "aacbcccd", "ccccddda", "cababaab", "addcaccd" };
            var t = CommonChars(A);
            Console.ReadKey();
        }
        public static IList<string> CommonChars(string[] A)
        {
            bool[] arr = new bool[26];
            for (int i = 0; i < 26; i++)
            {
                arr[i] = true;
            }
            foreach (string items in A)
            {
                bool[] sec = new bool[26];
                for (int i = 0; i < items.Length; i++)
                {
                    if (arr[items[i]-'a'])
                    {
                        sec[items[i]-'a'] = true;
                    }
                }
                Array.Copy(sec, arr, 26);
            }
            List<string> list = new List<string>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i])
                {
                    char m = Convert.ToChar(i+65);
                    list.Add(m.ToString());
                }
            }
            return list;
        }
    }
}
