using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Programs.Facebook
{
    // https://www.geeksforgeeks.org/minimum-number-of-squares-whose-sum-equals-to-given-number-n/
    // Description
    // Base case: 1= 1*1,  2= 1*1 + 1*1,  3= 1*1 + 1*1 + 1*1 

    // Example :
    // Min (12): Min ( MinSquare(12-1), MinSquare(12-4), MinSquare(12-9) } +1 
    //           Min { MinSquare(11), MinSquare(8), MinSquare(3) } +1  
    //           Min {3 (9+1+1), 2(4+4) , 3 (1+1+1) } + 1
    //           ans (2+1) =3 => ( 4+4+4)

    public class PerfectSquare
    {
        public int MinOfSquares(int num)
        {
            if (num <= 3)
                return num;

            int min = num;
            for (int i = 1; i * i <= num; i++) // choices 1,4,9,etc
            {
                var square = i * i;
                var sol = MinOfSquares(num - square) + 1;

                if (sol < min)
                    min = sol;
            }

            return min;

        }

    }
}
