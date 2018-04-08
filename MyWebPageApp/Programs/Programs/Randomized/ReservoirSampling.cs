using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace programs
{
    public class ReservoirSampling
    {
        

        public void SelectKItems(int[] stream,int k)
        {
            int[] resVoir = new int[k];
            Random rnd = new Random();
            for(int i=0; i < k; i++)
            {
                resVoir[i]= stream[i];
            }

            for (int i = k; i < stream.Length; i++)
            {
                int r = rnd.Next() % (i + 1);

                if (r < k)
                    resVoir[r] = stream[i];
            }

            //Print ResVoir
        }
    }
}
