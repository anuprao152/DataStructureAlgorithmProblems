using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Programs
{
    //Given a stream of integers and a window size, 
    //calculate the moving average of all integers in the sliding window.
    public class MovingAverage
    {
        public double sum = 0;
        public double avg = 0;
        int windowSize = 4;
        public Queue<int> q = new Queue<int>();

        public double NextAverage(int value)
        {
            sum += value;
            q.Enqueue(value);

            if (q.Count <= windowSize)
            {
                avg = sum / q.Count;
            }
            else
            {
                int num = q.Dequeue(); 
                sum -= num;
                avg = sum / windowSize;
            }

            return avg;
        }
    }
}