using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace programs
{
    public class Maze
    {
        public Boolean[,] visited;

        public Maze(int[][] M)
        {
            visited = new Boolean[M.Length, M[0].Length];// another 2d array that keep track of path
        }

        public Boolean FindPath(int[][] M, int i, int j)
        {
            if (i == M.Length - 1 && j == M[0].Length - 1) return true;//base condition we reach the destination

            visited[i, j] = true;

            // it is DFS algorithm , but you need to check weather cell is already visited or not,
            // because you are giving direction down or right
            // if you apply DFS for all adjacent node,then you don't aware which adjacent node is going to pick up,
            // and you need to take care of visited or not
            if ((i < M.Length || j < M[0].Length))
            {
                if (M[i + 1][j] == 1)
                    return FindPath(M, i + 1, j);//down 
                if (M[i][j + 1] == 1)
                    return FindPath(M, i, j + 1);//right

                //backtrack;
                visited[i, j] = false;
                return false;
            }
            return false;
        }
    }
}
