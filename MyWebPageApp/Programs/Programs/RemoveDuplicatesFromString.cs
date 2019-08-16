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

        // https://www.geeksforgeeks.org/remove-duplicates-from-a-given-string/
        // https://www.geeksforgeeks.org/remove-duplicates-from-a-string-in-o1-extra-space/

        public void RemoveDup(string str)
        {
            if (str == null) return;

            Boolean[] ascii = new Boolean[256];

            for (int i = 0; i < str.Length; i++)
            {
                char ch = str[i];
                if (!ascii[ch])
                {
                    ascii[ch] = true;
                }
            }

            var res = new StringBuilder();
            for (int i = 0; i < ascii.Length; i++)
            {
                if (ascii[i])
                    res.Append((char)i);
            }
        }
    }
}
