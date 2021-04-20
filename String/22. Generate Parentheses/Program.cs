using System;
using System.Collections.Generic;

namespace _22._Generate_Parentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GenerateParenthesis(3));
            Console.ReadKey();
        }
        public static IList<string> GenerateParenthesis(int n)
        {
            List<string> ans = new List<string>();
            GenerateParenthesisDP(ans, "", 0, 0, n);
            return ans;
        }

        private static void GenerateParenthesisDP(IList<string> ans, string cur, int open, int close, int n)
        {
            if (cur.Length == n * 2)
            {
                ans.Add(cur);
                return;
            }
            if (open < n)
            {
                GenerateParenthesisDP(ans, cur + "(", open + 1, close, n);
            }
            if (close < open)
            {
                GenerateParenthesisDP(ans, cur + ")", open, close + 1, n);
            }
        }
    }
}
