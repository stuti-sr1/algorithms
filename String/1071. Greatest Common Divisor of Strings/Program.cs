using System;

namespace _1071._Greatest_Common_Divisor_of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            String str1 = "ABABAB", str2 = "ABAB";
            Console.WriteLine(GcdOfStrings(str1, str2));
            Console.ReadKey();
        }
        public static string GcdOfStrings(string str1, string str2)
        {
            if (str1+str2 !=str2+str1)
            {
                return "";
            }
            int l1 = str1.Length;
            int l2 = str2.Length;
            int gcd = GCD(l1, l2);
            if (l1>l2)
            {
                return str1.Substring(0, gcd);
            }
            return str2.Substring(0, gcd);
        }

        public static int GCD(int n, int m)
        {
            if (m == 0)
            {
                return n;
            }
            return n % m == 0 ? m : GCD(m, n % m);
        }
    }
}
