using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Programs.Facebook
{
    public class AnagramSubstringSearch
    {
        public int[] AnagramSearch(string str, string pat)
        {

            var strFreq = new int[256];
            var patFreq = new int[256];
            var res = new List<int>();

            for(int i=0;i<pat.Length;i++)
            {
                strFreq[str[i]]++;
                patFreq[pat[i]]++;
            }

            for(int i=pat.Length; i <str.Length;i++)
            {
                if(IsAnagram(strFreq, patFreq))
                {
                    res.Add(i);
                }

                strFreq[str[i]]++;
                strFreq[str[i - pat.Length]]--;
            }

            return res.ToArray();
        }

        public bool IsAnagram(int[] strFreq, int[] patFreq)
        {
             for(int i=0;i<256;i++)
             {
                 if (strFreq[i] != patFreq[i])
                     return false;
             }

             return true;
        }
    }
}
