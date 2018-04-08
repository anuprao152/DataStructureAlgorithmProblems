using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace programs
{
    public class FindNumInSortedMatrix
    {
        public Boolean FindNum(int[][] Matrix,int k)
        {
            int row = 0;
            int col = Matrix.Length - 1;


            while (col >= 0 && row < Matrix.Length)
            {
                if (Matrix[row][col] == k)
                {
                    return true;
                }
                else if (k < Matrix[row][col])
                {
                    col--;
                }
                else
                {
                    row++;
                }

            }

            return false;
        }
    }
}
