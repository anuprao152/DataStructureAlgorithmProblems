using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace programs
{
    public class BinaryTreeToDoublyLinkedList
    {

        /// <summary>
        /// http://www.geeksforgeeks.org/convert-a-given-binary-tree-to-doubly-linked-list-set-2/
        /// </summary>
        /// <param name="root"></param>

        private static Bnode<int> prev=null;

        public void ConvertB2DDL(Bnode<int> root)
        {
            fixprevPointer(root);
            fixNextPointer(root);

        }

        public void fixprevPointer(Bnode<int> root)
        {
            //Fix the left pointer first
            //root is current node

            if (root == null) return;

            fixprevPointer(root.left);
            root.left = prev;
            prev = root;
            fixprevPointer(root.right);
        }

        //
        public void fixNextPointer(Bnode<int> root)
        {
            //reach the right most node, which is last node in ddl
            while (root != null && root.right != null)
                root = root.right;

            //iterate through left pointer that we set previosly 
            //in that aslo 
            while (root != null && root.left!=null)
            {
                prev = root;
                root = root.left;//next
                root.right = prev; //next points to prev
            }
        }

    }
}
