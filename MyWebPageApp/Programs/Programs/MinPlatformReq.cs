using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace programs
{
    /// <summary>
    /// maximum number of overlaps problem.
    /// http://buttercola.blogspot.com/2015/08/leetcode-meeting-rooms-ii.html
    /// http://www.geeksforgeeks.org/minimum-number-platforms-required-railwaybus-station/
    /// </summary>
    public class MinPlatformReq
    {
        public int MinPlatform(int[] arr, int[] dep)
        {
            //Sort Array by start time



            int platform = 1;
            Heap minHeap = new Heap(arr.Length); // this maintains all standing bus 
            
            //for the first bus
            minHeap.insert(dep[0]);

            for(int i=1; i < arr.Length; i++)
            {
                if (arr[i] < minHeap.GetMin()) // check weather all the standing bus departure time with current bus arrival time for platform availibility
                {
                    minHeap.insert(dep[i]);
                    platform++;
                }
                else  // min departure time alredy due for current bus;
                {
                    minHeap.extractMin();
                    minHeap.insert(dep[i]);
                }
            }

            return platform;
        }
    }
}
