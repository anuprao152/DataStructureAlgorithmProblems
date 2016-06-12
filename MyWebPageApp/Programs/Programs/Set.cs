using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace programs
{
    public class Set
    {
        // Set Characteristics
        // 1. No Duplicate
        // 2. Non negative
        // 3. Sorted (increasing order )
        // Asked in Microsoft Second round
        // 11233344555888

        public Boolean IsSet(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0) return false;

                // if duplicate exist, then they occure next to each other as it is sorted
                if (i + 1 < array.Length && array[i] >= array[i + 1]) return false;
            }
            return true;
        }

        //Merge two set into third set ( Check for duplicate value into merge set )
        public int?[] MergeIntoSet(int[] set1, int[] set2)
        {
            int?[] res = new int?[set1.Length + set2.Length];

            int i=0;
            int j=0;
            int r=0;

            while (i < set1.Length && j < set2.Length)
            {
                if (set1[i] < set2[j])
                {
                    res[r] = set1[i];
                    i++;
                    r++;
                }

                else if (set1[i] > set2[j])
                {
                    res[r] = set2[j];
                    r++;
                    j++;
                }

                //Don't add duplicate values in a third set
                else if(set1[i] == set2[j])
                {
                    res[r] = set1[i];
                    i++;
                    j++;
                    r++;
                }     
            }

            if (i == set1.Length)
            {
                while (j < set2.Length)
                {
                    res[r] = set2[j];
                    r++;
                    j++;
                }
            }

            if (j == set2.Length)
            {
                while (i < set1.Length)
                {
                    res[r] = set1[i];
                    r++;
                    i++;
                }
            }

            return res;
        }

    }
}
