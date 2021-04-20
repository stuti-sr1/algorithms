using System;
using System.Collections.Generic;
using System.Linq;

namespace _905._Sort_Array_By_Parity
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] A = { 3, 1, 2, 4 };
            int[] A = { 0, 1 };
            int[] A1 = { 1, 4, 3, 2 };
            int t1 = ArrayPairSum(A1);
            var t = SortArrayByParity(A);
            Console.ReadKey();
        }
        public static int ArrayPairSum(int[] nums)
        {
            List<int> num = new List<int>(nums);
            var t = num.OrderBy(x => x).ToList();
            int sum = 0;
            for (int i = 0; i < nums.Length; i += 2)
            {
                sum += t[i];
            }
            return sum;
        }
        public static int[] SortArrayByParity(int[] A)
        {
            if (A.Length < 2) return A;
            int i = 0, j = A.Length - 1;
            while (i < j)
            {
                if (A[j] % 2 == 0 && A[i] % 2 != 0)
                {
                    int temp = A[i];
                    A[i] = A[j];
                    A[j] = temp;
                    i++;
                    j--;
                }
                if (A[i] % 2 == 0)
                {
                    i++;
                }
                if (A[j] % 2 != 0)
                {
                    j--;
                }
            }
            return A;
        }
    }
}
