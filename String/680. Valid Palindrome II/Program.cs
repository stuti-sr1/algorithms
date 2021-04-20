using System;

namespace _680._Valid_Palindrome_II
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ValidPalindrome("abca"));
            Console.ReadKey();
        }
        public static bool ValidPalindrome(string s)
        {
            int l = s.Length;
            for (int i = 0; i < l / 2; i++)
            {
                int j = l - 1 - i;
                if (s[i] != s[j])
                {
                    return isPalindrome(s, i + 1, j) || isPalindrome(s, i, j - 1);
                }
            }
            return true;
        }

        private static bool isPalindrome(string s, int i, int j)
        {
            while (i <= j)
            {
                if (s[i] != s[j]) return false;
                i++;
                j--;
            }
            return true;
        }
    }
}
