using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Programs.Interview.Zulily
{
    public class UperLowerCasePermutation
    {

        public void PermuteUpperLower(String str, Boolean[] output, int index)
        {
            if(index == str.Length)
            {
                for (int j = 0; j < str.Length;j++ )
                {
                    if (output[j])
                        Console.Write(str[j].ToString().ToUpper());
                    else
                        Console.Write(str[j].ToString().ToLower());
                }

                Console.WriteLine();
                return;
            }

                output[index] = true;
                PermuteUpperLower(str,output, index+1);
                output[index] = false;
                PermuteUpperLower(str,output, index+1);
            
        }
    }
}
