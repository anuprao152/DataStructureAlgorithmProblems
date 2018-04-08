using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace programs
{
    public class FibonaciSeries
    {
        //recursive
        public int Fib(int number)
        {
            if (number == 0 ) return 0;
            if (number == 1 ) return 1;

            return Fib(number - 2) + Fib(number - 1);

        }

        public int fibIteratively(int number)
        {
            //Fn = fn-1 + fn-2

            int fn=0;

            if (number == 0) return 0;
            if (number == 1) return 1;

            int fn2 = 0;
            int fn1 = 1;

            for(int i=2; i <= number; i++)
            {
                fn = fn2 + fn1;

                fn2 = fn1;
                fn1 = fn;
            }

            return fn;
        }

    }
}
