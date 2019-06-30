using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace programs
{
    public class MinimumDepthBinaryTree
    {
        public static int depth = 0;
        public int MinDepthBinaryTree(Bnode<int> root)
        {
            //base 
            if (root == null) return depth;

            if (root.left == null || root.right == null) return depth;

            depth++;

            int lefth = MinDepthBinaryTree(root.left);
            int righth = MinDepthBinaryTree(root.right);

            if (lefth > righth)
            {
                return righth;
            }
            else
            {
                return lefth;
            }


        }
    }
}
