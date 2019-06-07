using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Programs.BitManipulation
{
    public class IntegerPalindrom
    {
        public bool IsIntPalindrom(int num)
        {
            var l = 0;
            var r = (sizeof(int) * 8 ) - 1;

            while(l<=r)
            {
                if (getBit(num, l) != getBit(num, r))
                    return false;
                l++;
                r--;
            }

            return true;

        }

        // 1001 - 9 , rev = 0000
        // 1001 & 0001 ,rev 0001 (left shift) , num=0100 ( right shift)
        // 0100 & 0001 ,rev 0010 (left shift) , num=0010 ( right shift)
        // 0010 & 0001 ,rev 0100 (left shift) , num=0001 ( right shift)
        // 0001 & 0001 , rev 1001 (left shift) , num=0001 ( right shift)
        public  int reverseBits(int n)
        {
            int rev = 0;

            // traversing bits of 'n'  
            // from the right 
            while (n > 0)
            {
                // bitwise left shift  
                // 'rev' by 1 
                rev <<= 1;

                // if current bit is '1' , then set it
                if ((int)(n & 1) == 1)
                    rev |= 1;

                // bitwise right shift  
                //'n' by 1 
                n >>= 1;
            }
            // required number 
            return rev;
        } 

        public bool getBit(int num, int i)
        {
            var x = num & (1 << i);
            Console.WriteLine(x);
            return x > 0 ? true:false;
        }
    }
}
