using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayCollection
{
    public static class _179LargestNumber
    {
        public static string LargestNumber(int[] nums)
        {
            string[] numStr = nums.Select(x => x.ToString()).ToArray();
            Array.Sort(numStr, (a, b) => (a + "" + b).CompareTo(b + "" + a));
            if (numStr[numStr.Length - 1][0] == '0')
                return "0";
            string result = string.Empty;
            for (int i = numStr.Length - 1; i >= 0; i--)
            {
                result += numStr[i];
            }
            return result;
        }


        //dont do it
        //public static string LargestNumber(int[] nums)
        //{
        //    int len = nums.Length;
        //    int max = Int32.MinValue;
        //    for (int i = 0; i < len; i++)
        //    {
        //        max = Math.Max(max, nums[i]);
        //    }
        //    int count = getDigitCount(max);
        //    int newcount = 0;
        //    Dictionary<int, int> newNum = new Dictionary<int, int>();
        //    int num;
        //    for (int i = 0; i < len; i++)
        //    {
        //        newcount = getDigitCount(nums[i]);
        //        num = nums[i];
        //        while ((count - newcount) > 0)
        //        {
        //            num *= 10;
        //            newcount++;
        //        }
        //        newNum[i] = num;
        //        newcount = 0;
        //    }
        //    var t = newNum.OrderByDescending(x => x.Value);
        //    StringBuilder str = new StringBuilder();
        //    string s = string.Empty;
        //    foreach (var t1 in t)
        //    {
        //        string a = s + nums[t1.Key];
        //        string b = nums[t1.Key] + s;
        //        if (string.Compare(a , b))
        //        { s = a; }
        //        else s = b;
        //        str.Append(nums[t1.Key]);
        //    }
        //    return str.ToString();
        //}

        //private static int getDigitCount(int n)
        //{
        //    int count = 0;
        //    int r;
        //    while (n > 0)
        //    {
        //        r = n % 10;
        //        count++;
        //        n /= 10;
        //    }
        //    return count;
        //}
    }
}
