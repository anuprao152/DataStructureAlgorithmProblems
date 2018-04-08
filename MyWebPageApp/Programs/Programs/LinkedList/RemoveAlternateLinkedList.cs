using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace programs
{
    public class RemoveAlternateLinkedList
    {
        //iteratively
        public void RemoveAlt(node<int> head)
        {
            node<int> cur = head;
            while (cur != null)
            {
                if (cur.next != null)
                {
                    // a node that needs to be deleted
                    node<int> deletenode = cur.next;
                    cur.next = deletenode.next;
                    deletenode = null;
                }

                //increment
                cur = cur.next;

            }
        }

        //Recursively delete alternate nodes
        public void RemoveAltRecursive(node<int> head)
        {
            if (head == null) return;

            node<int> cur = head;
            
            if(cur.next!=null)
            {
                node<int> deletenode = cur.next;
                cur.next = deletenode.next;
                deletenode = null;
            }

            RemoveAltRecursive(cur.next);

        }

        public void print(node<int> head)
        {
            while (head != null)
            {
                Console.Write(" " + head.data);
                head = head.next;
            }
        }
    }
}
