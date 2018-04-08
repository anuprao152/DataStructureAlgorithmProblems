using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace programs
{ 
    public class node<T>
    {
        public T data;
        public node<T> next;

        public node(T data)
        {
            this.data = data;
        }
    }

    public class LinkedList
    {
        public node<int> head;

        public void Add(node<int> anode)
        {
            if (head == null)
            {
                head = anode;
            }
            else
            {
                node<int> cur = head;
               
                while (cur.next != null)
                {
                    cur = cur.next;
                }
                cur.next = anode;
            }
        }

        public Boolean IsloopExist()
        {
                node<int> slow = head;
                node<int> fast = head.next;
                while (slow != null && fast.next !=null )
                {
                    //loop find
                    if (slow == fast)
                        return true;

                    slow = slow.next;
                    fast = fast.next.next;
                }
                return false;
        }

        //This works for head node also
        public void Delete(node<int> node)
        {
            node<int> temp = node.next; // you are going to delete next node
            node.data = node.next.data; // so you copy next node data first into origional node 
            node.next = temp.next;

            temp = null;
        }

        public int Length
        {
            get
            {
                var cur = head;
                int count = 0;
                while(cur!=null)
                {
                    count++;
                    cur = cur.next;
                }
                return count;
            }
        }
    }
}
