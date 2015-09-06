using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace programs
{
    public class ShuffleNumbers
    {
        int[] numbers;

        public ShuffleNumbers()
        {
            numbers = new int[] {1,2,3,4,5,6,7,8};
        }

        public int[] shuffleNumbers()
        {
            Random random = new Random();

            for (int i= numbers.Length ; i > 1; i --)
            {
                int index = random.Next(i);
                int temp = numbers[index];
                numbers[index] = numbers[i - 1];
                numbers[i - 1] = temp;

            }
                return numbers;
        }
    }
}
