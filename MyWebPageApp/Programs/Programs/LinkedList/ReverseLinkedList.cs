using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace programs
{
    public class ReverseLinkedList
    {
        //  video link on youtube : http://www.youtube.com/watch?v=CXjQUdAwRSg

        //Recursion
        public void Reverse(node<int> cur)
        {
            //base
            if (cur.next == null)
            { 
                return;
            }

            Reverse(cur.next);

            //print reverse
            //Console.WriteLine(first.next.data);

            // formula to reverse a linked list
            cur.next.next = cur;
            cur.next = null;
        }

        static node<int> head;

        public node<int> RecursiveReverseLinkedList(node<int> cur, node<int> prev)
        {
            if (cur == null)
            {
                head = prev; // set head (static)
                return cur;
            }

            var next = cur.next;
            cur.next = prev;

            prev = cur;

            RecursiveReverseLinkedList(next, prev);

            return head;
        }

        //Iteratively
        //http://crackinterviewtoday.wordpress.com/2010/03/24/reverse-a-single-linked-list-iterative-procedure/
        public node<int> ReverseIterative(node<int> head)
        {
            //two pointer preve an current
            
            node<int> prev = null;
            node<int> cur = head;
            node<int> next = null;

            while (cur != null)
            {
                next = cur.next;//  store next node
                cur.next = prev;
                prev = cur; // prev is current
                cur = next; // cur is next that we store in 1st step
            }

            return prev;
        }

       

    }
}
