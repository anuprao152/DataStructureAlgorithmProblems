using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace programs
{
    public class CelebrityProblem
    {
        //represent people know each other in Matrix form

        private Boolean IsKnow(int a, int b, int[][] PeopleKnowMatrix)
        {
            if (PeopleKnowMatrix[a][b] == 1)
                return true;

            return false;
        }

        //using two pointers
        //if people[start] knows people[end], then people[start] must not be a celebrity
        //else people[end] must not be a celebrity
        // ------known-------|-------don't know (no celebrity)---

        public int? findCelebrity(int[] people, int[][] PeopleKnowMatrix)
        {
            int start = 0;
            int end = people.Length - 1;

            while (start < end)
            {
                if (IsKnow(people[start], people[end], PeopleKnowMatrix))
                {
                    start++;
                }
                else
                {
                    end--;
                }
            }

            //lets check if people[start] actually celebrity

            for (int i = 0; i < people.Length; i++)
            {
                if (!IsKnow(people[i], people[start], PeopleKnowMatrix) && IsKnow(people[start], people[i], PeopleKnowMatrix))
                    return null;
            }

            return people[start];
        }
    }
}
