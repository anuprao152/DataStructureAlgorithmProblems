using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace programs
{
    public class FindNumInSortedMatrix
    {
        public Boolean FindNum(int[][] Matrix, int k)
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

        public Boolean FindNumInSortedMatrixFun(int[][] Matrix, int k, int rowStart, int rowEnd, int colStart, int colEnd)
        {
            if (colStart > colEnd || rowStart > rowEnd)
                return false;

            var rowMid = (rowStart + rowEnd) / 2;
            var colMid = (colStart + colEnd) / 2;

            if (Matrix[rowMid][colMid] == k)
                return true;

            if (k < Matrix[rowMid][colMid])
            {
                return FindNumInSortedMatrixFun(Matrix, k, rowStart, rowEnd, colStart, colMid - 1) // left vertical matrix
                || FindNumInSortedMatrixFun(Matrix, k, rowStart, rowMid - 1, colMid, colEnd); // top right corner
            }

            if (k > Matrix[rowMid][colMid])
            {
                return FindNumInSortedMatrixFun(Matrix, k, rowMid + 1, rowEnd, colStart, colEnd) //lower horizontal
                || FindNumInSortedMatrixFun(Matrix, k, rowStart, rowMid, colMid + 1, colEnd); //top right corner
            }

            return false;
        }
    }
}
