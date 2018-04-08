using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Programs.Interview
{
    public class TestBooking1
    {

        public void DeltaEncoding(int[] array)
        {
            Console.Write(array[0]+ " ");
            for (int i = 1; i < array.Length; i++)
            {
                var number = array[i] - array[i-1];
                try
                {
                    var n = Convert.ToSByte(number);
                }
                catch
                {
                    Console.Write("-128");
                }

                //if (-127 <= n && n <= 127)
                //{
                //    Console.Write("-128" + number + " ");
                //}
                //else
                //{
                    Console.Write(" " + number + " ");
                //}
            }
        }
    }
}
