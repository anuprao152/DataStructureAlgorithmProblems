using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace programs
{
    public class ConnectedIsland
    {
        public int FindNumberOfIsland(int[][] matrix)
        {
            Boolean[,] visited = new Boolean[matrix.Length,matrix[0].Length];
            int islandcount = 0;
            //visit every cell in matrix to check Island starts and apply DFS 
            for (int row = 0; row < matrix.Length; row++)
            {
                for (int col = 0; col < matrix[0].Length; col++)
                {
                    //DFS (Explore)
                    if(!visited[row,col] && matrix[row][col]==1)
                        islandcount++;
                    ExploreIsland(matrix,visited,row, col);
                }
            }

                return islandcount;
        }

        //DFS
        private void ExploreIsland(int[][] matrix, bool[,] visited, int row, int col)
        {
            if (col >= matrix[0].Length || col < 0 || row >= matrix.Length || row < 0 )
                return;

            if (!visited[row, col] && matrix[row][col] == 1)
            {
                visited[row, col] = true;
                for (int r = -1; r <= 1; r++)
                    for (int c = -1; c <= 1; c++)
                        ExploreIsland(matrix, visited, row + r, col + c);
            }
        }
    }
}
