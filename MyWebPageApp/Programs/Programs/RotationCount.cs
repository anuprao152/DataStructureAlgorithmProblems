using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace programs
{
    public class RotationCount
    {
        //input should be rotated sorted array
        public int CalcRotationCount(int[] array)
        {
            int low = 0;
            int high = array.Length - 1;
            int minimal=low;
            int middle;

            while (array[low] >= array[high])
            {
                if (high - low == 1)
                {
                    minimal = high;
                    break;
                }

                middle = low + (high - low) / 2;

                

                if(array[low]==array[high] && array[high]==array[middle])
                {
                    //get sequentially
                    return GetSequentially(array, low, high);
                }

                //in first sub-array
                if (array[middle] >= array[low])
                {
                    low = middle;
                }
                else if (array[middle] <= array[high]) // second sub-array
                {
                    high = middle;
                }
            }

            return array[minimal];
        }

        public int GetSequentially(int[] array, int low, int high)
        {
            int result = array[low];
            for (int i = low + 1; i <= high; i++)
            {
                if (result > array[i])
                {
                    result = array[i];
                    break;
                }
            }

            return result;
        }
    }
}
