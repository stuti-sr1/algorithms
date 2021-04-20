using System;
using System.Collections.Generic;

namespace _1122._Relative_Sort_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 2, 3, 1, 3, 2, 4, 6, 7, 9, 2, 19 };
            int[] arr2 = { 2, 1, 4, 3, 9, 6 };
            var t = RelativeSortArray(arr1, arr2);
            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
        public static int[] RelativeSortArray(int[] arr1, int[] arr2)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();
            Array.Sort(arr1);
            int i = 0;
            foreach (var item in arr2)
            {
                map[arr2[i++]] = 0;
            }
            for (i = 0; i < arr1.Length; i++)
            {
                if (!map.ContainsKey(arr1[i]))
                {
                    map[arr1[i]] = 1;
                }
                else
                {
                    map[arr1[i]]++;
                }
            }
            int[] newAr = new int[arr1.Length];
            i = 0;
            foreach (var item in map)
            {
                for (int j = 0; j < item.Value; j++)
                {
                    newAr[i] = item.Key;
                    i++;
                }
            }
            return newAr;
        }
    }
}
