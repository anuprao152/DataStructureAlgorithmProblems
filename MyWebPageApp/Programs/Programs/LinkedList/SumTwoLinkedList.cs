using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace programs
{
    //http://www.geeksforgeeks.org/sum-of-two-linked-lists/
    public class SumTwoLinkedList
    {
        public Stack<int> st = new Stack<int>();
        public Stack<int> sumLinkedlist(node<int> headOne, node<int> headTwo,  ref int carry)
        {
            
            if (headOne ==null && headTwo == null) return null;

            //if (headOne.next == null)
            //    sumLinkedlist(null, headTwo.next);
            //else if (headTwo.next == null)
            //    sumLinkedlist(null, headOne.next);
            //else

                sumLinkedlist(headOne.next, headTwo.next,ref carry);

            
            int sum =  carry +  headOne.data + headTwo.data;
            //if (sum > 10)
            //{
                carry = sum / 10;
                st.Push(sum % 10);
            //}
            return st;
        }

        public void LinkedListsSum(node<int> headOne, node<int> headTwo)
        {
            int headOneLength = getSize(headOne);
            int headTwoLength = getSize(headTwo);
            int diff;
            Stack<int> res;

            //for different lengh of linked list
            if (headOneLength > headTwoLength)
            {
                diff = headOneLength - headTwoLength;
                LinkedList append = new LinkedList();
                for (int i = 0; i < diff; i++)
                    append.Add(new node<int>(0));
                node<int> last = GetlastNode(append.head);
                last.next = headTwo;

                int carry = 0;
                res = sumLinkedlist(headOne, append.head,ref carry);
                
            }
            else if (headOneLength < headTwoLength)
            {
                diff = headTwoLength - headOneLength;
                LinkedList append = new LinkedList();
                for (int i = 0; i < diff; i++)
                    append.Add(new node<int>(0));
                node<int> last = GetlastNode(append.head);
                last.next = headOne;

                int carry = 0;
                res = sumLinkedlist(headOne, append.head, ref carry);
              
            }
            else
            {
                int carry = 0;
                res = sumLinkedlist(headOne, headTwo, ref carry);
                
            }
            print(res);
        }

        public void print(Stack<int> res)
        {
            LinkedList reslist = new LinkedList();
            while (res.Count > 0)
            {
                reslist.Add(new node<int>(res.Pop()));
            }

            node<int> cur = reslist.head;
            while (cur != null)
            {
                Console.Write("{0} --> ", cur.data);
                cur = cur.next;
            }
        }

        //utiltiy function
        public node<int> GetlastNode(node<int> head)
        {
            node<int> last = head;
            while (last.next != null)
                last = last.next;
            return last;
        }


        

        public int getSize(node<int> head)
        {
            int count =0;
            node<int> cur = head;
            while (cur != null)
            {
                cur = cur.next;
                count++;
            }
            return count;
        }

        //public node<int> addSameSize(node<int> head1, node<int> head2, int carry)
        //{
        //    // Since the function assumes linked lists are of same size,
        //    // check any of the two head pointers
        //    if (head1 == null)
        //        return null;

        //    int sum;

        //    // Allocate memory for sum node of current two nodes
        //    node<int> result = new node<int>(0);

        //    // Recursively add remaining nodes and get the carry
        //    result.next = addSameSize(head1.next, head2.next, carry);

        //    // add digits of current nodes and propagated carry
        //    sum = head1->data + head2->data + *carry;
        //    *carry = sum / 10;
        //    sum = sum % 10;

        //    // Assigne the sum to current node of resultant list
        //    result->data = sum;

        //    return result;
        //}
    }
}
