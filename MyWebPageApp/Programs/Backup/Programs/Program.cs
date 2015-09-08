using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace programs
{
    public class stack<T>
    {
        private int _capacity;
        public int capacity
        {
            get { return _capacity; }
            set { _capacity = value; }
        }

        private T[] _elements;
        public T[] elements
        {
            get { return _elements; }
            set { _elements = value; }
        }

        private int _index = -1;
        public int index
        {
            get { return _index; }
            set { _index = value; }
        }

        public stack()
        {
            elements = new T[capacity];
        }

        public stack(int capacity)
        {
            this.capacity = capacity;
            elements = new T[capacity];
        }

        //private int length;
        public int length
        {
            get { return index + 1; }
            //set { _length = value; }
        }

        public void push(T aelement)
        {
            if (length == capacity)
            {
                increaseCapacity();
            }
            index++;
            elements[index] = aelement;
            Console.WriteLine("Element[" + index + "] = " + elements[index]);
        }

        public T pop()
        {
            if (length < 1)
            {
                throw new Exception("Invalid Operation");
            }


            T aelement = elements[index];
            elements[index] = default(T);
            index--;
            return aelement;
        }

        public void increaseCapacity()
        {
            capacity++;
            capacity *= 2;
            T[] newelement = new T[capacity];
            Array.Copy(elements, newelement, elements.Length);
            elements = newelement;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            stack<int> s = new stack<int>();
            s.push(1);
            s.push(2);
            s.push(3);
            int element = s.pop();
            Console.WriteLine(element);
            element = s.pop();
            Console.WriteLine(element);
            s.push(4);

            Queue<int> q = new Queue<int>();

            q.enqueue(1);
            q.enqueue(2);
            q.enqueue(3);
            element = q.dequeue();
            element = q.dequeue();
            element = q.dequeue();
            element = q.dequeue();

            QueueWith2Stack qs = new QueueWith2Stack();
            qs.enqueue(1);
            qs.enqueue(2);
            element = qs.dequeue();
            element = qs.dequeue();

            //circular queue

            circularQueue<int> cq = new circularQueue<int>(3);
            cq.enqueue(1);
            cq.enqueue(2);
            cq.enqueue(3);
            cq.enqueue(4);
            element = cq.dequeu();
            element = cq.dequeu();


            LinkedList l = new LinkedList();
            node<int> l1 = new node<int>(5);
            node<int> l2 = new node<int>(6);
            node<int> l3 = new node<int>(7);
            node<int> l4 = new node<int>(8);
            node<int> l5 = new node<int>(10);
            node<int> l6 = new node<int>(11);
            node<int> l7 = new node<int>(12);
            node<int> l8 = new node<int>(13);
            node<int> l9 = new node<int>(14);

            node<int> l10 = l3;
           // node<int> l7 = new node<int>(8);
            l.Add(l1); l.Add(l2); l.Add(l3); l.Add(l4); l.Add(l5); l.Add(l6); l.Add(l7); l.Add(l8); l.Add(l9); l.Add(l10);
            //l.Add(new node<int>(6));
            //l.Add(new node<int>(7));
            //l.Add(new node<int>(8));

            l.traverse();

            BinaryTree btree = new BinaryTree();
            btree.insert(new bnode<int>(6));
            btree.insert(new bnode<int>(11));
            btree.insert(new bnode<int>(8));
            btree.insert(new bnode<int>(12));
            btree.insert(new bnode<int>(2));
            btree.insert(new bnode<int>(1));
            btree.insert(new bnode<int>(4));
            btree.insert(new bnode<int>(13));
            btree.insert(new bnode<int>(5));
            btree.insert(new bnode<int>(3));
            btree.insert(new bnode<int>(7));
            btree.insert(new bnode<int>(9));
            btree.insert(new bnode<int>(10));

            //in-order with recursion
            btree.inorderTraverse(btree.root);

            //In-Order Traversal without recuriosn using stack
            Console.WriteLine("In-Order Traversal without recuriosn using stack");
            BinaryTreeInOrderWithoutRecursion prog = new BinaryTreeInOrderWithoutRecursion();
            prog.InorderTraversalUsingStack(btree.root);

            Console.WriteLine("All the Leaf nodes of Btree");
            btree.printleafnodes(btree.root);

            Console.WriteLine("All the Left Edge nodes of Btree");
            btree.printleftEdge(btree.root);

            Console.WriteLine("All the right Edge nodes of Btree");
            btree.printrightEdge(btree.root);

            Console.WriteLine("Print Outer Edges of a Btree");
            btree.printouterMostEdge(btree.root);
            
            //Print lowest common Ancestor
            bnode<int> LCA = btree.findCommonAncestor(btree.root, new bnode<int>(13), new bnode<int>(10));
            Console.WriteLine("Print lowest common Ancestor:" + LCA.data);
            int height = btree.findHeight(btree.root);

            //print out order level Btree
            Console.WriteLine("Print order-level binary tree");
            btree.printOrderLevelBtree(btree.root);

            //Construct a binary tree
            List<int> preOrder = new List<int>() { 1, 2, 4, 8, 9, 10, 11, 5, 3, 6, 7 };
            List<int> InOrder = new List<int>() { 8, 4, 10, 9, 11, 2, 5, 1,6,3,7 };
            bnode<int> root1 = BinaryTree.ConstructBinaryTree(preOrder, InOrder);

            Console.WriteLine("BTree Construction test by InOrder Traversal");
            btree.inorderTraverse(root1);

            //Find Ceiling Value form BST
            BinaryTree btree2 = new BinaryTree();
            btree2.insert(new bnode<int>(8));
            btree2.insert(new bnode<int>(4));
            btree2.insert(new bnode<int>(12));
            btree2.insert(new bnode<int>(2));
            btree2.insert(new bnode<int>(6));
            btree2.insert(new bnode<int>(10));
            btree2.insert(new bnode<int>(14));
            int ceil = btree2.FindCeiling(btree2.root,1);

            //btree2.BSTwithNeighbourPointers(btree2.root);
     
            //Two Array Merge
            int[] B = new int [6];
            B[0] = 2 ; B[1] = 3; B[2]=5;
            int[] A = new int [3];
            A[0]= 1; A[1]= 4; A[2]=6;
            MergeTwoSortedArrays m = new MergeTwoSortedArrays(A, B);
            m.Merge();

            B = new int[] { 1, 3, 5, 13, 15,17 };
            A = new int[] { 2, 4, 5, 8, 10, 11 };
            m = new MergeTwoSortedArrays(A, B);
            //This operation Median finding applicable if both A and B are same size.
            m.MergeOperation();
            
            int med = m.MedianCoparision(A, B);
            for (int i = 0; i < B.Length; i++)
            {
                Console.WriteLine(B[i].ToString());
            }

            //Find Celebrity
           
            List<person> persons= new List<person>();
            persons.Add( new person(1, new int[] { 2,3,4 }));
            persons.Add( new person(2, new int[] { 1,3,4 }));
            persons.Add(  new person(3, new int[] { 1,4 }));
            persons.Add(  new person(4, new int[] {}));
            persons.Add(  new person(5, new int[] { 2, 4 }));

            FindCelebrity c = new FindCelebrity();
            person p = c.findCelebrity(persons);

            StringReversalinPlace_and_Recursion pg = new StringReversalinPlace_and_Recursion("ABCD");
            string reverse = pg.ReverseStringRecursion("ABCDEF");
            pg.ReverseString();

             
            //max sum subsequence
            int[] e = new int[]{ 4,-9,3,-2,4,-12};
            MaxSubSequenceSum m1 = new MaxSubSequenceSum(e);
            m1.GetMaxSubSequenceSum();
            m1.GetMaxSubSequenceSumDynamicprog();

            e = new int[] { -1,0,2,-1,1,0,-2};
            PositivNegativZeroSort NZP = new PositivNegativZeroSort(e);
            NZP.sortNPZ();

         
            //find duplicates
            FindDuplicates fd = new FindDuplicates();
            int[] arr = new int[] { 1, 2, 3, 1, 3, 0, 6 };
            fd.findDup(arr);

            //find purmutation to find anagram
            FindAnagramUsePermutation per = new FindAnagramUsePermutation("ABCD");
            per.permutation("", "ABCD");

            Console.WriteLine("-----------------------");
            char[] c1 = new char[] { 'A', 'B'};
            per.purmutUsingSwap(c1,c1.Length);
            //foreach (char[] c2 in per.str)
            //{
            //    for (int i = 0; i < c2.Length; i++)
            //    {
            //        Console.Write(c2[i]);
            //    }
            //    Console.WriteLine("");
            //}

            int[] arr3 = new int[12] { 1, 1, 2, 2, 2, 3, 3, 3, 4, 4, 5, 5 };
            FindTheNumberOfOccurencesInSortedArray fnc = new FindTheNumberOfOccurencesInSortedArray();
            fnc.FindNumberOfOccurnece(arr3);

            

            Console.Read();
        }
    }
}
