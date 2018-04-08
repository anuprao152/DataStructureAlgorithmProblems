using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace programs
{
    public class TopKFrequentWords
    {
        public class Entry
        {
            public string word;
            public int frequency;
            public Boolean isInHeap;
        }

        public void GetMaxFrequencyWords(string str, int k)
        {
            string[] words = str.Split(',');

            Dictionary<string, Entry> wordFrequencyMap = new Dictionary<string, Entry>();

            SortedDictionary<string, Entry> heap = new SortedDictionary<string, Entry>();
            
            Entry entry = null;
            int wordCount=0;

            for (int i = 0; i < words.Length; i++)
            {
                var word = words[i];

                if(wordFrequencyMap.ContainsKey(word))
                {
                    entry = wordFrequencyMap[word];
                }
                else
                {
                    entry = new Entry{word = word};
                    wordFrequencyMap.Add(word,entry);
                    wordCount++;
                }

                entry.frequency++;

                if(wordCount<k)
                {
                    heap.Add(word,entry);
                    entry.isInHeap = true;
                }

                //
                if(entry.frequency > heap.Min(w => w.Value.frequency))
                {
                    if(entry.isInHeap)
                    {
                        //remove and re-add with new frequency
                        heap.Remove(entry.word);
                        heap.Add(entry.word,entry);
                    }
                    else
                    {
                        heap.Remove(heap.Min().Value.word);
                        heap.Add(entry.word,entry);
                    }

                }
            }
        }
    }
}
