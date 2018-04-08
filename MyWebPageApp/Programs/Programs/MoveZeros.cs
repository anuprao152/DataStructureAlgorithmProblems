using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace programs
{
    public class MoveZerosSolution
    {
        public void MoveZeros(int[] num)
        {
            int i=0;
            int j=0;
            while (i < num.Length)
            {
                if (num[i] != 0)
                {
                    num[j] = num[i]; // update j index with non-zero number
                    j++;
                }
               i++;
            }

            while (j < num.Length)
            {
                num[j] = 0;
                j++;
            }
        }
    }
}
