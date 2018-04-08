using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Programs
{
    public class test1
    {

        public void GetMaxSubSequenceSum(int[] elements)
        {
            List<int> MaxsumSeq = new List<int>();

            int maxSum = int.MinValue;
            int curSum = 0;//afte adding next element
            int start = 0;
            int end = 0;

            for (int i = 0; i < elements.Length; i++)
            {
                curSum += elements[i];//afte adding next element

                if (maxSum < curSum)
                {
                    //once you find that nw sequence that you generating has max sum take it as a new max sum 
                    // and compare for a next sequence if you have a new window
                   
                    maxSum = curSum;
                    end++;
                    
                }
                else if (curSum < 0)
                {
                    //if seqsum < 0 then start a new sequence from scratch
                    curSum = 0;
                    start = i;
                    end = i;
                }
                start++;
            }

            Console.WriteLine("start Index" + start);
            Console.WriteLine("end  Index" + end);

        }
    }
}
