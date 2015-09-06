using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace programs
{
    public class BSTSuccessorAndPredecessor
    {
        //Minimum value always deep left side of the tree
        // you can do this prog using while loop
        public bnode<int> Min(bnode<int> root)
        {
            if (root.left != null)
                Min(root.left);
            return root;
        }

         //Minimum value always deep right side of the tree
        // you can do this prog using while loop
        public bnode<int> Max(bnode<int> root)
        {
            if (root.right != null)
              Max(root.right);
            return root;
        }

        /// <summary>
        /// successor : Minimum value in a right sub tree from a given node x e.g X here
        ///if  right tree is not there then,
        /// successor is furtherst parent of x that you get following right branches  
        ///                            / <------Successor
        ///                           /  
        ///                          /
        ///                         /
        ///                        X
        ///                         \ No right Sub Tree
        /// </summary>
        /// <param name="root">Tree</param>
        /// <param name="x">X node for which we find Successor</param>
        /// <returns></returns>
        public bnode<int> InOrderSuccesor(bnode<int> root, bnode<int> x)
        {
            //If right sub tree exist from node x node,
            //then find minimum value in right sub tree which is succ
            if (x.right != null) 
                return Min(x.right);
            
            bnode<int> suc = null;
            //If right tree doens't exist, do the following
            while (root != null)
            {
                if (x.data < root.data)
                {
                    suc = root;
                    root = root.left;
                }
                else if (x.data > root.data)
                {
                    root = root.right;
                }
                else break;
            }

            return suc;
        }

        /// <summary>
        /// opposite of successor
        /// find node with maximum value in a left sub tree from x
        /// if left sub tree doens't exist then do the opposite thing but 
        /// same way that i did for successor
        ///         \ <---Predecessor
        ///          \
        ///           \
        ///            \
        ///             X
        //no left tree /
        /// </summary>
        /// <param name="root"></param>
        /// <param name="x">X node for which we find Predecessor</param>
        /// <returns></returns>
        public bnode<int> InOrderPredecessor(bnode<int> root, bnode<int> x)
        {
            if (x.left != null) return Max(x.left);

            bnode<int> pred = null;
            while (root != null)
            {
                if (x.data < root.data)
                {
                    root = root.left;
                }
                else if (x.data > root.data)
                {
                    pred = root;
                    root = root.right;
                }
                else
                {
                    break;
                }
            }

            return pred;
        }

    }
}
