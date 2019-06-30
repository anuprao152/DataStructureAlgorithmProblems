using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace programs
{
    public class PrintAllPathBinaryTree
    {
        private Bnode<int>[] Path;
        //private int PathLength = 0;


        public void PrintPathRootToLeaf(Bnode<int> root)
        {
            Path = new Bnode<int>[1000];
            PathRootToleafRec(root, 0);
        }

        public void PathRootToleafRec(Bnode<int> node, int length)
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
