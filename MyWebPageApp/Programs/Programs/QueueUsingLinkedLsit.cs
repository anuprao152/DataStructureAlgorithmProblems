using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace programs
{
    public class QueueUsingLinkedLsit
    {
        private LinkedList list = new LinkedList();

        public void enqueue(int n)
        {
            list.Add(new node<int>(n));
        }

        public node<int> dequeue()
        {
            if (list.head == null)
                return null;

            var temp = list.head;
           
            //new head
           list.head = list.head.next;

           return temp;
        }

        private node<int> SetHead(node<int> head)
        {
            if (head == null || head.next == null)
                return head;

            var temp = head;
            head = head.next;
            temp = null;
            return head;
        }

    }
}
