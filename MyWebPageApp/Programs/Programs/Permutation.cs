using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Basic case is for permutaion is swaping character

//Eg. Str="ABC" i=0, n=2
// 1. Fix A by Swaping itself
// 2. Permute rest of the string by recursion (BC, 1,2)
// 3. Fix B by Swaping itself
// 4. Permute rest of the string by recursion (C,2,2)
// print C


namespace programs
{
    public class PermutationAlgo
    {
        public void Permutation(char[] str, int i, int len)
        {
            if (i >= len - 1)
            {
                Console.Out.WriteLine(str);
                return;
            }
 
            //you have len choice to swap current element a[i] with each a[j]
            for (int j = i; j < len; j++)
            {
                swap(ref str[i], ref str[j]);
                Permutation(str, i + 1, len);
                swap(ref str[i], ref str[j]); // backtrack to origional string
            }
            
        }
        private void swap(ref char x, ref char y)
        {
            char temp = x;
            x = y;
            y = temp;
        }


        //Second way and best way
        // http://www-cs-faculty.stanford.edu/~eroberts/courses/cs106b/chapters/06-recursive-procedures.pdf
        // Initially prefix = ""
        // Rest = "ABCD"

        // How Algo works, string ABCD
        // A followed by every possible permutation of "BCD"
        // B followed by every possible permutation of "ACD"
        // C followed by every possible permutation of "ABD"
        // D followed by every possible permutation of "ABC"

        //Steps 
        // Recursion
        //1. perfix="" rest="ABCD"
        //2. prefix= A rest="BCD" , Permute(A,BCD)
        //3. prefix= AB rest="CD" , permute(AB,CD)
        //4. prefix= ABC rest="D" , permute(ABC,D)
        //5. prefix= ABCD rest="", Display (ABCD);

        public void permutationAlgo(string prefix, string rest)
        {
            if (rest == string.Empty)
            {
                Console.Write(prefix + "\n");
            }
            else
            {
                //For each character in Rest
                for (int i = 0; i < rest.Length; i++)
                {
                    //Add the character to the end of the prefix
                    string newPrefix = prefix + rest[i]; // NewPrefix = "" + A = A
                    string newRest = rest.Substring(0,i) + rest.Substring(i+1); // NewRest= BCD
                    permutationAlgo(newPrefix,newRest);// Permute( A, BCD)
                }
            }
        }

        public List<string> PrintAllPermutations(int[] arr)
        {
            if (arr.Length == 1)
            {
                return new List<string> { arr[0].ToString() };
            }

            var list = arr.ToList();
            var returnList = new List<string>();
            for (var i = 0; i < arr.Length; ++i)
            {
                var number = arr[i];
                list.RemoveAt(i);

                var perms = PrintAllPermutations(list.ToArray());
                foreach (var perm in perms)
                {
                    returnList.Add(number.ToString() + perm);
                }

                list.Insert(i, number);
            }

            return returnList;
        }
    }
}
