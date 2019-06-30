using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace programs
{
    public class IsBalancedBinaryTree
    {
        // Definition : height difference between left subtree and right subtree no more than 1 

        // is balanced or not checked by checking height of the right and left sub trees
        // Steps
        // if tree empty then tree is balanced
        // else
        // leftheight = get the height of the left subtree
        // rightheight = get the height of the right subtree
        // if leftheight - rightheigh <=1 ( not more than 1) declare balanced

        public Boolean Isbalanced(Bnode<int> root)
        {
            //base case

            if (root == null) return true;

            int leftSubTreeHeight = Height(root.left);
            int rightSubTreeHeight = Height(root.right);

            if (!(Math.Abs(leftSubTreeHeight - rightSubTreeHeight) <= 1)) return false;

            if (!Isbalanced(root.left)) return false;

            if (!Isbalanced(root.right)) return false;

            return true;

        }

        public int Height(Bnode<int> root)
        {
            if (root == null) return 0;

            int left = Height(root.left);
            int right = Height(root.right);

            if (left > right)
                return left + 1;
            else
                return right + 1;
        }
    }
}
