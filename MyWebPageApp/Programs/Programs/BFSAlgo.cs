using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace programs
{
    public class gNode
    {
        int data;
        public List<gNode> gNodes;
        public Boolean visited;
    }
    class BFSAlgo
    {
        public void BFS(gNode root)
        {
            Queue<gNode> q = new Queue<gNode>();
            q.enqueue(root);
            root.visited = true;

            while (q.length > 0)
            {
                gNode gnode = q.dequeue();
                
                foreach (gNode n in gnode.gNodes)
                {
                    if(!n.visited)
                    {
                        n.visited = true;
                        q.enqueue(n);
                    }
                }
            }
        }
    }
}
