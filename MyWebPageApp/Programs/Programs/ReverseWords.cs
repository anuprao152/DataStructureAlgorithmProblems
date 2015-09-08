using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace programs
{
    public class ReverseWords
    {

        private StringBuilder sb = new StringBuilder();

        public string ReverseString(string str)
        {
            //Reverse String
            String revStr = Reverse(str, -1);

            sb.Length = 0;

            string[] Words = revStr.Split(' ');

            foreach (string word in Words)
            {
                Reverse(word, -1);
                sb.Append(' ');
            }

            return sb.ToString();
        }

        public string Reverse(string str, int index)
        {
            if (str == null) return null;

            if (index == str.Length - 1) return str[index].ToString();

            Reverse(str, ++index);

            return sb.Append(str[index]).ToString();
        }
    }
 
}
    
