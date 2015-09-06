using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace programs
{
    public abstract class Deck
    {
       public abstract void Deal();
       public abstract void shuffle();
    }
    public enum Suit
    {
        CLUBS,SPADES, HEARTS, DIAMONDS
    };
    public class Card 
    {
        public int card;
        public Suit suit;
        public Card(int card, Suit suit)
        {
            this.card = card;
            this.suit = suit;
        }

        public void Dealing()
        {
            //behavior
        }

        public virtual int Value()
        {
            return card;
        }
    }

    public class BlackJackCard : Card
    {
        public BlackJackCard(int r, Suit s):base(r,s)
        {
        }

        public override int Value()
        {
            int card = base.Value();

            if (card == 1) // ace is 11
                return 11;
            if (card < 10) // 0-9
                return base.Value();

            return 10;
        }

        public Boolean IsAce()
        {
            Boolean isAce = false;
            if (base.card == 1) return true;

            return isAce;
        }

    }




}
