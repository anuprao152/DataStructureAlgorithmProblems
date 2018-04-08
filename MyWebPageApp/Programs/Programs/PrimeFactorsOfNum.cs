using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Programs
{
    public class PrimeFactorsOfNum
    {
        public void FindPrimFactors(int number)
        {
            List<int> primeFactors = new List<int>();

            while (number % 2 == 0)
            {
                primeFactors.Add(2);
                number /= 2;
            }

            // here num will be odd, you can skip 1 num in a loop
            for (int i = 3; i <= Math.Sqrt(number); i += 2)
            {
                while (number % i == 0)
                {
                    primeFactors.Add(i);
                    number /= i;
                }
            }
        }
    }
}
