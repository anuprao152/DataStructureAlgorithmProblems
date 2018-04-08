using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Programs.Array
{
    public class TwoSumCloseToTarget
    {
       //O(n^2)
        public void Find2SumCloseToTarget(int[] array, int target)
        {
            int minDiff = int.MaxValue;
            int min_i = 0;
            int min_j = 0;
            int res = 0;

            for (int i = 0; i < array.Length; i++)
            {
                for(int j=i+1;j< array.Length;j++)
                {
                    int sum = array[i] + array[j];
                    int diff = Math.Abs( target - sum);
                    if(diff < minDiff)
                    {
                        minDiff = diff;
                        res = sum;
                        min_i = i;
                        min_j = j;
                    }
                }
            }
        }

        //another approach Sorted (O(nlogn) + O(n))
        public void Find2SumCloseToTargetOptimized(int[] array, int target)
        {
            if (array == null) 
                return;

            var list = array.ToList();
            list.Sort();
            var sortedArr = list.ToArray();

            int i = 0;
            int j = sortedArr.Length - 1;
            int minDiff = int.MaxValue;
            int min_i;
            int min_j;
            int res = 0;

            while(i<j)
            {
                var sum = sortedArr[i] + sortedArr[j];
                var diff = Math.Abs(target - sum);
                if(minDiff > diff)
                {
                    minDiff = diff;
                    min_i = i;
                    min_j = j;
                    res = sum;
                }
            }
        }
    }
}
