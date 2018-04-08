using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Programs
{
    public class StockBuySell
    {
        public struct BuySell
        {
           public int buy;
           public int sell;
        }

        public int getMaxProfitSingleBuySell(int[] prices)
        {
            int min = prices[0];
            int profit = 0;

            for (int i = 1; i < prices.Length; i++)
            {
                if (profit < prices[i] - min)
                {
                    profit = prices[i] - min;
                }

                if (prices[i] < min)
                {
                    min = prices[i];
                }
            }
            return profit;
        }

        public List<BuySell> getMaxProfitMultipleBuySell(int[] prices)
        {
            int i = 0;
            List<BuySell> list = new List<BuySell>();

            while (i < prices.Length)
            {
                ///find minima
                while (i + 1 < prices.Length && prices[i] > prices[i + 1])
                    i++;

                //no buy
                if (i + 1 == prices.Length)
                    return null;

                var buysell = new BuySell();
                buysell.buy = i;

                //find maxima
                i++;
                while (i < prices.Length && prices[i] > prices[i - 1])
                    i++;

                if(i!=prices.Length)
                    buysell.sell = i;

                i++;

                list.Add(buysell);
            }

            return null;
        }
    }
}
