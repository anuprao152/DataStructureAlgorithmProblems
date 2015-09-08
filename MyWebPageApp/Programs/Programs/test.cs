using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace programs
{
    public class test
    {
        public int func()
        {
            int[] n = new int[] { 1, 2, 3, 5, 6, 7, 8, 9 };
            int i = 0;

            while (  i < n.Length-1 && n[i+1] > n[i])
            i++;

            return i + 1;

        }
    }
}
