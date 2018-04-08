using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Programs.Recursion
{
    public class LongestRouteInMatrix
    {
        public void PrintLongestRouteInMatrix(int[][] M)
        {
            var visited = new Boolean[9,9];
            FindLongestRouteInMatrix(M, 0, 0, 5, 7, visited, 0, int.MinValue);

            //Print visited matrix which is longest path
        }

        public void FindLongestRouteInMatrix(int[][] M, int i, int j, int x, int y, Boolean[,] visited, int dist, int maxdist)
        {
            if (i < 0 || j < 0 || i >= M.Length || j >= M[0].Length)
                return;

            if (M[i][j] != 0 && !visited[i,j])
                return;

            visited[i,j] = true;

            if (i == x && j == y)
            {
                if (maxdist < dist)
                    maxdist = dist;
                return;
            }

            //right direction
            FindLongestRouteInMatrix(M, i + 1, j, x, y, visited, dist + 1, maxdist);

            //down direction
            FindLongestRouteInMatrix(M, i, j + 1, x, y, visited, dist + 1, maxdist);

            //up direction
            FindLongestRouteInMatrix(M, i - 1, j, x, y, visited, dist + 1, maxdist);

            visited[i,j] = false;
        }
    }
}
