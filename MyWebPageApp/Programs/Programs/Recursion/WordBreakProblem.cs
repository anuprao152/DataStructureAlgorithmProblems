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
    }
}
