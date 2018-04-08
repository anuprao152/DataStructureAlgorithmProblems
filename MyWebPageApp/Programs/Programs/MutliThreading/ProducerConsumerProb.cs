using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Programs.MutliThreading
{
    public class ProducerConsumerProb
    {
        private const int size = 10;
        private Queue<int> Q;
        private object key = new object();
        private int num = 0;
        Boolean produced = false; // used for thready syncronization. produce,consume, produce, consume.

        public ProducerConsumerProb()
        {
            Q = new Queue<int>(size);
        }

        public void Produce()
        {
            while (true)
            {
                lock (key)
                {
                    if (Q.Count < size)
                    {
                        if (!produced)
                        {
                            Q.Enqueue(num);
                            Console.WriteLine("produce:" + num);
                            produced = true;
                            num++;
                            Thread.Sleep(1000);
                        }
                    }
                }
            }
        }

        public void Consume()
        {
            while (true)
            {
                lock (key)
                {
                    if (Q.Count > 0)
                    {
                        if (produced)
                        {
                            var n = Q.Dequeue();
                            Console.WriteLine("consume:" + n);
                            produced = false;
                            Thread.Sleep(1000);
                        }
                    }
                }
            }
        }
        
    }
}
