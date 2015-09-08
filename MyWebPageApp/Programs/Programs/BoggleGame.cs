using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace programs
{
    public class BoggleGame
    {
        public char[,] grid;
        public Boolean[,] visited;
        public int N;

        public Tries trie= new Tries();

        public BoggleGame(int N)
        {
            this.N = N;
            grid = new char[N,N];
            visited = new Boolean[N, N];//all false
            Random rnd = new Random();
            for(int i=0; i<N; i++)
                for (int j = 0; j < N; j++)
                    grid[i,j]= Convert.ToChar(rnd.Next(0,25) + 'a');
        }


        //DFS for all the grid position to explore path and get the word
        public void constructWord()
        {
            for (int i = 0; i < N; i++)
                for (int j = 0; j < N; j++)
                    DFS("", i, j);

        }

        //DFS takes vertex and explore all the path from that vertex
        //Here Vertex is a grid position 0,0 and explore all the words
        //from 0,0 ,,,
        // More, we don't explore path only from 0,0...we do the DFS for 
        //all the position in a grid
        public void DFS(string prefix,int i, int j)
        {
            if (i < 0 || j < 0 || i >= N || j >= N) return; // back track

            if (visited[i, j]) return; //if visited then backtrack

            if (!trie.Contains(prefix)) return;

            visited[i,j]=true;

            //Found a word
            prefix = prefix + grid[i,j];
            if(trie.Contains(prefix)) 
                Console.WriteLine(prefix);

            //Apply DFS for every vertex's positions (top,right,left,bottom and diagonal)
            for (int n = -1; n <= 1; n++)
                for (int m = -1; m <= 1; m++)
                    DFS(prefix, i + m, j + n);

            visited[i, j] = false;
        }
    }
}
