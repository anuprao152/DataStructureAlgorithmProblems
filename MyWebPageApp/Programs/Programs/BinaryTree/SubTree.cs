using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace programs
{
    public class SubTree
    {
        //Tree1 is a big tree and Tree2 is a Sub Tree
        //Steps
        //1. For each Tree1 node 
        //     you check Tree2 is subTree ( identical )
        //And Identical Tree means every node of Tree1 must match with every node of Tree2
        // 


        public Boolean FindSubTree(Bnode<int> Tree1, Bnode<int> Tree2)
        {
            //When traversing through Tree1 you never return with 
            if (Tree1 == null) return false;

            //if Tree2 is itself null means it is sub tree
            if (Tree2 == null) return true;

            if(IsIdentical(Tree1, Tree2)) return true;

            //if you don't find sub tree with Tree1's root, try left and Try right subTrees 
            // one by one.
            return (FindSubTree(Tree1.left, Tree2) || FindSubTree(Tree1.right, Tree2));
        }

        public Boolean IsIdentical(Bnode<int> Tree1, Bnode<int> Tree2)
        {
            //base case both null or terminate condition
            if (Tree1 == null && Tree2 == null) return true;

            //Either of Two Tree reached  null that means root2 is not sub tree
            // becuase both should end with null togather, otherwise return false
            if (Tree1 ==null || Tree2 == null ) return false;

            //In Traverse, you find that if data doesn't match, then 
            //Simply return false,  because every node of Tree1 must match with every node of Tree2
            if (Tree1.data != Tree2.data) return false;

            // Traverse In-order 
            return (IsIdentical(Tree1.left, Tree2.left) && IsIdentical(Tree1.right, Tree2.right));
        }
    }
}
