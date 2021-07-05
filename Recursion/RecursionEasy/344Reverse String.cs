using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursionEasy
{
    public static class ReverseStringFun
    {
        //public static void ReverseString(char[] s)
        //{
        //    int len = s.Length;
        //    for (int i = 0; i < len/2; i++)
        //    {
        //        char temp = s[i];
        //        s[i] = s[len - 1 - i];
        //        s[len - 1 - i] = temp;
        //    }
        //    Console.WriteLine(s);
        //}

        public static void ReverseString(char[] s)
        {
            helper(s, 0, s.Length - 1);
            Console.WriteLine(s);
        }

        private static void helper(char[] s, int start, int end)
        {
            if (start >= end) return;
            char temp = s[start];
            s[start] = s[end];
            s[end] = temp;
            helper(s, ++start, --end);
        }
    }
}
