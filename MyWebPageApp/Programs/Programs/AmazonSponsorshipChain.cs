using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace programs
{
    public interface Member
    {
        double getMonthlyAmazonDollars();
        List<Member> getRecruitedMembers();
    }

    /// <summary>
    /// https://www.careercup.com/question?id=6376647859109888
    /// </summary>
    public class AmazonSponsorshipChain 
    {
        public double CalcTotalPayout(Member m)
        {
            if (m.getRecruitedMembers().Count <= 0) 
                return 0.1 * m.getMonthlyAmazonDollars();
            double total = 0;

            foreach (Member mem in m.getRecruitedMembers())
            {
               total = total + 0.04 * CalcTotalPayout(mem);
            }

            return total;
        }

    }
}
