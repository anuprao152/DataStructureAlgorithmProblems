using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Programs.Facebook
{
    /// <summary>
    /// http://www.voidcn.com/article/p-ahfzmyxc-kv.html
    /// </summary>
    public class SubstringAtleastKRepeatingChars
    {
        public int LongestSubstringWithKRepeatingCharacters(string str, int k)
        {
            var dict = new Dictionary<char, int>();
            for (int i = 0; i < str.Length; i++)
            {
                if (!dict.ContainsKey(str[i]))
                {
                    dict.Add(str[i], 0);
                }
                else
                {
                    dict[str[i]]++;
                }
            }

            var badChars = new List<char>();

            foreach (var key in dict.Keys)
            {
                if (dict[key] < k)
                    badChars.Add(key);
            }

            if (badChars.Count <= 0)
                return str.Length;

            var max = 0; var start = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (dict[str[i]] < k)
                {
                    max = Math.Max(max, LongestSubstringWithKRepeatingCharacters(str.Substring(start, i), k));
                    start = i + 1;
                }
            }

            max = Math.Max(max, LongestSubstringWithKRepeatingCharacters(str.Substring(start), k));

            return max;
        }
    }
}
