using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace programs
{
    public class SortElementByFrequency
    {
        public class ele
        {
            public int val;
            public int index;
            public int frequency;
        }

        // you need to take care of index when you sort by frequency. in tie with frequency, element comes first whose index is first

        //sort by value
        //count the frequency
        //sort by frequency

        public int[] sortbyFreq(int[] array)
        {
            Dictionary<int,ele> num_freqDict = new Dictionary<int,ele>();
             
            for (int i = 0; i < array.Length; i++)
            {
                if (num_freqDict.ContainsKey(array[i]))
                {
                    num_freqDict[array[i]].frequency++;
                }
                else
                {
                    num_freqDict.Add(array[i], new ele { val = array[i], index = i, frequency = 1 });
                }
            }

            ele[] elements = new ele[num_freqDict.Count];
            int count=0;

            foreach (var kp in num_freqDict)
            {
                elements[count] = kp.Value;
                count++;
            }

            ele[] res = FunSortElementsByFreq(elements, 0, elements.Length - 1);

            return res.Select(e => e.val).ToArray();
        }

        private ele[] FunSortElementsByFreq(ele[] array, int low, int high)
        {

            if (low >= high) return array;

            int mid = (high + low) / 2;

            ele[] left = FunSortElementsByFreq(array, low, mid);
            ele[] right = FunSortElementsByFreq(array, mid + 1, high);

            return Merge(left, right);
        }

        private ele[] Merge(ele[] left, ele[] right)
        {
            ele[] res = new ele[left.Length + right.Length];
            
            int i=0,j=0,k=0;

            while (i < left.Length && j < right.Length)
            {
                if (left[i].frequency == right[j].frequency)
                {
                    if (left[i].index < right[i].index)
                    {
                        res[k] = left[i];
                        k++;
                        i++;
                    }
                    else
                    {
                        res[k] = right[j];
                        k++;
                        j++;
                    }

                }
                else if (left[i].frequency < right[j].frequency)
                {
                    res[k] = left[i];
                    k++;
                    i++;
                }
                else
                {
                    res[k] = right[j];
                    k++;
                    j++;
                }
            }

            while (i < left.Length)
            {
                res[k] = left[i];
                i++;
                k++;
            }

            while (j < right.Length)
            {
                res[k] = right[j];
                j++;
                k++;
            }

            return res;
        }
    }
}
