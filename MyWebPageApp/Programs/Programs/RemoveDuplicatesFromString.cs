using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace programs
{
    public class RemoveDuplicatesFromString
    {
        // Remove Duplicated from Unsorted Array and output should be sorted. e.g.

        // jdctndjmckp            -->    cdj
        // 1.2AE.B/ab(231/.CB/A   -->   ./12AB

        // Condition: You can't use dictionary and sort method

        //C# doesn't allow inplace removal as string is immutable

        public void RemoveDup(string str)
        {
            if (str == null) return;

            Boolean[] ascii = new Boolean[256];

            Boolean[] output = new Boolean[256]; // for sorted output by ascii

            //StringBuilder sb = new StringBuilder();

            for (int i = 0; i < str.Length; i++)
            {
                int Value = (int)str[i]; // conver character to ascii value
                if (!ascii[Value])
                {
                    ascii[Value] = true;
                }
                else
                {
                    //sb.Append(str[i]);

                    if (!output[Value])
                        output[Value] = true;
                }
            }

            StringBuilder opStr = new StringBuilder();
            for (int i = 0; i < output.Length; i++)
            {
                if(output[i])
                    opStr.Append((char)i);
            }

            //string unsorted = sb.ToString(); // unsorted output which presever order of duplicates in string

            ////For Sorted output, 

            ////1. Clare boolan array with false values
            //for (int i = 0; i < ascii.Length; i++)
            //    ascii[i] = false;

            ////Read the duplicate character string and set to true for ascill values
            //for (int i = 0; i < unsorted.Length ; i++)
            //{
            //    int val = (int)unsorted[i]; //char to ascii value
            //    ascii[val] = true; 
            //}

            //char[] sorted = new char[unsorted.Length];

            //int index = 0;
            ////print sorted output
            //for (int i = 0; i < ascii.Length; i++)
            //{
            //    if (ascii[i])
            //    {
            //        sorted[index] = (char)i;
            //        index++;
            //    }    
            //}  
        }
    }
}
