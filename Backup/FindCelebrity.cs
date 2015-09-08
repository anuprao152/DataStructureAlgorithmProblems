using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StackProgram
{

    class person
    {
        public int id;
        public int[] knownPersonId;
        public person(int id, int[] knownPersonId)
        {
            this.id = id;
            this.knownPersonId = knownPersonId;
        }
    }
    class FindCelebrity
    {
        public person findCelebrity(List<person> candidatesforCelebrity)
        {
            List<person> p = GetCelebrityCandidatePeople(candidatesforCelebrity);
            if (p.Count == 1)  return p[0];
            else 
                return findCelebrity(p);
        }

        public List<person> GetCelebrityCandidatePeople(List<person> candidatesforCelebrity)
        {
            List<person> newcandidates = new List<person>();
            for (int i = 0; i < candidatesforCelebrity.Count; i++)
            {
                for (int j = 0; j < candidatesforCelebrity.Count; j++)
                {
                    if (IsKnow(candidatesforCelebrity[i], candidatesforCelebrity[j]))
                    {
                        //candidatesforCelebrity.Add(people[j]);
                        newcandidates.Add(candidatesforCelebrity[j]);
                    }
                }
                return newcandidates;
            }

            return newcandidates;
        }

        public Boolean IsKnow(person a, person b)
        {
            Boolean know= false;
           
                for (int i = 0; i < a.knownPersonId.Length; i++)
                {
                    if (a.knownPersonId[i] == b.id)
                    {
                        know = true;
                        return know;
                        //break;
                    }
                }

                if (!know)
                {
                    return know;
                }
                return know;
        }
    }
}
