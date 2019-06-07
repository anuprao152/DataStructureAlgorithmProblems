using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Programs
{

    public class ArrayContainer : IComparable<ArrayContainer>
    {
        public int[] array;
        public int index;

        public ArrayContainer(int[] array, int index)
        {
            this.array = array;
            this.index = index;
        }

        public int CompareTo(ArrayContainer that)
        {
            //sorted in ascending order in priority queue
            return this.array[index].CompareTo(that.array[that.index]);
        }

    }

    public class PriorityQueue
    {
        public ArrayContainer GetMin()
        {
            throw new NotImplementedException();
        }
        public void Extract()
        {
            throw new NotImplementedException();
        }
        public void Add(ArrayContainer o)
        {
            throw new NotImplementedException();
        }
        public bool IsEmpty()
        {
            throw new NotImplementedException();
        }
    }

    //https://www.programcreek.com/2014/05/merge-k-sorted-arrays-in-java/
    public class MergeKSortedArrays
    {
        public int[] MergeKSortedArraysFunc(int[][] arr)
        {
            var heap = new PriorityQueue();
            var total = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                heap.Add(new ArrayContainer(arr[i], 0));
                total += arr[i].Length;
            }

            var res = new int[total];

            while(!heap.IsEmpty())
            {
                var min = heap.GetMin();

                heap.Extract();
                if(min.index +1 < min.array.Length )
                {
                    heap.Add(new ArrayContainer(min.array, min.index + 1));
                }
            }
            return res;
        }
    }
}
