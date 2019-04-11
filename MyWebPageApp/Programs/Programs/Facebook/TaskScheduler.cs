using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Programs.Facebook
{
    // https://zhuhan0.blogspot.com/2017/07/leetcode-621-task-scheduler.html

    // this problem can be solved by heap also. look above link
    // if you use heap you dont need to sort everytime after loop
    public class TaskScheduler
    {
        // tasks = ['A','A','A','B','B','B','C'], n = 3
        public int leastInterval(char[] tasks, int n)
        {
            var interval = 0;

            int[] frequency = new int[26];

            //calc frequency of each task
            for (int i = 0; i < tasks.Length;i++ )
            {
                frequency[tasks[i] - 'A']++;
            }

           System.Array.Sort(frequency);// ( 0 to 25 index ) [0,0,0,....,3,4,5]

           while(frequency[25] > 0)
           {
               for(int i=0;i< n;i++) // iteration cycle till cooling time
               {
                   interval++;

                   if (i > 25)
                       continue;

                   if (frequency[25 - i] > 0) // cool down
                       frequency[25 - i]--;

                   if (frequency[25] == 0)
                       break;
               }

               System.Array.Sort(frequency);//sort again after every cooling time finish
               
           }

            return interval;
        }
    }
}
