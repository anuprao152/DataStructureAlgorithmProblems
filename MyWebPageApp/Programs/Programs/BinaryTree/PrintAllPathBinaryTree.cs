using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace programs
{
    public class PrintAllPathBinaryTree
    {
        private bnode<int>[] Path;
        //private int PathLength = 0;


        public void PrintPathRootToLeaf(bnode<int> root)
        {
            Path = new bnode<int>[1000];
            PathRootToleafRec(root, 0);
        }

        public void PathRootToleafRec(bnode<int> node, int length)
        {
            if (node == null) return;

            Path[length] = node;
            length++;

            if (node.left == null && node.right == null)
                print(length);

            PathRootToleafRec(node.left, length);
            PathRootToleafRec(node.right, length);

        }

        public void print( int length)
        {
            for (int i = 0; i < length; i++)
            {
                Console.Write(Path[i].data.ToString() + " ");
            }
            Console.WriteLine();
           
        }


    }
}
