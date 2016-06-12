using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace programs
{
    public class ShuffleLinkedList
    {

        public void Shuffle(LinkedList linkedList)
        {
            Random r = new Random();
            var cur = linkedList.head;

            while (cur != null)
            {
                int index = r.Next(1, linkedList.Length); // random index 

                var rNode = Traverse(linkedList, index); // node on that index

                //swap nodes
                swap(cur, rNode);

                cur = cur.next;
            }
        }

        private node<int> Traverse(LinkedList linkedList, int index)
        {
            //get the value for that index and swap with cur
            int count = 1;
            var rNode = linkedList.head;
            while (count < index)
            {
                count++;
                rNode = rNode.next;
            }
            return rNode;
        }

        private void swap(node<int> n1, node<int> n2)
        {
            var temp = n1.data;
            n1.data = n2.data;
            n2.data = temp;
        }

    }
}
