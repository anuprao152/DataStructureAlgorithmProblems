using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace programs
{
    public class Anagram
    {
        //Find two strings are anagram of eachother

        public const int numberOfChar = 256;

        public Boolean FindAnagram(String s1, String s2)
        {

            if (s1.Length != s2.Length)
                return false;

            char[] charS1 = s1.ToCharArray();
            char[] charS2 = s2.ToCharArray();

            int[] countS1 = new int[numberOfChar];//dictionary  256
            int[] countS2 = new int[numberOfChar];

            //both string characters should exist in both string with same count 
            for (int i = 0; i < s1.Length ; i++)
            {
                countS1[charS1[i]]++; // ascii value as a index
                countS2[charS2[i]]++;
            }

            for (int i = 0; i < numberOfChar; i++)
            {
                if(countS1[i]!=countS2[i])
                    return false;
            }
            
            return true;
        }
    }
}
