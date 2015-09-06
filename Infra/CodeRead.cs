using System;
using System.IO;
using System.Text;

namespace Infra
{
    public class CodeRead
    {
        public static void DisplayCodeSnippet()
        {
            StringBuilder sb = new StringBuilder();
            try
            {
                using (StreamReader sr = new StreamReader("TestFile.txt"))
                {
                    String line = sr.ReadToEnd();
                    sb.Append(line);
                   
                    //Console.WriteLine(line);
                }

                
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
        }
    }
}
