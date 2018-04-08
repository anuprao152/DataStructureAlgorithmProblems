using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace programs
{
    public class EditDistanceAlgo
    {
        public int EditDistance(string source, string target, int i, int j)
        {
            //if source string is empty, then you need to insert each character from target string
            //so that operation is length of target string
            if (i == 0) return j;

            //if target string is empty, then you need to delete each character from source string,
            //that operation is length of source string
            if (j == 0) return i;

            // if current character in doesn't match, then perform operation
            if (source[i] == target[j])
               return EditDistance(source, target, i - 1, j - 1);
            
            int res1 =  EditDistance(source, target, i - 1, j - 1);  // DOG -> DOT , replace G with T , subproblem EditDistance( DO, DO )
            int res2 = EditDistance(source, target, i - 1, j);       // DO - > DOT, remove G , subproblem EDitDistance(DO, DOT)
            int res3 = EditDistance(source, target, i, j - 1);       // DOG (T) -> DOT , Insert T , subproblem EditDistance(DOG,DO) 

            return 1 + Math.Min(Math.Min(res1, res2), res3);  
        }
    }
}
