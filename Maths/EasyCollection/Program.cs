using System;

namespace EasyCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            int nums = 4421;
            Console.WriteLine(SubtractProductAndSumOfDigitsOfAnInteger.SubtractProductAndSum(nums));

            nums = 9669;
            Console.WriteLine(Maximum69Number.Maximum69NumberFun(nums));

            int[] num = { 1, 2, 3, 1, 1, 3 };
            Console.WriteLine(NumberofGoodPairs.NumIdenticalPairs(num));

            num =new int[] { -1, 1, -1, 1, -1 };
            Console.WriteLine(SignOfTheProductOfAnArray.ArraySign(num));

            Console.ReadKey();
        }
    }
}
