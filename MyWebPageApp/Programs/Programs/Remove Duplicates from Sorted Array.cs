using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace programs
{
    /// <summary>
    /// Logic is there are two pointers
    /// 1. i pointer linearly loop through integer  i=1 to n 1st.
    /// 2. j pointer updates the values in a array if i found different value next to the element
    /// 
    /// A=  |1||1||2||2||3||3||3||4||5|  Pointer i loop through this array
    ///            |    |         |  |
    ///           |    |         |   |  
    ///          |    |         |    |
    /// A'= |1| |2| |3|        |4|  |5| Pointer j updates the value if i pointer found different consective
    /// 
    // i loop through Array A and if next element is different update the value at pointer j and j++

    // Don't forget to extra elements at the end of the resulting array 
    // e.g in this case |3||3||4||5|

    /// A and A' are same array ( we doing inspace removal)
    /// http://discuss.leetcode.com/questions/207/remove-duplicates-from-sorted-array ( last answer)
    /// </summary>
    public class Remove_Duplicates_from_Sorted_Array
    {
        public void RemoveDuplicatesFromSortedArray(int[] sorted)
        {
            int j = 0; //update elements pointer

            for (int i = 1; i < sorted.Length; i++)
            {
                // here we checkin next element match or not, 
                //if doesn't match then j++ and update element at j index
                if (sorted[i] != sorted[j])
                {
                    sorted[++j] = sorted[i];
                }
            }

            //Remove extra elements at the end of the resulting array
            // J++ index to end of the string

        } 

        // Same logic you can use for compresse the array like
        //e.g. [aBBBAAAaaa] compress to a1B2A3 ( in place)

        public void CompressString(char[] str)
        {
            int j = 0;
            int i=1;
            int count =1;
            char temp;
            for (i = 1; i < str.Length; i++)
            {
                if (str[i] != str[j])
                {
                    j++;
                     temp = str[i];
                    str[j] = Convert.ToChar(count);// put count value 
                    j++;
                    str[j] = temp; // update the char
                    count = 1;
                }
                else{
                    count++;
                }
            }

            // last character(S) doesn't go in a if condition, so
            str[j++] = str[i-1];// for the last character
            str[j] = Convert.ToChar(count);// for the last character count
        }


    }
}
