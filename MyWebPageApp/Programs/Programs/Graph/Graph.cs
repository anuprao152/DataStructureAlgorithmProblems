using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Programs.Graph
{
    public class Graph
    {
        public List<Vertex> Verticies;

        public Graph()
        {
            Verticies = new List<Vertex>();
        }

        public void AddEdge(Vertex source, Vertex dest)
        {
            source.Neighbours.Add(dest);
        }
    }

    public class Vertex
    {
        public List<Vertex> Neighbours;
        public int value;
        public int vId;

        public Vertex(int value)
        {
            this.value = value;
            Neighbours = new List<Vertex>();
        }
    }
}
