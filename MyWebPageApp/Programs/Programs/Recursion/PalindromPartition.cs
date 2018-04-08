using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Programs.Recursion
{
    public class PalindromPartitionProg
    {
        public List<List<string>> PalindromPartitionUtil(string str, int i, List<string> partition, List<List<string>> res)
        {
            if (i >= str.Length)
            {
                res.Add(partition);
                return res;
            }

            for(int j=i;j<str.Length;j++)
            {
                var prefix = str.Substring(i, j - i);
                if(Ispalindrom(prefix))
                {
                    partition.Add(prefix);
                    PalindromPartitionUtil(str, j + 1, partition, res);
                    partition.RemoveAt(partition.Count - 1); // backtrack remove at last index. what you added last
                }
            }

            return res;
        }

        private bool Ispalindrom(string str)
        {
            if (str == null || str == string.Empty)
                return false;

            int i = 0;
            int j = str.Length;

            while(i < j && str[i]==str[j])
            {
                i++;j--;
            }

            return (i >= j);
        }
    }
}
