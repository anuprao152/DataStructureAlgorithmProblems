using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace programs
{
    public class LongestSubstringWithKUniqueCharacters
    {
        public int LongestSubstringWithKUniqueChars(string str, int k)
        {
            if (str == null || k == 0)
                return 0;

            if (str.Length < k)
                return 0;

            var dict = new Dictionary<char, int>();
            var count = 0;
            var start = 0;

            var max = int.MinValue;

            for (int i = 0; i < str.Length; i++)
            {
                if (!dict.ContainsKey(str[i]))
                {
                    dict.Add(str[i], 1);
                    count++;
                }
                else
                {
                    dict[str[i]]++;
                }

                if (count > k)
                {

                    max = Math.Max(max, i - start);
                    while (count > k)
                    {
                        if (dict[str[start]] == 1)
                        {
                            dict.Remove(str[start]);
                            count--;
                        }
                        else
                        {
                            dict[str[start]]--;
                        }
                        start++;
                    };
                }
            }

            return max;
        }
    }
}
