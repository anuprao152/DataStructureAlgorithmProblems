using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using programs;
using Programs.Amazon;
using Programs.Interview;
using Programs.Interview.SalesForce;
using Programs.Interview.Zulily;
using Programs.Interview.Vmware;
using Programs.MutliThreading;
using System.Threading;
using Programs.Facebook;

namespace programs
{
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

            l.IsloopExist();


            //nth node from last 
            LinkedList ll = new LinkedList();
            node<int> ll1 = new node<int>(5);
            node<int> ll2 = new node<int>(6);
            node<int> ll3 = new node<int>(7);
            node<int> ll4 = new node<int>(8);
            node<int> ll5 = new node<int>(9);
            node<int> ll6 = new node<int>(10);
            node<int> ll7 = new node<int>(11);
            ll.Add(ll1); ll.Add(ll2); ll.Add(ll3); ll.Add(ll4); ll.Add(ll5); ll.Add(ll6); ll.Add(ll7);
            DeleteNthElementFromLastLinkedList nthlast = new DeleteNthElementFromLastLinkedList();
            nthlast.GetNthFromLast(ll.head, 3);

            // Delete nth nod
            nthlast.DeleteNthFromLast(ll.head, 3);//delete 9 
            nthlast.traverse(ll.head);

            //Drawing BST
            //                   6
            //          2                11
            //      1       4        8       12
            //            3   5    7   9        13
            //                           10

            BinaryTree btree = new BinaryTree();
            btree.insert(new Bnode<int>(6));
            btree.insert(new Bnode<int>(11));
            btree.insert(new Bnode<int>(8));
            btree.insert(new Bnode<int>(12));
            btree.insert(new Bnode<int>(2));
            btree.insert(new Bnode<int>(1));
            btree.insert(new Bnode<int>(4));
            btree.insert(new Bnode<int>(13));
            btree.insert(new Bnode<int>(5));
            btree.insert(new Bnode<int>(3));
            btree.insert(new Bnode<int>(7));
            btree.insert(new Bnode<int>(9));
            btree.insert(new Bnode<int>(10));



            PrintAllPathBinaryTree PPath = new PrintAllPathBinaryTree();
            PPath.PrintPathRootToLeaf(btree.root);

            //Convert tree in doubly linked list ( this program shoule be commented out to run)
            //BinaryTreeToDoublyLinkedList b2ddl = new BinaryTreeToDoublyLinkedList();
            //b2ddl.ConvertB2DDL(btree.root);


            //Sub Tree
            BinaryTree subtree = new BinaryTree();
            //subtree.insert(new bnode<int>(4));
            //subtree.insert(new bnode<int>(3));
            //subtree.insert(new bnode<int>(5));


            SubTree progIsSubTree = new SubTree();
            Boolean issubtree = progIsSubTree.FindSubTree(btree.root, subtree.root);

            var twosum = new _2Sum();
            twosum.TwoSumK(new int[] { 1, 4, 3, 5, 9, 2, 7 }, 6);


        //IsBalanced or Not ( ans not balanced, if you want balanced ans, then 
        // Please remove node 5 and 3 

        IsBalancedBinaryTree balancedTree = new IsBalancedBinaryTree();
            Boolean ansbalanced = balancedTree.Isbalanced(btree.root);

            //find Kth smallest element in binary search tree
            KthSmallelementBinarySearchTree kelement = new KthSmallelementBinarySearchTree();
            kelement.inorder(btree.root);

            //in-order with recursion
            btree.inorderTraverse(btree.root);

            //In-Order Traversal without recuriosn using stack
            Console.WriteLine("In-Order Traversal without recuriosn using stack");
            BinaryTreeInOrderWithoutRecursion prog = new BinaryTreeInOrderWithoutRecursion();
            prog.InorderTraversalUsingStack(btree.root);

            Console.WriteLine("All the Leaf nodes of Btree");
            //btree.printleafnodes(btree.root);
            LeafOrBoundryofBinaryTree binaryTree = new LeafOrBoundryofBinaryTree();
            binaryTree.printleafnodes(btree.root);

            Console.WriteLine("All the Left Edge nodes of Btree");
            //btree.printleftEdge(btree.root);
            binaryTree.printleftEdge(btree.root);

            Console.WriteLine("All the right Edge nodes of Btree");
            //btree.printrightEdge(btree.root);
            binaryTree.printrightEdge(btree.root);

            Console.WriteLine("Print Outer Edges of a Btree");
            //btree.printouterMostEdge(btree.root);
            binaryTree.printouterMostEdge(btree.root);
            
            //Print lowest common Ancestor in Binary Search Tree
            Bnode<int> LCA = btree.findCommonAncestor(btree.root, new Bnode<int>(13), new Bnode<int>(10));
            Console.WriteLine("Print lowest common Ancestor in Binary Search Tree:" + LCA.data);
            int height = btree.findHeight(btree.root);

            //print lowest common Ancestor in Binary Tree
            LowestCommonAncesstorBinaryTree blca = new LowestCommonAncesstorBinaryTree();
            LCA = blca.FindLCA(btree.root, new Bnode<int>(13), new Bnode<int>(10));
            Console.WriteLine("Print lowest common Ancestor in Binary Tree:" + LCA.data);
           
            //print out order level Btree
            Console.WriteLine("Print order-level binary tree");
            btree.printOrderLevelBtree(btree.root);

            //Construct a binary tree
            List<int> preOrder = new List<int>() { 1, 2, 4, 8, 9, 10, 11, 5, 3, 6, 7 };
            List<int> InOrder = new List<int>() { 8, 4, 10, 9, 11, 2, 5, 1,6,3,7 };
            Bnode<int> root1 = BinaryTree.ConstructBinaryTree(preOrder, InOrder);

            Console.WriteLine("BTree Construction test by InOrder Traversal");
            btree.inorderTraverse(root1);

            //Find Ceiling Value form BST
            BinaryTree btree2 = new BinaryTree();
            btree2.insert(new Bnode<int>(8));
            btree2.insert(new Bnode<int>(4));
            btree2.insert(new Bnode<int>(12));
            btree2.insert(new Bnode<int>(2));
            btree2.insert(new Bnode<int>(6));
            btree2.insert(new Bnode<int>(10));
            btree2.insert(new Bnode<int>(14));
            int ceil = btree2.FindCeiling(btree2.root,1);

            //btree2.BSTwithNeighbourPointers(btree2.root);

            //------------------IsBinary Search Tree------------------
            IsBST btreeIsBst = new IsBST();
            btreeIsBst.IsBinarySearchTree(btree2.root);


            //Two Array Merge
            int?[] arrA = new int?[] { 2, 4, 6, 8, 13 }; //Small Array
            int?[] arrB = new int?[13] { -1, 3, 5, 7, 9,11,12,null,null,null,null,null,null };//big Array

            MergeTwoSortedArrays mat = new MergeTwoSortedArrays(arrA, arrB);
            mat.Merge();

            int?[] B = new int?[] { 1, 3, 5, 13, 15,17 };
            int?[] A = new int?[] { 2, 4, 5, 8, 10, 11 };
            mat = new MergeTwoSortedArrays(A, B);
            //This operation Median finding applicable if both A and B are same size.
            mat.MergeOperation();
            
            int? med = mat.MedianCoparision(A, B);
            for (int i = 0; i < B.Length; i++)
            {
                Console.WriteLine(B[i].ToString());
            }

            //Find Celebrity
           
            //List<person> persons= new List<person>();
            //persons.Add( new person(1, new int[] { 2,3,4 }));
            //persons.Add( new person(2, new int[] { 1,3,4 }));
            //persons.Add(  new person(3, new int[] { 1,4 }));
            //persons.Add(  new person(4, new int[] {}));
            //persons.Add(  new person(5, new int[] { 2, 4 }));

            CelebrityProblem c = new CelebrityProblem();
            //person p = c.findCelebrity(persons);

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

            //Permutation
            PermutationAlgo pe = new PermutationAlgo();
            pe.permutationAlgo("", "ABCD");

            pe.PrintAllPermutations(new int[] { 1, 2 });


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

            //------------------- Shuffule Random Numbers -----------------
            ShuffleNumbers num = new ShuffleNumbers();
            int[] shuffledNum =  num.shuffleNumbers();

            //--------------------Balanced Parantheses Test Case --------------
            balancedparentheses exp = new balancedparentheses("{{[[()]]}}}");
            Boolean b= exp.IsBalanced();
            exp = new balancedparentheses("]]}}}");
            b = exp.IsBalanced();
            exp = new balancedparentheses("{[[(]]]}}");
            b = exp.IsBalanced();

            //---------------Reverse a Linked List ----------------------
            //linked list for test
            LinkedList list = new LinkedList();
            node<int> n1 = new node<int>(5);
            node<int> n2 = new node<int>(6);
            node<int> n3 = new node<int>(7);
            node<int> n4 = new node<int>(8);
            node<int> n5 = new node<int>(10);

            list.Add(n1); list.Add(n2); list.Add(n3); list.Add(n4); list.Add(n5);

            ReverseLinkedList revList = new ReverseLinkedList();

            //iterative reverse linked list
            node <int> reversedList = revList.ReverseIterative(list.head);


            //Recursion reverse linked list
            node<int> head = null;
            revList.RecursiveReverseLinkedList(list.head,null);


            //--------------------------Permutation---------------------

            PermutationAlgo perm = new PermutationAlgo();
            perm.Permutation(new char[] {'A','B','C'}, 0, 3);

            //-------------------SubArray Sum K --------------------------

            SubArraySumK sum = new SubArraySumK();
            sum.SubArraySumk (new int[] {15, 2, 4, 8, 9, 5, 10, 23}, 23);


            //------------------Find pair whoses sum is given number K in sorted array -----------------
            int[] sorted = new int[] {-8,1, 4, 6,8,8,10, 45};
            FindSumOfTwoElementsGivenNumber pairK = new FindSumOfTwoElementsGivenNumber();
            pairK.findKsumPair(sorted, 16); 
            //answer is multiple pair 6+10 and 8+8;

            //------------------------ Below two techniques are in place removal and compression tech------

            //------------------Remove Duplicates in sorted array and in space -------
            sorted = new int[] { -8, 1, 1, 2, 3, 3, 3, 4,4,5,5 };
            Remove_Duplicates_from_Sorted_Array removeDup = new Remove_Duplicates_from_Sorted_Array();
            removeDup.RemoveDuplicatesFromSortedArray(sorted);
            //answer is sorted array itself = -8,1,2,3,4,5, |3,4,4,5,5| ( extran elements remove) 

            //------------------Compress the sorted String [aBBBAAAaaa] compress to a1B2A3 ( in place)----
            char[] compressStr = new char[] { 'a', 'B', 'B', 'B', 'A', 'A', 'A', 'a', 'a', 'a' };
            removeDup.CompressString(compressStr);

            //------------------Find First non-Repeating Character------------------------------------

            FirstNonRepeatingCharacter fnrc = new FirstNonRepeatingCharacter();
            char nonrepeat = fnrc.FindFirstNonRepCh("abcbdeafcf");

            //------------Multiplication Recursion----------------
            int ans = new MultiplicationRecursion().Mul(2, 4);
            Console.WriteLine("Mul {0}", ans);


            //------------ Successor and Predessor -------------//

            BinaryTree BSuc = new BinaryTree();
            BSuc.insert(new Bnode<int>(18));
            BSuc.insert(new Bnode<int>(20));
            BSuc.insert(new Bnode<int>(14));
            BSuc.insert(new Bnode<int>(24));
            BSuc.insert(new Bnode<int>(19));
            BSuc.insert(new Bnode<int>(25));
            BSuc.insert(new Bnode<int>(23));
            BSuc.insert(new Bnode<int>(22));
            BSuc.insert(new Bnode<int>(21));
            BSuc.insert(new Bnode<int>(16));
            BSuc.insert(new Bnode<int>(17));
            BSuc.insert(new Bnode<int>(15));
            BSuc.insert(new Bnode<int>(13));

            BSTSuccessorAndPredecessor suc = new BSTSuccessorAndPredecessor();
            Bnode<int> Successor =  suc.InOrderSuccesor(BSuc.root, new Bnode<int>(22));
            Console.WriteLine("Successor : {0}", Successor.data.ToString());

            Bnode<int> Predecessor = suc.InOrderPredecessor(BSuc.root, BSuc.root.left); //14
            Console.WriteLine("Predecessor : {0}", Predecessor.data.ToString());

            //Phone Number Print 1-800-COM-CAST to 18002662278
           


            //Base Converter (binary or 0-9 base works)
            ConvertNumToBase conv = new ConvertNumToBase();
            Console.WriteLine("\nDecimal to Binary");
            conv.BaseConverter(8, 2);

            Console.WriteLine("\nDecimal to Eight");
            conv.BaseConverter(16, 8);

            Console.WriteLine("\nDecimal to Hex");
            //Hexadecimal converter
            conv.HexaDecimalConverter(95, 16);

            //Binary To Decimal
            Console.WriteLine("\nBinary To Decimal");
            NumberConverter conver = new NumberConverter();
            conver.NumConverter("110", 2);

            //Alphabates(26base) system to Decimal
            Console.WriteLine("\nAlphabates(26base) system to Decimal");
            _26BaseToDecimal base26 = new _26BaseToDecimal();
            base26.lettersToDecimal("az", 26);

            base26.Decimaltoletters(52, 26);

            //BoogleGame
            TrieNode t = new TrieNode();
            t.Contains('a');

            //Merge Sort
            MergeSortProg merge = new MergeSortProg();
            int[] array = new int[] {2,4,1,3, 8,7,9,6,5,10};
            int[] afterMergeSort = new int[10];
            afterMergeSort= merge.MergeSort(array);
            

            //Reverse words in a string
            ReverseWordsInString rw = new ReverseWordsInString();
            string rev=  rw.ReverseWords("Anup Rao");
            rev = rw.ReverseWords("Anup; Rao..");//fail

            //Remove Alternate nodes in a linked list
            LinkedList alt = new LinkedList();
            node<int> altl1 = new node<int>(1);
            node<int> altl2 = new node<int>(2);
            node<int> altl3 = new node<int>(3);
            node<int> altl4 = new node<int>(4);
            node<int> altl5 = new node<int>(5);
            node<int> altl6 = new node<int>(6);
            node<int> altl7 = new node<int>(7);
            node<int> altl8 = new node<int>(8);
            node<int> altl9 = new node<int>(9);
            node<int> altl10 = new node<int>(10);
            alt.Add(altl1); alt.Add(altl2); alt.Add(altl3); alt.Add(altl4); alt.Add(altl5); alt.Add(altl6); alt.Add(altl7); alt.Add(altl8); alt.Add(altl9); alt.Add(altl10);
            RemoveAlternateLinkedList altRnode = new RemoveAlternateLinkedList();
            //Console.WriteLine("\norigional\n");
            //altRnode.print(alt.head);
            //Console.WriteLine("\ndelte alternate iteratively\n");
            //altRnode.RemoveAlt(alt.head);
            //altRnode.print(alt.head);
            //Console.WriteLine("\ndelte alternate recursively\n");
            //altRnode.RemoveAltRecursive(alt.head);
            //altRnode.print(alt.head);

            swapAlternative swapalt = new swapAlternative();
            swapalt.swapAlternativeElements(alt.head);
            swapalt.SwapAlternateElementsRec(alt.head);
            altRnode.print(alt.head);


            ConvertNumToLinkedList cntl = new ConvertNumToLinkedList();
            cntl.NumToLinkedList(1234);

            //Sum Two linkedList
            LinkedList sumL = new LinkedList();
            node<int> sumL1 = new node<int>(1);
            node<int> sumL2 = new node<int>(2);
            node<int> sumL3 = new node<int>(3);
            node<int> sumL4 = new node<int>(4);
            node<int> sumL5 = new node<int>(5);
            sumL.Add(sumL1); sumL.Add(sumL2); sumL.Add(sumL3); sumL.Add(sumL4); sumL.Add(sumL5);

            LinkedList sumLS = new LinkedList();
            node<int> sumL12 = new node<int>(7);
            node<int> sumL22 = new node<int>(9);
            node<int> sumL32 = new node<int>(8);
            node<int> sumL42 = new node<int>(9);
            sumLS.Add(sumL12); sumLS.Add(sumL22); sumLS.Add(sumL32); sumLS.Add(sumL42);

            SumTwoLinkedList sumlink = new SumTwoLinkedList();
            sumlink.LinkedListsSum(sumL.head, sumLS.head);


            //Reverse string before X
            ReverseCharactersBeforeX revS = new ReverseCharactersBeforeX();

            int startIndex = -1;
            //string res = revS.ReverseX("abcx",ref startIndex);
            revS.ReverseX("abcxd", 0);

            //Regex parser
            RegexParser regexp = new RegexParser();
            regexp.Match("ab*ab", "abbbbab", 0, 0);
            regexp.Match("ab*ab", "aab", 0, 0);
            regexp.Match("ab*ab", "aab", 0, 0);
            regexp.Match("ab*ba", "abba", 0, 0);
            regexp.Match("ab*ba", "abbbaba", 0, 0);//fail
            regexp.Match("ab*ab", "ab", 0, 0);
            regexp.Match("ab*ab", "abbab", 0, 0);
            regexp.Match("ab*ab", "abbabb", 0, 0);

            //Matrix Spiral
            MatrixSpriral matrix = new MatrixSpriral();
            matrix.SpiralPrint(new int[][] { new int[] { 1, 2, 3, 4, 5 }, new int[] { 6, 7, 8, 9, 10 }, new int[] { 11, 12, 13, 14, 10 } });

            //Rotation Count minimal
            RotationCount rc = new RotationCount();
            int minimal = rc.CalcRotationCount(new int[]{ 4,5,6,7,1,2,3});
           

            //Replace spaces with %20
            ReplaceSpaces replace = new ReplaceSpaces();
            replace.ReplaceSpacesInStr("Anup Devangbhai Rao");

            //Set zeros for rows and columns in Matrix
            ZeroEntireRowAndColumn Zmat = new ZeroEntireRowAndColumn();
            int[][] Zmatrix= new int[][]{ new int[]{1,2,3,0}, new int[] {4,0,6,5}, new int[] {7,8,9,10}};
            Zmat.printMatrix(Zmatrix);
            Zmat.SetZero(Zmatrix);

            //Find Num in Sorted Matrix
            FindNumInSortedMatrix fsm = new FindNumInSortedMatrix();
            int[][] smMat = new int[][] {new int[]{ 1,2,8,9},new int[]{2,4,9,12}, new int[]{4,7,10,13}, new int[] {6,8,11,15}};
            
            Boolean find = fsm.FindNum(smMat,7);

            //Rotate Array
            RotateArrayProg ra = new RotateArrayProg();
            int[] rotArr =new int[] { 1, 2, 3, 4, 5, 6, 7 };
            //Naive Method
            ra.RotateArray(rotArr, 3);
            ra.printArray(rotArr);

            //Juggling Method
            ra.RotateJug(rotArr, 3);
            ra.printArray(rotArr);

            //Min Heap
            Heap h= new Heap(11);
            h.insert(17);
            h.insert(21);
            h.insert(18);
            h.insert(43);
            h.insert(19);
            h.insert(11);
            h.insert(26);
            h.insert(23);
            h.insert(13);
            h.insert(17);
            h.insert(12);

            //get min
            int min = h.GetMin();

            min = h.extractMin();

            //Find top k max number
            TopKMaxNumbers topk = new TopKMaxNumbers();
            topk.FindKMax(new int[] { 1, 5, 8, 10, 2, 11, 1, 6, 8, 7, 9 }, 4);

            //simple binary search algo
            BinarySearchAlgo bsearch = new BinarySearchAlgo();
            bsearch.BinarySearch(new int[] { 1, 2, 3, 4, 5, 6, 7 }, 6);

            //Reverse Words
            ReverseWords rv = new ReverseWords();
            rv.ReverseString("I am Anup Rao");

            //Fibonaci Series
            FibonaciSeries fb = new FibonaciSeries();
            fb.Fib(7);

            fb.fibIteratively(7);

            //root to leaf sum path
            RootToLeafPathSum r2l = new RootToLeafPathSum();

            BinaryTree r2fsumTree = new BinaryTree();

            r2fsumTree.insert(new Bnode<int>(6));
            r2fsumTree.insert(new Bnode<int>(11));
            r2fsumTree.insert(new Bnode<int>(2));
            r2fsumTree.insert(new Bnode<int>(4));
            r2fsumTree.insert(new Bnode<int>(5));
            r2fsumTree.insert(new Bnode<int>(1));
            r2fsumTree.insert(new Bnode<int>(3));

            Boolean br2f = r2l.FindSumPath(r2fsumTree.root, 17);

            SerializeAndDeserializeBtree sdb = new SerializeAndDeserializeBtree();
            sdb.Serialize(r2fsumTree.root);

            char[] darr= new char[] {'3','1','5', '#','#','#','2','4', '#','#','6','#','#'};
            Queue<char> srlq = new Queue<char>();
            srlq.enqueue('3'); srlq.enqueue('1'); srlq.enqueue('5'); srlq.enqueue('#'); srlq.enqueue('#');
            srlq.enqueue('#'); srlq.enqueue('2'); srlq.enqueue('4'); srlq.enqueue('#'); srlq.enqueue('#');
            srlq.enqueue('6'); srlq.enqueue('#'); srlq.enqueue('#'); 

            BinaryNode root = new BinaryNode();
            sdb.Desearlize(darr);

            var serilazeroot = sdb.Desearlize(darr, 0,srlq);

            //All continiousSequences
            var cmb = new Substrings();
            cmb.PrintAllSubstrings(new int[] { 1, 2, 3, 4 });

            //Anagram is solved by permuation

            //Longest palindromic subsequence
            longestPalindromSubSequence lps = new longestPalindromSubSequence();
            string lpsstr = "AAXAYBZBAMANA";
            Boolean[] res = new Boolean[lpsstr.Length];
            lps.LPS(lpsstr, 0, lpsstr.Length - 1,res);

            //test
            new test().func();

            //Random number
            RandomNumber r = new RandomNumber();
            int[] stream = new int[5] { 1, 2, 3, 4, 5 };
            for (int i = 0; i < stream.Length; i++)
            {
                int randomNum = r.SelectRandom(stream[i]);
                Console.WriteLine(randomNum);

            }

            //Design question asked by Microsoft

            // Movie        | director              | Actors

            // Matrix       |  Andy Wachowski       | Keanu Reeves
            // Matrix       |  Andy Wachowski       | Laurence Fishburne
            // Matrix       |  Andy Wachowski       | Carrie-Anne 
            // Interstellar |  Christopher Nolan    | Matthew McConaughey
            // Interstellar |  Christopher Nolan    | Anne Hathaway
            // Inception    |  Christopher Nolan    | Leonardo DiCaprio   
            // Inception    |  Christopher Nolan    | Joseph Gordon-Levitt
            // Inception    |  Christopher Nolan    | Ellen Page

            String[] data = new String[] {  "Matrix       |  Andy Wachowski       | Keanu Reeves" ,
                                           "Matrix       |  Andy Wachowski       | Laurence Fishburne" ,
                                            "Matrix       |  Andy Wachowski       | Carrie-Anne",
                                            "Interstellar       |  Christopher Nolan       | Matthew McConaughey" ,
                                            "Interstellar       |  Christopher Nolan       | Anne Hathaway" ,
                                            "Inception       |  Christopher Nolan       | Leonardo DiCaprio" ,
                                            "Inception       |  Christopher Nolan       | Joseph Gordon-Levitt" ,
                                            "Inception       |  Christopher Nolan       | Ellen Page" ,
                                            };

            DesignQuestion dq = new DesignQuestion();
            dq.Read(data);


            RemoveDuplicatesFromString rdu = new RemoveDuplicatesFromString();
            rdu.RemoveDup("jdctndjmckp");

            rdu.RemoveDup("1.2AE.B/ab(231/.CB/A");


            ConnectedIsland island = new ConnectedIsland();
            int Islands = island.FindNumberOfIsland(new int[][]{new int[] {1, 1, 0, 0, 0},
                                                  new int[] {0, 1, 0, 0, 1},
                                                  new int[] {1, 0, 0, 1, 1},
                                                  new int[] {0, 0, 0, 0, 0},
                                                  new int[] {1, 0, 1, 0, 1}
                                                });
            Console.WriteLine("\n"+Islands);



            Set set = new Set();
            Boolean isset = set.IsSet(new int[] { 1, 3, 5, 6, 8, 23, 45 });
            isset = set.IsSet(new int[] { 1, 3, 5, 6, 8, 23,23, 45 });
            
            int?[] setr = set.MergeIntoSet(new int[] {1,3,8,9,},new int[]{2,4,6,8,9,10});

            ShuffleLinkedList shufflell = new ShuffleLinkedList();
            LinkedList sll = new LinkedList() { head = new node<int>(1) };
            sll.Add(new node<int>(2));
            sll.Add(new node<int>(3));
            sll.Add(new node<int>(4));
            sll.Add(new node<int>(5));
            sll.Add(new node<int>(6));

            shufflell.Shuffle(sll);

            //Hashtable
            HashTableLinearProbing hashtbl = new HashTableLinearProbing(5);
            hashtbl.Put(1, "Anup");
            hashtbl.Put(2, "Dhaval");
            hashtbl.Put(3, "Hardik");
            hashtbl.Put(4, "Vishal");
            hashtbl.Put(1, "UpdateAnup");
            hashtbl.Put(5, "Kiran");
            hashtbl.Put(6, "Raina");
            hashtbl.Put(7, "Sehwag");
            hashtbl.Remove(4);

            PhoneDictionary pd = new PhoneDictionary();
            pd.printWords(new int[] { 2, 3, 4 }, 0, new char[3], 0);

            NumberToWords ntw = new NumberToWords();
            ntw.PrintNumberToWords(11);
            ntw.PrintNumberToWords(110);
            ntw.PrintNumberToWords(250);
            ntw.PrintNumberToWords(9999);
            ntw.PrintNumberToWords(999);
            ntw.PrintNumberToWords(500);

            Anagram anagram = new Anagram();
            anagram.FindAnagram("abcde", "acbed");
            anagram.FindAnagram("abacde", "acbedb");
            anagram.FindAnagram("abaecdef", "afacbede");

            Programs.MovingAverage ma= new Programs.MovingAverage();
            ma.NextAverage(1);
            ma.NextAverage(2);
            ma.NextAverage(3);
            ma.NextAverage(4);
            ma.NextAverage(5);
            ma.NextAverage(6);

            MoveZerosSolution mz = new MoveZerosSolution();
            mz.MoveZeros(new int[] { 0, 1, 0, 3, 12 });


            int cityWidth = 5;
            int cityLength = 7;
            int[] xCordinates = { 2, 4 };
            int[] yCordinates = { 3, 7 };

           Programs.lockerlocation.printMatrix(cityWidth, cityLength, xCordinates, yCordinates);


           LongestRepeatedSubString lrs = new LongestRepeatedSubString();
           String longestrepeatedSubstring = lrs.FindLongestRepeatedSubstring("banana");
           longestrepeatedSubstring = lrs.FindLongestRepeatedSubstring("geeksforgeeks");
           longestrepeatedSubstring = lrs.FindLongestRepeatedSubstring("atcgatcga");

           EditDistanceAlgo eda = new EditDistanceAlgo();

           int editD =  eda.EditDistance("sunday", "saturday", "sunday".Length -1 , "saturday".Length - 1);

           //minimum coin change problem
           minimumcoinProblem mcp = new minimumcoinProblem();
           var minimumCoins = mcp.MinCoins(new int[] { 1, 5, 10, 25 }, 35);

           DeletionDistanceProg dsg = new DeletionDistanceProg();
           dsg.DeletionDistance("thought", "sloughs", "thought".Length - 1, "sloughs".Length - 1);

           LongestPalindromicSubstring lpsubstring = new LongestPalindromicSubstring();
           lpsubstring.FindLongestPalindromicSubstring("forgeeksskeegfor");

           lpsubstring.FindLongestPalindromicSubstring("EDREPUBLIC");

           Graph g = new Graph();

           g.AddEdge("SFO", "LAX").AddEdge("LAX", "ATL").AddEdge("ATL", "DEN")
               .AddEdge("DEN", "BOS").AddEdge("BOS", "JFK")
               .AddEdge("JFK", "DEN").AddEdge("DEN", "PHL")
               .AddEdge("PHL", "DFW").AddEdge("DFW", "SEA")
               .AddEdge("SEA", "DEN").AddEdge("DEN", "HOU")
               .AddEdge("HOU", "MIA");

           g.DFT("SFO");

           TestBooking1 tb1 = new TestBooking1();
           tb1.DeltaEncoding(new int[] { 25626, 25757, 24367, 24267, 16, 100, 2, 7277});

           SortedArrayToBSTProg sortedArrToBST = new SortedArrayToBSTProg();
            var sortedArr = new int[]{1,2,3,4,5,6,7,8};
            sortedArrToBST.SortedArrayToBST(sortedArr, 0, sortedArr.Length - 1);

            MergeIntervals mergeIntervals = new MergeIntervals();

            var Intervals = new List<MergeIntervals.Interval>();
            //[1,3],[2,6],[8,10],[15,18]
            
             Intervals.Add(new  MergeIntervals.Interval {startime = 1, endtime =3});
             Intervals.Add(new  MergeIntervals.Interval {startime = 2, endtime =6});
             Intervals.Add(new  MergeIntervals.Interval {startime = 8, endtime =10});
             Intervals.Add(new  MergeIntervals.Interval { startime = 15, endtime = 18 });
           
            mergeIntervals.FunMergeIntervals(Intervals);

            TopologicalSortig topologicalsortProg = new TopologicalSortig(6);
            topologicalsortProg.TopologicalSort();

            SubSetProb subsetprob = new SubSetProb();
            subsetprob.Subset(new int[] { 1, 2, 3 }, 0, new int[3], 0);
            
            FriendshipScore frdscore = new FriendshipScore();

            int[][] FrdMat = new int[][] { new int[] {0,1,1,1,0,0,0},
                                           new int[] {1,0,0,0,1,0,0},
                                           new int[] {1,0,0,1,1,0,0},
                                           new int[] {1,0,1,0,0,0,1},
                                           new int[] {0,1,1,0,0,1,0},
                                           new int[] {0,0,0,0,1,0,1},
                                           new int[] {0,0,0,1,0,1,0}
                                            };

           var friendscor =  frdscore.FindScore(FrdMat,0,new Boolean[7], 0, 0,6);
           Console.WriteLine(friendscor);

            var lightGrid = new char[][]{new char[]{'N','Y'},new char[]{'Y','N'},new char[]{'Y','N'}};

             var OriglightGrid = new char[][]{new char[]{'N','Y'},new char[]{'Y','N'},new char[]{'Y','N'}};

            SwitchFlip switchflip = new SwitchFlip();
            var minflip = switchflip.MaxRowsLitup(lightGrid, 0, 0, new int[lightGrid[0].Length], int.MinValue, new Stack<int>(), int.MaxValue, OriglightGrid);
            Console.WriteLine(minflip);

            CardRemoval crm = new CardRemoval();
            crm.SubArraySumk1("MMMMMBRU23", 13);
            crm.SubArraySumk1("MMMMMMMMMM", 13);

            crm.SubArraySumk1("MMMMBUR23L", 13);
            crm.SubArraySumk1("BU68482BM6875RL5M9573R", 13);
            crm.SubArraySumk1("BRM262362UMMBR6262437892MUULB332", 13);
            crm.SubArraySumk1("MUR55662LL3MBBMM2235RMMBM253525MMLMMU", 13);
            crm.SubArraySumk1("L92L43MU5U879RB2RM3", 13);
            crm.SubArraySumk1("7879L4LRM24R46M2B3UR7U4256632UR738LB6MB8M959L5U895", 13);
            crm.SubArraySumk1("B8929LUBR6L247759UMM5M3M947LRB284R4256R36587U6833B", 13);
            crm.SubArraySumk1("BLLUMM29U883L2LLU9329LBLLULMM2LULMRR88UL2B", 13);

            MaxProfitRod rdm = new MaxProfitRod();
            string sfsf="fsafs";
            string[] nums = sfsf.Split();

             

            rdm.FindMaxProfitCut(new int[] { 26, 103, 59 }, 1, 10);

            //DependancyProg progdpe = new DependancyProg();

            //string[] lines = System.IO.File.ReadAllLines(@"C:\Users\Anup Rao\Desktop\r\System Dependencies v3.in.txt");

            //Dictionary<String, DependancyProg.Item> Itemlist = new Dictionary<String, DependancyProg.Item>();

            //foreach (var ln in lines)
            //{
            //    string[] w = ln.Split(' ');
               
            //    var cmd = w[0];

            //    if(cmd == "DEPEND")
            //    {
            //        var itms = new List<DependancyProg.Item>();


            //        DependancyProg.Item newitem = null;
            //        for(int i=2;i<w.Length;i++)   
            //        {
            //            if (w[i] == string.Empty)
            //                continue;

            //            if (!Itemlist.ContainsKey(w[i].ToString()))
            //                newitem = new DependancyProg.Item { Name = w[i].ToString() };

            //            newitem = Itemlist[w[i].ToString()];


            //            itms.Add(newitem);
                       
            //        }

                    

            //        if (!Itemlist.ContainsKey(w[1].ToString()))
            //            newitem = new DependancyProg.Item { Name = w[1].ToString() };

            //        newitem = Itemlist[w[1].ToString()];

            //        progdpe.DependOn(new DependancyProg.Item {Name = w[1].ToString()},itms.ToArray());
            //    }

            //    if (cmd == "INSTALL")
            //    {
            //        progdpe.Install(new DependancyProg.Item { Name = w[1].ToString() });
            //    }

            //    if (cmd == "REMOVE")
            //    {
            //        progdpe.Remove(new DependancyProg.Item { Name = w[1].ToString() });
            //    }

            //}

            var testmy = new test();
           

            UperLowerCasePermutation ulcp = new UperLowerCasePermutation();
            ulcp.PermuteUpperLower("abc",new Boolean[3], 0);

            WordLadder wld = new WordLadder();
           // wld.Transform("hit", "cog");

            string slu = "00:01:07,400-234-090\n 00:05:01,701 - 080 - 080\n00:05:00,400 - 234 - 090";
            slu = "00:01:07,400-234-090\n00:05:01,701-080-080\n00:05:00,400-234-090";

            slu = "00:01:07,400-234-090\n00:05:01,701-080-080\n00:05:00,400-234-090\n00:01:07,301-080-081\n00:04:00,301-080-081\n00:01:00,301-080-081";
            programs.Interview.VistaPrint.SolutionF tf = new Interview.VistaPrint.SolutionF();
            tf.solution(slu);

            Programs.Facebook.DecodeDigitsProg decodedigit= new Programs.Facebook.DecodeDigitsProg();

            decodedigit.DecodeDigits(new int[]{ 1,2,3},0, new string[3],0);

            decodedigit.DecodeDigits(new int[] { 1, 2, 3, 4 }, 0, new string[4], 0);

            new SortSegmentProg().sortSegments("AZQF013452BAB");

            IPAddressValidation ipadr = new IPAddressValidation();
           var len =  new List<string> { "22.231.113.64",
            "22.231.113.164",
            "222.231.113.64",
          "1050:1000:1000:a000:5:600:300c:326b",
            "1050:1000:2000:ab00:5:600:300c:326a",
            "1051:1000:4000:abcd:5:600:300c:326b" };

            for (int i = 0; i < len.Count; i++)
            { 
                if (ipadr.IsValidIPV4Address(len[i]))
                    Console.WriteLine("IPv4");
                else if (ipadr.IsValidIPV6Address(len[i]))
                    Console.WriteLine("IPv6");
                else
                    Console.WriteLine("Neither");
            }

            var uniqarraysum = new MinUniqeArraySum();
            uniqarraysum.FindMiniumUniqeArraySum(new int[] { 5, 2, 6, 3, 2, 9, 10, 4, 5, 2 });

            compression cpr = new compression();
            cpr.CompressString("aaaaabbbbbbbbbccccpqrstuv");

            var pc = new ProducerConsumerProb();
            Thread[] T = new Thread[3];
            for(int i=0;i<3;i++)
            {
                T[i] = new Thread(pc.Produce);
                T[i].Start();
            }
            for (int i = 0; i < 3; i++)
            {
                T[i] = new Thread(pc.Consume);
                T[i].Start();
            }


            var gp = new GenerateParantheses();
            gp.GenerateCombinationParentheses(3, 3, 3, "");

            var StrobogrammaticNumber = new StrobogrammaticNumber();
           var resstrobog =  StrobogrammaticNumber.StroboGrammaticNumberPattern(4);
           var resstrobog1 = StrobogrammaticNumber.StroboGrammaticNumberPattern(5);
           var resstrobog2 = StrobogrammaticNumber.StroboGrammaticNumberPattern(6);

            AmazonSlidingWindowK aswk = new AmazonSlidingWindowK();
            aswk.subStringsKDist("wawaglknagagwunagkwkwagl", 4);
            aswk.subStringsKDist("democracy", 5);

            PartitionSequenceNoCharacterAppear pscnca = new PartitionSequenceNoCharacterAppear();
            pscnca.LengthEachScene(new List<char> { 'a', 'b', 'c', 'd', 'a', 'e', 'f', 'g', 'h', 'i', 'j', 'e' }, new List<int>(),0);
            pscnca.LengthEachScene(new List<char> { 'z','z','c','b','z','c','h','f','i','h','i' }, new List<int>(), 0);

            // pscnca.LengthEachScene(new List<char> { 'a', 'b', 'c', 'd', 'a', 'e', 'f', 'g', 'h', 'i', 'j', 'e' });

            Programs.Google.MaxProductSubArray mpsa = new Programs.Google.MaxProductSubArray();
            mpsa.MaxProductSubArrayFunc(new int[] { 2, 3, -4, 5, -3, -5 });


            var intPalindrom = new Programs.BitManipulation.IntegerPalindrom();
            //intPalindrom.IsIntPalindrom(9);

            intPalindrom.reverseBits(9);

            var numpower2 = new Programs.BitManipulation.NumPowerOf2OrNot();
            numpower2.isNumPower2(8);
            numpower2.isNumPower2(10);

            var graycode = new Programs.BitManipulation.GrayCode();
            var graycodeRes = graycode.GrayCodeFunc(4);


            var MinSpaceWordBreak = new WordBreakProblem();
            var ansSpace = MinSpaceWordBreak.MinSpaceWordBreak("ILikeFaceBookiceCream",0, new Dictionary<string,string> {{"ice","ice"},{"Cream","Cream"},{"iceCream","IceCream"},{"I","I"},{"Like", "Like"}, {"Face","Face"},{"Book","Book"},{"FaceBook","FaceBook"}});

            Console.WriteLine(ansSpace);

            Console.Read();
        }
    }
}
