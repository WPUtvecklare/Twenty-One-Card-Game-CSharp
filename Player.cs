using System;
using System.Collections.Generic;

namespace ab224qr_examination_3
{
    class Player
    {
        List<Card> hand = new List<Card>();

        public void AddCard (Card card)
        {
            hand.Add(card);
        }

        public int SumOfHand ()
        {
            int sum = 0;
            for (int i = 0; i < hand.Count; i++)
            {
                sum += (int)hand[i].GetName() + 2;
                System.Console.WriteLine(hand[i].GetName());
                System.Console.WriteLine((int)hand[i].GetName() + 2);
            }

            for (int i = 0; i < hand.Count; i++)
            {
                if (hand[i].GetName() == Card.Name.Ace)
                {
                    System.Console.WriteLine("Found an Ace"); // Working!
                }
            }

            return sum;
        }
    }
}
