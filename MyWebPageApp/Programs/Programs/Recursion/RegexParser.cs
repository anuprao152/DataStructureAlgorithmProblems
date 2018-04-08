using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace programs
{
    public class RegexParser
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="exp"> expression</param>
        /// <param name="str">String</param>
        /// <param name="i">i is expresion pointer</param>
        /// <param name="j">j is string pointer</param>
        /// <returns></returns>
        public Boolean Match(string exp, string str, int i, int j)
        {
            // if string and expression both terminates togather then return true
            if ( i == exp.Length  && j == str.Length) return true;

            // if patters is finish, but string is not then return false
            if (i == exp.Length && j != str.Length) return false;

            // if next is * in your expression
            if (i+1!=exp.Length && exp[i + 1] == '*')
            {
                if ( (j != str.Length && exp[i] == str[j]) || (exp[i] == '.' && j != str.Length))//string is short then expressioin
                {
                    //case 1 got to next step( see in a book)
                    //case 2 repeat in current state (don't move expression pos and keep repeat string)
                    //case 3 zero occurence 
                    return (Match(exp, str, i + 2, j + 1) ||
                           Match(exp, str, i, j + 1) ||
                           Match(exp, str, i + 2, j));
                }
                else
                {
                    //ignore *
                   return Match(exp, str, i + 2, j);
                }
            }

            if ( (j!=str.Length && exp[i] == str[j]) || (exp[i] =='.' && j !=str.Length) )
            {
               return Match(exp, str, i+1, j+1);
            }
            return false;
        }
    }
}
