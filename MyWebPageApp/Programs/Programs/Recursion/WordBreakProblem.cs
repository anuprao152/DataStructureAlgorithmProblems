using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace programs
{
    public class WordBreakProblem
    {

        Dictionary<String, String> dict;

        public WordBreakProblem()
        {
            dict = new Dictionary<String, String>();
            dict.Add("a", "a");
            dict.Add("it", "it");
            dict.Add("am", "am");
            dict.Add("ram", "ram");
            dict.Add("pro", "pro");
            dict.Add("grammer", "grammer");
            dict.Add("program", "program");
            dict.Add("programmer", "programmer");
            //dict.Add("me", "me");
            dict.Add("merit", "merit");

        }

        public void BreakWords(String s, int index, string output)
        {
            for (int i = 1; i <= s.Length; i++)
            {
                String prefix = s.Substring(0, i);

                if (dict.ContainsKey(prefix))
                {
                    output += prefix + " ";

                    if (i == s.Length)
                    {
                        Console.WriteLine(output);
                        return;
                    }

                    String postfix = s.Substring(i, s.Length - i);

                    BreakWords(postfix, postfix.Length, output);

                    output = string.Empty;
                }
            }

        }

        public int MinSpaceWordBreak(string s, int index, Dictionary<string,string> dict)
        {
            if (index >= s.Length)
                return 0;

            var min = int.MaxValue;
            for(int i=index;i<s.Length;i++)
            {
                var prefix = s.Substring(index, i - index +1);

                if(dict.ContainsKey(prefix))
                {
                     var sol = 1 + MinSpaceWordBreak(s, i + 1, dict);

                     if (sol != int.MinValue && sol < min)
                     {
                         min = sol;
                     }
                }
            }
            return min;
        }
    }
}
