using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Programs.Facebook
{
    public class MergeTwoSortedIntervals
    {
        public class Interval
        {
            public int start;
            public int end;
        }


        public List<Interval> MergeTwoSortedIntervalsFunc(Interval[] list1, Interval[] list2)
        {
            if (list1 == null && list2 == null)
                return null;

            Interval prev = null;
            int i = 0;
            int j = 0;
            var res = new List<Interval>();
            if (list1[0].start < list2[0].start)
            {
                prev = list1[0];
                i++;
            }
            else
            {
                prev = list2[0];
                j++;
            }

            res.Add(prev);


            while (list1.Length > 0 && list2.Length > 0)
            {
                if (list1[i].start < list2[j].start)
                {
                    if (prev.end < list1[i].start)
                    {
                        res.Add(list1[i]);
                        prev = list1[i];
                    }
                    else
                    {
                        //merge
                        if (prev.end < list1[i].end)
                        {
                            prev.end = list1[i].end;
                        }
                    }
                    i++;
                }
                else
                {
                    if (prev.end < list2[j].start)
                    {
                        res.Add(list2[j]);
                        prev = list2[j];
                    }
                    else
                    {
                        //merge
                        if (prev.end < list2[j].end)
                        {
                            prev.end = list2[j].end;
                        }
                    }
                    j++;
                }
            }

            while (list1 != null && i < list1.Length)
            {
                if (prev.end < list1[i].start)
                {
                    res.Add(list1[i]);
                    prev = list1[i];
                }
                else
                {
                    //merge
                    if (prev.end < list1[i].end)
                    {
                        prev.end = list1[i].end;
                    }
                }
                i++;
            }

            while (list2 != null && j < list2.Length)
            {
                if (prev.end < list2[j].start)
                {
                    res.Add(list2[j]);
                    prev = list2[j];
                }
                else
                {
                    //merge
                    if (prev.end < list2[j].end)
                    {
                        prev.end = list2[j].end;
                    }
                }
                j++;
            }

            return res;
        }
    }
}
