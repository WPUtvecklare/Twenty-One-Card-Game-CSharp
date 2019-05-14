using System;
using System.Collections.Generic;
using System.Linq;

namespace ab224qr_examination_3
{
    class Deck
    {
        public List<Card> cards;

        public void GenerateDeck () {
            cards = new List<Card>();

            for (int s = 0; s < (int)Card.Suit.Count; s++)
            {
             for (int n = 0; n < (int)Card.Name.Count; n++)
             {
                 cards.Add(new Card((Card.Name)n, (Card.Suit)s));
             }   
            }
        }

        public void Shuffle () {
            Random r = new Random();
            for (int i = 0; i < 1000; i++)
            {
                int ix = r.Next(cards.Count);
                Card c = cards.ElementAt(ix);
                cards.RemoveAt(ix);
                cards.Add(c);
            }
        }

        public void NewDeck () {
            GenerateDeck();
            Shuffle();
        }

        public Card DrawCard () {
            Card c = cards.ElementAt(0);
            cards.RemoveAt(0);
            return c;
        }
    }
}
