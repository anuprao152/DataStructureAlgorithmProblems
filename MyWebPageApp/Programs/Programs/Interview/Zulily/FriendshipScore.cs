using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Programs.Interview.Zulily
{
    public class FriendshipScore
    {

        //public Boolean[] Visited;

        public FriendshipScore()
        {
            //int[,] AdjancyMatrix = new int[4,4];

            

        }

        public int FindScore(int[][] M, int r, Boolean[] Visited, int joint, int p1, int p2)
        {
            if(r == p2) return joint;

            Visited[r] = true;

            var min = int.MaxValue;
            for (int c = 0; c < M[0].Length; c++)
            {
                if(r!=c && M[r][c] == 1 && !Visited[c])
                {
                    //Visited[c] = true;
                    var score =  FindScore(M,c,Visited,joint+1, p1, p2);
                    Visited[c] = false;
                    if(score!=int.MaxValue && score < min)
                        min = score;
                }
            }

            return min;
        }

    }

    
}
