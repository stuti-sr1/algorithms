using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayCollection
{
    public static class BestTimetoBuyandSellStock
    {
        public static int MaxProfit(int[] prices)
        {
            int minPrice = prices[0];
            int maxProfit = 0;
            for (int i = 1; i < prices.Length; i++)
            {
                if (maxProfit < (prices[i] - minPrice))
                    maxProfit = prices[i] - minPrice;
                else if(minPrice > prices[i])
                    minPrice = prices[i];
            }
            return maxProfit;
        }
    }
}
