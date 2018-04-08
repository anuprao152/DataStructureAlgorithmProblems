using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Programs
{
    public class PortfolioMg
    {
        static int maxOddLevel = 0;
        static int maxEvenLevel = 0;
        static int findMax(int n, string tree)
        {
            int i =0;
            int level =0;
            while (i < tree.Length)
            {
                while (i < Math.Pow(2, level))
                {
                    if (level % 2 == 0)
                    {
                        if (tree[i] != '#')
                            maxEvenLevel += int.Parse(tree[i].ToString());
                    }
                    else
                    {
                        if (tree[i] != '#')
                            maxOddLevel += int.Parse(tree[i].ToString());
                    }
                    i++;
                }
                level++;
            }

            return Math.Max(maxEvenLevel, maxOddLevel);

        }
    }
}
