using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace programs
{
    public class _2Sum
    {
        public int[] arr = new int[5] { 1, 2, 3, 4, 5 };

        public void SumK(int sum)
        {
            Dictionary<int,int> dict = new Dictionary<int,int>();

            for (int i = 0; i < arr.Length; i++)
            {
                int value = sum - arr[i];
                if (dict.ContainsValue(value))
                {
                    Console.WriteLine("pair Exist");
                }
                else
                {
                    dict.Add(i, value);
                }

            }
        }

        //public void 3Sum(

    }
}
