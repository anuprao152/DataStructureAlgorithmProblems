using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Programs.Facebook
{
    public class DecodeDigitsProg
    {
        private string atoz = " abcdefghijklmnopqrstuvwxyz";
        
        public void DecodeDigits(int[] array, int i, string[] output, int j)
        {
            if(i>=array.Length)
            {
                print(output, j);

                return;
            }

            if (array[i] > 0)
            {
                output[j] = "[" + array[i].ToString() + "]";

                DecodeDigits(array, i + 1, output, j + 1);// [1] [2] [3]
            }

            if (i + 1 < array.Length && array[i] < 2 || (array[i] == 2 && array[i + 1] < 7))
            {
                output[j] = "[" + array[i].ToString() + array[i + 1].ToString() + "]"; //[12]

                DecodeDigits(array, i + 2, output, j + 1);
            }
        }

        private void print(string[] output, int len)
        {
            for(int i=0;i<len;i++)
                Console.Write(output[i]);

            Console.Write("  -->");

            //print interpretation
            for (int i = 0; i < len; i++)
            {
                string num=string.Empty;
                var str = output[i];
                for (int j = 1; j < str.Length - 1; j++)
                    num+= str[j].ToString();

                Console.Write(atoz[int.Parse(num)]);

            }

                Console.WriteLine();
        }
    }
}
