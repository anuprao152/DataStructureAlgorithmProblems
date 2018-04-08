using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Programs.Amazon
{
    public class AmazonSlidingWindowK
    {
        public List<string> subStringsKDist(string inputString, int num)
        {

            if (inputString == null || num == 0)
                return null;

            if (inputString.Length < num)
                return null;

            var dict = new Dictionary<char, int>();
            var start = 0;

            var res = new List<string>();

            for (int i = 0; i < inputString.Length; i++)
            {
                if (!dict.ContainsKey(inputString[i]))
                {
                    dict.Add(inputString[i], 1);
                }
                else
                {
                    dict[inputString[i]]++;
                }

                //wawaglknagagwunagkwkwagl
                if (dict.Count >= num-1) // find k-1 distinct
                {
                   if( HasOneDuplicateChar(inputString.Substring(start, num)))
                        Console.WriteLine(inputString.Substring(start, num));


                    dict.Remove(inputString[start]);
                    start++;
                }
            }

            return res;
        }

        public Boolean HasOneDuplicateChar(string str)
        {
            //return false;
            var duplicatCount = 0;
            var dict = new Dictionary<char, int>();
            for (int i = 0; i < str.Length; i++)
            {
                if (!dict.ContainsKey(str[i]))
                    dict.Add(str[i], 1);
                else
                {
                    dict[str[i]]++;
                    duplicatCount++;
                }
            }

            if (duplicatCount == 1) return true;
            else return false;
        }
        
    }
}
