using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace programs
{
    public class ReverseCharactersBeforeX
    {
        public StringBuilder sb = new StringBuilder();

        //public static int j = 0;

        // Reverse ( str, 
        public void ReverseX(string str, int i)
        {
            i++;
            int Xindex = i; // index for x where it breaks(return)

            if (i < str.Length && str[i] == 'x') return;

            ReverseX(str,  i);

            //if (str[i] != 'x')
            //{
            //    i = i + 1;
            //    ReverseX(str,ref i);
                
            //}

            Console.WriteLine(str[i]);

            //Remaining characters of a string after x
            //for (int j = Xindex; j < str.Length; j++)
            //    Console.WriteLine(str[j]);

            //sb.Append(str[i]);

            //return sb.ToString();
        }
    }
}
