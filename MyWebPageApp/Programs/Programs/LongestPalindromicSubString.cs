using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace programs
{
    public class LongestPalindromicSubstring
    {

        //o(n2) solution, using pivot

        //http://www.geeksforgeeks.org/longest-palindromic-substring-set-2/

        public Boolean IsPalindrome(string str, int i, int j)
        {
            if (i <= j) return true;

            if (str[i] != str[j])
                return false;

            return IsPalindrome(str, i + 1, j - 1);

        }

        public string FindLongestPalindromicSubstring(String str)
        {
            int maxlps = 0; // length from start index
            int start = 0; // start index of lps
            int high;
            int low;

            for (int pivot = 0; pivot < str.Length; pivot++)
            {
                //Take pivot as center and construct string , e.g. geek -> e as center
                high = pivot + 1;
                low = pivot - 1;
                while (low >= 0 && high < str.Length && str[low] == str[high])
                {
                    if (maxlps < high - low + 1)
                    {
                        start = low;
                        maxlps = high - low + 1;
                    }

                    low--;
                    high++;
                }

                // Take center points as pivot and pivot -1 , e.g  geek -> ee as center
                high = pivot;
                low = pivot - 1;
                while (low >= 0 && high < str.Length && str[low] == str[high])
                {
                    if (maxlps < high - low + 1)
                    {
                        start = low;
                        maxlps = high - low + 1;
                    }

                    low--;
                    high++;
                }
            }

            if (start == 0 && maxlps == 0)
                return str[start].ToString();

            return str.Substring(start, maxlps);
        }
    }
}
