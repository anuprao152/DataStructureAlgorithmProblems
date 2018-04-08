using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace programs
{
    public class MergeIntervals
    {
        public class Interval
        {
            public int startime;
            public int endtime;
        }

        public void FunMergeIntervals(List<Interval> intervals)
        {
            //sort the array based on their starttime
            List<Interval> sortedIntervals = intervals.OrderBy(i => i.startime).ToList();

            List<Interval> MergedIntervals = new List<Interval>();

            MergedIntervals.Add(sortedIntervals[0]);

            Interval prev = MergedIntervals.LastOrDefault();// last Interval

            for (int i = 1; i < sortedIntervals.Count; i++)
            {
                //Merge not possible
                // --------Prev
                //           -----cur 
                if (sortedIntervals[i].startime > prev.endtime)
                {
                    MergedIntervals.Add(sortedIntervals[i]);
                    prev = MergedIntervals.LastOrDefault(); // cur will be previous
                }
                else
                {
                    //or -------------Prev
                    //       ----cur

                    //merege them
                    //  ---------Prev
                    //     --------------- cur
                    if(sortedIntervals[i].endtime > prev.endtime)
                    {
                        //MergeInterval last also need to update
                        prev = MergedIntervals.LastOrDefault();

                        prev.endtime = sortedIntervals[i].endtime;
                        
                        
                    }
                }

            }
        }
       
    }
}
