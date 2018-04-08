using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace programs
{
    /// <summary>
    /// Conver any numberSystem to any NumberSystem
    /// 1. Convert into Decimal system
    /// 2. decimal to another system that you want  
    /// 
    /// Example
    /// //Convert Number to Decimal System
    //Formula :
    //Decimal = 0;
    //Decimal = Decimal * Base + every character of numString ( left to right ) 
    //Example Binary 110 is 6 in Decimal
    //         1  = 0 * 2(base) + 1 ( from left side)
    //         3  = 1 * 2(base) + 1
    //         6  = 3 * 2(base) + 0
    // you get Decimal 6 is Answer. Done
    // And we know how to convert decimal to any system.(prog ConvertNumToBase)
    /// </summary>
    public class NumberConverter
    {
        public void NumConverter(string num, int baseN)
        {
            int decimalN = 0;
            for( int i=0; i < num.Length; i++)
            {
                decimalN = decimalN * baseN + int.Parse(num[i].ToString());
            }
            Console.Write("\n" + decimalN);
        }
    }
}
