using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using programs;
using System.Collections;

namespace Programs.Amazon
{
    //http://www.geeksforgeeks.org/median-of-stream-of-integers-running-integers/
    public class MedianInStreamOfIntegersProg
    {
        //1. sort the array everytime you insert element and get middle element in array

        //2. Use augmented self balanced binary treee

        //3. Use Heap

        public void MedianInStream(int[] stream)
        {
            var left = new SortedList<int, int>();
            var right = new SortedList<int, int>();

            int median = 0;

            for (int i = 0; i < stream.Length; i++)
               median =   FindMedian(stream[i], left, right, median);  
        }

        private int IsBalanced(SortedList<int,int> left, SortedList<int,int> right)
        {
            if (left.Count == right.Count)
                return 0;
            else if (left.Count > right.Count)
                return 1;
            else
                return -1;
        }

        private int FindMedian(int element, SortedList<int, int> left, SortedList<int, int> right, int median)
        {
            int num = IsBalanced(left, right);

            if (num == 0)// balanced
            {
                if (element < median)
                {
                    left.Add(element, element);
                    //median = left.Peek();
                }
                else
                {
                    right.Add(element, element);
                    //median = right.Peek();
                }

               
            }

            if (num == 1) // left has more element
            {
                if (element < median)
                {
                   // right.Add(left.ExtractTop());

                    //left.Add(element,element);
                }
                else
                {
                    //right.Add(element, element);
                }

               // median = left.Peek() + right.Peek();
            }

            if(num == -1) // right has more elements
            {
                if (element < median)
                {
                    //left.Add(element,element);
                }
                else
                {
                   // right.Add(left.ExtractTop());

                   // left.Add(element, element);
                }

               //median = left.Peek() + right.Peek();
            }

            return median;
        }

    }
}
