using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Programs
{
    public class RomanToInt
    {
        public int funRomanToInt(String roman)
        {
            //basics
            // A number written in Arabic numerals can be broken into digits. 
            // For example, 1903 is composed of 1 (one thousand), 9 (nine hundreds), 0 (zero tens), and 3 (three units). 
            // To write the Roman numeral, each of the non-zero digits should be treated separately. In the above example, 1,000 = M, 900 = CM, and 3 = III. Therefore, 1903 = MCMIII.  
            // The symbols "I", "X", "C", and "M" can be repeated three times in succession, but no more. 
            // (They may appear more than three times if they appear non-sequentially, such as XXXIX.) "V", "L", and "D" can never be repeated. 
            // "I" can be subtracted from "V" and "X" only. "X" can be subtracted from "L" and "C" only. "C" can be subtracted from "D" and "M" only. "V", "L", and "D" can never be subtracted.
            // Only one small - value symbol may be subtracted from any large-value symbol.
            // You would not put more than one smaller number in front of a larger number to subtract. For example, IIV would not mean 3.

            // You must separate ones, tens, hundreds, and thousands as separate items.
            // That means that 99 is XCIX, 90 + 9, but never should be written as IC.
            // Similarly, 999 cannot be IM and 1999 cannot be MIM.

            // Input is guaranteed to be within the range from 1 to 3999.

            //https://www.youtube.com/watch?v=KwrAArXFF30
            //https://ideone.com/CCO0w0

            Dictionary<char, int> dict = new Dictionary<char, int>();
            dict.Add('I', 1);
            dict.Add('V', 5);
            dict.Add('X', 10);
            dict.Add('L', 50);
            dict.Add('C', 100);
            dict.Add('D', 500);
            dict.Add('M', 1000);

            int sum=0;
            int p = 0;

            for(int i=roman.Length-1; i<=0; i++)
            {
                if(dict[roman[i]]>=p)
                {
                    sum += dict[roman[i]];
                }
                else
                {
                    sum -= dict[roman[i]];
                }

                p = dict[roman[i]];
                
            }

            return 0;
            
        }
    }
}
