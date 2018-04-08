using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Programs.Interview.Bloomberg
{
    public class VowelsReverse
    {
        public String ReverseStringVowels(String str)
        {
            var dict = new Dictionary<char, char>();
            dict.Add('a', 'a');
            dict.Add('e', 'e');
            dict.Add('i', 'i');
            dict.Add('o', 'o');
            dict.Add('u', 'u');

            int low = 0;
            int high = str.Length - 1;

            var charArray = str.ToCharArray();

            while (low < high)
            {
                while (low < charArray.Length && !dict.ContainsKey(charArray[low]))
                    low++;

                if (low == charArray.Length)
                    return new string(charArray);

                while (high >= 0 && low < high && !dict.ContainsKey(charArray[high]))
                    high--;

                if (low == high)
                    return new string(charArray);
                //swap
                var temp = charArray[low];
                charArray[low] = charArray[high];
                charArray[high] = temp;

                low++;
                high--;

            }

            return new string(charArray);
        }
    }
}
