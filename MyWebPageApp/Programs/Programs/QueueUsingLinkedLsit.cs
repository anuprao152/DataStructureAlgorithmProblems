using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace programs
{
    public class QueueUsingLinkedLsit
    {
        private LinkedList list;

        public QueueUsingLinkedLsit()
        {
            list= new LinkedList();
        }

        public void enqueue(int n)
        {
            list.Add(new node<int>(n));//add to last
        }

        public node<int> dequeue()
        {   
            if(list.head ==null) return null;

            node<int> node = list.head;
            list.Delete(list.head);

            return node;//which is head
        }

    }
}
