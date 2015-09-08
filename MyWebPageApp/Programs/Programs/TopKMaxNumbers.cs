using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace programs
{
    public class TopKMaxNumbers
    {
        //Find top 10 
        public void FindKMax(int[] array, int k)
        {
            Heap minHeap = new Heap(k);
            //int index = 0;//heap index

            for (int i = 0; i < array.Length; i++)
            {
                if (i < k)
                {
                    minHeap.insert(array[i]);
                    //index++;
                }
                else
                {
                   int min = minHeap.GetMin();
                   if (array[i] > min)
                   {
                       minHeap.extractMin();
                       minHeap.insert(array[i]);
                   }
                }
            }
        }
    }
}
