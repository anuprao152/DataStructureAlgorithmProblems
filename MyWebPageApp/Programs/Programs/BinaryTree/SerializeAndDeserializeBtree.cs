using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace programs
{
    public class BinaryNode
    {
        public char c;
        public BinaryNode left;
        public BinaryNode right;

        public BinaryNode()
        {
        }

        public BinaryNode(char c)
        {
            this.c = c;
        }
    }

    public class SerializeAndDeserializeBtree
    {
        public void Serialize(Bnode<int> root)
        {
            if (root == null)
            {
                Console.WriteLine("#");
                return;
            }
            Console.WriteLine("{0} ",root.data);
            Serialize(root.left);
            Serialize(root.right);
        }

        public BinaryNode Desearlize(char[] array)
        {
            BinaryNode root = new  BinaryNode();
            BinaryNode cur = root;
            BinaryNode res = null;
            Desearlize(root, array, 0,res);

            return cur;
        }

        public BinaryNode Desearlize(BinaryNode b, char[] array, int i, BinaryNode root)
        {
            if ( array == null || i >= array.Length) return null;

           

            if (array[i] != '#') // rather than if condition you can return here
            {
                b = new BinaryNode(array[i]);

                if (root == null)
                    root = b;

                Desearlize(b.left, array,i+1,root);
                Desearlize(b.right,array,i+1,root);
            }

            return root;
        }

        public  int j = 0;

        //another version
        public BinaryNode Desearlize(char[] array, int i, Queue<char> q)
        {
            if (array == null || j >= array.Length || array[j]=='#')
                return null;

            var n = new BinaryNode(array[j]);

            ///u need to use queue here becuse u need to keep track of next element to read.
            // u need to use global variable to read next element. on a backtrack u need to incrment index aslo to read 
            // next element
            j = j + 1;
            n.left = Desearlize(array, i + 1,q);
            j = j + 1;
            n.right = Desearlize(array, i + 1,q);

            return n;
        }
    }
}
