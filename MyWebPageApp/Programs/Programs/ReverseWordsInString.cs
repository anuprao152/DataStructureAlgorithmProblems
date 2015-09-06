using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace programs
{
    //Reverse a words in string is a two step procedure
    //1. Reverse a string
    // And then 2. reverse words
    // you also use split function to split string in array of words
    // string[] ay = s.Split(‘ ‘, ‘,’, ‘;’, ‘.’);
    class ReverseWordsInString
    {

        //private string Reverse(string str)
        //{
        //   // char[] c = str.ToCharArray();
        //   // for (int i=0, j=c.Length-1; i < j; i++,j--)
        //   // {
        //   //     c[i] = str[j];
        //   //     c[j] = str[i];
        //   // }
        //   //return c.ToString();
        //}

        public string ReverseWords(string input)
        {
            //Reverse a String
            input = new StringReversalinPlace_and_Recursion(input).ReverseStringRecursion(input);

            Boolean ischar=false;
            int startIndex = 0;
            StringBuilder sb = new StringBuilder();
             
            //reverse words in a reversed string
            for (int curIndex = 0; curIndex < input.Length; curIndex++)
            {
                // when you encounter first char after any punctuation set ischar = true,
                // so it doesn't set startIndex for consecutive characters.
                if (input[curIndex] >= 'a' && input[curIndex] <= 'z' && !ischar)
                {
                    startIndex = curIndex;
                    ischar = true;
                }
                else if (input[curIndex] ==' ' || input[curIndex] == ',' || input[curIndex]== '.' || input[curIndex]==';') // this can be only else condition for any 
                {
                    if (curIndex != startIndex)
                    {
                        string revWord = new StringReversalinPlace_and_Recursion(input).ReverseStringRecursion(input.Substring(startIndex, curIndex - startIndex));
                        sb.Append(revWord);
                    }

                   sb.Append(input[curIndex]);

                   ischar = false;
                }   
            }

            //Last word
            string last = new StringReversalinPlace_and_Recursion(input).ReverseStringRecursion(input.Substring(startIndex, input.Length - startIndex));
            sb.Append(last);
            return sb.ToString();
        }
    }
}
