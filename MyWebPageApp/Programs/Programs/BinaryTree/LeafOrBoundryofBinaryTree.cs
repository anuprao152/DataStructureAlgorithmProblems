using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace programs
{
    public class LeafOrBoundryofBinaryTree
    {

        //print outermost edge of a Binary Tree
        //root is printing 2 times for left edge and for right edge
        public void printouterMostEdge(Bnode<int> root)
        {
            printleftEdge(root);
            printleafnodes(root);
            printrightEdge(root);
        }

        //traverse left only 
        public void printleftEdge(Bnode<int> root)
        {
            if (root == null) return;
            //this codition doesn't print the leaf node
            if (root.left != null)
            {
                Console.WriteLine(root.data);
                printleftEdge(root.left);
            }
        }

        //traverse right only
        public void printrightEdge(Bnode<int> root)
        {
            if (root == null) return;
            //this codition doesn't print the leaf node
            if (root.right != null)
            {
                Console.WriteLine(root.data);
            }
            printrightEdge(root.right);
        }

        //To print leaf node is simply a in-order traversal
        //but print the visit node which has left and right node=null 
        public void printleafnodes(Bnode<int> root)
        {
            if (root == null) return;
            printleafnodes(root.left);
            if (root.right == null && root.left == null)
            {
                Console.WriteLine(root.data);
            }
            printleafnodes(root.right);

        }

    }
}
