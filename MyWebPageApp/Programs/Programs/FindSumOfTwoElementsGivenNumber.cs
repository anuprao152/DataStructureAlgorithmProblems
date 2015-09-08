using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace programs
{
    /// <summary>
    /// If Array is given ( Unsorted ) and number is given K,
    /// find two pair of elements where elem 1 + elem 2 = k
    /// http://www.geeksforgeeks.org/write-a-c-program-that-given-a-set-a-of-n-numbers-and-another-number-x-determines-whether-or-not-there-exist-two-elements-in-s-whose-sum-is-exactly-x/
    /// 1. Method
    /// Sort the array and intialize two pointers 
    /// first index i and last index pointer j
    /// if ( arr (i) + arr (j) ) > sum  j--;
    /// if ( arr (i) + arr (j) ) < sum  j++;
    /// else ( arr (i) + arr (j) ) = sum  i++; j--;
    /// </summary>
    class FindSumOfTwoElementsGivenNumber
    {
        //I am applying this function for sorted array to find kSum pair , you need to sort an array befor applying this
        public void findKsumPair(int[] arr, int sum)
        {
            int i = 0;
            int j = arr.Length - 1;

            while (i < j)
            {
                if (arr[i] + arr[j] > sum) j--; // decrement last index because you need to step toward less value numbers
                else if (arr[i] + arr[j] < sum) i++; // increment first index becasue you need to step higher value numbers
                else //arr[i] + arr[j] = sum , to find multiple pairs put i++ and j-- rather than return
                {
                    Console.WriteLine(" {0} + {1} = {2} ", arr[i], arr[j], sum);
                    i++; j--;
                    //return;
                }
            }
        }

        //Unsorted Array
        public void FindKsumPairUSingHashMap(int[] arr, int sum)
        {

        }
    }
}
