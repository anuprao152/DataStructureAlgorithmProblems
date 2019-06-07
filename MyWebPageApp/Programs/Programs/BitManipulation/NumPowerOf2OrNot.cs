using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Programs.BitManipulation
{
    //https://www.geeksforgeeks.org/program-to-find-whether-a-no-is-power-of-two/
    //property
    //if any number is power of 2, then it has only 1 bit set, 
    //if set bit count is 1 then num is power of 2

    //If we subtract a power of 2 numbers by 1 then all unset bits after the only set bit become set; and the set bit become unset.
    //For example for 4 ( 100) and 16(10000), we get following after subtracting 1
    //3 –> 011
    //15 –> 01111
    public class NumPowerOf2OrNot
    {
        public bool isNumPower2(int num)
        {
            return (num > 0 && (num & (num - 1)) == 0);
        }
    }
}
