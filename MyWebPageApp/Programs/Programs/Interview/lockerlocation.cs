using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Programs
{

    //Amazon Interview
    public class lockerlocation
    {

        public static void printMatrix(int cityWidth, int cityLength,
          int[] xCordinates, int[] yCordinates) {
        
         //each grid cell calculate distance
        for(int i=1;i<=cityLength;i++){
            for(int j=1;j<=cityWidth;j++){
                int dist=findNearestLocker(i,j,xCordinates,yCordinates);
                Console.Out.Write(dist +" ");
            }
            Console.Out.WriteLine();
        }
        
        
    }

        private static int findNearestLocker(int i, int j, int[] xCordinates,
                int[] yCordinates)
        {
            int totalLocker = xCordinates.Length;
            int dist = int.MaxValue;
            for (int l = 0; l < totalLocker; l++)
            {
                int x = xCordinates[l]; // 
                int y = yCordinates[l];
                int temp = Math.Abs(x - j ) + Math.Abs(y - i);
                if (dist > temp)
                {
                    dist = temp;
                }
            }
            return dist;
        }
    }
}
