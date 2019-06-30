using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace programs
{
    public class RootToLeafPathSum
    {
        public Boolean FindSumPath(Bnode<int> curNode, int sum)
        {

        //every time we substract current node with sum value
        // at the end sum == 0 then we found the sum path

        if (curNode==null && sum == 0) return true;

        if (curNode == null) return false;
        
        int subsum = sum - curNode.data;
        
        if( curNode.left == null && curNode.right==null && subsum ==0)
        return true;
        
         return FindSumPath(curNode.left, subsum) || FindSumPath (curNode.right, subsum);

        }
    }
}
