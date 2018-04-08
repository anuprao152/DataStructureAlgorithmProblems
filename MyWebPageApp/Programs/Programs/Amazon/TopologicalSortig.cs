using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Programs.Amazon
{
    public class Vertex
    {
        public int Num;
        public List<Vertex> Adj =  new List<Vertex>();
    }

    /// <summary>
    /// http://www.geeksforgeeks.org/topological-sorting/
    /// http://www.onlineclassnotes.com/2016/03/sort-dependency-list-or-topological-sorting-in-php.html
    /// </summary>
    public class TopologicalSortig
    {
        public Vertex[] Vertexes;
        public Boolean[] Visited;

        public TopologicalSortig(int num)
        {
            Vertexes = new Vertex[num];
            Visited = new Boolean[num];

            for (int i = 0; i < Vertexes.Length; i++)
            {
                Vertexes[i] = new Vertex();

                Vertexes[i].Num = i;
            }

            Vertexes[2].Adj.Add(Vertexes[3]);
            Vertexes[3].Adj.Add(Vertexes[1]);

            Vertexes[4].Adj.Add(Vertexes[0]);
            Vertexes[4].Adj.Add(Vertexes[1]);

            Vertexes[5].Adj.Add(Vertexes[2]);
            Vertexes[5].Adj.Add(Vertexes[0]);


        }

        //PostOrder DFS
        private void TopologicalSortUtil(Vertex v, List<Vertex> output)
        {
            Visited[v.Num] = true;

            for (int i = 0; i < v.Adj.Count; i++)
            {
                if (!Visited[v.Adj[i].Num])
                    TopologicalSortUtil(v.Adj[i], output);
            }

            output.Add(v);   
        }

        public void TopologicalSort()
        {
            List<Vertex> output = new List<Vertex>();
            
            for (int i = 0; i < Vertexes.Length; i++)
            {
                if (!Visited[Vertexes[i].Num])
                    TopologicalSortUtil(Vertexes[i], output);
            }
        }
    }
}
