using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace programs
{
     

    public class FloodFillPathFindAlgo
    {
        public class cell
        {
            public int x;
            public int y;
            public int dist;
            public int val;
        }

        public int FindMinPath(cell[,] matrix, cell source, cell dest)
        {
            var dist=0;

            while (source.x!=dest.x && source.y!=dest.y)
            {
                findMinCell(matrix);
            }

            return dist;
        }

        public cell findMinCell(cell[,] matrix)
        {
            return null;
        }

        public void FloodFill(cell[,] matrix, cell source, cell dest)
        {
              var r = matrix.GetLength(0);
              var l = matrix.GetLength(1);
              var visited = new Boolean[9,9];
             

              Queue<cell> q = new Queue<cell>();
              q.enqueue(source);
              visited[source.x,source.y] = true;

              while (q.length > 0)
              {
                  var cur = q.dequeue();
                  for(int i=-1; i<=1;i++)
                      for(int j=-1;j<=1;j++)
                      {
                          if(IsSafe(cur.x + i, cur.y + j, matrix, visited))
                          {
                             matrix[cur.x + i , cur.x + i].dist = cur.dist +1;
                             visited[cur.x + i, cur.x + i] = true;
                          }
                      }      
              }

              
        }

        private Boolean IsSafe(int r, int c, cell[,] matrix, Boolean[,] visited)
        {
            //check within the matrix
            if (r < 0 || c < 0 || r >= matrix.GetLength(0) || c >= matrix.GetLength(1))
                return false;

            //check within the 
            if ((matrix[r,c].val == 0)|| visited[r,c])
                return false;

            return true; 
        }
    }
}
