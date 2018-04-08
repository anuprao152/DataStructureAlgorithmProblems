using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace programs
{
    public class NumberToWords
    {
        String[] single_digits = new String[] { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine"};

        String[] double_digits = new String[] { "","Ten","Twenty","Thirty","Fourty","Fifty","Sixty","Seventy","Eighty","Ninty","Hundred" };

        String[] eleven_to_nineteen = new String[] { "", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };

        public void PrintNumberToWords(int number)
        {
            StringBuilder sb = new StringBuilder();

            if (number == 0)
            {
                Console.WriteLine(number);
                return;
            }

            while(number!=0)
            {
                if(number < 10)
                {
                    sb.Append(single_digits[number]);
                    number = number / 10; // or number = 0; terminate the loop
                }

                if (number == 10)
                {
                    sb.Append("Ten");
                    number = 0; // terminate the loop
                }
                
                if(number> 10 && number <20)
                {
                    sb.Append(eleven_to_nineteen[number % 10]);
                        number=0; //terminate the loop
                }

                if ( number >= 20 && number <= 100)
                {
                    sb.Append(double_digits[number / 10]);
                    number = number % 10;
                }

                if (number > 100 && number <= 999)
                {                             
                    sb.Append(single_digits[number / 100] + "Hundred");
                    number = number % 100;                              // next number will be two digit
                }

                if (number > 1000 && number <= 9999)
                {
                    sb.Append(single_digits[number / 1000] + "Thousand");
                    number = number % 1000;                             //next number will be three digit
                }

            }

            Console.WriteLine(sb.ToString());
        }
    }
}
