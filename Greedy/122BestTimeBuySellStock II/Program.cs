using System;
using System.Collections.Generic;

namespace _122BestTimeBuySellStock_II
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] price = new int[] { 7, 1, 5, 3, 6, 4 };
            price = new int[] { 1, 2, 3, 4, 5 };
            price = new int[] { 7, 6, 4, 3, 1 };
            Console.WriteLine(MaxProfit1(price));
            Console.ReadKey();
        }

        private static int MaxProfit1(int[] prices)
        {
            if (prices == null || prices.Length == 0) return 0;
            int sum = 0;
            for (int i = 1; i < prices.Length; i++)
            {
                if (prices[i] > prices[i - 1])
                {
                    sum += prices[i] - prices[i - 1];
                }
            }
            return sum;
        }

        public static int MaxProfit(int[] prices)
        {
            if (prices == null || prices.Length == 0) return 0;
            
            int sum = 0;
            Stack<int> st = new Stack<int>();
            int min = prices[0];
            st.Push(prices[0]);
            for (int i = 1; i < prices.Length; i++)
            {
                if (prices[i] > prices[i - 1])
                {
                    st.Pop();
                }
                else
                {
                    int latest = st.Pop();
                    sum += (latest - min);
                    min = prices[i];
                }
                st.Push(prices[i]);
                if (i == prices.Length - 1)
                {
                    int latest = st.Pop();
                    sum += (latest - min);
                }
            }
            return sum;
        }
    }
}
