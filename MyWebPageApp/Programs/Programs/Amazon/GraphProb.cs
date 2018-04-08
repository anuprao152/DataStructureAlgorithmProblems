using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Programs.Amazon
{

    // A frequent traveller collects all his travel tickets. 
    // A ticket has only 2 attributes, Start Journey Location name and Destination Name. Example from Delhi to Mumbai. 
    // At the end of the year, the traveller gets all his tickets together and tries to map his journey across the year. Print his travel route in a readable format. He does not remember his start location. 
    // Edit: he can visit a location multiple times, and can also go back and forth a place several times.

    //Thinking .. you can come back to same city ( vertex ) on traversal path here, so that means you considering cycle in your directed graph
    //So, here you need to consider edges ( paths ) , if you visiting same city but having different edge then visit that edge,
    // so it is a variation of DFS, where you visiting edges, not vertex
    // if you didn't visit the edge then visit and print path

    // cyclic graph you need to visit by edge not by vertex

    //Careercup - https://www.careercup.com/question?id=5178781644881920

    public class Graph
    {
        public class Vertex
        {
            public string Name;
            public List<Edge> Edges = new List<Edge>(); // Paths

            public void AddEdge(Edge e)
            {
                Edges.Add(e);
            }
        }

        public class Edge
        {
            public string source;
            public string dest;
            public Boolean visited = false;
        }

        Dictionary<string, Vertex> VertexMap;

        public Graph()
        {
            VertexMap = new Dictionary<string, Vertex>();
        }

        //create graph ,directed graph represented adjacency list
        public Graph AddEdge(string source, string dest)
        {
            if (!VertexMap.ContainsKey(source))
            {
                Vertex src = new Vertex { Name = source };
                src.AddEdge(new Edge { source = source, dest = dest });

                VertexMap.Add(source, src);
            }
            else
            {
                Vertex src = VertexMap[source];
                src.AddEdge(new Edge { source = source, dest = dest });
            }

            //create vertex for destination
            if (!VertexMap.ContainsKey(dest))
            {
                Vertex v = new Vertex { Name = dest };
                VertexMap.Add(dest, v);
            }

            return this;
        }

        //Depth first Traversal
        public void DFT(string source)
        {
            Vertex cur = VertexMap[source];

            foreach (var edge in cur.Edges)
            {
                if (!edge.visited)
                {
                    edge.visited = true;
                    Console.WriteLine(source + "-->" + edge.dest);
                    DFT(edge.dest);
                }
            }
        }
    }
}
