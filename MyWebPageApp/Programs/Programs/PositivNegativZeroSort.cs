using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace programs
{
    class PositivNegativZeroSort
    {
        public int[] ele;
        public PositivNegativZeroSort(int[] ele)
        {
            this.ele = ele;
        }

        public void swap(int i, int j)
        {
            int temp;
            temp = ele[i];
            ele[i] = ele[j];
            ele[j] = temp;
        }

        public void sortNPZ()
        {
            int low = 0, mid = 0, high = ele.Length - 1;
            while (mid <= high)
            {
                if (ele[mid] < 0)
                {
                    swap(low, mid);
                    low++;
                    mid++;
                }
                else if (ele[mid] == 0)
                    mid++;
                else
                {
                    swap(mid,high);
                    high--;
                }
            }	
        }
    }
}
