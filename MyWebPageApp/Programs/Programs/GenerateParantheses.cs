using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace programs
{
    public class GenerateParantheses
    {
        public void GenerateCombinationParentheses(int n, int open, int close, string str)
        {
            if (open == 0 && close == 0)
            {
                Console.WriteLine(str);
                return;
            }

            if (open > close)
                return;

            if(open > 0)
            {
                GenerateCombinationParentheses(n, open - 1, close, str + "(");
            }

            if(close > 0)
            {
                GenerateCombinationParentheses(n, open, close - 1, str + ")");
            }
        }
    }
}
