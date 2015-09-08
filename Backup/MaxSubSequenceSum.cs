using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StackProgram
{
    class MaxSubSequenceSum
    {
        public int[] elements;

        public MaxSubSequenceSum(int[] elements)
        {
            this.elements = elements;
        }
        
        // example 4,-9,3,-2,4,-12
        //intial max sum = 4
        //2nd time  max sum = 4-9 = -5 < 0 so {4,-9} couldn't be a seq or max sum so start  finding sequence max sum from 3 now. (remember 4 as a oldsequenc sum)
        // now start with 3 < 4 continue still 4 maxsumsubsequence wins
        // now 3-2 = 1 < 4 still 4 wins as a max seq
        // now 3-2+4= 5 , but now 4 < 5 so 5 will be new max sum subsequence
        public void GetMaxSubSequenceSum()
        {
            List<int> MaxsumSeq = new List<int>();

            int prevsum = 0;
            int maxsum = 0;//afte adding next element

            for (int i = 0; i < elements.Length; i++)
            {
                maxsum += elements[i];//afte adding next element

                if (prevsum < maxsum)
                {
                    //once you find that nw sequence that you generating has max sum take it as a new max sum 
                    // and compare for a next sequence if you have a new window

                    prevsum = maxsum;
                }
                else if (maxsum < 0)
                {
                    //if seqsum < 0 then start a new sequence from scratch
                    maxsum = 0;
                }
            }
        }

        public void GetMaxSubSequenceSumDynamicprog()
        {
            //maxsum [i] = Max ( maxsum(i-1) + A[i], A[i])
            int maxsum = 0;
            //int prevsum;
            for (int i = 0; i < elements.Length -1; i++)
            {
                //prevsum = maxsum;
                maxsum += elements[i];
                maxsum = Math.Max(maxsum, elements[i]);
            }
        }

    }
}
