using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace programs
{
    public class PhoneNumberPrint
    {
        public string numbers = "0123456789";
        public string letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        public Dictionary<char,int> Dicletters= new Dictionary<char,int>();

        public PhoneNumberPrint()
        {
            MapCharactersToValues();
        }

        public void PhoneNumber(string phoneNum)
        {
            for (int i = 0; i < phoneNum.Length; i++)
            {
                if (phoneNum[i] != '-')
                {
                    Console.Out.WriteLine(Dicletters[phoneNum[i]]);
                }
            }
        }

        public void MapCharactersToValues()
        {
            //Dicletters.Add('0',0);
            //Dicletters.Add('1',1);
            //Dicletters.Add('2',2);
            //Dicletters.Add('3',3);
            //Dicletters.Add('4',4);
            //Dicletters.Add('5',5);
            //Dicletters.Add('6',6);
            //Dicletters.Add('7',7);
            //Dicletters.Add('8',8);
            //Dicletters.Add('9',9);

             //map Number 0 to 9
            for (int i = 0; i < numbers.Length; i++)
            {
                Dicletters.Add(numbers[i], i);
            }

            //map letters 0 to 35 ABC - 2 so 
            for (int i = 0; i < letters.Length; i++)
            {  
                if ( i < 15)
                Dicletters.Add(letters[i], i / 3 + 2);
                else if (i >= 15 && i <= 18)
                    Dicletters.Add(letters[i], 7);
                else if (i >= 19 && i <= 22)
                    Dicletters.Add(letters[i], 8);
                else
                    Dicletters.Add(letters[i], 9);

            }
        }
    }
}
