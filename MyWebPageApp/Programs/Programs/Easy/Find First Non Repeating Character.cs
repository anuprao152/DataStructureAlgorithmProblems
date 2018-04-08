using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;

namespace programs
{
    public class FirstNonRepeatingCharacter
    {
        /// <summary>
        /// Scan the String first time and count character
        /// Scan the String second time where encounter coutn 1, 
        /// for the first time for a character return that character
        /// 
        /// twist question: read the string and print char once it has been found duplicate.
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public char FindFirstNonRepCh(String str)
        {
            char firstNonRep ='\0';
            Dictionary<char, int> chrCount = new Dictionary<char, int>();

            //scan First time and count the occurrence of char
            for (int i = 0; i < str.Length; i++)
            {
                if (!chrCount.ContainsKey(str[i]))
                {
                    chrCount.Add(str[i], 1);
                }
                else
                {
                    int count = chrCount[str[i]];
                    chrCount[str[i]] = count+1;
                }
            }

            //Scan the string second time and check the character that occure 1 time,
            //character you found first that occure 1 time return
            for (int i = 0; i < str.Length; i++)
            {
                if (chrCount[str[i]] == 1)
                {
                    return str[i];//retrun from here only, below return never execute
                }
            }

            return firstNonRep;
        }
    }
}
