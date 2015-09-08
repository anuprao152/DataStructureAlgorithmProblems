using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StackProgram
{
    class FindAnagramUsePermutation
    {
        private string s;
        public List<char[]> str = new List<char[]>();
         
        
        public FindAnagramUsePermutation(string s)
        {
            this.s = s;
        }

        public void permutation(string beginningString, string endingString)
        {
            if (endingString.Length == 1) //return s; 
                Console.WriteLine(beginningString );
            else
            {
                for (int i = 0; i < endingString.Length ; i++)
                {
                    String newString = endingString.Substring(0, i) + endingString.Substring(i + 1);
                    permutation(beginningString + endingString[i], newString);
                }
                //return s[0].ToString() + permutation(s.Substring(1, s.Length - 1));
            }
        }

        private static void swap1(char[] a, int i, int j)
        {
            char c;
            c = a[i]; a[i] = a[j]; a[j] = c;
        }

        /* Function to swap values at two pointers */
        void swap(ref char x, ref char y)
        {
            char temp;
            temp = x;
            x = y;
            y = temp;
        }

        public void purmutUsingSwap(Char[] c, int n)
        {
            if (n == 1)
            {
                str.Add(c);
                 
                    for (int i = 0; i < c.Length; i++)
                    {
                        Console.Write(c[i]);
                    }
                    Console.WriteLine("");
                 
                return;
            }
            else
            {
                for (int i = 0; i < n; i++)
                {
                    swap1( c ,  i,n-1);
                    purmutUsingSwap(c, n - 1);
                    swap1(c, n-1, i);
                }
            }
        }
    }
}
