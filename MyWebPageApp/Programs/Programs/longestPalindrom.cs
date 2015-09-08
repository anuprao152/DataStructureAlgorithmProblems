using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace programs
{
    public class longestPalindrom
    {
        //optimal sub structure
        //wrong program
        //public char[] res;
        public StringBuilder sb = new StringBuilder();
        public  Boolean[] res;

        public void FindLongestPalindromSubSequence(string s)
        {
            //res = new char[s.Length];
            res = new Boolean[s.Length];
        }

        public int LPS(string str, int i, int j,Boolean[] res)
        {
            if (i == j)
            {
                //res[i] = str[i];
                //sb.Append(str[i]);
                res[i] = true;
                return 1;
            }

            if (i + 1 == j && str[i] == str[j])
            {
                res[i] = true;
                res[j] = true;
                //sb.Append(sb.Append(str[i]));
                return 2;
            }

            if (str[i] == str[j])
            {
                res[i] = true;
                res[j] = true;
                return LPS(str, i + 1, j - 1, res) + 2;
            }

            return Math.Max(LPS(str, i , j-1,res), LPS(str, i+1, j,res ));

        }
    }
}
