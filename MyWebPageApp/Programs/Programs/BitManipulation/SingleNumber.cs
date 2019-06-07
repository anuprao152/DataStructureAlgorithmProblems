using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Programs.BitManipulation
{
    public class SingleNumber
    {
        //XOR operation of two same number make number 0
        //all the duplicate number that appears even time nullify on XOR, but atlast odd num will stay
        //https://www.programcreek.com/2012/12/leetcode-solution-of-single-number-in-java/
        public int SingleNumberFunc(int[] array)
        {
            var x = 0;
            for(int i=0;i< array.Length;i++)
            {
                x ^= array[i];
            }
            return x;
        }
    }
}
