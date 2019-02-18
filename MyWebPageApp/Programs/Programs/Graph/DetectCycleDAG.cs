using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Programs
{
    //https://www.geeksforgeeks.org/detect-cycle-in-a-graph/
    public class DetectCycleDAG
    {
        public bool IsCycle(Graph graph)
        {

            bool[] visited = new bool[graph.Verticies.Count];
            bool[] recursionArr = new bool[graph.Verticies.Count];

            for(int i=0; i< graph.Verticies.Count; i++)
            {
                if (IsCycleUtil(graph.Verticies[i], visited, recursionArr))
                    return true;
            }

            return false;
            
        }

        public bool IsCycleUtil(Vertex v, bool[] visited, bool[] recursionArr)
        {
            if(recursionArr[v.vId])
                return true;

            if(visited[v.vId])
                return false;

            visited[v.vId] = true;
            recursionArr[v.vId] = true;

            for(int i=0;i < v.Neighbours.Count; i++)
            {
                var neighbhour = v.Neighbours[i];

                if (IsCycleUtil(neighbhour, visited, recursionArr))
                    return true;
            }

            recursionArr[v.vId] = false;

            return false;
        }

    }
}
