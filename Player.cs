using System;
using System.Collections.Generic;

namespace ab224qr_examination_3
{
    class Player
    {
        List<string> hand = new List<string>();

        public string Name { get; set; }
        public int Limit { get; set; }
        public List<string> Hand { get; set; }
        
        public Player (string name, int limit)
        {
            Name = name;
            Limit = limit;
            Hand = hand;
        }

        public void AddCard (string card)
        {
            hand.Add(card);
        }

        public int SumOfHand (List<string> hand)
        {
            throw new NotImplementedException();
        }

        public string ShowHand (List<string> hand)
        {
            throw new NotImplementedException();
        }
    }
}
