using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace programs
{
    /// <summary>
    /// Trie structure consist of TrieNodes,
    /// These nodes are not only left or right (like binary tree)
    /// nodes are consist of 26 characters that stores char value
    /// </summary>
    public class TrieNode
    {
        public TrieNode[] nodes;
        public Boolean isEnd = false;

        public TrieNode()
        {
            nodes = new TrieNode[26];
        }

        // childe point node exist that has c character
        public Boolean Contains(Char c)
        {
            int n = c - 'a';
            if (n < 26)
                return (nodes[n] != null);
            else
                return false;
        }

        //return the child tree with rooted with c character
        //e.g Boot word will get scan from left to right
        // b get the tree that starts on o
        public TrieNode GetChild(char c)
        {
            int n = c - 'a';
            return nodes[n];
        }
    }

    public class Tries
    {
        public TrieNode root;
        public Tries()
        {
            root = new TrieNode();
        }


        private TrieNode Insert(char c, TrieNode node)
        {
            if (node.Contains(c))
                return node.GetChild(c);
            else
            {
                int n = c - 'a';
                return node.nodes[n] = new TrieNode();
            }
        }

        private TrieNode Contains(char c, TrieNode node)
        {
            if (node.Contains(c))
                return node.GetChild(c);
            else
                return null;
        }

        public void Insert(string word)
        {
            TrieNode node = root;
            foreach (char c in word)
            {
                node = Insert(c, node);
            }
            node.isEnd = true;
        }

        public Boolean Contains(string word)
        {
            TrieNode node = root;
            Boolean contains = true;
            foreach (char c in word)
            {
                node = Contains(c, node);
                if (node == null)
                    contains = false;
                break;
            }

            if (node == null || (!node.isEnd))
                contains = false;

            return contains;
        }
    }
}
