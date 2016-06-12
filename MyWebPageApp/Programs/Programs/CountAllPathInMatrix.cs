using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Programs
{

    //Count All number of path for top left to bottom right in Matrix
    // you either move down or right

    public class CountAllPathInMatrix
    {
        public int count = 0;
        public int CountPath(int[][] matrix, int r, int c)
        {
            if (r == matrix.Length || c == matrix[0].Length)
                return 1;

           return (CountPath(matrix, r + 1, c) +
                  CountPath(matrix, r, c + 1));
        }
    }
}
