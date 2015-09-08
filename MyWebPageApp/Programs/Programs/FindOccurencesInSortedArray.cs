using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace programs
{
    public class FindOccurencesInSortedArray
    {
        public void FindOccurence(int number, int[] sortedArr)
        {
            int firstIndex = GetFirst(sortedArr, 0, sortedArr.Length - 1, number);
            int lastIndex = GetLast(sortedArr, 0, sortedArr.Length - 1, number);

            int occurence = firstIndex - lastIndex + 1;
        }

        public int GetFirst(int[] array, int high, int low, int k)
        {
            if (low > high) return -1;

            int middle = low + (high - low) / 2;

            if (array[middle] == k)
            {
                // number before middle number is different then you get the first k number
                if( (middle > 0 && array[middle-1]!=k) || middle==0)
                return middle;//returning index

                high = middle - 1;
            }
            else if( array[middle] > k)
            {
                high = middle - 1;
                
            }
            else
            {
                low = middle + 1;
            }

            return GetFirst(array, high, low, k);
        }

        public int GetLast(int[] array, int low, int high, int k)
        {
            if (low > high) return -1;

            int middle = low + (high - low) / 2;

            if (array[middle] == k)
            {
                if ((middle < array.Length - 1 && array[middle + 1] != k) || ( middle == array.Length - 1))
                    return middle;

                low = middle + 1;
                
            }

            if (array[middle] > k)
            {
                high = middle - 1;
            }
            else
            {
                low = middle + 1;
            }

            return GetLast(array, low, high, k);
        }


    }
}
