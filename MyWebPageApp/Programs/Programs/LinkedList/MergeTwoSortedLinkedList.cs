using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using programs;

namespace Programs.LinkedList
{
    public class MergeTwoSortedList
    {
        public node<int> MergeTwoSortedLinkedList(node<int> a, node<int> b)
        {
            node<int> res = null;

            if (a == null)
                return b;
            if (b == null)
                return a;

            if (a.data < b.data)
            {
                res = a;
                res.next = MergeTwoSortedLinkedList(a.next, b);
            }
            else
            {
                res = b;
                res.next = MergeTwoSortedLinkedList(a, b.next);
            }

            return res;
        }
    }
}
