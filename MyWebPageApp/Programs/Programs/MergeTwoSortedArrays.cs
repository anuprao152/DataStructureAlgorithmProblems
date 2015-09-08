using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace programs
{
    //You have 2 sorted Arrays. A and B. A is shorter than B. B has few elements in sorted order and has space for all elements of A.
    //Now Merge these both array so that All elements are sorted. You cant use extra Array. Use Only Array B.
    class MergeTwoSortedArrays
    {
        public int?[] ArrayA;
        public int?[] ArrayB;
        public int indexA;
        public int indexB;
        public int Fillindex;

        // A is smaller Array and B is large Array with space to occupy A
        public MergeTwoSortedArrays(int?[] A, int?[] B)
        {
            ArrayA = A;
            ArrayB = B;
        }

        public void Merge()
        {
            pushUpElementsofArrayB();
            indexB = 0;// reset the index for ArrayB to top

            //loop till indexB reach start value of Array
            while (indexB < ArrayB.Length && indexA < ArrayA.Length)
            {
                if (ArrayB[indexB] != null)
                {
                    if (ArrayA[indexA] > ArrayB[indexB])
                    {
                        ArrayB[Fillindex] = ArrayB[indexB];
                        ArrayB[indexB] = null;
                        indexB++;
                    }
                    else
                    {
                        ArrayB[Fillindex] = ArrayA[indexA];
                        indexA++;
                    }
                    Fillindex++;
                }
                else { indexB++; }

            }

            while (indexA < ArrayA.Length)
            {
                ArrayB[Fillindex] = ArrayA[indexA];
                indexA++;
                Fillindex++;
            }

            while (indexB < ArrayB.Length)
            {
                ArrayB[Fillindex] = ArrayB[indexB];
                ArrayB[indexB] = null;
                indexB++;
                Fillindex++;
            }
        }

        //push all the elements of ArrayB from bottom to top
        // and create the space in bottom of ArrayB
        public void pushUpElementsofArrayB()
        {
            //ArrayB[pushindex] = value;
            //pushindex--;
            indexB = ArrayB.Length - 1;
            for (int i = ArrayB.Length - 1; i >= 0; i--)
            {
                if (ArrayB[i] != null)
                {
                    ArrayB[indexB] = ArrayB[i];
                    ArrayB[i] = null;
                    indexB--;
                }
            }
        }

        //Find Median of Two Sorted Arrays  M and N
        // Note : For sorted arrays median is a middle element
        //1. Brute Force  Copy M and N into 3rd Array Res and Sort them and get median (middle element )
        //2. Merge : sort using Merge O(M+N) and get middle
        //3. median Comprision : http://www.youtube.com/watch?feature=endscreen&NR=1&v=_H50Ir-Tves&ytsession=M8entVFhEkWgFI-T1tIXAladaoRSzxdEjtKWy9DGZVt-sc-n1DZUkqGscLBC_G1SyQ-kVIusyoC9OLvLn7xxxICHmXI_ZkfdHlAeNC7_BLj5WykpzHDA12AN3HoOVa0MQ8FL0y2AvBVI-y8rh2opx_Bu-YRNp7K7Gx3_ULyZiJWuPvXtNCwG1fwWKS2JP-vYfVp_qk6422h-ZF1aMEjK8gaVGO8CxKMxNZOZZcboOrU
        //4. median finding
        
        //Method number 2
        public void MergeOperation()
        {
            int?[] ResultArr = new int?[ArrayA.Length + ArrayB.Length];
            int resultIdx=0;

            while (indexA < Math.Max(ArrayA.Length, ArrayB.Length) && indexB < Math.Max(ArrayA.Length, ArrayB.Length))
            {
                if (ArrayA[indexA] > ArrayB[indexB])
                {
                    ResultArr[resultIdx] = ArrayB[indexB];
                    indexB++;
                }
                //else if (ArrayA[indexA] < ArrayB[indexB])
                else
                {
                    ResultArr[resultIdx] = ArrayA[indexA];
                    indexA++;
                }

                resultIdx++;
            }

            //copy rest elements
            while (resultIdx < ResultArr.Length)
            {
                if (indexA < Math.Max(ArrayA.Length, ArrayB.Length))
                {
                    ResultArr[resultIdx] = ArrayA[indexA];
                    indexA++;
                }
                else
                {
                    ResultArr[resultIdx] = ArrayB[indexB];
                    indexB++;
                }
                resultIdx++;
            }

            int medianIdx = resultIdx/2;
            Console.WriteLine("Median Index" + medianIdx);
            Console.WriteLine("Median:" + ResultArr[medianIdx]);
        }

        //Method number 3
        public int? MedianCoparision(int?[] A, int?[] B)
        {
            int m1Idx=  A.Length/2;
            int m2Idx=  B.Length/2;

            if (A.Length == 1 && B.Length == 1)
            {
                return B[m2Idx];
            }

            if (A[m1Idx] == B[m2Idx])
            {
                Console.WriteLine("Median Using Median Comparision" + A[m1Idx]);
                return  A[m1Idx];
            }
            else if (A[m1Idx] < B[m2Idx])
            {
                int?[] newArrA = new int?[A.Length - 1- m1Idx];
                Array.Copy(A, m1Idx + 1, newArrA, 0, newArrA.Length);

                int?[] newArrB = new int?[m2Idx];
                Array.Copy(B, 0, newArrB, 0, newArrB.Length);

                return MedianCoparision(newArrA, newArrB);
            }
            else
            {
                int?[] newArrB = new int?[B.Length -1 - m2Idx];
                Array.Copy(B, m2Idx + 1, newArrB, 0, newArrB.Length);

                int?[] newArrA = new int?[m1Idx];
                Array.Copy(A, 0, newArrA, 0, newArrA.Length);

                return MedianCoparision(newArrA, newArrB);
            }
        }
    }
}
