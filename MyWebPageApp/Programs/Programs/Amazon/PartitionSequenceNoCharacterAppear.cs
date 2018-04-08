using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Programs.Amazon
{
    public class PartitionSequenceNoCharacterAppear
    {

        public List<int> LengthEachScene(List<char> inputlist, List<int> partition, int i)
        {
            if (i >= inputlist.Count)
            {
                return partition;
            }

            for (int j = i; j < inputlist.Count; j++)
            {
                var partionlist = GetSubSequence(inputlist,i, j);

                if (!IsContainsIn(partionlist,j + 1, inputlist))
                {
                    if(partionlist.Count<inputlist.Count)
                        partition.Add(partionlist.Count);
                    LengthEachScene(inputlist, partition, j+1);
                   // partition.RemoveAt(partition.Count - 1); // backtrack remove at last index. what you added last
                }
            }

            return partition;
        }

        private List<char> GetSubSequence(List<char> inputlist,int i, int j)
        {
            var res = new List<char>();
            while (i <= j)
            {
                res.Add(inputlist[i]);
                i++;
            }
            return res;
        }

        //whaterver is there in partion avaialble next partition or not
        public bool IsContainsIn(List<char> partionList,int partionStartIndex, List<char> inputlist)
        {
            if (partionList == null) return false;

            var dict = new Dictionary<char, char>();

            for (int i = 0; i < partionList.Count; i++)
            {
                if(!dict.ContainsKey(partionList[i]))
                    dict.Add(partionList[i], partionList[i]);
            }

          

            for(int i=partionStartIndex; i< inputlist.Count;i++)
            {
                if (dict.ContainsKey(inputlist[i]))
                    return true;
            }

          

            return false;
        }

        public List<int> LengthEachScene(List<char> inputlist)
        {
            var partition = new List<int>();

            for (int i = 0; i < inputlist.Count; i++)
            {
                var partionList = GetSubSequence(inputlist, i, i);

                var dict = new Dictionary<char, char>();

                for (int j = 0; j < partionList.Count; j++)
                {
                    if (!dict.ContainsKey(partionList[j]))
                        dict.Add(partionList[j], partionList[j]);
                }



                for (int j = i+1; j < inputlist.Count; j++)
                {
                    if (dict.ContainsKey(inputlist[j]))
                    {
                        i = j;
                        break;
                    }
                } 
            }

            return partition;
        }
    }
}
