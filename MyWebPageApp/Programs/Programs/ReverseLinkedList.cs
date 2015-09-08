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
        public void Reverse(node<int> head)
        {
            //basic case
            if (head == null) return;

            node<int> first = head;
            node<int> rest = first.next;

            if (rest == null) return;
            Reverse(rest);

            //print reverse
            //Console.WriteLine(first.next.data);

            // formula to reverse a linked list
            first.next.next = first;
            
            first.next = null;
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
                next = cur.next;// we store next node because we breaking the link that pointing to next
                cur.next = prev;
                prev = cur; // prev is current
                cur = next; // cur is next that we store in 1st step
            }

            return prev;
        }

       

    }
}
