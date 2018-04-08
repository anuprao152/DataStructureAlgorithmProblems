using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Programs.Interview
{
    public class Class11
    {
        public class hotel
        {
            public int hotelId;
            public String Review;
            public int Reviewfreq;
        }

        public void sortByReview( hotel[] hotels)
        {
            Dictionary<string, string> wordsDict = new Dictionary<string, string>();
            Dictionary<int,int> hotel_reviewDict = new Dictionary<int,int>();

            for (int i = 0; i < hotels.Length; i++)
            {
                if (!hotel_reviewDict.ContainsKey(hotels[i].hotelId))
                {
                    hotel_reviewDict.Add(hotels[i].hotelId, 0);
                 
                }

                string[] words = hotels[i].Review.Split(' ');

                for (int w = 0; w < words.Length; i++)
                {
                    if (wordsDict.ContainsKey(words[w]))
                    {
                        hotels[i].Reviewfreq = hotel_reviewDict[hotels[i].hotelId]++;
                    }

                }
            }

           // FunSorthotelmentsByFreq(hotels, 0, hotels.Length);
            List<hotel> hotelsReview = new List<hotel>();
            foreach(var kvp in hotel_reviewDict)
            {
               
                hotelsReview.Add(new hotel { hotelId = kvp.Key, Reviewfreq = kvp.Value});
            }

            var hotelarray = hotelsReview.ToArray();

            FunSorthotelmentsByFreq(hotelarray,0,hotelarray.Length-1);




        }

        private hotel[] FunSorthotelmentsByFreq(hotel[] array, int low, int high)
        {

            if (low > high) return array;

            int mid = (high - low) / 2;

            hotel[] left = FunSorthotelmentsByFreq(array, low, mid);
            hotel[] right = FunSorthotelmentsByFreq(array, mid + 1, high);

            return Merge(left, right);
        }

        private hotel[] Merge(hotel[] left, hotel[] right)
        {
            hotel[] res = new hotel[left.Length + right.Length];

            int i = 0, j = 0, k = 0;

            while (i < left.Length && j < right.Length)
            {
                if (left[i].Reviewfreq < right[j].Reviewfreq)
                {
                    res[k] = left[i];
                    k++;
                    i++;
                }
                else
                {
                    res[k] = right[j];
                    k++;
                    j++;
                }
            }

            while (i < left.Length)
            {
                res[k] = left[i];
                i++;
                k++;
            }

            while (j < right.Length)
            {
                res[k] = right[j];
                j++;
                k++;
            }

            return res;
        }


    }
}
