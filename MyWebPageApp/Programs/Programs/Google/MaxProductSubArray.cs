using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Programs.Google
{
    public class MaxProductSubArray
    {
        //https://www.geeksforgeeks.org/maximum-product-subarray-set-3/
        public int MaxProductSubArrayFunc(int[] array)
        {
            int max = array[0];
            int min = array[0];
            int res = array[0];
            for(int i=1;i<array.Length;i++)
            {
                if(array[i] > 0 )
                {
                    max = Math.Max(array[i], max * array[i]);
                    min = Math.Min(array[i], min * array[i]);
                }
                else
                {
                    //negativ then swap min and max value
                    // When multiplied by -ve number, 
                    // maxVal becomes minVal 
                    // and minVal becomes maxVal. 
                    var prevMax = max;
                    max = Math.Max(array[i], min * array[i]);
                    min = Math.Min(array[i], prevMax * array[i]);
                }

                if (max > res)
                    res = max;
            }

            return res;
        }
    }
}
