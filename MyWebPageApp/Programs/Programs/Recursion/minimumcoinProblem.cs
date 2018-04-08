using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace programs
{
    public class minimumcoinProblem
    {
        // Minimum coin change problem -> divide into sub-problems and solve sub-problems to solve origional problems

        // MinCoins ( j ) = Minimum coins required to make the change for j

        // Consider last coin MinCoins ( j ), value of that coin has to be one of v1, v2, ...vn

        // we don't know which coin will be used a the last coin, but we know below facts

        // if coin is v1
        // 1.  The remaining number of coins are minimum number of coins to make the change of j - v1
        // if coin is v2
        // 2.  The remaining number of coins are minimum number of coins to make the change of j- v2

        // So, MinCoins ( j ) =  Min {  MinCoins (j - v1) , MinCoins ( j-  v2), ... MinCoins ( j- vn) }


        // Anytime adding a coin to make a change shouldn't exceed target ( target > 0 )
        // Anytime coin value smaller than target value, then and only then you consider than coin in a solution.

        public int MinCoins(int[] coins, int target)
        {
            if (target == 0) return 0; // no coins require to make the change for 0 , base case

            int min = int.MaxValue;

            for (int i = 0; i < coins.Length; i++)
            {
                //if (coins[i] > target || target < 0) // you can't add a coin in a solution which is greater than target value, 
                //    return target;                   // and your total coins value shouldn't exceed the target 

                if (coins[i] <= target && target > 0)
                {
                    int value = MinCoins(coins, target - coins[i]) + 1; // minCoins require to make the change target - coins[i]

                    if (value != int.MaxValue && value < min)
                        min = value;
                }
            }

            return min;
        }

    }
}
