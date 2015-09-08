using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace programs
{
    class BinaryTreeInOrderWithoutRecursion
    {
        public void InorderTraversalUsingStack( bnode<int> node)
        {
            Stack<bnode<int>> s = new Stack<bnode<int>>();
            
            while (node !=null)
            {
                while (node != null)
                {
                    if (node.right != null) s.Push(node.right);           
                    s.Push(node);
                    node = node.left;
                }

                bnode<int> p = s.Pop();// visit left child First

                while(p.right == null && s.Count!=0)
                {
                    Console.WriteLine(p.data); //visit middle (root) node 
                    p = s.Pop();                                          
                }
                // you are visiting middle node any case
                // weather it has right child or not 
                Console.WriteLine(p.data); //visit middle (root) node

                //if right child exist go for iteration
                if (s.Count!= 0)
                    node = s.Pop(); // pop right child and now iterat again
                else
                    node = null;
            }
        }
    }
}
