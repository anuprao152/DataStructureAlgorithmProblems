using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace programs
{
    public class Word
    {
        public int frequency;
        public List<int> line = new List<int>();

        public Word(){}

        public Word(int frequency, int lineNum)
        {
            this.frequency = frequency;
            this.line.Add(lineNum);
        }
    }

    public class Concordance
    {
        private Dictionary<string, Word> dict = new Dictionary<string,Word>();

        public void Read(string fileName)
        {
            if (File.Exists(fileName))
            {
                StreamReader sr = new StreamReader(File.OpenRead(fileName), Encoding.Default, true);

                string line = string.Empty;
                string word = string.Empty;

                int lineCount =1;
                Boolean wordEnd = true;

                while (!sr.EndOfStream)
                {
                    line = sr.ReadLine();

                    int start = 0;//start Index of the word
                    int end = 0; //end Index of the word 

                    for (int i = 0; i < line.Length; i++)
                    {
                        //word always start when you encounter first character after last word found 
                        if ((line[i] >= 'a' && line[i] <= 'z' || line[i] >= '0' && line[i] <= '9' || line[i] >= 'A' && line[i] <= 'Z') && wordEnd)
                        {
                                start = i;
                                wordEnd = false;
                        }
                        else
                        {
                            //word ends with space or line ends
                            if ((line[i] == ' ' || i == line.Length-1) && !wordEnd)
                            {
                                //word should be end with char or digits
                                for (int j = i; j >= start; j--)
                                {
                                    if (line[j] >= 'a' && line[j] <= 'z' || line[j] >= '0' && line[j] <= '9' || line[j] >= 'A' && line[j] <= 'Z')
                                    {
                                        end = j;
                                        break;
                                    }
                                }

                                word = line.Substring(start, end - start + 1);

                                //first time, Add a word in a dictionary obj
                                //if word already in dictionary obj, update frequncy and line number
                                if (dict.ContainsKey(word))
                                {
                                    Word w = dict[word];
                                    w.frequency++;
                                    w.line.Add(lineCount);
                                }
                                else
                                {
                                    dict.Add(word,new Word(1,lineCount));
                                }
                                    
                                wordEnd = true;
                            }
                        }
                    }

                    lineCount++;
                }
                sr.Close();
            }

            print();
        }

        //Print the Words Frequencies and line Numbers
        private void print()
        {
            StringBuilder sb = new StringBuilder();

            //sort the dict key values (words) by ascending order and print
            dict = dict.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);

            foreach(string word in dict.Keys)
            {
                Word w = dict[word];
                sb.Append(word);
                sb.Append("         " + w.frequency +" :");
                foreach (int lineNum in w.line)
                    sb.Append(lineNum + ",");

               Console.WriteLine(sb.ToString().TrimEnd(',') );
               sb.Remove(0, sb.Length); 
            }
        }
    }
}
