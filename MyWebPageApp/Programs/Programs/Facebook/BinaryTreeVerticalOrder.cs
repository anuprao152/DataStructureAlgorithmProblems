using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace programs
{
    public class BinaryTreeVerticalOrder
    {
        public void printTreeVertically(bnode<int> root)
        {
            var dict = new Dictionary<int,List<bnode<int>>>();
            GetVerticalOrder(root, 0, dict);

            var min = int.MaxValue;
            var max = int.MinValue;

            //get min hd distance ( left ) and max hd distance 
           foreach(var k in dict.Keys)
           {
               if (k < min)
                   min = k;

               if (k > max)
                   max = k;
           }

           while (min < max)
           {
               if (dict.ContainsKey(min))
               {
                   var list = dict[min];
                   for (int i = 0; i < list.Count; i++)
                       Console.Write(list[i].data);
                   Console.WriteLine("\n");
               }
                    
           }
            


        }

        public void  GetVerticalOrder(bnode<int> cur, int hd, Dictionary<int,List<bnode<int>>> dict)
        {
            if (cur == null)
                return;

            // add horizontal distace in dict as a key and node as value,
            if (!dict.ContainsKey(hd))
            {
                var list = new List<bnode<int>>();
                list.Add(cur);
                dict.Add(hd, list);
            }
            else
            {
                var list = dict[hd];
                list.Add(cur);
            }


            GetVerticalOrder(cur.left, hd + 1, dict);
            GetVerticalOrder(cur.right, hd - 1, dict);
             
        }


    }
}
