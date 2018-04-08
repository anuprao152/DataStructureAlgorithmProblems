using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace programs
{
    public class HeapMax
    {
        public int[] collection;
        public int index;
        public int length;

        public HeapMax(int size)
        {
            collection = new int[size];
            index = 0;
            length = collection.Length;
        }

        public void insert(int number)
        {
            collection[index] = number;
            
        }

        public void heapifyUp(int index)
        {
            int parentindex;
            GeParent(index,out parentindex);

            if (collection[parentindex] < collection[index])
                swap(ref collection[parentindex], ref collection[index]);
            else
                return;

            heapifyUp(parentindex);
        }

        public int GetMax()
        {
           return collection[0];
        }

        public int ExtractMax()
        {
            int max = collection[0];

            index--;

            collection[0] = collection[index];

            collection[index] = default(int);

            heapify(0);

            return max;
        }

        public void heapify(int index)
        {
            int leftindex;
            int rightindex;

           int left = GetLeft(index, out leftindex);
           int right = GetRight(index, out rightindex);

           if (collection[index] > left && collection[index] > right)
               return;

           int replaceIndex;
           
           if(left > right)
           {
               replaceIndex = leftindex;
           }
           else
           {
               replaceIndex = rightindex;
           }

           swap(ref collection[index], ref collection[replaceIndex]);

           heapify(replaceIndex); 
        }

        public int GetLeft(int index,out int leftindex)
        {
            leftindex = 2 * index + 1;
            return collection[leftindex];
        }
        public int GetRight(int index, out int rightindex)
        {
            rightindex = 2 * index + 2;
            return collection[rightindex];
        }

        public void swap(ref int parent, ref int child)
        {
            int temp = parent;
            parent = child;
            child = temp;
        }

        public int GeParent(int index, out int parentindex)
        {
            parentindex = (int)Math.Floor(Convert.ToDouble((index + 1) / 2));

            if (parentindex > 0)
                parentindex--;

            return collection[parentindex];
        }
    }
}
