using System;
using System.Collections.Generic;

namespace _443._String_Compression
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "()[]{}";
            Console.WriteLine(IsValid(s));

            // char[] str = { 'a', 'a', 'b', 'b', 'c', 'c', 'c' };
            //char[] str = { 'a' };
            char[] str = { 'a', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b' };
            Console.WriteLine(Compress(str));
            Console.ReadKey();
        }
        public static bool IsValid(string s)
        {
            Stack<char> st = new Stack<char>();
            foreach (char item in s)
            {
                if (item == '(' || item == '[' || item == '{')
                {
                    st.Push(item);
                }
                else
                {
                    if (st.Count > 0)
                    {
                        char peek = st.Peek();
                        if ((peek == '(' && item == ')') || (peek == '{' && item == '}') || (peek == '[' && item == ']'))
                        {
                            st.Pop();
                        }
                        else return false;
                    }
                    else return false;
                }
            }
            return st.Count > 0 ? false : true;
        }
        public static int Compress(char[] chars)
        {
            int len = chars.Length;
            int start = 0, end = 0;
            int count = 0, i = 0;
            while (start < len && end < len && i < len)
            {
                while (start < len && end < len && i < len && chars[start] == chars[end])
                {
                    count++;
                    end++;
                }
                chars[i] = chars[start];
                if (count > 1)
                {
                    foreach (char c in count.ToString().ToCharArray())
                    {
                        i++;
                        chars[i] = Convert.ToChar(c);
                    }
                }
                start = end;
                i++;
                count = 0;
            }
            return i;
        }
    }
}
