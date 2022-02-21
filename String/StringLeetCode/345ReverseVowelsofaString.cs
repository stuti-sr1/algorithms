using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringLeetCode
{
    public static class _345ReverseVowelsofaString
    {
        public static string ReverseVowels(string s)
        {
            int l = 0;
            int r = s.Length - 1;
            char[] str = s.ToCharArray();
            char temp;

            while (l < r)
            {
                while (l < r && !CheckVowel(l, str))
                {
                    l++;
                }
                while (l < r && !CheckVowel(r, str))
                {
                    r--;
                }
                temp = str[l];
                str[l] = str[r];
                str[r] = temp;
                l++;
                r--;
            }
            return new String(str);
        }

        private static bool CheckVowel(int l, char[] s)
        {
            if (s[l] == 'a' || s[l] == 'e' || s[l] == 'i' || s[l] == 'o' || s[l] == 'u' ||
                s[l] == 'A' || s[l] == 'E' || s[l] == 'I' || s[l] == 'O' || s[l] == 'U')
                return true;
            else return false;
        }
    }
}
