using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace programs
{
    public class PhoneDictionary
    {
        //input number[] { 2,3,4} ==> { {A,B,C} , {D,E,F} , {G,H,I} } e.g. 
        //So, All possible words consist of lenght of size 3 characters only as we pick 1 character from each associated number

        String[] hashMap = new String[] { "", "", "ABC", "DEF", "GHI", "JKL", "MNO", "PQRS", "TUV", "XYZ" };


        public void printWords(int[] numbers, int curNum, char[] output, int index)
        {
            if(index == numbers.Length)
            {
                //print word
                for (int i = 0; i < numbers.Length; i++)
                    Console.Write(output[i]);

                Console.Write("\n");
                return;
            }

            for(int i=0; i < hashMap[numbers[curNum]].Length; i++)
            {
                output[index] = hashMap[numbers[curNum]][i];
                printWords(numbers, curNum + 1, output, index + 1);
            }
        }
    }
}
