using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace programs
{
    public class Substrings // continues combination
    {
        //brute force with continious substrings ( all the prefixes/suffix of the string) or you can say all the suffix (not combination)
        // important property - all the continious subsequence formula is n * (n+1) /2
        //e.g. 123 ( 
        //1
        //12
        //123
        //2
        //23
        //3

        public void PrintAllSubstrings(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i; j < arr.Length; j++)
                {
                     print(arr,i,j);
                }
            }
        }

        public void print(int[] arr,int start, int end)
        {
            for (int i= start ; i <=end; i++)
            {
                Console.Write(arr[i]);
            }
            Console.WriteLine("\n");
        }
    }
}
