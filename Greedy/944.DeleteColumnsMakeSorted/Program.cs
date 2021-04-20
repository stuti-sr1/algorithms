using System;

namespace _944.DeleteColumnsMakeSorted
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = new string[] { "cba", "daf", "ghi" };
            s = new string[] { "a", "b" };
            s = new string[] {"zyx", "wvu", "tsr"};
            s = new string[] { "rrjk", "furt", "guzm" };
            int ans = MinDeletionSize(s);
            Console.WriteLine(ans);
            Console.ReadKey();
        }
        public static int MinDeletionSize(string[] A)
        {
            int size = A[0].Length;
            int count = 0;
            for (int i = 0; i < size; i++)
            {
                bool flag = false;
                for (int j = 1; j < A.Length; j++)
                {
                    if (A[j - 1][i] <= A[j][i])
                    {
                        flag = true;
                        continue;
                    }
                    else
                    {
                        flag = false;
                        break;
                    }
                }
                if (flag)
                {
                    count++;
                }
            }
            return size-count;
        }
    }
}
