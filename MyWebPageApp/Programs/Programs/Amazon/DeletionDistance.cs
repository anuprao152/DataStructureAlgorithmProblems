using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Programs.Amazon
{
    public class DeletionDistanceProg
    {

        public int DeletionDistance(string source, string target, int i, int j)
        {
            //if source string is empty, then you need to insert each character from target string
            //so that operation is length of target string
            if (i == 0) return j;

            //if target string is empty, then you need to delete each character from source string,
            //that operation is length of source string
            if (j == 0) return i;

            // if current character in doesn't match, then perform operation
            if (source[i] == target[j])
                return DeletionDistance(source, target, i - 1, j - 1);


            int res2 = DeletionDistance(source, target, i - 1, j);       // DO - > DOT, remove G , subproblem EDitDistance(DO, DOT)

            return res2; 

        }

    }
}
