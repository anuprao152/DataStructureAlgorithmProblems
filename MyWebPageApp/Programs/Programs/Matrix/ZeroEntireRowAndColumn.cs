using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace programs
{
    public class ZeroEntireRowAndColumn
    {
        public void SetZero(int[][] matrix)
        {
            //Use New Matrix to flag the Matrix cell that has Zero in it or ( Array row and column) 
            //basically you flaggin which row and column you need to zero in next iteration

            Boolean[] row = new Boolean[matrix.Length];
            Boolean[] col = new Boolean[matrix[0].Length];

            for (int i=0; i < matrix.Length; i++)
                for (int j = 0; j < matrix[0].Length; j++)
                {
                    if (matrix[i][j] == 0)
                    {
                        row[i] = true;
                        col[j] = true;
                    }
                }

             for (int i=0; i < matrix.Length; i++)
                 for (int j = 0; j < matrix[0].Length; j++)
                 {
                     if (row[i] || col[j])
                     {
                         matrix[i][j] = 0;
                     }
                 }

             printMatrix(matrix);
        }

        public void printMatrix(int[][] matrix)
        {
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[0].Length; j++)
                {
                    Console.Write("{0} ", matrix[i][j]);
                }
                Console.WriteLine();
            }
        }
    }
}
