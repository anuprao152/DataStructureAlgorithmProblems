using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Programs.Recursion
{
    public class Power
    {
        public int PowerFun(int x, int y)
        {
            if (y == 0)
                return 1;

            if (y % 2 == 0)
            {
                var temp = PowerFun(x, y / 2);
                return temp * temp;
                //return Power(x, y / 2) * Power(x, y / 2);
            }
            else
            {
                var temp = PowerFun(x, y / 2);
                return temp * temp;
                //return x * Power(x, y / 2) * Power(x, y / 2);
            }
        }
    }
}
