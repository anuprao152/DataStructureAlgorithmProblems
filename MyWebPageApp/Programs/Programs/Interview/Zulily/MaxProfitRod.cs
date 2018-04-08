using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Programs.Interview.Zulily
{
    public class MaxProfitRod
    {
        public int FindMaxProfitCut(int[] rods, int cutCost, int unitCost)
        {
            int maxMoney = int.MinValue;

            int maxrodlength = int.MinValue;
            
            //find min in rods
            for (int i = 0; i < rods.Length; i++)
            {
                if (maxrodlength < rods[i])
                    maxrodlength = rods[i];
            }

            int low = 1;
            while (low <= maxrodlength)
            {
                int totalUnits = 0;

                 for(int i=0;i<rods.Length;i++)
                 {
                     totalUnits+= rods[i] / low;
                 }

                 var money = totalUnits * ( low * unitCost  -  cutCost);

                 if (maxMoney < money)
                     maxMoney = money;

                 low++;
            }

            return maxMoney;
        }
    }
}
