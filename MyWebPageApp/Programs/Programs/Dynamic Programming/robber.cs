using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Programs
{
    //program
    //http://www.programcreek.com/2014/03/leetcode-house-robber-java/

    class robber
    {
        public int maxProfit(int[] array)
        {
            if (array == null || array.Length == 0)
                return 0;

            var even = 0;
            var odd = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 == 0)
                {
                    even += array[i];
                    even = (even > odd) ? even : odd;
                }
                else
                {
                    odd += array[i];
                    odd = (even > odd) ? even : odd;
                }
            }

            return (even > odd) ? even : odd;
        }

        public int maxprofitdp(int[] array)
        {
            if (array == null || array.Length == 0)
                return 0;

            if (array.Length == 1)
                return array[0];

            var dp = new int[array.Length];
            dp[0] = array[0];
            dp[1] = array[1];

            for (int i = 2; i < array.Length; i++)
                dp[i] = Math.Max(dp[i - 2] + array[i], dp[i - 1]);

            return dp[array.Length - 1];
        }
    }
}
