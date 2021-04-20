using System;

namespace _1016._Binary_String_With_Substrings_Representing_1_To_N
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(scoreOfParentheses("(()(()))"));
            Console.WriteLine(QueryString("0110",10)); 
            Console.ReadKey();
        }
        public static int scoreOfParentheses(String S)
        {
            int ans = 0, bal = 0;
            for (int i = 0; i < S.Length; ++i)
            {
                if (S[i] == '(')
                {
                    bal++;
                }
                else
                {
                    bal--;
                    if (S[i - 1] == '(')
                        ans += 1 << bal;
                }
            }
            return ans;
        }
        public static bool QueryString(string S, int N)
        {
            for (int i = 1; i <= N; i++)
            {
                if (!Generate(S, i))
                {
                    return false;
                }
            }
            return true;
        }
        private static bool Generate(string s, int decimalNumber)
        {
            int remainder;
            string result = string.Empty;
            while (decimalNumber > 0)
            {
                remainder = decimalNumber % 2;
                decimalNumber /= 2;
                result = remainder.ToString() + result;
            }
            Console.WriteLine("Binary:  {0}", result);
            if (s.Contains(result))
            {
                return true;
            }
            return false;
        }
    }
}
