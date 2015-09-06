using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StackProgram
{
    public class FindTheNumberOfOccurencesInSortedArray
    {
      // one approach is O(n); count and display

        //second is using binary search
        public void FindNumberOfOccurnece(int[] arr)
        {
            //it will fail in case for 5 last element
            int firstindex = First(arr, 0, arr.Length - 1, 3);
            int lastIndex = Last(arr, 0, arr.Length - 1, 3);

            Console.WriteLine(lastIndex - firstindex + 1);
        }

        public int First(int[] arr, int low, int high, int x)
        {
            while (high >= low)
            {

                int mid = (high + low) / 2;

                if (x < arr[mid])
                {
                    return First(arr, low, mid, x);
                }
                else if (x==arr[mid])
                {
                    if (mid != 0 && x > arr[mid - 1])
                    {
                        Console.WriteLine("First Index:" + mid + "Value" + arr[mid]);
                        return  mid ;
                    }
                    else return First(arr, low, mid, x);
                }
                else if (x > arr[mid])
                {
                    return First(arr, mid, high,x);
                }   
            }
            return -1;
        }

        public int Last(int[] arr, int low, int high, int x)
        {
            while (high >= low)
            {
                int mid = (high + low) / 2;
                if (x < arr[mid])
                {
                    return Last(arr, low, mid, x);
                }
                else if (x == arr[mid])
                {
                    if (mid == arr.Length - 1)
                    {
                        return mid;
                    }
                    if ( mid != arr.Length-1 && x < arr[mid + 1])
                    {
                        Console.WriteLine("Last Index:" + mid + "Value" + arr[mid]);
                        return  mid ;
                    }
                    else return Last(arr, mid, high, x);
                }
                else if (x > arr[mid])
                {
                    return Last(arr, mid, high, x);
                }
                
            }
            return -1;
        } 

    }
}
