using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace programs
{
    public class SubArraySumK
    {
        public void SubArraySumk(int[] arr, int k)
        {
            int curSum = 0;
            int start = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                curSum += arr[i];

                while (curSum > k && start < i)
                {
                    curSum -= arr[start];
                    start++;
                }

                if (curSum == k)
                {
                    Console.Write(string.Format("start {0}, End {1}",start, i));
                    curSum -= arr[start];
                    start++;
                }
            }
        }
    }
}
