using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringLeetCode
{
    public static class _266PalindromePermutation
    {
        public static bool CanPermutePalindrome(string s)
        {
            Dictionary<char, int> map = new Dictionary<char, int>();
            foreach (var str in s)
            {
                if (!map.ContainsKey(str)) map.Add(str, 1);
                else map[str]++;
            }
            int countodd = 0;
            int counteven = 0;
            foreach (var item in map)
            {
                if (item.Value % 2 == 0) counteven++;
                else countodd++;
            }
            return countodd <= 1;
        }
    }
}
