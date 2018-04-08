using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Quick Sort Algorithm
//http://www.youtube.com/watch?feature=player_detailpage&v=COk73cpQbFQ
namespace programs
{
    public class QuickSortAlgo
    {
            public void QuickSort(int[] array, int low, int high)
            {
                if (low > high) return;

                int pivot = Partition(array, low, high);
                QuickSort(array, low, pivot - 1);
                QuickSort(array, pivot, high);
            }

            public int Partition(int[] array, int low, int high)
            {
                //last element is pivot
                int pivot = array[high];
                int j = 0;

                // all elements less than pivot goes left
                for(int i=0; i<high; i++)
                {
                    if (array[i] <= pivot)
                    {
                        swap(ref array[j], ref array[i]);
                        j++;
                    }   
                }
                swap(ref array[j], ref array[high]); //last you swap last element(pivot) with array[j] 

                return j;
            }
            public void swap(ref int num1, ref int num2)
            {
                int temp = num1;
                num1 = num2;
                num2 = temp;
            }
    }
}
