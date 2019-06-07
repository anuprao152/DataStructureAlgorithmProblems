using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Programs.BitManipulation
{
    //https://www.geeksforgeeks.org/count-set-bits-in-an-integer/
    public class CountSetBits
    {
        // Brian Kernighan’s Algorithm:
        public int CountSetBitsFunc(int n)
        {
            int count = 0;
            while (n > 0)
            {
                n &= (n - 1);
                count++;
            }
            return count; 
        }
    }
}
