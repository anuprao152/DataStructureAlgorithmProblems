using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StackProgram
{
    class StringReversalinPlace_and_Recursion
    {
        //public string s;
        public StringBuilder sb;
        public string s;
        public StringReversalinPlace_and_Recursion(string s)
        {
            sb = new StringBuilder();
            sb.Append(s);
            this.s = s;
        }

        //public void swapChar(int i ,int j)
        //{
        //   cahr temp = s[i];
           
        //   s[j] = temp;
        //}

        public void ReverseString()
        {

            for (int i = 0, j = sb.ToString().Length - 1; i <= j; i++, j--)
            {
                //swapChar(i, j);
                //char temp = sb.ToString()[i];
                //sb.ToString()[i] = sb.ToString()[j];
                //sb.ToString()[j] = temp;
            }

            Console.WriteLine(sb.ToString());
        }

        public string ReverseStringRecursion(string s)
        {
            char c = s[s.Length-1];
            if (s.Length == 1) return s;
            else
            {
                return c + ReverseStringRecursion(s.Substring(0,s.Length-1));
            }
        }
    }
}
