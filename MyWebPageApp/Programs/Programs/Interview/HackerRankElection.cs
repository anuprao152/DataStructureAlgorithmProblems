using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Programs
{
    class HackerRankElection
    {

        public class Candiate
        {
            public String Name;
            public int votes;
        }

        static string electionWinner(string[] votes)
        {

            string winner = string.Empty;
            Dictionary<Candiate, int> dict = new Dictionary<Candiate, int>();
           

            for (int i = 0; i < votes.Length; i++)
            {
                var candidate = new Candiate { Name = votes[i], votes = 0 };

                if (dict.ContainsKey(candidate))
                {
                    dict[candidate]++;
                    //candiate
                    candidate.votes = dict[candidate]++;
                    
                }
                else
                {

                    dict[candidate] = 1;
                    candidate.votes = 1;
                }
            }

            
            //sort by vote count and then 

            return winner;

        }

    }
}
