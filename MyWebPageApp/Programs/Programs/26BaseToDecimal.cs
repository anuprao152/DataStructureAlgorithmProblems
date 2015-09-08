﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace programs
{
    public class _26BaseToDecimal
    {

        char[] alpha = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

        public void lettersToDecimal(string input, int baseN=26)
        {
           

            int decimalN = 0;

            for (int i = 0; i < input.Length; i++)
            {
                // aasci value for 'a' is 97 so, a-a + 1=97-97 + 1= 1 , So a=>1, b-a+1=98-97+1=2, so b=>2 (mapping)
                decimalN = decimalN * baseN + int.Parse((input[i] - 'a' + 1).ToString());


                //decimalN = decimalN * baseN + int.Parse((indexOf(input[i])  + 1).ToString());
            }

            Console.WriteLine("For alphabate {0} decimal is {1}", input, decimalN);
        }

        public void Decimaltoletters(int number, int baseN = 26)
        {
            Stack<char> letters = new Stack<char>();
            while (number != 0)
            {
                int rIndx = number % baseN;
                letters.Push(Convert.ToChar(alpha[rIndx]+'a'-1));
                number = number / baseN;
            }

            while (letters.Count != 0)
                Console.Write(letters.Pop());
        }

        //public int indexOf(char c)
        //{
        //    int i = 0;
        //    for (; i < alpha.Length; i++)
        //    {
        //        if (alpha[i] == c)
        //        {
        //            break;
        //        }
        //    }
        //    return i;
        //}
    }
}
