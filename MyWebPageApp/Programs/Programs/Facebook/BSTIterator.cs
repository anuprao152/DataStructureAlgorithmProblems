using programs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Programs.Facebook
{
    //http://qa.geeksforgeeks.org/3996/qa.geeksforgeeks.org/3996/implement-an-iterator-over-a-binary-search-tree-bst.html
    public class BSTIterator
    {
        private Stack<bnode<int>> stack = new Stack<bnode<int>>();

        public BSTIterator(bnode<int> root)
        {
            PushAll(root);
        }

        public bool hasNext()
        {
            return (stack.Count > 0);// if stack empty return false
        }

        public bnode<int> Next()
        {
            var node = stack.Pop();

            if (node.right != null)
            {
                PushAll(node.right);  
            }
            
            return node;
        }

        private void PushAll(bnode<int> node)
        {
            while(node!=null)
            {
                stack.Push(node);
                node = node.left;
            } 
        }  
    }
}
