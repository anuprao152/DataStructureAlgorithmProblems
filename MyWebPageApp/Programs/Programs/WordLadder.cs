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
            //["hot","dot","dog","lot","log"]
            dict.Add("hot", false);
            dict.Add("dot", false);
            dict.Add("dog", false);
            dict.Add("lot", false);
            dict.Add("log", false);
        }

        public List<string> Transform(string src, string dest)
        {
            Queue<string> q = new Queue<string>();
            q.enqueue(src);
            dict[src] = true;//visited

            var res = new List<string>();

            while (q.length!=0)
            {
                string word = q.dequeue();

                if (word == dest)
                    return res;

                //create a new word and check into dictionary and add into queue
                for (int i = 0; i < word.Length; i++)
                {
                    var wordArray = word.ToCharArray();

                    for (char c = 'a'; c <= 'z'; c++)
                    {
                        var temp = wordArray[i];

                        if (wordArray[i] != c)
                        {
                            wordArray[i] = c;
                        }

                        var newWord = wordArray.ToString();

                        if (dict.ContainsKey(newWord) && !dict[newWord])// newWord should not be visited (avoid loop)
                        {
                            q.enqueue(newWord);
                            dict[newWord] = true;
                            res.Add(newWord);
                        }

                        wordArray[i] = temp;
                    }
                    
                } 
            }

            return res;
        }
    }
}
