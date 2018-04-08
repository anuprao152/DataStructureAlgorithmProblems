using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Programs.Interview.Vmware
{
    public class compression
    {

        public string CompressString(string str)
        {
            int j = 0;
            int i = 1;
            int count = 1;
            char temp;

            var charArray = str.ToCharArray();

            for (i = 1; i < charArray.Length; i++)
            {
                if (charArray[i] != charArray[j])
                {
                    j++;
                    temp = charArray[i];
                    if (count > 1)
                    {
                        charArray[j] = Convert.ToChar(count.ToString());// put count value 
                        j++;
                    }

                    charArray[j] = temp; // update the char
                    count = 1;
                }
                else
                {
                    count++;
                }
            }

            return new string(charArray).Substring(0,j+1);
        }
    }
}
