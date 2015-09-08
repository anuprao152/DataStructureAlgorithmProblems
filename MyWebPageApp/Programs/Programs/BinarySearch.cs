using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace programs
{
    //simple binary search algo
    public class BinarySearchAlgo
    {
        public void BinarySearch(int[] array, int k)
        {
            int low = 0;
            int high = array.Length - 1;

            while (low < high)
            {
                int mid = low + (high - low) / 2;

                if (array[mid] == k)
                {
                    Console.WriteLine(array[mid]);
                    break;
                }
                else if (k > array[mid])
                {
                    low = mid;
                }
                else
                {
                    high = mid;
                }
               
            }
        }
    }
}
