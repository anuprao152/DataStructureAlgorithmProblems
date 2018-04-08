using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace programs
{
    public class KthSmallelementBinarySearchTree
    {
        public int k = 5;
        public static int i = 0;

        //Do in order traversal and print kth element by checking condition
        public void inorder(bnode<int> root)
        {
            bnode<int> cur = root;
            if (cur == null) return;

            
            inorder(cur.left);
            i++;
            if (i == k) Console.WriteLine(cur.data);
            inorder(cur.right);
        }
    }
}
