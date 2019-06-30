using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace programs
{

    //Amazon Interview Question
    public class SortedArrayToBSTProg
    {
        public Bnode<int> SortedArrayToBST(int[] array, int start, int end)
        {
           //base case
            if (start > end)
                return null;

            int mid = (start + end) / 2;
             
            Bnode<int> node = new Bnode<int>(array[mid]);

            //recursivly construct left subtree
            node.left= SortedArrayToBST(array, start, mid - 1);

            //recursivly construct right subtree
            node.right = SortedArrayToBST(array, mid + 1, end);

            return node;
        }
    }
}
