using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace programs
{

    //Summary
    // 
    public class KMP
    {
        private int[] lps;

        public void findPattern(string pattern, string text)
        {
           PreProcessPattern(pattern);
        }

        private void PreProcessPattern(string pattern)
        {
            int len = 0; // longest prefix suffix string in pattern
            lps[0] = 0; // it is alwasy 0;
            int i =1;

            while (i < pattern.Length)
            {
                if (pattern[i] == pattern[len])
                {
                    len++;
                    lps[i] = 1;
                    i++;
                }
                else
                {

                }
            }

        }
    }
}
