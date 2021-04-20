using System;
using System.Globalization;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime startTime = DateTime.UtcNow;
            string batchId = ((long)(startTime - new DateTime(1970, 1, 1)).TotalSeconds).ToString(CultureInfo.InvariantCulture);
            string batchId1 = ((startTime - new DateTime(1970, 1, 1)).TotalSeconds).ToString(CultureInfo.InvariantCulture);
            Console.WriteLine(batchId);
            Console.WriteLine(batchId1);
            Console.ReadKey();
        }
    }
}
