using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace programs
{
    public class MinimumCostPath
    {
        public int FindMinCostPath(int[][] Matrix, int r, int c, int cost, int min)
        {
            if (r < 0 || r >= Matrix.Length || c < 0 || c >= Matrix[0].Length)
                return cost;

            // you reach destination
            if (r == Matrix.Length - 1 && c == Matrix[0].Length - 1)
            {
               return Matrix[r][c];
            }

            cost += Matrix[r][c];

            var min1 = Matrix[r][c] + FindMinCostPath(Matrix, r + 1, c, cost, min);
            var min2 = Matrix[r][c] + FindMinCostPath(Matrix, r, c + 1, cost, min);
            var min3 = Matrix[r][c] + FindMinCostPath(Matrix, r + 1, c + 1, cost, min);

             var tem = Math.Min(min1, min2);
             return Math.Min(min3, tem);
            // return min;

        }
    }
}
