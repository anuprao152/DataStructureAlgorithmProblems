using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace programs
{

    // Before you delete any node you need to save that delete node in temp node 
    // because delete node has a information to go to next node.
    public class DeleteNthElementFromLastLinkedList
    {
        public void GetNthFromLast(node<int> head, int n)
        {
            // 1st Method
            // Maintain two pointers
            // reference point and main pointer
            // mover reference pointer to Nth element
            // Now move both pointer togather till reference pointer reach to the end
            // Example ( you want to delete 3rd from last ) which is 8 node below
            // 1 -> 2 -> 3 -> 4 -> 5 -> 6 -> 7 -> 8 -> 9 -> 10
            // |         |                                      ( move ref pointer to n(3rd) node)
            // Main      ref
            // 1 -> 2 -> 3 -> 4 -> 5 -> 6 -> 7 -> 8 -> 9 -> 10
            //                                    |         |   ( move both pointer till ref reach end)
            //                                   Main      ref
            // you can see main pointer referencing n(3rd node ) from last

            // 2nd Method (simple)
            // calculagte lenght of the linked list ( which is 10 here)
            // nth (3rd node ) from last is calculates using formula ( len - n + 1)
            // so ( 10-3+1) = 8th node

            node<int> refe = head;
            node<int> main = head;
            int count =0;
            while (count < n)
            {
                refe = refe.next;
                count ++;
            }

            while ( refe != null)
            {
                refe = refe.next;
                main = main.next;
            }

            Console.WriteLine("{0} node from last is {1} ", n, main.data);

        }

        public void DeleteNthFromLast(node<int> head, int n)
        {
            // delete nth from last 
            // why don't delete ( len - n + 1) from start ( both same )
            // n element from start = ( len - n + 1)

            //Logic : to delete n element you need to stop your 
            // traverse pointer n-1 position,, ( becasue there is no way to go back from nth element)
            // and remember don't simply delete nth element firs store in temp node, becasue delete node has information to go to next node

            int length =0;
            node<int> cur = head;

            int count =1;// star index make 1 easy for understand

            while ( cur!=null)
            {
                length++;
                cur = cur.next;
            }

            int deleteNodePos = length - n + 1; // deleteNode is a index from start (nth positioin)

            cur = head;// now set to cur to head again

            // you need to stop at n-2 position, becasue in loop cur is getting set to cur.next
            // cur will be at n-1 position at end of the loop
            while (count < deleteNodePos-1)
            {
                cur = cur.next;
                count++;
            }

            // cur = n-1 position
            // cur.next = n ( delete) position
            // cur.next.next = n + 1 position
            node<int> temp = cur.next; // cur.next is delete node that we store in temp node first
            cur.next = temp.next; // n-1 points to n+1 position
            temp = null; // delete nth node

        }

        public void traverse(node<int> head)
        {
            node<int> cur = head;
            while (cur != null)
            {
                Console.Write("{0} -->", cur.data);
                cur = cur.next;
            }
        }
    }
}
