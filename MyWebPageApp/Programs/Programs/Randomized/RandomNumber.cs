using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace programs
{
    public class RandomNumber
    {

         static int count = 0;

         Random random = new Random();
         int res;

        public int SelectRandom(int n)
        {
            count++;
            if (count == 1)
                res = n;
            else
            {
                //generate the random number between 0 to count 1
                int r = random.Next() % count;

                //replace the prev number with new number with 1/count probability
                if (r == count - 1)
                    res = n;
            }
            return res;
        }
    }
}
