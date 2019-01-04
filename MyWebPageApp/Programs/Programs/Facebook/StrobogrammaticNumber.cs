using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Programs.Facebook
{

    //https://www.geeksforgeeks.org/strobogrammatic-number/
    //https://careercup.com/question?id=5804910846148608

    /// <summary>
    /// if you looking for solution for size K    ( example K = 4 )
    ///  Solution(4-2) = Solution(2) = "00", "11", "69", "88", "96"      
    ///  0   + Solution(k-2)  + 0   //   0   + "00"  + 0 
    ///  1   + Solution(k-2)  + 1   //   1   + "11"  + 1  
    ///  6   + Solution(k-2)  + 9   //   6   + "69"  + 9 
    ///  8   + Solution(k-2)  + 8   //   8   + "88"  + 8 
    ///  9   + Solution(k-2)  + 6   //   9   + "96"  + 6 
    /// </summary>
    public class StrobogrammaticNumber
    {
        public List<string> StroboGrammaticNumberPattern(int size)
        {
            
            Dictionary<string,string> map = new Dictionary<string,string>();
            map.Add("0","0");
            map.Add("1","1");
            map.Add("6","9");
            map.Add("8","8");
            map.Add("9","6");

            if (size == 0)
                return null; //recursion never hit here.
            if (size == 1)
                return new List<string>() { "0", "1", "8" };
            if (size == 2)
                return new List<string>() { "00", "11", "69", "88", "96" };

            var middles = StroboGrammaticNumberPattern(size -2);
            var res = new List<string>();

            

            for(int i=0;i<middles.Count;i++)
            {
                foreach (var kv in map)
                {
                    res.Add(kv.Key + middles[i] + kv.Value);
                }
            }
          return res;
        }
    }
}
