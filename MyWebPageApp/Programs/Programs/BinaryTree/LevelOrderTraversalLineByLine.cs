using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using programs;

namespace Programs.BinaryTree
{
    public class LevelOrderTraversalLineByLine
    {
        public void LineByLineLevelOrderTraversal(bnode<int> head)
        {
            var q = new System.Collections.Generic.Queue<bnode<int>>();

            q.Enqueue(head);
            int curlevel = 1;
            int nextlevel = 0;

            while (q.Count > 0)
            {
                var node = q.Dequeue();
                curlevel--;

                if(node.left!=null)
                {
                    q.Enqueue(node.left);
                    nextlevel++;
                }
                if (node.right != null)
                {
                    q.Enqueue(node.right);
                    nextlevel++;
                }

                if (curlevel == 0)
                {
                    curlevel = nextlevel;
                    curlevel = 0;
                    Console.Write("\n");
                }

            }

        }
    }
}
