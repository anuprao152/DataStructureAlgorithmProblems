using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Programs.Facebook
{
    //Minimum Window Substring
    public class SmallestStringContainingAllChars
    {
        //https://www.geeksforgeeks.org/find-the-smallest-window-in-a-string-containing-all-characters-of-another-string/

        public string SmallestWindowContainingAllCharsFun(string str, string pat)
        {
            if (str == null || str.Length < pat.Length)
            {
                return string.Empty;
            }

            var pat_freq = new int[256];
            var str_freq = new int[256];

            for (int i = 0; i < pat.Length; i++)
            {
                pat_freq[pat[i]]++;
            }

            var count = 0;
            var start = 0;
            var minWindowLen = int.MaxValue;
            string res = string.Empty;

            for (int i = 0; i < str.Length; i++)
            {
                str_freq[str[i]]++;

                if (pat_freq[str[i]] > 0 && str_freq[str[i]] <= pat_freq[str[i]])
                    count++;

                //window found that contains pattern
                if (count == pat.Length)
                {
                    // try to minimize window
                    // 1. if current char contain more frequency than pattern 
                    // 2. cur char doesn't exist in pattern.
                    while (str_freq[str[start]] > pat_freq[str[start]] || pat_freq[str[start]] == 0)
                    {
                        str_freq[str[start]]--;
                        start++;
                    }

                    var curWindowLen = i - start + 1;

                    if (curWindowLen < minWindowLen)
                    {
                        minWindowLen = curWindowLen;
                        res = str.Substring(start, minWindowLen);
                    }
                }
            }

            if (start == 0 && minWindowLen == int.MaxValue)
                return string.Empty;

            return res;
        }
    }
}
