using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace programs
{
    public class swapAlternative
    {
        //swapping alternative is changing the data only
        //not a linked list structure.
        public void swapAlternativeElements(node<int> head)
        {
            node<int> cur = head;

            while (cur != null && cur.next!=null)
            {
                swap(ref cur.data, ref cur.next.data);
                cur = cur.next.next;
            }
        }

        //Recursivly 
        public void SwapAlternateElementsRec(node<int> head)
        {
            if (head != null && head.next != null)
            {
                swap(ref head.data, ref head.next.data);
                SwapAlternateElementsRec(head.next.next);
            }
        }

        public void swap(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }


    }
}
