using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace programs
{
    public class NumberOfWaysCoinChange
    {
        public int CoinCount(int[] Coins, int target, int index)
        {
            if (target == 0)
                return 1;     // including no coin

            if (target < 0)
                return 0;

            if (index < 0 && target != 0) // coins are over
                return 0;

            // 1. Including Coins[index] mutliple times ( no index change ) 2. Excluding  Coins[index] , so no sum change  
            return CoinCount(Coins, target - Coins[index], index) + CoinCount(Coins, target, index - 1);

            //if you don't want multiple times coins then
            //return CoinCount(Coins, target - Coins[index], index - 1) + CoinCount(Coins, target, index - 1);
        }
    }
}
