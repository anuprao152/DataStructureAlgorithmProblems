using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace programs
{
    class LowestCommonAncesstorBinaryTree
    {
        /// <summary>
        /// Looks like you need to traverse every node ( in order traversal)
        /// but in order traversal return back when you find null
        /// here you find a node1/node2 then you return
        /// In return from left you also check right side for another node2
        /// if you find right side also then found node in opposite side. and return root
        /// otherwise return right or left ( from where you returned)
        /// </summary>
        /// <param name="root"></param>
        /// <param name="node1"></param>
        /// <param name="node2"></param>
        /// <returns></returns>
        public bnode<int> FindLCA(bnode<int> root, bnode<int> node1, bnode<int> node2)
        {
            if (root == null) return null;
            if (root.data == node1.data || root.data == node2.data) return root; //

            //in-order traversal returns when null or found a either node1 or node2
            bnode<int> left = FindLCA(root.left, node1, node2);
            bnode<int> right = FindLCA(root.right, node1, node2);

            //if you found node1 and node 2 opposite side (left and right return root)
            if(left!=null && right!=null) return root;

            // don't find right becasue it was below in left subtree (DFS)
            // but you return because you find node1/node2 in left and didn't do DFS and back
            if (left != null) return left;

            // don't find left becasue it was below there in a right subtree (DFS)
            // but you returned because you find node1/node2 in right and didn't do DFS and back
            else return right; // don't find left because you 

        }



        /// <summary>
        /// Find lowest common ancesstor in Binary Search Tree.
        /// This is the Binary Search Tree, you if both given nodes are in same
        /// direction left/right you just continue with recursion if you find 
        /// any node opposite of the root return root.
        /// </summary>
        /// <param name="root"></param>
        /// <param name="p"></param>
        /// <param name="q"></param>
        /// <returns></returns>
        public bnode<int> findCommonAncestor(bnode<int> root, bnode<int> p, bnode<int> q)
        {
            if (root == null) return null;
            // p and q is left of the root 
            if (p.data > root.data && q.data > root.data)
            {
                return findCommonAncestor(root.right, p, q);
            }
            // p and q is right side of the root
            if (p.data < root.data && q.data < root.data)
            {
                return findCommonAncestor(root.left, p, q);
            }

            // if above both codition wrong then two are getting diversion at this root so return root.
            return root;
        }
    }
}
