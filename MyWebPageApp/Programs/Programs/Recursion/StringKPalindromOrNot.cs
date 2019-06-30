using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Programs.Recursion
{
    // https://www.geeksforgeeks.org/find-if-string-is-k-palindrome-or-not/
    // https://www.techiedelight.com/check-given-string-k-palindrome-not/

    //variation of edit distance problem
    public class StringKPalindromOrNot
    {
        public int IsKpalindromRec(string str, int i, string rev, int j)
        {
            if (i == 0)
                return j;

            if (j == 0)
                return i;

            if (str[i] == rev[j])
                return IsKpalindromRec(str, i - 1, rev, j - 1);

            var sol1 = IsKpalindromRec(str, i - 1, rev, j); // delete char from str
            var sol2 = IsKpalindromRec(str, i, rev, j - 1); //delete char from rev

            return 1 + Math.Min(sol1, sol2);
        }

        public bool IsKPalindrom(string str, int k)
        {
            var rev = Reverse(str);
            return (IsKpalindromRec(str, str.Length - 1, rev, rev.Length - 1) <= (2 * k));

        }

        public string Reverse(string str)
        {
            if (str == null || str.Length <= 1)
                return str;

            return Reverse(str.Substring(1)) + str[0];
        }
    }
}
