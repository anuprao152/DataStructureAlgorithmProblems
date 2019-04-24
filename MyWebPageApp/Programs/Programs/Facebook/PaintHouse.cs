using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Programs.Facebook
{
    public class PaintHouse
    {
        /// <summary>
        /// https://www.youtube.com/watch?v=fZIsEPhSBgM
        /// </summary>
        /// <param name="cost"></param>
        /// <returns></returns>
        public int PaintHouseColor(int[][] cost)
        {
            var r = cost.Length;
            var c = cost[0].Length;
            var dp = new int[r+1,c];
            for(int i=0; i < c;i++)
                dp[0,c]=0;

            //suppose 0 - green, 1- red, 2- blue

            for(int i=1; i< cost.Length;i++)
            {
                dp[i, 0] += Math.Min(dp[i - 1, 1], dp[i - 1, 2]);//cur house green paint cost, so i-1 house mincost( red , blue )
                dp[i, 1] += Math.Min(dp[i - 1, 0], dp[i - 1, 2]);//cur house red paint cost, so i-1 house mincost( green, blue )
                dp[i, 2] += Math.Min(dp[i - 1, 0], dp[i - 1, 1]);//cur house blue paint cost, so i-1 house mincost( red, blue )
            }

            return Math.Min(dp[r,0], Math.Min(dp[r,1], dp[r,2])); 
        }
    }
}
