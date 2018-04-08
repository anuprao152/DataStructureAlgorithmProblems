using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace programs
{
    public class _2Sum
    {
        //Please look at programcreek solution
        public void TwoSumK(int[] arr,int sum)
        {
            Dictionary<int,int> dict = new Dictionary<int,int>();

            for (int i = 0; i < arr.Length; i++)
            {
                int value = sum - arr[i];
                if (dict.ContainsKey(arr[i]))
                {
                    Console.Write("Sum Found: arr[{0}]: {1} + arr[{2}]: {3}", 
                                    dict[arr[i]], arr[dict[arr[i]]], i, arr[i]);
                    return;
                }
                else
                {
                    dict.Add(value, i);
                }
            }
        }

    }
}
