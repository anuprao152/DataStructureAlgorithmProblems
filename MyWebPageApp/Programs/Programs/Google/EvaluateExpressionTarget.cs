using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Programs.Google
{
    public class EvaluateExpressionTarget
    {
        public void EvaluateExpressionTargetFun(int[] digit, int target)
        {
            DFSCore(digit, 0, 0, target, new List<string>(), "", 0);
        }

        public void DFSCore(int[] digit, int cur, int prev, int target, List<string> output, string expression, int ans)
        {
            if (cur == digit.Length)
            {
                if (ans == target)
                {
                    Print(output);
                }
            }

            for (int i = cur; i < digit.Length; i++)
            {
                //first time
                if (string.IsNullOrEmpty(expression))
                {
                    DFSCore(digit, cur + 1, cur, target, output, expression + digit[i].ToString(), digit[i]);
                }
                else
                {
                    //3 operations
                    DFSCore(digit, cur + 1, cur, target, output, expression + "+" + digit[i], ans + digit[i]); // +
                    DFSCore(digit, cur + 1, -cur, target, output, expression + "-" + digit[i], ans - digit[i]); // -
                    DFSCore(digit, cur + 1, cur, target, output, expression + "*" + digit[i], ans - prev + prev * digit[i]); // *

                }
            }

        }

        public void Print(List<string> output)
        {
            for (int i = 0; i < output.Count; i++)
            {
                Console.WriteLine(output[i]);
            }
        }
    }
}
