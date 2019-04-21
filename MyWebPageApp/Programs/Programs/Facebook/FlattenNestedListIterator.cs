using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Programs.Facebook
{
    //https://github.com/awangdev/LintCode/blob/master/Java/Flatten%20Nested%20List%20Iterator.java
    public class FlattenNestedListIterator
    {

        Stack<object> stack = new Stack<object>();

        public void FlattenNestedListIteratorFun(List<object> nestedList)
        {
            for(int i=nestedList.Count - 1; i >= 0; i--)
            {
                stack.Push(nestedList[i]);
            }
        }

        public int? Next()
        {
            if (HasNext())
                return (int)stack.Pop();

            return null;
        }


        // hasNext make sure you always have int in top of stack
        public bool HasNext()
        {
            while(stack.Count > 0)
            {
                var val = stack.Peek();

                if (val is int)
                {
                    return true;
                }
               
                // val is a List type, puhs into stack
                var list = (List<object>) stack.Pop();

                for(int i= list.Count -1 ; i >=0 ; i--)
                {
                    stack.Push(list[i]);
                }
                
            }

            return false;
        }
    }
}
