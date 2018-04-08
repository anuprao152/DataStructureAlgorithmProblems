using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Programs.Amazon
{
    public class NumberOfKsBetween0toNProg
    {
        // Count numbers from 1 to n that have 4 as a a digit
        
        //Solution : we will loop through each number and check it that number has 4 in it
        // Has4 ( itoa, where u check num % 10 == 4)

        //Best solution 
        // Formula 
        // Count ( 10^d ) = 9 * Count (10 ^ d-1) +  10 ^ d-1
        // Count (10) = only 9 =  1
        // Count (100) = 9 * 1 + 10 = 19
        // count (1000) = 9 * 19 + 10 = 273 
    }
}
