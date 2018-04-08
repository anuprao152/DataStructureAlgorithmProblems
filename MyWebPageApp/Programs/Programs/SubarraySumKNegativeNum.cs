using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Programs
{
    public class SubarraySumKNegativeNum
    {

        //http://www.geeksforgeeks.org/find-subarray-with-given-sum-in-array-of-integers/

        // . . . . . . . . . . . . . . .|
        //      |----(curSum - K) ------|curSum

        public void SubarraySumK(int[] array, int k)
        {
            var curSum = 0;
            var dict = new Dictionary<int, int>();

            for (int i = 0; i < array.Length; i++)
            {
                curSum += array[i];
                if (curSum == k)
                {
                    Console.WriteLine("sum found between 0 index to " + i + "index");
                    return;
                }

                if (dict.ContainsKey(curSum - k))
                {
                    //you found the sum
                    Console.WriteLine("sum found between " + dict[curSum-k] + 1 +"index to " + i + "index");
                    return;
                }

                dict.Add(curSum, i);
            }

        }
    }
}
