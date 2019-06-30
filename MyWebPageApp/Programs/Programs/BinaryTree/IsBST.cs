using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace programs
{
    /// <summary>
    ///  Do In order Traversal- In order traversal results is ascending order
    ///  
    /// </summary>
    public class IsBST
    {
        public static Bnode<int> prev=null;
        public  Boolean IsBinarySearchTree(Bnode<int> root)
        {
            if (root == null) 
                return false;

            if (!IsBinarySearchTree(root.left)) return false;

            if (prev != null && prev.data > root.data) return false;

            //save the previous node to comare with current
                prev = root;

            if (!IsBinarySearchTree(root.right))
                return false;

            return true;
        }
    }
}
