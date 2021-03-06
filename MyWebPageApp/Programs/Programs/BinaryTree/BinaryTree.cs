﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace programs
{
    public class Bnode<T>
    {
        public T data;
        public Bnode<int> left;
        public Bnode<int> right;

        public Bnode(T data)
        {
            this.data = data;
        }
    }

    class BinaryTree
    {
        public Bnode<int> root;

        public void insert(Bnode<int> node)
        {
            if (root == null)
            {
                root = node;
                return;
            }
               var cur = root;

            while(cur!=null)
            {
                if (node.data < cur.data)
                {
                    if (cur.left == null)
                    {
                        cur.left = node;
                        return;
                    }
                    cur = cur.left;
                }
                else
                {
                    if(cur.right == null)
                    {
                        cur.right = node;
                        return;
                    }

                    cur = cur.right;
                }  
            }
        }

        //Depth First Search (goes deeper and deeper till encounter null)
        public void inorderTraverse(Bnode<int> anode)
        {
            Bnode<int> cur = anode;
            if (cur.left != null)
            {
                inorderTraverse(cur.left);
            }
            
            Console.WriteLine(cur.data);

            if(cur.right != null)
            {
                inorderTraverse(cur.right);
            }
        }

        public Bnode<int> findCommonAncestor(Bnode<int> root,Bnode<int> p, Bnode<int> q)
        {
            if (root == null) return null;
            // p and q is left of the root 
            if (p.data > root.data && q.data > root.data)
            {
                return findCommonAncestor(root.right, p, q);
            }
            // p and q is right side of the root
            if (p.data < root.data && q.data < root.data)
            {
                return findCommonAncestor(root.left, p, q);
            }

            // if above both codition wrong then two are getting diversion at this root so return root.
            return root;
        }

        // print height of the tree
        public int findHeight(Bnode<int> root)
        {
            if (root == null) return 0;
            
            int heighleft=findHeight(root.left);
            int heightright = findHeight(root.right);
            return( Math.Max(heighleft,heightright) + 1);

        }

        //Breadth First search is a level-order binary tree traversal 
        //(linked list n- connection problem solution)
        // And remeber that BFS use Queue data structure
        public void printOrderLevelBtree(Bnode<int> root)
        {
            Queue<Bnode<int>> q = new Queue<Bnode<int>>();

            if (root == null) return;
            else
            q.enqueue(root);
            while ( true) // there should be a terminate condition like queue should be empty but 
                          //I terminated when dequeue operation is null no 
            {             // no node need have adjanct right and left vertex to visit now.  
                Bnode<int> node = q.dequeue();
                if (node != null) Console.WriteLine(node.data);
                else return;
                if(node.right !=null) q.enqueue(node.right);
                if(node.left != null) q.enqueue(node.left);
            }
        }

        public static Bnode<int> ConstructBinaryTree(List<int> preOrder, List<int> inOrder)
        {
            Bnode<int> root = null;
             
             if (preOrder.Count != 0 && inOrder.Count != 0)
             {
                 root = new Bnode<int>(preOrder[0]);
                 int rootIdx = inOrder.IndexOf(root.data);
                 //Left & Right SubTree inOrder
                 List<int> leftSubTreeIn = inOrder.GetRange(0, rootIdx);
                 List<int> rightSubTreeIn = inOrder.GetRange(rootIdx + 1, inOrder.Count - 1 - rootIdx );

                 //left & right SubTree PreOrder
                 int position = leftSubTreeIn.Count;
                 List<int> leftSubTreePre = preOrder.GetRange(1, position);
                 List<int> rightSubTreePre = preOrder.GetRange(position + 1, preOrder.Count - 1 - position);
                 root.left = ConstructBinaryTree(leftSubTreePre, leftSubTreeIn);
                 root.right = ConstructBinaryTree(rightSubTreePre, rightSubTreeIn);
             }

             return root;
        }


        //public Boolean IsBST(bnode<int> root)
        //{
        //    if (root == null) return true;

        //    //left value in binary search tree is always less than the root
        //    //So I am checking all the values in  left sub binary tree of a root,
        //    // and finding maximum value from left sub tree, and if I found that 
        //    // maximum value if found is greater than root value so not bst return false
        //    //if (root.left != null && MaxValueFromSubTree(root.left) > root.data)
        //        return false;
        //    //if (root.right!=null && MinValueFromSubTree(root.right) < root.data)
        //    //return false;

        //}

        //Ceil value =  node with smallest data value which is larger or equal to key value 
        //
       
        //if key value is grater that maxium value in BST than return null

       
        public int FindCeiling(Bnode<int> root, int key)
        {
            if (root == null ) return -1;

            //Case 1: you found key matches with some node data
            if (root.data == key ) return root.data;

            //case 2: if key is greater than root go to the right subtree,
            //probably you found ceiling value  in right subtree
            if (root.data < key)
                    return FindCeiling(root.right, key);
           
            // Case 3: Go to the left subtree becuase key is less value than root data, 
            // so you find ceiling value in left subt tree

            //basically below statment says that you can find ceil value to the left subtree , 
            //We may find a node with is larger data than key value in left subtree, 
            //if not the root itself will be ceil node.
            int ceil = FindCeiling(root.left, key);
            if (ceil >= key)return ceil;
            else return root.data;
        }

        //in-order level traversal and pointers points to their neighbours 
        //                          output                     origional
        //                     1---> null                        1
        //                 4------->12 ---> null             4         12
        //              2--->6-->10--->14 -->null         2     6   10     14


        //Approach 

        // Creat Queue for order level traversal
        //------------------------------------------------------------------------------
        //| 1 | null | 4 | 12 | null | 2 | 6 | 8 | 10 | null
        //------------------------------------------------------------------------------
        // you can see every time i am enquing null if I encounter null in a queue /FYI null is a marker node 
        // that you can use to calcualte height also
        // e.g.
        // enqueue 1 , enqueue null
        // dequeue 1 , enqueue  4 and 12 in queue
        // dequeue null, so enqueue null 
        // dequeue 4 , enqueue 2 and 6
        // dequeue 12, enqueue 8 and 10 
        // dequeue null, so enque null

        // two consecutive null values determines terminate the while loop by flag variable

        public class bnodeNeighbour<T>
        {
            public T data;
            public bnodeNeighbour<int> right;
            public bnodeNeighbour<int> left;
            public bnodeNeighbour<int> rightNeighbour;

            public bnodeNeighbour(T data)
            {
                this.data = data;
            }
        }
        public void BSTwithNeighbourPointers(bnodeNeighbour<int> root)
        {
            Queue<bnodeNeighbour<int>> q = new Queue<bnodeNeighbour<int>>();
            if (root == null) return;
            else
                q.enqueue(root);
            q.enqueue(null);

            Boolean flag=true;// terminate condition
            while (true)
            {
                bnodeNeighbour<int> node = q.dequeue();

                if (node != null)
                {
                    flag= true;
                    //node.rightNeighbour = q.front ( this logic for pointing neigbour node)
                    Console.WriteLine(node.data); 
                    if (node.left != null) q.enqueue(node.left);
                    if (node.right != null) q.enqueue(node.right);
                    
                }
                else
                {
                    
                    if (flag) q.enqueue(null);
                    else return;
                    flag= false;
                }
            }
        }

    }
}
