using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace programs
{
    public class MultiplicationRecursion
    {
        public int Mul(int x, int y)
        {
            //base case
            if (y == 0)
                return 0;
            // 2*4 e.g 2 + Mul ( 2, 3) + Mul ( 2, 2) + Mul ( 2, 1) + Mul ( 2, 0)
            if ( y > 0)
                return x + Mul(x,y-1);

            //  for negative y, Just make y positive so it hits above condition result is minus
            else
                return -Mul(x, -y);
        }
    }
}
