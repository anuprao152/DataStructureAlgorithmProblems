using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Programs.Interview.Zulily
{
    public class CardRemoval
    {
        public Dictionary<char, int> dict = new Dictionary<char, int>();

        public CardRemoval()
        {
            dict.Add('B', 1);
            dict.Add('U', 10);
            dict.Add('L', 11);
            dict.Add('R', 12);
            dict.Add('M', 13);
        }

        public int getCardValue(char c)
        {
            if (c >= '2' && c <= '9')
                return c - '0';

            if (dict.ContainsKey(c))
               return dict[c];

            return -1;

        }

        public int SubArraySumk1(String Cards, int k)
        {
            var removedCards = new Dictionary<int, Boolean>();

            int curSum = 0;
            int startIdx = 0;
            int i = 0;
            int j = Cards.Length;
            bool flag = false;

            while (i < Cards.Length)
            {
                if (!removedCards.ContainsKey(i))
                {
                    int Cardvalue = getCardValue(Cards[i]);

                    curSum += Cardvalue;

                    while (curSum > k && startIdx < i)
                    {
                        if (!removedCards.ContainsKey(startIdx))
                            curSum = curSum - getCardValue(Cards[startIdx]);
                        startIdx++;
                    }

                    if (curSum == k)
                    {
                        flag = true;
                        while (startIdx <= i)
                        {
                            if (!removedCards.ContainsKey(startIdx))
                                removedCards.Add(startIdx, true);
                            startIdx++;
                        }

                        curSum = 0;
                        startIdx = i + 1;
                    }
                }

                i++;

                if(i==Cards.Length)
                {
                    if (!flag)
                    {
                        break;
                    }
                    //Cards = null;
                    String s = String.Empty;
                    for (int l = startIdx  /* startIdx + 1 */; l < Cards.Length; l++)
                    {
                        if (!removedCards.ContainsKey(l))
                            s += Cards[l];
                    }

                    for (int l = 0; l < startIdx; l++)
                    {
                        if (!removedCards.ContainsKey(l))
                            s += Cards[l];
                    }

                    removedCards = null;
                    removedCards = new Dictionary<int, Boolean>();

                    Cards = null;
                    i = 0;
                    startIdx = 0;
                    curSum = 0;
                    flag = false;
                    Cards = s;
                }
            }
            if (Cards == null) return 0;
            return Cards.Length;
        }

    }
}
