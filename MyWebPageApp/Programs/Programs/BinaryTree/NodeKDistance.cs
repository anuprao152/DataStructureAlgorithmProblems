using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using programs;

namespace Programs.BinaryTree
{
    public class NodeKDistance
    {

        public int KDistanceNodes(Bnode<int> node, Bnode<int> target, int k)
        {
            if (node == null)
                return -1;

            if (node == target)
            {
                PrintKDistanceNodeDownTree(target, 0, k);
                return 1;
            }

            var leftHeight = KDistanceNodes(node.left, target, k);

            if (leftHeight != -1)
            {
                if (leftHeight == k)
                {
                    Console.WriteLine(node.data);
                }
                else
                {
                    KDistanceNodes(node.right, target, k - leftHeight - 1);// since you recurs from right node on backtrack so -1
                }

                return leftHeight + 1;
            }


            var rightHeight = KDistanceNodes(node.right, target, k);

            if (rightHeight != -1)
            {
                if (rightHeight == k)
                {
                    Console.WriteLine(node.data);
                }
                else
                {
                    KDistanceNodes(node.right, target, k - rightHeight - 1);// since you recurse from left node on backtrack so -1
                }

                return rightHeight + 1;
            }

            //if none of the branch find target node.
            return -1;

        }

        private void PrintKDistanceNodeDownTree(Bnode<int> node, int level, int k)
        {
            if (node == null || level > k)
                return;

            if (level == k)
            {
                Console.Write(node.data);
            }

            PrintKDistanceNodeDownTree(node.right, level + 1, k);
            PrintKDistanceNodeDownTree(node.left, level + 1, k);
        }


    }
}
