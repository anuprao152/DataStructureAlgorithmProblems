using System;
using System.Linq;
using System.Text;
using programs;

namespace Programs.BinaryTree
{
    using System.Collections.Generic;

    // Microsoft
    //https://www.geeksforgeeks.org/find-next-right-node-of-a-given-key/
    public class NextRightNode
    {
        public Bnode<int> GetNextRightNode(Bnode<int> node, Bnode<int> root)
        {
            var nodeQueue = new Queue<Bnode<int>>();
            var levelQueue = new Queue<int>();

            nodeQueue.Enqueue(root);
            levelQueue.Enqueue(0);

            while (nodeQueue.Count > 0)
            {
                var curNode = nodeQueue.Dequeue();
                var curlevel = levelQueue.Dequeue();

                if (curNode == node)
                {
                    if (levelQueue.Count == 0 || levelQueue.Dequeue() == curlevel + 1)
                    {
                        return null;
                    }

                    return nodeQueue.Dequeue();
                }

                if (curNode.left != null)
                {
                    nodeQueue.Enqueue(curNode.left);
                    levelQueue.Enqueue(curlevel + 1);
                }

                if (curNode.right != null)
                {
                    nodeQueue.Enqueue(curNode.right);
                    levelQueue.Enqueue(curlevel + 1);
                }
            }

            return null;
        }
    }
}
