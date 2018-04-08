using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class ComplexNode
{
    public int data;
    public ComplexNode next;
    public ComplexNode down;
}

namespace Programs.LinkedList
{
    public class FlattenLinkedListProg
    {
        public static ComplexNode last;
        public ComplexNode FlattenLinkedList(ComplexNode node)
        {
            if (node == null)
                return node;

            last = node;

            var next = node.next;
             
            node.next = FlattenLinkedList(node.down);

            if (next != null)
                last.next = FlattenLinkedList(next);

            return node;
        }

    }
}
