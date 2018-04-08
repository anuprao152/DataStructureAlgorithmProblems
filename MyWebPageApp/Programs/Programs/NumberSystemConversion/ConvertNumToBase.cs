using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace programs
{
    /// <summary>
    /// Convert any decimal number to any base System
    ///  DecimalNum %  Base = Last Digit 
    ///  DecimalNum / Base = remaining digits ( that don't include last)
    ///  remaining digit is a new number now.
    ///  
    /// E.g if you divide decimal number with base 10 ( decimal base)
    /// e.g num = 123 , base = 10
    /// 123 % 10 = 3 ( last digit)
    /// 123 / 10 = 12 ( remaining digit)
    /// 
    /// Now do the same thing with remaing digit
    /// </summary>
    public class ConvertNumToBase
    {
        /// <summary>
        /// e.g Number  = 8, in binary it is 1000
        /// 8/2 = 4 + 0 is reminder -- push (0)
        /// 4/2 = 2 + 0 is reminder -- push (0)
        /// 2/2 = 1 + 0 is reminder -- push (0)
        /// 1/2 = 0 + 1 is reminder -- push (1)
        /// 
        /// And then pop in reverse. Done
        /// Logic : Reminder is your answer
        /// In any number system digit values are less then Base
        /// </summary>
        /// <param name="num">AnyNumber</param>
        /// <param name="baseN">BaseNumber</param>
        public void BaseConverter( int num, int baseN)
        {
            Stack<int> res = new Stack<int>();
            //while (num >= baseN)
            while ( num!=0)
            {
                int reminder = num % baseN;
                res.Push(reminder);
                num = num / baseN;
            }

            //It is for while (num >= baseN)
            //Last reminder will be push here. It will not go in a 
            //while loop because it is less than the base value
            //res.Push(num);

            //pop all the value till stack become empty
            while (res.Count != 0)
                Console.Write(res.Pop()); 
        }

        //Hexadecimal Converter
        //This works for binary converter also
        public void HexaDecimalConverter(int num, int baseN)
        {
            char[] reminders = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };

            Stack<char> res = new Stack<char>();
            while (num != 0)
            {
                int rIndex = num % 16;
                res.Push(reminders[rIndex]);
                num = num / 16;
            }

            while (res.Count != 0)
                Console.Write(res.Pop());
        }




    }
}
