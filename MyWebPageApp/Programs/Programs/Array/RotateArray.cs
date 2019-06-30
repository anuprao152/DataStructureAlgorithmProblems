using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace programs
{
    // d - you move array d times
    // Naive Method
    public class RotateArrayProg
    {
        public void RotateArray(int[] array, int d)
        {
            for(int i=0; i<d; i++)
            {
                RotateByOne(array);
            }
        }

        public void RotateByOne(int[] array)
        {
            int temp = array[0];
            int i=0;
            for (i = 0; i < array.Length - 1; i++)
            {
                array[i] = array[i + 1];
            }
            array[i] = temp;
        }


        //Another way : juggling alogrithm
        public void RotateJug(int[] array, int d)
        {
            for (int i = 0; i < GCD(d, array.Length); i++)
            {
                int j = i;

                int temp= array[i];
                while (true)
                {
                    int k = j + d;
                    if (k >= array.Length)
                    {
                        k = k - array.Length;
                    }

                    if (k == i) break;

                    array[j] = array[k];
                    j = k;
                }
                array[j]= temp;
            }
        }

        public int GCD(int d, int b)
        {
            if (b == 0) return d;
            else
                return GCD(b, d%b);
        }

        public void printArray(int[] arr)
        {
            for(int i=0; i < arr.Length ; i ++)
            {
                Console.Write("{0}", arr[i]);
            }
        }


        //reversal algorithm
        public void RotateReversalAlgo(int[] arr, int k)
        {
            ReverseArray(arr,0, k - 1);
            ReverseArray(arr, k, arr.Length -1);
            ReverseArray(arr, 0, arr.Length - 1);
        }

        private void ReverseArray(int[] arr, int start, int end)
        {
            while(start <= end)
            {
                var temp = arr[start];
                arr[start] = arr[end];
                arr[end] = temp;
                start++;
                end--;
            }
        }
    }
}
