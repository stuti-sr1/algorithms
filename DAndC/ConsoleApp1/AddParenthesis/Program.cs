using System;
using System.Collections.Generic;

namespace AddParenthesis
{
    class Program
    {
        static void Main(string[] args)
        {
            //string a = "2-1-1";
            string a = "2*3-4*5";

            var t = DiffWaysToCompute(a);
            foreach (var item in t)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }

        private static IList<int> DiffWaysToCompute(string a)
        {
            IList<int> result = new List<int>();
            if (String.IsNullOrEmpty(a) || a.Length == 0) return result;
            for (int i = 0; i < a.Length; i++)
            {
                if (!IsOperator(a[i]))
                {
                    continue;
                }
                var l = DiffWaysToCompute(a.Substring(0, i));
                var r= DiffWaysToCompute(a.Substring(i+1));
                foreach (var left in l)
                {
                    foreach (var right in r)
                    {
                        int sum = Cal(left, right, a[i]);
                        result.Add(sum);
                    }
                }
            }
            if (result.Count==0)
            {
                result.Add(int.Parse(a));                
            }
            return result;
        }

        private static int Cal(int left, int right, char c)
        {
            switch(c)
            {
                case '+': return left + right;
                case '-': return left - right;
                case '*': return left * right;
                default:
                    return 0;
            }
        }

        private static bool IsOperator(char v)
        {
            switch (v)
            {
                case '+': return true;
                case '-': return true;
                case '*': return true;
                default:
                    return false;
            }
        }
        
    }
}
