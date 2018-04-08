using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace programs
{
    public class MergeSortProg
    {
        public int[] MergeSort(int[] arr)
        {
            if (arr.Length == 1) return arr;

            int middle = arr.Length / 2;

            int[] left = new int[middle];
            int[] right = new int[arr.Length - middle];

            int j=0;
            int k=0;

            //Left and right array initialization
            for (int i = 0; i < arr.Length; i++)
            {
                if (i < middle)
                {
                    left[j] = arr[i];
                    j++;
                }
                else
                {
                    right[k] = arr[i];
                    k++;
                }
            }

            left= MergeSort(left);
            right=MergeSort(right);
            arr = Merge(left, right);
            
            return arr;
        }

        public int[] Merge(int[] left, int[] right)
        {
            int[] res = new int[left.Length + right.Length];

            int resI =0;
            int leftI=0;
            int rightI=0;

            while (leftI < left.Length || rightI < right.Length)
            {
                //if we done with the left mereg 
                //just right elements goes to res array
                if (leftI >= left.Length)
                {
                    res[resI] = right[rightI];
                    rightI++;
                    resI++;
                }
                //if we done with the right mereg 
                //just left elements goes to res array
                else if (rightI >= right.Length)
                {
                    res[resI] = left[leftI];
                    leftI++;
                    resI++;
                }
                else if (left[leftI] <= right[rightI])
                {
                    res[resI] = left[leftI];
                    leftI++;
                    resI++;
                }
                else
                {
                    res[resI] = right[rightI];
                    rightI++;
                    resI++;
                }
            }

            return res;
        }
    }
}
