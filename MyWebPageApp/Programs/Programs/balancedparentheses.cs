using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace programs
{
    public class balancedparentheses
    {
        string exp;

        public balancedparentheses(string exp)
        {
            this.exp = exp;
        }

        public Boolean IsBalanced()
        {
            Stack<char> stack = new Stack<char>();

            for (int i = 0; i < exp.Length - 1; i++)
            {
                if (exp[i] == '{' || exp[i] == '[' || exp[i] == '(')
                {
                      stack.Push(exp[i]);
                }

                if (exp[i] == '}' || exp[i] == ']' || exp[i] == ')')
                {
                    //If there is nothing to pop,
                    //There is no opening bracket 
                    if (stack.Count ==0)
                    {
                        return false;
                    }
                    else{

                      if(!isMatch(stack.Pop(), exp[i]))
                      return false;
                    }
                }
            }

            //if all the push equal to all the pop that means
            //end of the for loop you will get empty stack
            return (stack.Count == 0) ? true : false;
        }

        public Boolean isMatch(char openPara, char closePara)
        {
            if (openPara == '{' && closePara == '}')
                return true;
            else if (openPara == '[' && closePara == ']')
                return true;
            else if (openPara == '(' && closePara == ')')
                return true;
            else
                return false;

        }
    }
}
