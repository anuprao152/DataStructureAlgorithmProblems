using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace programs
{
    public class StringReversalinPlace_and_Recursion
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
           sb = new StringBuilder();
           return Reverse(s, -1);
        }

        private string Reverse(string s,int i)
        {
            if (i == s.Length-1) return s[i].ToString(); //reach last index return last character
            i++;
            Reverse(s, i);

            return sb.Append(s[i]).ToString();
        }

        //There is another way to reverse a string
        
        //private string Reverse(string s,int i)
        //{
            //char c = s[s.Length-1];
            //if (s.Length == 1) return s;
            //else
            //{
            //    return c + ReverseStringRecursion(s.Substring(0,s.Length-1));
            //}
        //}
    }
}
