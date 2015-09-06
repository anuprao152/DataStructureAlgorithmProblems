using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using programs;

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

            l.traverse();


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
            bnode<int> LCA = btree.findCommonAncestor(btree.root, new bnode<int>(13), new bnode<int>(10));
            Console.WriteLine("Print lowest common Ancestor in Binary Search Tree:" + LCA.data);
            int height = btree.findHeight(btree.root);

            //print lowest common Ancestor in Binary Tree
            LowestCommonAncesstorBinaryTree blca = new LowestCommonAncesstorBinaryTree();
            LCA = blca.FindLCA(btree.root, new bnode<int>(13), new bnode<int>(10));
            Console.WriteLine("Print lowest common Ancestor in Binary Tree:" + LCA.data);
           
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

            //Permutation
            Permutation pe = new Permutation();
            pe.permutationAlgo("", "ABCD");


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
            revList.Reverse(list.head);

            

            //--------------------------Permutation---------------------

            Permutation perm = new Permutation();
            perm.Findpermutation(new char[] {' ','A','B','C'}, 0, 3);

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
            BSuc.insert(new bnode<int>(18));
            BSuc.insert(new bnode<int>(20));
            BSuc.insert(new bnode<int>(14));
            BSuc.insert(new bnode<int>(24));
            BSuc.insert(new bnode<int>(19));
            BSuc.insert(new bnode<int>(25));
            BSuc.insert(new bnode<int>(23));
            BSuc.insert(new bnode<int>(22));
            BSuc.insert(new bnode<int>(21));
            BSuc.insert(new bnode<int>(16));
            BSuc.insert(new bnode<int>(17));
            BSuc.insert(new bnode<int>(15));
            BSuc.insert(new bnode<int>(13));

            BSTSuccessorAndPredecessor suc = new BSTSuccessorAndPredecessor();
            bnode<int> Successor =  suc.InOrderSuccesor(BSuc.root, new bnode<int>(22));
            Console.WriteLine("Successor : {0}", Successor.data.ToString());

            bnode<int> Predecessor = suc.InOrderPredecessor(BSuc.root, BSuc.root.left); //14
            Console.WriteLine("Predecessor : {0}", Predecessor.data.ToString());

            //Phone Number Print 1-800-COM-CAST to 18002662278
            PhoneNumberPrint phone = new PhoneNumberPrint();
            phone.PhoneNumber("1-800-COM-CAST");


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

            //Permutation
            Permutation perm1 = new Permutation("abc");
            //perm.Permutation(a

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
            revS.ReverseX("abcxd", startIndex);

            //concordance problem
            Console.WriteLine("\n");
            Concordance conc = new Concordance();
            conc.Read("C:\\Users\\arao\\Desktop\\TestFile.txt");

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

            //check book
            CheckBookNumtoString cnum = new CheckBookNumtoString();
            cnum.NumToString(1100);

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

            r2fsumTree.insert(new bnode<int>(6));
            r2fsumTree.insert(new bnode<int>(11));
            r2fsumTree.insert(new bnode<int>(2));
            r2fsumTree.insert(new bnode<int>(4));
            r2fsumTree.insert(new bnode<int>(5));
            r2fsumTree.insert(new bnode<int>(1));
            r2fsumTree.insert(new bnode<int>(3));

            Boolean br2f = r2l.FindSumPath(r2fsumTree.root, 17);

            SerializeAndDeserializeBtree sdb = new SerializeAndDeserializeBtree();
            sdb.Serialize(r2fsumTree.root);

            char[] darr= new char[] {'3','1','5', '#','#','#','2','4', '#','#','6','#','#'};

            BinaryNode root = new BinaryNode();
            sdb.Desearlize(darr);

            //combination
            Combination cmb = new Combination();
            cmb.FindCombination(new int[] { 1, 2, 3, 4 });

            //Anagram is solved by permuation

            //Longest palindromic subsequence
            longestPalindrom lps = new longestPalindrom();
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
           

            Console.Read();
        }
    }
}
