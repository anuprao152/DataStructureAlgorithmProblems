using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace programs
{
    public class PrefixMatchingTrie
    {

        public class TrieNode
        {
            public char c;
            public Dictionary<char, TrieNode> trieNodes;
            public Boolean isEnd;

            public TrieNode(){ }

            public TrieNode(char c)
            {
                this.c = c;
                //trieNodes.Add(c, new TrieNode(c));
            }

            public TrieNode GetChild(char c)
            {
                return trieNodes[c];
            }
        }

        public class Trie
        {
            public TrieNode root;

            public Trie()
            {
                root = new TrieNode();
            }

            public void insert(string word)
            {
                TrieNode cur = root;

                for(int i=0;i < word.Length ; i++)
                {
                    char c = word[i];

                    if(cur.GetChild(c)!=null)
                        cur = cur.GetChild(c);
                    else{
                        TrieNode temp = new TrieNode(c);
                        cur.trieNodes.Add(c, temp);
                        cur = temp;
                    }
                }

                cur.isEnd = true;
            }

        }



        public Trie trie;
        //Program

        //http://www.geeksforgeeks.org/longest-prefix-matching-a-trie-based-solution-in-java/
        public void FindPrefixString(string input)
        {
            TrieNode crawl = trie.root;
            StringBuilder sb = new StringBuilder();

            int length = 0;
            for (int i = 0; i < input.Length; i++)
            {
                char c = input[i];

                if (crawl.GetChild(c) != null)
                {
                    sb.Append(c);
                    if (crawl.isEnd)
                    {
                        Console.Write(sb.ToString());
                        //crawl = crawl.GetChild(c);
                    }
                }
                else
                {
                    sb.Append(sb.ToString());
                    break;

                }
            }

            if (crawl != null)
            {
            }

        }

    }
}
