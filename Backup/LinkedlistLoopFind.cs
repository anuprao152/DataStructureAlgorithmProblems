using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StackProgram
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
        node<int> head;

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

        public void traverse()
        {
            if (head != null)
            {
                node<int> cur = head;
                node<int> fastTraverse = head.next;
                while (cur.next != null)
                {
                    //loop find
                    if (cur.next == fastTraverse.next)
                    {
                        Console.WriteLine("Loop exist");
                        return;
                    }
                    
                    Console.WriteLine(cur.data);
                    cur = cur.next;
                    fastTraverse = fastTraverse.next.next;
                }
                Console.WriteLine(cur.data);
            }
        }
    }
}
