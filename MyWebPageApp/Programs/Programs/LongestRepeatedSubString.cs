using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace programs
{
    /// <summary>
    /// https://www.careercup.com/question?id=5694865288462336
    /// Longest prefix matching (Trie based solution);
    /// </summary>
    public class LongestRepeatedSubString
    {

        TrieNode root = new TrieNode();

        public string FindLongestRepeatedSubstring(String S)
        {
            string SubString = string.Empty;
            for (int i = 0; i < S.Length; i++)
            {
                string suffix = S.Substring(i);
                SubString = crowl(suffix, SubString );
            }

            return SubString;
        }

        String crowl(string suffix, string substring)
        {
            string res = string.Empty;
            TrieNode cur = root;
            for (int i = 0; i < suffix.Length; i++)
            {
                if (cur.Contains(suffix[i]))
                {
                    res+= suffix[i].ToString();
                    cur = cur.GetChild(suffix[i]);
                }
                else
                {
                   int index = suffix[i]-'a';
                   cur = cur.nodes[index] = new TrieNode();
                }
            }
            cur.isEnd = true;

            if (res.Length > substring.Length)
                return res;

            return substring;
        }
    }
}
