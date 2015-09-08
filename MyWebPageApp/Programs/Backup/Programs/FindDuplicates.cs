using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace programs
{
    //basically what it does is 
    // take the value as a index and make the number -ve at that index 
    /// <summary>
    ///  For duplicate value,
    ///  if you go to index (value) so will find negavtive number that is already set.
    ///  0(n) time complexity
    ///  This program works only for positive number and number range should be within array range.
    /// </summary>
    class FindDuplicates
    {
        public void findDup(int[] arr)
        {
            int i;
            Console.WriteLine("The repeating elements are: \n");
            for (i = 0; i < arr.Length; i++)
            {
                if (arr[Math.Abs(arr[i])] >= 0)
                    arr[Math.Abs(arr[i])] = -arr[Math.Abs(arr[i])];
                else
                    Console.WriteLine(  Math.Abs(arr[i]));
            }
        }
    }
}
