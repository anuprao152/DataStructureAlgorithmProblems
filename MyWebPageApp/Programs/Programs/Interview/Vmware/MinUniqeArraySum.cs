using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Programs.Interview.Vmware
{
    public class MinUniqeArraySum
    {

        public int FindMiniumUniqeArraySum(int[] array)
        {
            if (array == null)
                return 0;

            var dict = new Dictionary<int, bool>();
            int sum = array[0];
            dict.Add(array[0], true);

            for (int i = 1; i < array.Length; i++)
            {
                if(dict.ContainsKey(array[i]))
                {
                    while (dict.ContainsKey(array[i]))
                    {
                        array[i] += 1;
                    }
                }

                dict.Add(array[i], true);// add into dictionary 1. if first time 2. duplicate then make uniqe and add

                sum += array[i];
            }

            return sum;



        }
    }
}
