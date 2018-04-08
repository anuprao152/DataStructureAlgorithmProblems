using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Programs.Interview.Zulily
{
    public class SwitchFlip
    {
        private int FindTotalLit(char[][] Grid, int[] columnsToflip, int index, Stack<int> stack, char[][] origionalGrid)
        {
            Stack<int> saveStack = new Stack<int>();


            while(stack.Count > 0)
            //for (int i = 0; i <=index ; i++)
            {
                var c = stack.Pop();
                saveStack.Push(c);
                //var c = columnsToflip[i];
                //flip column
                for(int r=0;r<Grid.Length;r++)
                {
                    if (Grid[r][c] == 'Y')
                        Grid[r][c] = 'N';
                    else if (Grid[r][c] == 'N')
                        Grid[r][c] = 'Y';
                }
            }

            //Count number of row that lit up 
            int count = 0;
            for(int r =0;r < Grid.Length; r++)
            {
                var flag = false;
                for(int c=0; c < Grid[0].Length ; c++)
                {
                    if (Grid[r][c] == 'N')
                    {
                        flag = true;
                        break;
                    }      
                }

                if (!flag)
                    count++;
            }

            while (saveStack.Count > 0)
                stack.Push(saveStack.Pop());

            //make origional grid
            for (int r = 0; r < origionalGrid.Length; r++)
            {
                for (int c = 0; c < origionalGrid[0].Length; c++)
                {
                    Grid[r][c] = origionalGrid[r][c];
                }
            }

            return count;
        }

        public int MaxRowsLitup(char[][] Grid, int c, int index, int[] cols, int maxRowsLitup, Stack<int> stack, int min, char[][] origional)
        {
            if (c >= Grid[0].Length) return maxRowsLitup;

            cols[index] = c;
            stack.Push(c);

            var value = FindTotalLit(Grid, cols, index, stack, origional);

           if (value > maxRowsLitup)
           {
               maxRowsLitup = value;
               min = stack.Count;
           }

            MaxRowsLitup(Grid, c + 1, index + 1, cols, maxRowsLitup, stack,min,origional);

            stack.Pop();

            MaxRowsLitup(Grid, c + 1, index, cols, maxRowsLitup,stack, min,origional);

            //return maxRowsLitup;
            return min;
        }
    }
}
