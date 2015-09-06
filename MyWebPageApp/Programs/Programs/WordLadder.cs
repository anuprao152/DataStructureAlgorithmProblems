using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace programs
{
    public class WordLadder
    {
        public Dictionary<string,Boolean> dict;

        public WordLadder()
        {
            dict = new Dictionary<string, Boolean>(); // boolean represents visited or not, initially nothing is visited so false
        }

        public void Transform(string src, string dest)
        {
            Queue<string> q = new Queue<string>();
            q.enqueue(src);
            dict["src"] = true;// I visited this node.

            string temp= src;
            List<string> res = new List<string>();

            while (q.length!=0)
            {
                string word = q.dequeue();

                //if(word == dest) break;

                //create a new word and check into dictionary and add into queue
                for (int i = 0; i < word.Length; i++)
                {
                    for (int j = 0; i < 26; j++)
                    {
                        //creat a new word by replacing character at ith position
                        string newWord = word.Substring(0, i) + word[j] + word.Substring(i + 1); //w may be a dest

                        if (dict.ContainsKey(newWord) && dict["newWord"]==false)// newWord should not be visited, false means not visited before
                        {
                            q.enqueue(newWord);
                            res.Add(newWord);
                            temp = newWord;
                            break;
                        }
                    }
                    break;
                } 
            }
        }
    }
}
