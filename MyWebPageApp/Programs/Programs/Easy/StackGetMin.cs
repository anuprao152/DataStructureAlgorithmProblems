using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace programs
{
    //http://leetcode.com/2010/11/stack-that-supports-push-pop-and-getmin.html

    //Thoughts
    //1. maintaion min values when you push
    //2. use second stack that maintain min value
    //3. when you push new value, check min stack value if push value < min stack value, then push into min stack also
    public class TransformWord
    {
        public Stack<int> stc;
        public Stack<int> min;

        public TransformWord()
        {
            stc = new Stack<int>();
            min = new Stack<int>();
        }

        public void push(int element)
        {
            stc.Push(element);
            if (min.Count == 0 || element < min.Peek())
            {
                min.Push(element);
            }
        }

        public int Pop()
        {
            if (stc.Count == 0) return -1;
            //in top of the stack,
            // minimum in stack always top otherwise it is not minimum
            //if you pop min element then pop also from min stack.
            if (stc.Peek()== min.Peek())
                 min.Pop();

            return stc.Pop();

        }

        public int GetMin()
        {
            if (min.Count == 0) return -1;

            return min.Peek();
        }
    }
}
