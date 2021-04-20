using System;

namespace day_of_the_week
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DayOfTheWeek(18,7,1999));
            Console.ReadKey();
        }
        public static string DayOfTheWeek(int day, int month, int year)
        {
            int[] arr = new int[] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            if (year % 4 == 0)
            {
                arr[1] = 29;
                if (year % 100 != 0) arr[1] = 28;
            }
            int total = 0;
            for (int i = 0; i < month - 1; i++)
            {
                total += arr[i];
            }
            total += day;
            int rem = total % 7;
            switch (rem)
            {
                case 0: return "Sunday";
                case 1: return "Monday";
                case 2: return "Tuesday";
                case 3: return "Wednesday";
                case 4: return "Thursday";
                case 5: return "Friday";
                case 6: return "Saturday";
                default: return "wrong";
            }
        }
    }
}
