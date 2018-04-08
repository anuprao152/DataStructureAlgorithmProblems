using programs;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Programs.BinaryTree
{
    public class ZigZagOrderTraversal
    {
        public void PrintZigZag(bnode<int> root)
        {
            var s1 = new Stack<bnode<int>>();
            var s2 = new Stack<bnode<int>>();

            s1.Push(root);

            while(s1.Count > 0 || s2.Count > 0)
            {

                while (s1.Count > 0)
                {
                    var node = s1.Pop();
                    Console.Write(node.data);

                    //right push befor left
                    if (node.right != null) s2.Push(node.right);
                    if (node.left != null) s2.Push(node.left);
                }

                //next line print
                Console.WriteLine();

                while (s2.Count > 0)
                {
                    var node = s2.Pop();
                    Console.Write(node.data);

                    //left push befor right
                    if (node.left != null) s1.Push(node.left);
                    if (node.right != null) s1.Push(node.right);
                }

                Console.WriteLine();

            }


        }
    }
}
