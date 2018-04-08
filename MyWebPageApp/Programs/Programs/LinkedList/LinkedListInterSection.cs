using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace programs
{
    public class LinkedListInterSection
    {
        public node<int> FindInterSectionNode(LinkedList l1, LinkedList l2 )
        {
            int length1 = l1.Length;
            int length2 = l2.Length;

            int diff = length1 - length2;

            node<int> commonNode;

            if (diff >= 0)
            {
               commonNode = FindInterSectionNode(diff, l1.head, l2.head);
            }
            else
            {
               commonNode = FindInterSectionNode(diff, l2.head, l1.head);
            }

            return commonNode;
        }

        private node<int> FindInterSectionNode(int diff,node<int> head1, node<int> head2)
        {
            node<int> cur1 = head1;
            int count = 1;
            while (count < diff)
            {
                count++;
                cur1 = cur1.next;
            }


            node<int> cur2 = head2;
            while (cur1 != null)
            {
                if (cur1 == cur2)
                    return cur1;

                cur1 = cur1.next;
                cur2 = cur2.next;
            }
            return null;
        }

        

    }
}
