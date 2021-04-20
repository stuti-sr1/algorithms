using System;
using System.Collections.Generic;

namespace _628._Maximum_Product_of_Three_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = { 1, 2, 0, 0 };
            int K = 34;
            var t = AddToArrayForm(A, K);
            Console.WriteLine(FindLengthOfLCIS(A));
            Console.ReadKey();
        }
        public static int FindLengthOfLCIS(int[] nums)
        {
            if (nums.Length < 1) return 0;
            int max = 1;
            int count = 1;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] < nums[i + 1])
                {
                    count++;
                }
                else count = 1;
                max = Math.Max(max, count);
            }
            return max;
        }

        public static IList<int> AddToArrayForm(int[] oldA, int K)
        {
            List<int> res = new List<int>();
            List<int> k = new List<int>();
            List<int> A = new List<int>(oldA);
            A.Reverse();
            while (K > 0)
            {
                int n = K % 10;
                k.Add(n);
                K = K / 10;
            }
            int i = k.Count - 1;
            int j = A.Count - 1;
            if (i > j)
            {
                for (int m = 0; m < i - j; m++)
                {
                    A.Add(0);
                }
            }
            else if (i < j)
            {
                for (int m = 0; m < j - i; m++)
                {
                    k.Add(0);
                }
            }
            i = A.Count-1;
            int carry = 0;
            int sum = 0;
            while (i >= 0)
            {
                sum = k[i] + A[i] + carry;
                i--;
                if (sum > 9)
                {
                    carry = sum / 10;
                }
                else
                {
                    carry = 0;
                }
                res.Add(sum % 10);
            }
            if (carry > 0)
            {
                res.Add(carry);
            }
            return res;
        }
    }
}
