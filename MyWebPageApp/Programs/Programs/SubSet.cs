using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace programs
{
    public class SubSetProb
    {
        public void Subset(int[] arr, int i, int[] output, int j)
        {
            if (i >= arr.Length)
                return;

            output[j] = arr[i];

            print(output, j);

            //include   
            Subset(arr, i + 1, output, j + 1);
            //Exclude
            Subset(arr, i + 1, output, j);
        }

        private void print(int[] output,int len)
        {
            for (int i = 0; i <= len; i++)
                Console.Write(output[i]);

            Console.WriteLine();
        }
    }
}
