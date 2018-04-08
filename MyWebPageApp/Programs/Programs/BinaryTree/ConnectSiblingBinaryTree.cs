using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Programs.BinaryTree
{
    public class BNodeNext
    {
        public int data;
        public BNodeNext right;
        public BNodeNext left;
        public BNodeNext next;
    }
    public class ConnectSiblingBinaryTree
    {
        public void ConnectSibling(BNodeNext head)
        {
            Queue<BNodeNext> q = new Queue<BNodeNext>();
            q.Enqueue(head);
            BNodeNext prev = null;
            int curLevel = 1;
            int nextLevel = 0;

            while (q.Count > 0)
            {
                var node = q.Dequeue();
                curLevel--;

                if (prev != null)
                    prev.next = node;

                prev = node;

                if (node.left != null)
                {
                    q.Enqueue(node.left);
                    nextLevel++;
                }
                if (node.right != null)
                {
                    q.Enqueue(node.right);
                    nextLevel++;
                }

                //you need to maintain leve, to make prev =  null
                if (curLevel == 0)
                {
                    curLevel = nextLevel;
                    nextLevel = 0;
                    prev = null;
                }

            }

        }
    }
}
