using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace programs
{
    class QueueWith2Stack
    {
        private stack<int> inbox;
        private stack<int> outbox;

        public void enqueue(int element)
        {
            inbox.push(element);
        }

        public QueueWith2Stack()
        {
            inbox = new stack<int>();
            outbox = new stack<int>();
        }

        public int dequeue()
        {
            if (outbox.length == 0)
            {
                for (int i = inbox.length; i > 0; i--)
                {
                    int element = inbox.pop();
                    outbox.push(element);
                }
            }
            return outbox.pop();
        }
    }
}
