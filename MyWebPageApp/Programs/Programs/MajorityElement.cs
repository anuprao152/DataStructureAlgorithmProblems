using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Programs
{
    //Moore’s Voting Algorithm
    public class MajorityElement
    {
        public int FindMajorityElement(int[] array)
        {
            int majorityIndex = 0;
            int count = 1;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[majorityIndex] == array[i])
                    count++;
                else
                    count--;

                if (count == 0)
                    majorityIndex = i;
            }

            return array[majorityIndex];
        }
    }
}
