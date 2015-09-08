using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace programs
{
    // min heap
    public class Heap
    {
        int[] collection;
        int index;
        int length;

        public Heap(int size)
        {
            collection = new int[size];
            index = 0;
            length = collection.Length;
        }

        public void insert(int num)
        {
            collection[index] = num;

            heapifyUp(index);

            index++;
        }
        private void heapifyUp(int index)
        {
            int parentindex;
            int parent = GetParent(index, out parentindex);

            if (parent > collection[index])
                swap(ref collection[parentindex], ref collection[index]);
            else
                return;

            heapifyUp(parentindex);

        }

        public void heapify(int index)
        {
            int rightindex;
            int leftindex;
            int rightNode = GetRight(index, out rightindex);
            int leftNode = Getleft(index,out leftindex);

            // 0 means null = not exist
            if (leftNode == 0 && rightNode == 0)
                return;

            if ( collection[index] < leftNode && collection[index] < rightNode)
                return;

            int replaceIndex;

                if (rightNode > leftNode)
                {
                    replaceIndex = leftindex;
                    //swap(ref collection[index], ref leftNode);
                }
                else
                {
                    replaceIndex = rightindex;
                    //swap(ref collection[index], ref rightNode);
                }

                swap(ref collection[index], ref collection[replaceIndex]);

                heapify(replaceIndex);

        }
        private int GetParent(int index, out int parentindex)
        {
            // parent (i) = index/2 (lower bound)
            //double ele = index;
            parentindex = (int)Math.Floor(Convert.ToDouble((index + 1)/ 2));

            if(parentindex > 0)
                parentindex--;
            return collection[parentindex];

        }
        private int Getleft(int index, out int leftindex)
        {
            //Get left node= 2i
            //but index start from 0, so left node = 2 * index+ 1;
            leftindex= 2 * index + 1;
            if (leftindex < length - 1)
                return collection[leftindex];
            else
                return 0;

        }
        private int GetRight(int index, out int rightindex)
        {
            //Get right node= 2i+1;
            // but index starts from 0, sor right node = 2* index + 2;
            rightindex = 2 * index + 2;
            if (rightindex < length - 1)
                return collection[rightindex];
            else
                return 0;
        }

        public int GetMin()
        {
            return collection[0];
        }
        public int extractMin()
        {
            int min = collection[0];

            //last node becomes root == first;
            index--;
            collection[0] = collection[index];// last node first

            //now heapify
            collection[index] = default(int);
            heapify(0);//heapify at root

            return min;

        }

        private void swap(ref int a, ref int b)
        {
            int  temp = b;
            b = a;
            a = temp;
        }
    }
}
