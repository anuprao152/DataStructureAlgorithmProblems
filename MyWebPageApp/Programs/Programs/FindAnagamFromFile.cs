using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace programs
{
    public class FindAnagamFromFile
    {
         public Dictionary<string,string> dict;
         public List<string> anagrams;

         public FindAnagamFromFile()
        {
            dict = new Dictionary<string,string>();
            anagrams = new List<string>();
        }
    
        public void GeneratePermuation()
        {
            string[] words = new string[10];

            foreach(string word in words)
            {
                if (!dict.ContainsKey(word)) // this word not is dictionary
                    Permuation("", word);
                else
                    Console.WriteLine("{0} ", dict[word]);
            }
        }
    
        public void Permuation(string prefix, string postfix)
        {
            if(postfix == string.Empty) 
            {
                //Add all the permutation 
                dict.Add(prefix, prefix);
            }
            else
            {
                for(int i=0; i < postfix.Length;i++)
                {
                    string newprefix = prefix + postfix[i];
                    string newPostfix = postfix.Substring(0,i) + postfix.Substring(i + 1);
                    Permuation(newprefix, newPostfix);
                }
            }
    }
    }
}
