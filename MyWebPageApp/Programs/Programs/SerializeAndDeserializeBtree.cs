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
        public void Serialize(bnode<int> root)
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
            Desearlize(root, array, 0);

            return cur;
        }

        public void Desearlize(BinaryNode b, char[] array, int i)
        {
            if (i == array.Length) return;

            if (array[i] != '#') // rather than if condition you can return here
            {
                b = new BinaryNode(array[i]);
                Desearlize(b.left, array, ++i);
                Desearlize(b.right,array,++i);
            }
        }
    }
}
