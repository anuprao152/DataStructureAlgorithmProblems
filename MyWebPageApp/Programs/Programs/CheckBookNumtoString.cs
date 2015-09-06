using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace programs
{
    public class CheckBookNumtoString
    {
        public void NumToString(int num)
        {
            string[] strDigit = {"zero" ,"one", "two", "Three", "Five", "Six", "Seven", "Eight", "Nine"};

            int digit;
            stack<string> stc = new stack<string>();

            while (num!=0)
            {
                digit = num % 10;
                num = num / 10;
                stc.push(strDigit[digit]);
            }



            while (! (stc.length == 0))
            {
                Console.Write("{0} ", stc.pop());
            }
        }
    }
}
