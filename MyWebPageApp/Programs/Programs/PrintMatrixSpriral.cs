using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace programs
{
    public class MatrixSpriral
    {
        public int Cpointer = 0;
        public int Rpointer = 0;

        /// <summary>
        /// 4 pointer problem
        /// </summary>
        /// <param name="arr"></param>
        public void SpiralPrint (int[][] arr)
        {
            int rowStart = 0;// Row start
            int colStart =0; // column Start
            int rowEnd = arr.Length - 1; // Row End
            int colEnd = arr[0].Length - 1; // Column End

            //int track=0;

            //Example
            //  ______________________
            //  ___________________  |                  
            //  |    __________   |  |    
            //  |   |_____________|  |
            //  |____________________|
            //  Above : rowstart == rowEnd , so just print columns from start to end ,, not backword becasue rowstart == rowend
            //
            //          ________ 
            //          | ___  |
            //          | |  | |                 
            //          | |  | |   
            //          | |  | |
            //          | |____|
            // above : colstart= colend , so just print the row from start to end ,, not backword becasue colstart== columnend

            while (rowStart != rowEnd && colStart != colEnd)
            {

                for (int i = colStart; i <= colEnd; i++)
                {
                    Console.Out.WriteLine(arr[rowStart][i]);
                }

                rowStart++;

                for (int i = rowStart; i <= rowEnd; i++)
                {
                    Console.Out.WriteLine(arr[i][colEnd]);
                }

                colEnd--;

                //backward print only when rowstart doesn't reach row end( case 2 figure)
                if (rowStart < rowEnd) 
                {
                    for (int i = colEnd; i >= colStart; i--)
                    {
                        Console.Out.WriteLine(arr[rowEnd][i]);
                    }

                    rowEnd--;
                }

              

                //backward print only when rowstart doesn't reach row end( case 2 figure)
                if (colStart < colEnd)
                {
                    for (int i = rowEnd; i >= rowStart; i--)
                    {
                        Console.Out.WriteLine(arr[i][colStart]);
                    }

                    colStart++;
                }

               
            }

            //last inner central row print  case 1
            if (rowStart >= rowEnd)
            {
                for(int i= colStart; i<=colEnd; i++)
                {
                    Console.WriteLine(arr[rowStart][i]);
                }
            }

            //last inner central column print  case 2
            if(colStart >= colEnd)
            {
                for(int i=rowStart; i <= rowEnd; i++)
                {
                    Console.WriteLine(arr[i][colStart]);
                }
            }

            //for ( int 
        }



       
    }
}
