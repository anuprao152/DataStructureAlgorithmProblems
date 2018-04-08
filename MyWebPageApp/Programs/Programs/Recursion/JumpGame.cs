using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Programs.Recursion
{
    public class JumpGame
    {
        public Boolean CanReach(int[] array, int index)
        {
            if (index >= array.Length)
                return false;

            if (index == array.Length - 1)
                return true;

            var jumps = array[index];

            if (jumps == 0)
                return false;

            for(int i=1;i<=jumps;i++)
            {
                CanReach(array, index + i);
            }

            return false;
        }

        //public void canJump
    }
}
