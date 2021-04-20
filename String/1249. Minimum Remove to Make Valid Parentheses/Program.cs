using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1249._Minimum_Remove_to_Make_Valid_Parentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MinRemoveToMakeValid("lee(t(c)o)de)"));
            Console.ReadKey();
        }
        public static string MinRemoveToMakeValid(string s)
        {
            StringBuilder result = removeInvalidClosing(s, '(', ')');
            char[] array = result.ToString().ToCharArray();
            Array.Reverse(array);
            result = removeInvalidClosing(new string(array), ')', '(');
            array = result.ToString().ToCharArray();
            Array.Reverse(array);
            return new string(array);
        }
        private static StringBuilder removeInvalidClosing(string s, char open, char close)
        {
            StringBuilder sb = new StringBuilder();
            int balance = 0;
            for (int i = 0; i < s.Length; i++)
            {
                char c = s[i];
                if (c == open)
                {
                    balance++;
                }
                if (c == close)
                {
                    if (balance == 0) continue;
                    balance--;
                }
                sb.Append(c);
            }
            return sb;
        }
        private static StringBuilder removeInvalidClosing1(string s, char open, char close)
        {
            StringBuilder sb = new StringBuilder();
            int balance = 0;
            for (int i = s.Length - 1; i >= 0; i--)
            {
                char c = s[i];
                if (c == open)
                {
                    balance++;
                }
                if (c == close)
                {
                    if (balance == 0) continue;
                    balance--;
                }
                sb.Append(c);
            }
            return sb;
        }

        public static string MinRemoveToMakeValid1(string s)
        {
            List<int> removIndex = new List<int>();
            Stack<int> st = new Stack<int>();
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(')
                {
                    st.Push(i);
                }
                else if (s[i] == ')')
                {
                    if (st.Count > 0)
                    {
                        st.Pop();
                    }
                    else
                    {
                        removIndex.Add(i);
                    }
                }
            }
            while (st.Count > 0)
            {
                removIndex.Add(st.Pop());
            }
            StringBuilder str = new StringBuilder();
            for (int i = 0; i < s.Length; i++)
            {
                if (!removIndex.Contains(i))
                {
                    str.Append(s[i]);
                }
            }
            return str.ToString();
        }
    }
}
