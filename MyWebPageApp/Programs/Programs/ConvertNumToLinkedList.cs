using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace programs
{
    public class ConvertNumToLinkedList
    {
        public LinkedList lnk = new LinkedList();
        public void NumToLinkedList(int number)
        {
            stack<int> st = new stack<int>();
            while (number != 0)
            {
                int reminder = number % 10;
                st.push(reminder);
                number =number/10;
            }

            while (st.length != 0)
            {
                lnk.Add(new node<int>(st.pop()));
            }
        }


    }
}
