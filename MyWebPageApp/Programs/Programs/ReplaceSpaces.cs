using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace programs
{
    public class ReplaceSpaces
    {
        public void ReplaceSpacesInStr(string str)
        {
            StringBuilder sb = new StringBuilder();
            //count the Number of spaces
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ' ')
                {
                    sb.Append("%20");
                }
                else
                {
                    sb.Append(str[i]);
                }
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
