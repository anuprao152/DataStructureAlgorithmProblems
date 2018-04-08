using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace programs
{

    //how to clone a linked list
    //1. Create a cloned list in a origional linked list
    //2. Link Clone node's sibling pointer 
    //3. Split the list

    public class CloneLinkedList
    {
        //public 
        public CloneLinkedList()
        {
        }


    }

    public class ComplexNode
    {
        public int data;
        public ComplexNode Next { get; set; }
        public ComplexNode Sibling { get; set; }
    }
}
