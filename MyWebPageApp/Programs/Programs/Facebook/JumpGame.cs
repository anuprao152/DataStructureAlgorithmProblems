using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Programs.Facebook
{
    public class JumpGame
    {
        //Greedy
        //https://www.programcreek.com/2014/03/leetcode-jump-game-java/
        public bool JumpGameDest(int[] array)
        {
            if (array == null || array.Length <= 0)
                return false;

            int maxIndex = 0; //maxIndex that you can reach
            for (int i = 0; i < array.Length; i++)
            {
                if (i >= maxIndex && array[i] == 0)
                    return false;

                var maxJump = i + array[i]; // always jump max from current index;

                if (maxJump >= array.Length - 1)
                    return true;

                // if your jump more than maxIndex you can reach, then update maxIndex
                if(maxJump > maxIndex) 
                {
                    maxIndex = maxJump;
                }
            }

            return false;

        }
    }
}
