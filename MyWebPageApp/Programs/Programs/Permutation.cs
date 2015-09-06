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
    public class Permutation
    {
        public string output;
        public Boolean[] used;
        public StringBuilder sb;

        public Permutation() { }

        public Permutation(string str)
        {
            used = new Boolean[str.Length];
            sb = new StringBuilder();
        }
        //3 parameters
        //str is string for which we find permutations
        //i is starting index of the string
        //n is ending index of the string
        public void Findpermutation(char[] str, int i, int n)
        {
            if (i == n)
                Console.WriteLine(str[i]);
            else
            {

                //for each character in str we fix firs character
                //and find permuation of the rest of the string
                for (int j=i; j <= n; j++)
                {
                    //fix str[i] character by swaping with itself
                    swap(ref str[i],ref str[j]);

                    //char temp = str[i]; str[i] = str[j]; str[j] = temp;
                    Findpermutation(str, i + 1, n);
                    swap(ref str[i], ref str[j]); // backtrack
                    //temp = str[i]; str[i] = str[j]; str[j] = temp;
                    //recursive call for the rest string

                }
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
    }
}
