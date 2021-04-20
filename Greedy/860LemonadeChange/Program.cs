using System;

namespace _860LemonadeChange
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] bills = new int[] { 5, 5, 5, 10, 20 };
            bills = new int[] { 5, 5, 10 };
            bills = new int[] { 10, 10 };
            bills = new int[] { 5, 5, 10, 10, 20 };
            bills = new int[] { 5, 5, 5, 5, 10, 5, 10, 10, 10, 20 };

            Console.WriteLine(LemonadeChange(bills));
            Console.ReadKey();
        }
        public static bool LemonadeChange(int[] bills)
        {
            int num_5 = 0, num_10 = 0, num_20 = 0;
            if (bills == null || bills.Length == 0) return false;
            for (int i = 0; i < bills.Length; i++)
            {
                if (bills[i] == 5)
                    num_5++;
                else if (bills[i] == 10)
                {
                    num_10++;
                    if (num_5 > 0)
                    {
                        num_5--;
                    }
                    else return false;
                }
                else if (bills[i] == 20)
                {
                    num_20++;
                    if (num_10 > 0 && num_5 >= 1)
                    {
                        num_10--;
                        num_5--;
                    }
                    else if (num_5 >= 3)
                    {
                        num_5 = num_5 - 3;
                    }
                    else return false;
                }
            }
            return true;
        }
    }
}
