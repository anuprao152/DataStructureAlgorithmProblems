using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Programs
{
    public class RearrangeString
    {

        public class charFreq
        {
            public char c;
            public int frequency;
        }

        public class charFreqComparer : Comparer<charFreq>
        {
            //override
            public override int Compare(charFreq x, charFreq y)
            {
                if (x.frequency < y.frequency)
                    return 1;
                else
                    return -1;
            }
        }

        public void Rearrange(string str)
        {
            //calculate the frequency
            int[] frequency = new int[256];

            for(int i=0;i<str.Length;i++)
            {
                var c = str[i];
                frequency[c]++;
            }

            //sort list by frequency
            charFreqComparer comparator = new charFreqComparer();
            var sorted =  frequency.OrderBy(i => i);



            
        }
    }
}
