using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Programs.Facebook
{
    // next greater number
    //https://www.geeksforgeeks.org/find-next-greater-number-set-digits/

    // Please look above link for algo
    public class NextPermutation
    {
        public void GetNextPermutation(int[] num)
        {
            int i=num.Length -1;

            //find first smallest traversing from right e.g 3,4,9,8,7 ( 4 is first smallest)
            while( i-1 >=0 && num[i-1] >= num[i] )
                i--;
            

            //decresing sorted array(not possible e.g. 5,4,3,2,1)
            if(i==0)
                return;

            //find smallest digit right side of array but greater than num[i-1]
            int j = i; int smallest = i;
            while(num[i-1]< num[j] && num[j] < num[smallest]  )
            {
                smallest = j;
                j++;
            }

            swap(num, i - 1, smallest);

            //Sort i to num.Length -1
            System.Array.Sort(num, i, num.Length - i);

            Console.WriteLine(num);

        }

        private void swap(int[] num, int i, int j)
        {
            var temp = num[i];
            num[i] = num[j];
            num[j] = temp;
        }
    }
}
