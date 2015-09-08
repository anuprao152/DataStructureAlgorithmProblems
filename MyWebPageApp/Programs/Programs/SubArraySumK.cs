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
            int startIdx = 0;
            for (int i = 0; i <= arr.Length; i++)
            {
               

                //sum > k 
                //Suppose at last element i you find sum > k it doesn't mean for loop ends and done
                //increase start index you may probably get sum = k, 
                //if by doing this sum < k , you need to go to next element to add ( last step)
                while (curSum > k && startIdx < i)
                {
                    curSum = curSum - arr[startIdx];
                    startIdx++;
                }

                if (curSum == k)
                {
                    Console.Write(string.Format("startIdx {0}, EndIdx {1}",startIdx, i));
                    curSum = curSum - arr[startIdx];
                    startIdx++;
                }

                //Add elements
                if (i < arr.Length)
                {
                    curSum += arr[i];
                }
                //increx i inex of array by adding it
            }
        }
    }
}
