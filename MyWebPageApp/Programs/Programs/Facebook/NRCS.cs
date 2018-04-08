using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Programs.Facebook
{
    public class NRCS
    {
        public String LongestNonRepeatingSubString(String str)
        {
            int start = 0;
            int cur_length = 1;
            int maxlength = int.MinValue;

            int[] Visited = new int[256]; // index of each character

            for(int i=0;i<Visited.Length;i++)
                Visited[i]=-1;

            Visited[str[0]] = 0; 

            for(int i=1; i< str.Length; i++)
            {
                int index = Visited[str[i]];

                //not visited
                if (index == -1 || index < start)
                    cur_length++;
                else
                {
                    if (cur_length > maxlength)
                        maxlength = cur_length;

                    start = index + 1;
                    cur_length = i - start;
                }

                Visited[str[i]] = i;
            }

            return null;
        }
    }
}
